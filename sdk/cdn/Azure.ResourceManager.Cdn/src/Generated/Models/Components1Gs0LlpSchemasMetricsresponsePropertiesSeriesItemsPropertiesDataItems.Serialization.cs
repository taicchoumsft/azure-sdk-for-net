// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems : IUtf8JsonSerializable, IJsonModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DateOn))
            {
                writer.WritePropertyName("dateTime"u8);
                writer.WriteStringValue(DateOn.Value, "O");
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
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

        Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems IJsonModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComponents1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems(document.RootElement, options);
        }

        internal static Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems DeserializeComponents1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? dateTime = default;
            float? value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems(dateTime, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support writing '{options.Format}' format.");
            }
        }

        Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems IPersistableModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComponents1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
