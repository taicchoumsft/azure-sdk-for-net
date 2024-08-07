// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class DSRecordDigest : IUtf8JsonSerializable, IJsonModel<DSRecordDigest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DSRecordDigest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DSRecordDigest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DSRecordDigest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DSRecordDigest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AlgorithmType))
            {
                writer.WritePropertyName("algorithmType"u8);
                writer.WriteNumberValue(AlgorithmType.Value);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DSRecordDigest IJsonModel<DSRecordDigest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DSRecordDigest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DSRecordDigest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDSRecordDigest(document.RootElement, options);
        }

        internal static DSRecordDigest DeserializeDSRecordDigest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? algorithmType = default;
            string value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("algorithmType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    algorithmType = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DSRecordDigest(algorithmType, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DSRecordDigest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DSRecordDigest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DSRecordDigest)} does not support writing '{options.Format}' format.");
            }
        }

        DSRecordDigest IPersistableModel<DSRecordDigest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DSRecordDigest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDSRecordDigest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DSRecordDigest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DSRecordDigest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
