// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciPrecheckResultTags : IUtf8JsonSerializable, IJsonModel<HciPrecheckResultTags>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciPrecheckResultTags>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HciPrecheckResultTags>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciPrecheckResultTags>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciPrecheckResultTags)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        HciPrecheckResultTags IJsonModel<HciPrecheckResultTags>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciPrecheckResultTags>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciPrecheckResultTags)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciPrecheckResultTags(document.RootElement, options);
        }

        internal static HciPrecheckResultTags DeserializeHciPrecheckResultTags(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            string value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
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
            return new HciPrecheckResultTags(key, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HciPrecheckResultTags>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciPrecheckResultTags>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HciPrecheckResultTags)} does not support writing '{options.Format}' format.");
            }
        }

        HciPrecheckResultTags IPersistableModel<HciPrecheckResultTags>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciPrecheckResultTags>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHciPrecheckResultTags(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciPrecheckResultTags)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciPrecheckResultTags>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
