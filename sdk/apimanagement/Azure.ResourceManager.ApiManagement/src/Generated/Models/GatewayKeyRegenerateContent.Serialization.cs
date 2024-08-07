// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class GatewayKeyRegenerateContent : IUtf8JsonSerializable, IJsonModel<GatewayKeyRegenerateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GatewayKeyRegenerateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GatewayKeyRegenerateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayKeyRegenerateContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyType"u8);
            writer.WriteStringValue(KeyType.ToSerialString());
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

        GatewayKeyRegenerateContent IJsonModel<GatewayKeyRegenerateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayKeyRegenerateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGatewayKeyRegenerateContent(document.RootElement, options);
        }

        internal static GatewayKeyRegenerateContent DeserializeGatewayKeyRegenerateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GatewayRegenerateKeyType keyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyType"u8))
                {
                    keyType = property.Value.GetString().ToGatewayRegenerateKeyType();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GatewayKeyRegenerateContent(keyType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GatewayKeyRegenerateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GatewayKeyRegenerateContent)} does not support writing '{options.Format}' format.");
            }
        }

        GatewayKeyRegenerateContent IPersistableModel<GatewayKeyRegenerateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGatewayKeyRegenerateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GatewayKeyRegenerateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GatewayKeyRegenerateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
