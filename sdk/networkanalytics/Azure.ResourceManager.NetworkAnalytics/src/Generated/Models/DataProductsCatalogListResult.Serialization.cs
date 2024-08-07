// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    internal partial class DataProductsCatalogListResult : IUtf8JsonSerializable, IJsonModel<DataProductsCatalogListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProductsCatalogListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataProductsCatalogListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductsCatalogListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProductsCatalogListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink.AbsoluteUri);
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

        DataProductsCatalogListResult IJsonModel<DataProductsCatalogListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductsCatalogListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProductsCatalogListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProductsCatalogListResult(document.RootElement, options);
        }

        internal static DataProductsCatalogListResult DeserializeDataProductsCatalogListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataProductsCatalogData> value = default;
            Uri nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataProductsCatalogData> array = new List<DataProductsCatalogData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProductsCatalogData.DeserializeDataProductsCatalogData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataProductsCatalogListResult(value, nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProductsCatalogListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductsCatalogListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProductsCatalogListResult)} does not support writing '{options.Format}' format.");
            }
        }

        DataProductsCatalogListResult IPersistableModel<DataProductsCatalogListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductsCatalogListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProductsCatalogListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProductsCatalogListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProductsCatalogListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
