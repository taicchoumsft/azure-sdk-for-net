// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class OriginGroupOverrideActionProperties : IUtf8JsonSerializable, IJsonModel<OriginGroupOverrideActionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OriginGroupOverrideActionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OriginGroupOverrideActionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OriginGroupOverrideActionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OriginGroupOverrideActionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WritePropertyName("originGroup"u8);
            JsonSerializer.Serialize(writer, OriginGroup);
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

        OriginGroupOverrideActionProperties IJsonModel<OriginGroupOverrideActionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OriginGroupOverrideActionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OriginGroupOverrideActionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOriginGroupOverrideActionProperties(document.RootElement, options);
        }

        internal static OriginGroupOverrideActionProperties DeserializeOriginGroupOverrideActionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OriginGroupOverrideActionType typeName = default;
            WritableSubResource originGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new OriginGroupOverrideActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("originGroup"u8))
                {
                    originGroup = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OriginGroupOverrideActionProperties(typeName, originGroup, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OriginGroupOverrideActionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OriginGroupOverrideActionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OriginGroupOverrideActionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        OriginGroupOverrideActionProperties IPersistableModel<OriginGroupOverrideActionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OriginGroupOverrideActionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOriginGroupOverrideActionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OriginGroupOverrideActionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OriginGroupOverrideActionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
