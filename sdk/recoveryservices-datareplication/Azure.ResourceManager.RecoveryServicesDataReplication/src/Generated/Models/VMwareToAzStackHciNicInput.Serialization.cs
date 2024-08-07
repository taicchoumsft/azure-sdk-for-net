// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareToAzStackHciNicInput : IUtf8JsonSerializable, IJsonModel<VMwareToAzStackHciNicInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareToAzStackHciNicInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareToAzStackHciNicInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciNicInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciNicInput)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("nicId"u8);
            writer.WriteStringValue(NicId);
            writer.WritePropertyName("label"u8);
            writer.WriteStringValue(Label);
            if (options.Format != "W" && Optional.IsDefined(NetworkName))
            {
                writer.WritePropertyName("networkName"u8);
                writer.WriteStringValue(NetworkName);
            }
            writer.WritePropertyName("targetNetworkId"u8);
            writer.WriteStringValue(TargetNetworkId);
            writer.WritePropertyName("testNetworkId"u8);
            writer.WriteStringValue(TestNetworkId);
            writer.WritePropertyName("selectionTypeForFailover"u8);
            writer.WriteStringValue(SelectionTypeForFailover.ToString());
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

        VMwareToAzStackHciNicInput IJsonModel<VMwareToAzStackHciNicInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciNicInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciNicInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareToAzStackHciNicInput(document.RootElement, options);
        }

        internal static VMwareToAzStackHciNicInput DeserializeVMwareToAzStackHciNicInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nicId = default;
            string label = default;
            string networkName = default;
            string targetNetworkId = default;
            string testNetworkId = default;
            VmNicSelection selectionTypeForFailover = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkName"u8))
                {
                    networkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    targetNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    testNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectionTypeForFailover"u8))
                {
                    selectionTypeForFailover = new VmNicSelection(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VMwareToAzStackHciNicInput(
                nicId,
                label,
                networkName,
                targetNetworkId,
                testNetworkId,
                selectionTypeForFailover,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareToAzStackHciNicInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciNicInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciNicInput)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareToAzStackHciNicInput IPersistableModel<VMwareToAzStackHciNicInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciNicInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareToAzStackHciNicInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciNicInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareToAzStackHciNicInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
