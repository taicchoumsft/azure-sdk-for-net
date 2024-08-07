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
    internal partial class MarketplaceGalleryImagesListResult : IUtf8JsonSerializable, IJsonModel<MarketplaceGalleryImagesListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceGalleryImagesListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MarketplaceGalleryImagesListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceGalleryImagesListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceGalleryImagesListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        MarketplaceGalleryImagesListResult IJsonModel<MarketplaceGalleryImagesListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceGalleryImagesListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceGalleryImagesListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceGalleryImagesListResult(document.RootElement, options);
        }

        internal static MarketplaceGalleryImagesListResult DeserializeMarketplaceGalleryImagesListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MarketplaceGalleryImageData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MarketplaceGalleryImageData> array = new List<MarketplaceGalleryImageData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MarketplaceGalleryImageData.DeserializeMarketplaceGalleryImageData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MarketplaceGalleryImagesListResult(value ?? new ChangeTrackingList<MarketplaceGalleryImageData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceGalleryImagesListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceGalleryImagesListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceGalleryImagesListResult)} does not support writing '{options.Format}' format.");
            }
        }

        MarketplaceGalleryImagesListResult IPersistableModel<MarketplaceGalleryImagesListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceGalleryImagesListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarketplaceGalleryImagesListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceGalleryImagesListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceGalleryImagesListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
