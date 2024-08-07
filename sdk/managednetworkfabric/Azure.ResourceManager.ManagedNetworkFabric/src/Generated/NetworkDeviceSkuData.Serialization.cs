// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkDeviceSkuData : IUtf8JsonSerializable, IJsonModel<NetworkDeviceSkuData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkDeviceSkuData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkDeviceSkuData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceSkuData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkDeviceSkuData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model);
            if (Optional.IsDefined(Manufacturer))
            {
                writer.WritePropertyName("manufacturer"u8);
                writer.WriteStringValue(Manufacturer);
            }
            if (Optional.IsCollectionDefined(SupportedVersions))
            {
                writer.WritePropertyName("supportedVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedVersions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedRoleTypes))
            {
                writer.WritePropertyName("supportedRoleTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedRoleTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Interfaces))
            {
                writer.WritePropertyName("interfaces"u8);
                writer.WriteStartArray();
                foreach (var item in Interfaces)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
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

        NetworkDeviceSkuData IJsonModel<NetworkDeviceSkuData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceSkuData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkDeviceSkuData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkDeviceSkuData(document.RootElement, options);
        }

        internal static NetworkDeviceSkuData DeserializeNetworkDeviceSkuData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string model = default;
            string manufacturer = default;
            IList<SupportedVersionProperties> supportedVersions = default;
            IList<NetworkDeviceRoleName> supportedRoleTypes = default;
            IList<NetworkDeviceInterfaceProperties> interfaces = default;
            NetworkFabricProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("model"u8))
                        {
                            model = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("manufacturer"u8))
                        {
                            manufacturer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("supportedVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SupportedVersionProperties> array = new List<SupportedVersionProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SupportedVersionProperties.DeserializeSupportedVersionProperties(item, options));
                            }
                            supportedVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedRoleTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkDeviceRoleName> array = new List<NetworkDeviceRoleName>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new NetworkDeviceRoleName(item.GetString()));
                            }
                            supportedRoleTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("interfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkDeviceInterfaceProperties> array = new List<NetworkDeviceInterfaceProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkDeviceInterfaceProperties.DeserializeNetworkDeviceInterfaceProperties(item, options));
                            }
                            interfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkDeviceSkuData(
                id,
                name,
                type,
                systemData,
                model,
                manufacturer,
                supportedVersions ?? new ChangeTrackingList<SupportedVersionProperties>(),
                supportedRoleTypes ?? new ChangeTrackingList<NetworkDeviceRoleName>(),
                interfaces ?? new ChangeTrackingList<NetworkDeviceInterfaceProperties>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkDeviceSkuData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceSkuData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkDeviceSkuData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkDeviceSkuData IPersistableModel<NetworkDeviceSkuData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceSkuData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkDeviceSkuData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkDeviceSkuData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkDeviceSkuData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
