// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventUpdate : IUtf8JsonSerializable, IJsonModel<ResourceHealthEventUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthEventUpdate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceHealthEventUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventUpdate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updateDateTime"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
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

        ResourceHealthEventUpdate IJsonModel<ResourceHealthEventUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthEventUpdate(document.RootElement, options);
        }

        internal static ResourceHealthEventUpdate DeserializeResourceHealthEventUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string summary = default;
            DateTimeOffset? updateDateTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceHealthEventUpdate(summary, updateDateTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceHealthEventUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceHealthEventUpdate IPersistableModel<ResourceHealthEventUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceHealthEventUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthEventUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
