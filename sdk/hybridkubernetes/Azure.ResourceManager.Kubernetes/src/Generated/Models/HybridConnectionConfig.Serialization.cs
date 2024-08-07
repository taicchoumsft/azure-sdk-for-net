// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kubernetes.Models
{
    public partial class HybridConnectionConfig : IUtf8JsonSerializable, IJsonModel<HybridConnectionConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridConnectionConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HybridConnectionConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridConnectionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridConnectionConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ExpirationTime))
            {
                writer.WritePropertyName("expirationTime"u8);
                writer.WriteNumberValue(ExpirationTime.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(HybridConnectionName))
            {
                writer.WritePropertyName("hybridConnectionName"u8);
                writer.WriteStringValue(HybridConnectionName);
            }
            if (options.Format != "W" && Optional.IsDefined(Relay))
            {
                writer.WritePropertyName("relay"u8);
                writer.WriteStringValue(Relay);
            }
            if (options.Format != "W" && Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
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

        HybridConnectionConfig IJsonModel<HybridConnectionConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridConnectionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridConnectionConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridConnectionConfig(document.RootElement, options);
        }

        internal static HybridConnectionConfig DeserializeHybridConnectionConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? expirationTime = default;
            string hybridConnectionName = default;
            string relay = default;
            string token = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("hybridConnectionName"u8))
                {
                    hybridConnectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relay"u8))
                {
                    relay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HybridConnectionConfig(expirationTime, hybridConnectionName, relay, token, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridConnectionConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridConnectionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridConnectionConfig)} does not support writing '{options.Format}' format.");
            }
        }

        HybridConnectionConfig IPersistableModel<HybridConnectionConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridConnectionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridConnectionConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridConnectionConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridConnectionConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
