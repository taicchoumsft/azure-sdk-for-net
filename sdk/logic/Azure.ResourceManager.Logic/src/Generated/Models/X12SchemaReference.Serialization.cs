// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12SchemaReference : IUtf8JsonSerializable, IJsonModel<X12SchemaReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12SchemaReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<X12SchemaReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12SchemaReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12SchemaReference)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("messageId"u8);
            writer.WriteStringValue(MessageId);
            if (Optional.IsDefined(SenderApplicationId))
            {
                writer.WritePropertyName("senderApplicationId"u8);
                writer.WriteStringValue(SenderApplicationId);
            }
            writer.WritePropertyName("schemaVersion"u8);
            writer.WriteStringValue(SchemaVersion);
            writer.WritePropertyName("schemaName"u8);
            writer.WriteStringValue(SchemaName);
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

        X12SchemaReference IJsonModel<X12SchemaReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12SchemaReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12SchemaReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12SchemaReference(document.RootElement, options);
        }

        internal static X12SchemaReference DeserializeX12SchemaReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            string senderApplicationId = default;
            string schemaVersion = default;
            string schemaName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderApplicationId"u8))
                {
                    senderApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    schemaVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new X12SchemaReference(messageId, senderApplicationId, schemaVersion, schemaName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<X12SchemaReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12SchemaReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(X12SchemaReference)} does not support writing '{options.Format}' format.");
            }
        }

        X12SchemaReference IPersistableModel<X12SchemaReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12SchemaReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeX12SchemaReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(X12SchemaReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<X12SchemaReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
