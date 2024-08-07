// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class ComputeVmProperties : IUtf8JsonSerializable, IJsonModel<ComputeVmProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeVmProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeVmProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeVmProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeVmProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(NetworkInterfaceId))
            {
                writer.WritePropertyName("networkInterfaceId"u8);
                writer.WriteStringValue(NetworkInterfaceId);
            }
            if (Optional.IsDefined(OSDiskId))
            {
                writer.WritePropertyName("osDiskId"u8);
                writer.WriteStringValue(OSDiskId);
            }
            if (Optional.IsCollectionDefined(DataDiskIds))
            {
                writer.WritePropertyName("dataDiskIds"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
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

        ComputeVmProperties IJsonModel<ComputeVmProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeVmProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeVmProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeVmProperties(document.RootElement, options);
        }

        internal static ComputeVmProperties DeserializeComputeVmProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ComputeVmInstanceViewStatus> statuses = default;
            string osType = default;
            string vmSize = default;
            string networkInterfaceId = default;
            string osDiskId = default;
            IReadOnlyList<string> dataDiskIds = default;
            IReadOnlyList<ComputeDataDisk> dataDisks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeVmInstanceViewStatus> array = new List<ComputeVmInstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeVmInstanceViewStatus.DeserializeComputeVmInstanceViewStatus(item, options));
                    }
                    statuses = array;
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkInterfaceId"u8))
                {
                    networkInterfaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDiskId"u8))
                {
                    osDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataDiskIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dataDiskIds = array;
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeDataDisk> array = new List<ComputeDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeDataDisk.DeserializeComputeDataDisk(item, options));
                    }
                    dataDisks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeVmProperties(
                statuses ?? new ChangeTrackingList<ComputeVmInstanceViewStatus>(),
                osType,
                vmSize,
                networkInterfaceId,
                osDiskId,
                dataDiskIds ?? new ChangeTrackingList<string>(),
                dataDisks ?? new ChangeTrackingList<ComputeDataDisk>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeVmProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeVmProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeVmProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeVmProperties IPersistableModel<ComputeVmProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeVmProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeVmProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeVmProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeVmProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
