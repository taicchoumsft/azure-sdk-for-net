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
    public partial class SynapseOptimizedAutoscale : IUtf8JsonSerializable, IJsonModel<SynapseOptimizedAutoscale>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseOptimizedAutoscale>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseOptimizedAutoscale>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseOptimizedAutoscale>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseOptimizedAutoscale)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("version"u8);
            writer.WriteNumberValue(Version);
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("minimum"u8);
            writer.WriteNumberValue(Minimum);
            writer.WritePropertyName("maximum"u8);
            writer.WriteNumberValue(Maximum);
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

        SynapseOptimizedAutoscale IJsonModel<SynapseOptimizedAutoscale>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseOptimizedAutoscale>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseOptimizedAutoscale)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseOptimizedAutoscale(document.RootElement, options);
        }

        internal static SynapseOptimizedAutoscale DeserializeSynapseOptimizedAutoscale(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int version = default;
            bool isEnabled = default;
            int minimum = default;
            int maximum = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    maximum = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseOptimizedAutoscale(version, isEnabled, minimum, maximum, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseOptimizedAutoscale>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseOptimizedAutoscale>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseOptimizedAutoscale)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseOptimizedAutoscale IPersistableModel<SynapseOptimizedAutoscale>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseOptimizedAutoscale>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseOptimizedAutoscale(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseOptimizedAutoscale)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseOptimizedAutoscale>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
