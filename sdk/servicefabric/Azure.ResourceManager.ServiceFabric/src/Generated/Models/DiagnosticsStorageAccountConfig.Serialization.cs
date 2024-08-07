// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class DiagnosticsStorageAccountConfig : IUtf8JsonSerializable, IJsonModel<DiagnosticsStorageAccountConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnosticsStorageAccountConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiagnosticsStorageAccountConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticsStorageAccountConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticsStorageAccountConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountName"u8);
            writer.WriteStringValue(StorageAccountName);
            writer.WritePropertyName("protectedAccountKeyName"u8);
            writer.WriteStringValue(ProtectedAccountKeyName);
            if (Optional.IsDefined(ProtectedAccountKeyName2))
            {
                writer.WritePropertyName("protectedAccountKeyName2"u8);
                writer.WriteStringValue(ProtectedAccountKeyName2);
            }
            writer.WritePropertyName("blobEndpoint"u8);
            writer.WriteStringValue(BlobEndpoint.AbsoluteUri);
            writer.WritePropertyName("queueEndpoint"u8);
            writer.WriteStringValue(QueueEndpoint.AbsoluteUri);
            writer.WritePropertyName("tableEndpoint"u8);
            writer.WriteStringValue(TableEndpoint.AbsoluteUri);
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

        DiagnosticsStorageAccountConfig IJsonModel<DiagnosticsStorageAccountConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticsStorageAccountConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticsStorageAccountConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticsStorageAccountConfig(document.RootElement, options);
        }

        internal static DiagnosticsStorageAccountConfig DeserializeDiagnosticsStorageAccountConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageAccountName = default;
            string protectedAccountKeyName = default;
            string protectedAccountKeyName2 = default;
            Uri blobEndpoint = default;
            Uri queueEndpoint = default;
            Uri tableEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedAccountKeyName"u8))
                {
                    protectedAccountKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedAccountKeyName2"u8))
                {
                    protectedAccountKeyName2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobEndpoint"u8))
                {
                    blobEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queueEndpoint"u8))
                {
                    queueEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tableEndpoint"u8))
                {
                    tableEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DiagnosticsStorageAccountConfig(
                storageAccountName,
                protectedAccountKeyName,
                protectedAccountKeyName2,
                blobEndpoint,
                queueEndpoint,
                tableEndpoint,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiagnosticsStorageAccountConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticsStorageAccountConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiagnosticsStorageAccountConfig)} does not support writing '{options.Format}' format.");
            }
        }

        DiagnosticsStorageAccountConfig IPersistableModel<DiagnosticsStorageAccountConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticsStorageAccountConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiagnosticsStorageAccountConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiagnosticsStorageAccountConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiagnosticsStorageAccountConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
