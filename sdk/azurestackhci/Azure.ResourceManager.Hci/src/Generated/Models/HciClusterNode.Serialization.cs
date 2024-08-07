// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterNode : IUtf8JsonSerializable, IJsonModel<HciClusterNode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciClusterNode>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HciClusterNode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterNode)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(WindowsServerSubscription))
            {
                writer.WritePropertyName("windowsServerSubscription"u8);
                writer.WriteStringValue(WindowsServerSubscription.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(NodeType))
            {
                writer.WritePropertyName("nodeType"u8);
                writer.WriteStringValue(NodeType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(EhcResourceId))
            {
                writer.WritePropertyName("ehcResourceId"u8);
                writer.WriteStringValue(EhcResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(Manufacturer))
            {
                writer.WritePropertyName("manufacturer"u8);
                writer.WriteStringValue(Manufacturer);
            }
            if (options.Format != "W" && Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (options.Format != "W" && Optional.IsDefined(OSName))
            {
                writer.WritePropertyName("osName"u8);
                writer.WriteStringValue(OSName);
            }
            if (options.Format != "W" && Optional.IsDefined(OSVersion))
            {
                writer.WritePropertyName("osVersion"u8);
                writer.WriteStringValue(OSVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(OSDisplayVersion))
            {
                writer.WritePropertyName("osDisplayVersion"u8);
                writer.WriteStringValue(OSDisplayVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(CoreCount))
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemoryInGiB))
            {
                writer.WritePropertyName("memoryInGiB"u8);
                writer.WriteNumberValue(MemoryInGiB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastLicensingTimestamp))
            {
                writer.WritePropertyName("lastLicensingTimestamp"u8);
                writer.WriteStringValue(LastLicensingTimestamp.Value, "O");
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

        HciClusterNode IJsonModel<HciClusterNode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterNode)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciClusterNode(document.RootElement, options);
        }

        internal static HciClusterNode DeserializeHciClusterNode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            float? id = default;
            WindowsServerSubscription? windowsServerSubscription = default;
            ClusterNodeType? nodeType = default;
            string ehcResourceId = default;
            string manufacturer = default;
            string model = default;
            string osName = default;
            string osVersion = default;
            string osDisplayVersion = default;
            string serialNumber = default;
            float? coreCount = default;
            float? memoryInGiB = default;
            DateTimeOffset? lastLicensingTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("windowsServerSubscription"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsServerSubscription = new WindowsServerSubscription(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeType = new ClusterNodeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ehcResourceId"u8))
                {
                    ehcResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manufacturer"u8))
                {
                    manufacturer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osVersion"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDisplayVersion"u8))
                {
                    osDisplayVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("memoryInGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("lastLicensingTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastLicensingTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HciClusterNode(
                name,
                id,
                windowsServerSubscription,
                nodeType,
                ehcResourceId,
                manufacturer,
                model,
                osName,
                osVersion,
                osDisplayVersion,
                serialNumber,
                coreCount,
                memoryInGiB,
                lastLicensingTimestamp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HciClusterNode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HciClusterNode)} does not support writing '{options.Format}' format.");
            }
        }

        HciClusterNode IPersistableModel<HciClusterNode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHciClusterNode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciClusterNode)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciClusterNode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
