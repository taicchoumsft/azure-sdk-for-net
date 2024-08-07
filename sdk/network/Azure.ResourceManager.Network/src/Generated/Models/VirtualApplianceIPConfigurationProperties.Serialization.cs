// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class VirtualApplianceIPConfigurationProperties : IUtf8JsonSerializable, IJsonModel<VirtualApplianceIPConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualApplianceIPConfigurationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualApplianceIPConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplianceIPConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualApplianceIPConfigurationProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsPrimary))
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
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

        VirtualApplianceIPConfigurationProperties IJsonModel<VirtualApplianceIPConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplianceIPConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualApplianceIPConfigurationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualApplianceIPConfigurationProperties(document.RootElement, options);
        }

        internal static VirtualApplianceIPConfigurationProperties DeserializeVirtualApplianceIPConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? primary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primary = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualApplianceIPConfigurationProperties(primary, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualApplianceIPConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplianceIPConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualApplianceIPConfigurationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualApplianceIPConfigurationProperties IPersistableModel<VirtualApplianceIPConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplianceIPConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualApplianceIPConfigurationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualApplianceIPConfigurationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualApplianceIPConfigurationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
