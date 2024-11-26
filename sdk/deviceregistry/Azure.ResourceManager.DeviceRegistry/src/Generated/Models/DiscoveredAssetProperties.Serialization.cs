// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class DiscoveredAssetProperties : IUtf8JsonSerializable, IJsonModel<DiscoveredAssetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiscoveredAssetProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiscoveredAssetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveredAssetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveredAssetProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("assetEndpointProfileRef"u8);
            writer.WriteStringValue(AssetEndpointProfileRef);
            writer.WritePropertyName("discoveryId"u8);
            writer.WriteStringValue(DiscoveryId);
            writer.WritePropertyName("version"u8);
            writer.WriteNumberValue(Version);
            if (Optional.IsDefined(Manufacturer))
            {
                writer.WritePropertyName("manufacturer"u8);
                writer.WriteStringValue(Manufacturer);
            }
            if (Optional.IsDefined(ManufacturerUri))
            {
                writer.WritePropertyName("manufacturerUri"u8);
                writer.WriteStringValue(ManufacturerUri);
            }
            if (Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (Optional.IsDefined(ProductCode))
            {
                writer.WritePropertyName("productCode"u8);
                writer.WriteStringValue(ProductCode);
            }
            if (Optional.IsDefined(HardwareRevision))
            {
                writer.WritePropertyName("hardwareRevision"u8);
                writer.WriteStringValue(HardwareRevision);
            }
            if (Optional.IsDefined(SoftwareRevision))
            {
                writer.WritePropertyName("softwareRevision"u8);
                writer.WriteStringValue(SoftwareRevision);
            }
            if (Optional.IsDefined(DocumentationUri))
            {
                writer.WritePropertyName("documentationUri"u8);
                writer.WriteStringValue(DocumentationUri);
            }
            if (Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (Optional.IsDefined(DefaultDatasetsConfiguration))
            {
                writer.WritePropertyName("defaultDatasetsConfiguration"u8);
                writer.WriteStringValue(DefaultDatasetsConfiguration);
            }
            if (Optional.IsDefined(DefaultEventsConfiguration))
            {
                writer.WritePropertyName("defaultEventsConfiguration"u8);
                writer.WriteStringValue(DefaultEventsConfiguration);
            }
            if (Optional.IsDefined(DefaultTopic))
            {
                writer.WritePropertyName("defaultTopic"u8);
                writer.WriteObjectValue(DefaultTopic, options);
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
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
        }

        DiscoveredAssetProperties IJsonModel<DiscoveredAssetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveredAssetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveredAssetProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiscoveredAssetProperties(document.RootElement, options);
        }

        internal static DiscoveredAssetProperties DeserializeDiscoveredAssetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assetEndpointProfileRef = default;
            string discoveryId = default;
            long version = default;
            string manufacturer = default;
            string manufacturerUri = default;
            string model = default;
            string productCode = default;
            string hardwareRevision = default;
            string softwareRevision = default;
            string documentationUri = default;
            string serialNumber = default;
            string defaultDatasetsConfiguration = default;
            string defaultEventsConfiguration = default;
            Topic defaultTopic = default;
            IList<DiscoveredDataset> datasets = default;
            IList<DiscoveredEvent> events = default;
            DeviceRegistryProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetEndpointProfileRef"u8))
                {
                    assetEndpointProfileRef = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discoveryId"u8))
                {
                    discoveryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("manufacturer"u8))
                {
                    manufacturer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manufacturerUri"u8))
                {
                    manufacturerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productCode"u8))
                {
                    productCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hardwareRevision"u8))
                {
                    hardwareRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softwareRevision"u8))
                {
                    softwareRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentationUri"u8))
                {
                    documentationUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultDatasetsConfiguration"u8))
                {
                    defaultDatasetsConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultEventsConfiguration"u8))
                {
                    defaultEventsConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultTopic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultTopic = Topic.DeserializeTopic(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoveredDataset> array = new List<DiscoveredDataset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoveredDataset.DeserializeDiscoveredDataset(item, options));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoveredEvent> array = new List<DiscoveredEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoveredEvent.DeserializeDiscoveredEvent(item, options));
                    }
                    events = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DeviceRegistryProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DiscoveredAssetProperties(
                assetEndpointProfileRef,
                discoveryId,
                version,
                manufacturer,
                manufacturerUri,
                model,
                productCode,
                hardwareRevision,
                softwareRevision,
                documentationUri,
                serialNumber,
                defaultDatasetsConfiguration,
                defaultEventsConfiguration,
                defaultTopic,
                datasets ?? new ChangeTrackingList<DiscoveredDataset>(),
                events ?? new ChangeTrackingList<DiscoveredEvent>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiscoveredAssetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveredAssetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiscoveredAssetProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DiscoveredAssetProperties IPersistableModel<DiscoveredAssetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveredAssetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiscoveredAssetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiscoveredAssetProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiscoveredAssetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
