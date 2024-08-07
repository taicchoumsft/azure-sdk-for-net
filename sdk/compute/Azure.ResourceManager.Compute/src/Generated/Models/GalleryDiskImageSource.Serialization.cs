// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryDiskImageSource : IUtf8JsonSerializable, IJsonModel<GalleryDiskImageSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryDiskImageSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GalleryDiskImageSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryDiskImageSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryDiskImageSource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        GalleryDiskImageSource IJsonModel<GalleryDiskImageSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryDiskImageSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryDiskImageSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryDiskImageSource(document.RootElement, options);
        }

        internal static GalleryDiskImageSource DeserializeGalleryDiskImageSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri uri = default;
            ResourceIdentifier storageAccountId = default;
            ResourceIdentifier id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GalleryDiskImageSource(id, serializedAdditionalRawData, uri, storageAccountId);
        }

        BinaryData IPersistableModel<GalleryDiskImageSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryDiskImageSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryDiskImageSource)} does not support writing '{options.Format}' format.");
            }
        }

        GalleryDiskImageSource IPersistableModel<GalleryDiskImageSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryDiskImageSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryDiskImageSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryDiskImageSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryDiskImageSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
