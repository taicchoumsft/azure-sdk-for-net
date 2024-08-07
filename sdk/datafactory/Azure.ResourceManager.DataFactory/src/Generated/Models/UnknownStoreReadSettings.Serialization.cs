// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class UnknownStoreReadSettings : IUtf8JsonSerializable, IJsonModel<StoreReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StoreReadSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StoreReadSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoreReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoreReadSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StoreReadSettingsType);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        StoreReadSettings IJsonModel<StoreReadSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoreReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoreReadSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStoreReadSettings(document.RootElement, options);
        }

        internal static UnknownStoreReadSettings DeserializeUnknownStoreReadSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            DataFactoryElement<int> maxConcurrentConnections = default;
            DataFactoryElement<bool> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownStoreReadSettings(type, maxConcurrentConnections, disableMetricsCollection, additionalProperties);
        }

        BinaryData IPersistableModel<StoreReadSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoreReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StoreReadSettings)} does not support writing '{options.Format}' format.");
            }
        }

        StoreReadSettings IPersistableModel<StoreReadSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoreReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStoreReadSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StoreReadSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StoreReadSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
