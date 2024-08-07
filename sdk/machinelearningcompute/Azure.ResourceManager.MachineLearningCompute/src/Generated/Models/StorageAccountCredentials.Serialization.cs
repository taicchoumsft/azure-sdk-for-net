// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class StorageAccountCredentials : IUtf8JsonSerializable, IJsonModel<StorageAccountCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountCredentials>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageAccountCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountCredentials)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
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

        StorageAccountCredentials IJsonModel<StorageAccountCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountCredentials)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountCredentials(document.RootElement, options);
        }

        internal static StorageAccountCredentials DeserializeStorageAccountCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceId = default;
            string primaryKey = default;
            string secondaryKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageAccountCredentials(resourceId, primaryKey, secondaryKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountCredentials)} does not support writing '{options.Format}' format.");
            }
        }

        StorageAccountCredentials IPersistableModel<StorageAccountCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountCredentials)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
