// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheHealth : IUtf8JsonSerializable, IJsonModel<StorageCacheHealth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheHealth>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageCacheHealth>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheHealth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheHealth)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(StatusDescription))
            {
                writer.WritePropertyName("statusDescription"u8);
                writer.WriteStringValue(StatusDescription);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions"u8);
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        StorageCacheHealth IJsonModel<StorageCacheHealth>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheHealth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheHealth)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheHealth(document.RootElement, options);
        }

        internal static StorageCacheHealth DeserializeStorageCacheHealth(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageCacheHealthStateType? state = default;
            string statusDescription = default;
            IReadOnlyList<OutstandingCondition> conditions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new StorageCacheHealthStateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDescription"u8))
                {
                    statusDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutstandingCondition> array = new List<OutstandingCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutstandingCondition.DeserializeOutstandingCondition(item, options));
                    }
                    conditions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageCacheHealth(state, statusDescription, conditions ?? new ChangeTrackingList<OutstandingCondition>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheHealth>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheHealth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheHealth)} does not support writing '{options.Format}' format.");
            }
        }

        StorageCacheHealth IPersistableModel<StorageCacheHealth>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheHealth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheHealth(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageCacheHealth)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheHealth>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
