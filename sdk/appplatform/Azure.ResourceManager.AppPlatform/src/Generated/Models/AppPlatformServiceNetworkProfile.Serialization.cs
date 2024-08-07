// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformServiceNetworkProfile : IUtf8JsonSerializable, IJsonModel<AppPlatformServiceNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformServiceNetworkProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformServiceNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceNetworkProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceRuntimeSubnetId))
            {
                writer.WritePropertyName("serviceRuntimeSubnetId"u8);
                writer.WriteStringValue(ServiceRuntimeSubnetId);
            }
            if (Optional.IsDefined(AppSubnetId))
            {
                writer.WritePropertyName("appSubnetId"u8);
                writer.WriteStringValue(AppSubnetId);
            }
            if (Optional.IsDefined(ServiceCidr))
            {
                writer.WritePropertyName("serviceCidr"u8);
                writer.WriteStringValue(ServiceCidr);
            }
            if (Optional.IsDefined(ServiceRuntimeNetworkResourceGroup))
            {
                writer.WritePropertyName("serviceRuntimeNetworkResourceGroup"u8);
                writer.WriteStringValue(ServiceRuntimeNetworkResourceGroup);
            }
            if (Optional.IsDefined(AppNetworkResourceGroup))
            {
                writer.WritePropertyName("appNetworkResourceGroup"u8);
                writer.WriteStringValue(AppNetworkResourceGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(OutboundIPs))
            {
                writer.WritePropertyName("outboundIPs"u8);
                writer.WriteObjectValue(OutboundIPs, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RequiredTraffics))
            {
                writer.WritePropertyName("requiredTraffics"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredTraffics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IngressConfig))
            {
                writer.WritePropertyName("ingressConfig"u8);
                writer.WriteObjectValue(IngressConfig, options);
            }
            if (Optional.IsDefined(OutboundType))
            {
                writer.WritePropertyName("outboundType"u8);
                writer.WriteStringValue(OutboundType);
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

        AppPlatformServiceNetworkProfile IJsonModel<AppPlatformServiceNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceNetworkProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformServiceNetworkProfile(document.RootElement, options);
        }

        internal static AppPlatformServiceNetworkProfile DeserializeAppPlatformServiceNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier serviceRuntimeSubnetId = default;
            ResourceIdentifier appSubnetId = default;
            string serviceCidr = default;
            string serviceRuntimeNetworkResourceGroup = default;
            string appNetworkResourceGroup = default;
            NetworkProfileOutboundIPs outboundIPs = default;
            IReadOnlyList<AppPlatformServiceRequiredTraffic> requiredTraffics = default;
            IngressConfig ingressConfig = default;
            string outboundType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceRuntimeSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceRuntimeSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceCidr"u8))
                {
                    serviceCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceRuntimeNetworkResourceGroup"u8))
                {
                    serviceRuntimeNetworkResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appNetworkResourceGroup"u8))
                {
                    appNetworkResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPs = NetworkProfileOutboundIPs.DeserializeNetworkProfileOutboundIPs(property.Value, options);
                    continue;
                }
                if (property.NameEquals("requiredTraffics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformServiceRequiredTraffic> array = new List<AppPlatformServiceRequiredTraffic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformServiceRequiredTraffic.DeserializeAppPlatformServiceRequiredTraffic(item, options));
                    }
                    requiredTraffics = array;
                    continue;
                }
                if (property.NameEquals("ingressConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressConfig = IngressConfig.DeserializeIngressConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("outboundType"u8))
                {
                    outboundType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformServiceNetworkProfile(
                serviceRuntimeSubnetId,
                appSubnetId,
                serviceCidr,
                serviceRuntimeNetworkResourceGroup,
                appNetworkResourceGroup,
                outboundIPs,
                requiredTraffics ?? new ChangeTrackingList<AppPlatformServiceRequiredTraffic>(),
                ingressConfig,
                outboundType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformServiceNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformServiceNetworkProfile)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformServiceNetworkProfile IPersistableModel<AppPlatformServiceNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformServiceNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformServiceNetworkProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformServiceNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
