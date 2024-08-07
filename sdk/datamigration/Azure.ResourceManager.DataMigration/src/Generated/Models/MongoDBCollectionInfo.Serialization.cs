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
    public partial class MongoDBCollectionInfo : IUtf8JsonSerializable, IJsonModel<MongoDBCollectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBCollectionInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MongoDBCollectionInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBCollectionInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("isCapped"u8);
            writer.WriteBooleanValue(IsCapped);
            writer.WritePropertyName("isSystemCollection"u8);
            writer.WriteBooleanValue(IsSystemCollection);
            writer.WritePropertyName("isView"u8);
            writer.WriteBooleanValue(IsView);
            if (Optional.IsDefined(ShardKey))
            {
                writer.WritePropertyName("shardKey"u8);
                writer.WriteObjectValue(ShardKey, options);
            }
            writer.WritePropertyName("supportsSharding"u8);
            writer.WriteBooleanValue(SupportsSharding);
            if (Optional.IsDefined(ViewOf))
            {
                writer.WritePropertyName("viewOf"u8);
                writer.WriteStringValue(ViewOf);
            }
            writer.WritePropertyName("averageDocumentSize"u8);
            writer.WriteNumberValue(AverageDocumentSize);
            writer.WritePropertyName("dataSize"u8);
            writer.WriteNumberValue(DataSize);
            writer.WritePropertyName("documentCount"u8);
            writer.WriteNumberValue(DocumentCount);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("qualifiedName"u8);
            writer.WriteStringValue(QualifiedName);
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

        MongoDBCollectionInfo IJsonModel<MongoDBCollectionInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBCollectionInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBCollectionInfo(document.RootElement, options);
        }

        internal static MongoDBCollectionInfo DeserializeMongoDBCollectionInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            bool isCapped = default;
            bool isSystemCollection = default;
            bool isView = default;
            MongoDBShardKeyInfo shardKey = default;
            bool supportsSharding = default;
            string viewOf = default;
            long averageDocumentSize = default;
            long dataSize = default;
            long documentCount = default;
            string name = default;
            string qualifiedName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCapped"u8))
                {
                    isCapped = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSystemCollection"u8))
                {
                    isSystemCollection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isView"u8))
                {
                    isView = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("shardKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shardKey = MongoDBShardKeyInfo.DeserializeMongoDBShardKeyInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("supportsSharding"u8))
                {
                    supportsSharding = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("viewOf"u8))
                {
                    viewOf = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("averageDocumentSize"u8))
                {
                    averageDocumentSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataSize"u8))
                {
                    dataSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentCount"u8))
                {
                    documentCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MongoDBCollectionInfo(
                averageDocumentSize,
                dataSize,
                documentCount,
                name,
                qualifiedName,
                serializedAdditionalRawData,
                databaseName,
                isCapped,
                isSystemCollection,
                isView,
                shardKey,
                supportsSharding,
                viewOf);
        }

        BinaryData IPersistableModel<MongoDBCollectionInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBCollectionInfo)} does not support writing '{options.Format}' format.");
            }
        }

        MongoDBCollectionInfo IPersistableModel<MongoDBCollectionInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBCollectionInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBCollectionInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBCollectionInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
