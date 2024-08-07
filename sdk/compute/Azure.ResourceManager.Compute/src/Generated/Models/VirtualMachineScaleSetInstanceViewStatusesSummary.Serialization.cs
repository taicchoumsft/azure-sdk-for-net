// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class VirtualMachineScaleSetInstanceViewStatusesSummary : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetInstanceViewStatusesSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetInstanceViewStatusesSummary)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(StatusesSummary))
            {
                writer.WritePropertyName("statusesSummary"u8);
                writer.WriteStartArray();
                foreach (var item in StatusesSummary)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        VirtualMachineScaleSetInstanceViewStatusesSummary IJsonModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetInstanceViewStatusesSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetInstanceViewStatusesSummary DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<VirtualMachineStatusCodeCount> statusesSummary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusesSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineStatusCodeCount> array = new List<VirtualMachineStatusCodeCount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineStatusCodeCount.DeserializeVirtualMachineStatusCodeCount(item, options));
                    }
                    statusesSummary = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineScaleSetInstanceViewStatusesSummary(statusesSummary ?? new ChangeTrackingList<VirtualMachineStatusCodeCount>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetInstanceViewStatusesSummary)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetInstanceViewStatusesSummary IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetInstanceViewStatusesSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
