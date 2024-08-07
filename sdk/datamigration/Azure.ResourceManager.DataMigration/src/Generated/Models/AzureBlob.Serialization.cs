// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class AzureBlob : IUtf8JsonSerializable, IJsonModel<AzureBlob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureBlob>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureBlob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureBlob)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId"u8);
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey"u8);
                writer.WriteStringValue(AccountKey);
            }
            if (Optional.IsDefined(BlobContainerName))
            {
                writer.WritePropertyName("blobContainerName"u8);
                writer.WriteStringValue(BlobContainerName);
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

        AzureBlob IJsonModel<AzureBlob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureBlob)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureBlob(document.RootElement, options);
        }

        internal static AzureBlob DeserializeAzureBlob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageAccountResourceId = default;
            string accountKey = default;
            string blobContainerName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountResourceId"u8))
                {
                    storageAccountResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobContainerName"u8))
                {
                    blobContainerName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureBlob(storageAccountResourceId, accountKey, blobContainerName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureBlob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureBlob)} does not support writing '{options.Format}' format.");
            }
        }

        AzureBlob IPersistableModel<AzureBlob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureBlob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureBlob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureBlob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
