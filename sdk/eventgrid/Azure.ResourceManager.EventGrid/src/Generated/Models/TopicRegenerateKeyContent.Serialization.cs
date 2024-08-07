// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class TopicRegenerateKeyContent : IUtf8JsonSerializable, IJsonModel<TopicRegenerateKeyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TopicRegenerateKeyContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TopicRegenerateKeyContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopicRegenerateKeyContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
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

        TopicRegenerateKeyContent IJsonModel<TopicRegenerateKeyContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopicRegenerateKeyContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTopicRegenerateKeyContent(document.RootElement, options);
        }

        internal static TopicRegenerateKeyContent DeserializeTopicRegenerateKeyContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TopicRegenerateKeyContent(keyName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TopicRegenerateKeyContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TopicRegenerateKeyContent)} does not support writing '{options.Format}' format.");
            }
        }

        TopicRegenerateKeyContent IPersistableModel<TopicRegenerateKeyContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTopicRegenerateKeyContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TopicRegenerateKeyContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TopicRegenerateKeyContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
