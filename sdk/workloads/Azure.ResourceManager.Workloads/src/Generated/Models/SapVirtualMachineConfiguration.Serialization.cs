// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapVirtualMachineConfiguration : IUtf8JsonSerializable, IJsonModel<SapVirtualMachineConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapVirtualMachineConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SapVirtualMachineConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapVirtualMachineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapVirtualMachineConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("vmSize"u8);
            writer.WriteStringValue(VmSize);
            writer.WritePropertyName("imageReference"u8);
            writer.WriteObjectValue(ImageReference, options);
            writer.WritePropertyName("osProfile"u8);
            writer.WriteObjectValue(OSProfile, options);
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

        SapVirtualMachineConfiguration IJsonModel<SapVirtualMachineConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapVirtualMachineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapVirtualMachineConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapVirtualMachineConfiguration(document.RootElement, options);
        }

        internal static SapVirtualMachineConfiguration DeserializeSapVirtualMachineConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vmSize = default;
            SapImageReference imageReference = default;
            SapOSProfile osProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    imageReference = SapImageReference.DeserializeSapImageReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("osProfile"u8))
                {
                    osProfile = SapOSProfile.DeserializeSapOSProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SapVirtualMachineConfiguration(vmSize, imageReference, osProfile, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapVirtualMachineConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapVirtualMachineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapVirtualMachineConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        SapVirtualMachineConfiguration IPersistableModel<SapVirtualMachineConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapVirtualMachineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapVirtualMachineConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapVirtualMachineConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapVirtualMachineConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
