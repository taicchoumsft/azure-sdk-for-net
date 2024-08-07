// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class IotSecuritySolutionAnalyticsModelData : IUtf8JsonSerializable, IJsonModel<IotSecuritySolutionAnalyticsModelData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotSecuritySolutionAnalyticsModelData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotSecuritySolutionAnalyticsModelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionAnalyticsModelData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecuritySolutionAnalyticsModelData)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteObjectValue(Metrics, options);
            }
            if (options.Format != "W" && Optional.IsDefined(UnhealthyDeviceCount))
            {
                writer.WritePropertyName("unhealthyDeviceCount"u8);
                writer.WriteNumberValue(UnhealthyDeviceCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DevicesMetrics))
            {
                writer.WritePropertyName("devicesMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in DevicesMetrics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TopAlertedDevices))
            {
                writer.WritePropertyName("topAlertedDevices"u8);
                writer.WriteStartArray();
                foreach (var item in TopAlertedDevices)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MostPrevalentDeviceAlerts))
            {
                writer.WritePropertyName("mostPrevalentDeviceAlerts"u8);
                writer.WriteStartArray();
                foreach (var item in MostPrevalentDeviceAlerts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MostPrevalentDeviceRecommendations))
            {
                writer.WritePropertyName("mostPrevalentDeviceRecommendations"u8);
                writer.WriteStartArray();
                foreach (var item in MostPrevalentDeviceRecommendations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        IotSecuritySolutionAnalyticsModelData IJsonModel<IotSecuritySolutionAnalyticsModelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionAnalyticsModelData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecuritySolutionAnalyticsModelData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecuritySolutionAnalyticsModelData(document.RootElement, options);
        }

        internal static IotSecuritySolutionAnalyticsModelData DeserializeIotSecuritySolutionAnalyticsModelData(JsonElement element, ModelReaderWriterOptions options = null)
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
            IotSeverityMetrics metrics = default;
            long? unhealthyDeviceCount = default;
            IReadOnlyList<IotSecuritySolutionAnalyticsModelDevicesMetrics> devicesMetrics = default;
            IList<IotSecurityAlertedDevice> topAlertedDevices = default;
            IList<IotSecurityDeviceAlert> mostPrevalentDeviceAlerts = default;
            IList<IotSecurityDeviceRecommendation> mostPrevalentDeviceRecommendations = default;
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
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metrics = IotSeverityMetrics.DeserializeIotSeverityMetrics(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("unhealthyDeviceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unhealthyDeviceCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("devicesMetrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecuritySolutionAnalyticsModelDevicesMetrics> array = new List<IotSecuritySolutionAnalyticsModelDevicesMetrics>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecuritySolutionAnalyticsModelDevicesMetrics.DeserializeIotSecuritySolutionAnalyticsModelDevicesMetrics(item, options));
                            }
                            devicesMetrics = array;
                            continue;
                        }
                        if (property0.NameEquals("topAlertedDevices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecurityAlertedDevice> array = new List<IotSecurityAlertedDevice>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecurityAlertedDevice.DeserializeIotSecurityAlertedDevice(item, options));
                            }
                            topAlertedDevices = array;
                            continue;
                        }
                        if (property0.NameEquals("mostPrevalentDeviceAlerts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecurityDeviceAlert> array = new List<IotSecurityDeviceAlert>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecurityDeviceAlert.DeserializeIotSecurityDeviceAlert(item, options));
                            }
                            mostPrevalentDeviceAlerts = array;
                            continue;
                        }
                        if (property0.NameEquals("mostPrevalentDeviceRecommendations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecurityDeviceRecommendation> array = new List<IotSecurityDeviceRecommendation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecurityDeviceRecommendation.DeserializeIotSecurityDeviceRecommendation(item, options));
                            }
                            mostPrevalentDeviceRecommendations = array;
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
            return new IotSecuritySolutionAnalyticsModelData(
                id,
                name,
                type,
                systemData,
                metrics,
                unhealthyDeviceCount,
                devicesMetrics ?? new ChangeTrackingList<IotSecuritySolutionAnalyticsModelDevicesMetrics>(),
                topAlertedDevices ?? new ChangeTrackingList<IotSecurityAlertedDevice>(),
                mostPrevalentDeviceAlerts ?? new ChangeTrackingList<IotSecurityDeviceAlert>(),
                mostPrevalentDeviceRecommendations ?? new ChangeTrackingList<IotSecurityDeviceRecommendation>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotSecuritySolutionAnalyticsModelData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionAnalyticsModelData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotSecuritySolutionAnalyticsModelData)} does not support writing '{options.Format}' format.");
            }
        }

        IotSecuritySolutionAnalyticsModelData IPersistableModel<IotSecuritySolutionAnalyticsModelData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionAnalyticsModelData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotSecuritySolutionAnalyticsModelData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotSecuritySolutionAnalyticsModelData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotSecuritySolutionAnalyticsModelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
