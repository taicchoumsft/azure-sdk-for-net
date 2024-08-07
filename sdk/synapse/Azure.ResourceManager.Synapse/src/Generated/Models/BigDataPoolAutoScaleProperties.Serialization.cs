// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class BigDataPoolAutoScaleProperties : IUtf8JsonSerializable, IJsonModel<BigDataPoolAutoScaleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BigDataPoolAutoScaleProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BigDataPoolAutoScaleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BigDataPoolAutoScaleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BigDataPoolAutoScaleProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MinNodeCount))
            {
                writer.WritePropertyName("minNodeCount"u8);
                writer.WriteNumberValue(MinNodeCount.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(MaxNodeCount))
            {
                writer.WritePropertyName("maxNodeCount"u8);
                writer.WriteNumberValue(MaxNodeCount.Value);
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

        BigDataPoolAutoScaleProperties IJsonModel<BigDataPoolAutoScaleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BigDataPoolAutoScaleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BigDataPoolAutoScaleProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBigDataPoolAutoScaleProperties(document.RootElement, options);
        }

        internal static BigDataPoolAutoScaleProperties DeserializeBigDataPoolAutoScaleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? minNodeCount = default;
            bool? enabled = default;
            int? maxNodeCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BigDataPoolAutoScaleProperties(minNodeCount, enabled, maxNodeCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BigDataPoolAutoScaleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BigDataPoolAutoScaleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BigDataPoolAutoScaleProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BigDataPoolAutoScaleProperties IPersistableModel<BigDataPoolAutoScaleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BigDataPoolAutoScaleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBigDataPoolAutoScaleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BigDataPoolAutoScaleProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BigDataPoolAutoScaleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
