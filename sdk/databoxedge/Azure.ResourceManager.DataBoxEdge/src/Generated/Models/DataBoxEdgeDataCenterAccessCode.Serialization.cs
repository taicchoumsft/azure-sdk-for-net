// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDataCenterAccessCode : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeDataCenterAccessCode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeDataCenterAccessCode>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxEdgeDataCenterAccessCode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDataCenterAccessCode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDataCenterAccessCode)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthCode))
            {
                writer.WritePropertyName("authCode"u8);
                writer.WriteStringValue(AuthCode);
            }
            writer.WriteEndObject();
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

        DataBoxEdgeDataCenterAccessCode IJsonModel<DataBoxEdgeDataCenterAccessCode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDataCenterAccessCode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDataCenterAccessCode)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDataCenterAccessCode(document.RootElement, options);
        }

        internal static DataBoxEdgeDataCenterAccessCode DeserializeDataBoxEdgeDataCenterAccessCode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("authCode"u8))
                        {
                            authCode = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxEdgeDataCenterAccessCode(authCode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeDataCenterAccessCode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDataCenterAccessCode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDataCenterAccessCode)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxEdgeDataCenterAccessCode IPersistableModel<DataBoxEdgeDataCenterAccessCode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDataCenterAccessCode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeDataCenterAccessCode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDataCenterAccessCode)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeDataCenterAccessCode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
