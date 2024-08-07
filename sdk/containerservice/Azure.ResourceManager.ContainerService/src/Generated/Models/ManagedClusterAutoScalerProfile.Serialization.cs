// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAutoScalerProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterAutoScalerProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterAutoScalerProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterAutoScalerProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAutoScalerProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BalanceSimilarNodeGroups))
            {
                writer.WritePropertyName("balance-similar-node-groups"u8);
                writer.WriteStringValue(BalanceSimilarNodeGroups);
            }
            if (Optional.IsDefined(Expander))
            {
                writer.WritePropertyName("expander"u8);
                writer.WriteStringValue(Expander.Value.ToString());
            }
            if (Optional.IsDefined(MaxEmptyBulkDelete))
            {
                writer.WritePropertyName("max-empty-bulk-delete"u8);
                writer.WriteStringValue(MaxEmptyBulkDelete);
            }
            if (Optional.IsDefined(MaxGracefulTerminationSec))
            {
                writer.WritePropertyName("max-graceful-termination-sec"u8);
                writer.WriteStringValue(MaxGracefulTerminationSec);
            }
            if (Optional.IsDefined(MaxNodeProvisionTime))
            {
                writer.WritePropertyName("max-node-provision-time"u8);
                writer.WriteStringValue(MaxNodeProvisionTime);
            }
            if (Optional.IsDefined(MaxTotalUnreadyPercentage))
            {
                writer.WritePropertyName("max-total-unready-percentage"u8);
                writer.WriteStringValue(MaxTotalUnreadyPercentage);
            }
            if (Optional.IsDefined(NewPodScaleUpDelay))
            {
                writer.WritePropertyName("new-pod-scale-up-delay"u8);
                writer.WriteStringValue(NewPodScaleUpDelay);
            }
            if (Optional.IsDefined(OkTotalUnreadyCount))
            {
                writer.WritePropertyName("ok-total-unready-count"u8);
                writer.WriteStringValue(OkTotalUnreadyCount);
            }
            if (Optional.IsDefined(ScanIntervalInSeconds))
            {
                writer.WritePropertyName("scan-interval"u8);
                writer.WriteStringValue(ScanIntervalInSeconds);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterAdd))
            {
                writer.WritePropertyName("scale-down-delay-after-add"u8);
                writer.WriteStringValue(ScaleDownDelayAfterAdd);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterDelete))
            {
                writer.WritePropertyName("scale-down-delay-after-delete"u8);
                writer.WriteStringValue(ScaleDownDelayAfterDelete);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterFailure))
            {
                writer.WritePropertyName("scale-down-delay-after-failure"u8);
                writer.WriteStringValue(ScaleDownDelayAfterFailure);
            }
            if (Optional.IsDefined(ScaleDownUnneededTime))
            {
                writer.WritePropertyName("scale-down-unneeded-time"u8);
                writer.WriteStringValue(ScaleDownUnneededTime);
            }
            if (Optional.IsDefined(ScaleDownUnreadyTime))
            {
                writer.WritePropertyName("scale-down-unready-time"u8);
                writer.WriteStringValue(ScaleDownUnreadyTime);
            }
            if (Optional.IsDefined(ScaleDownUtilizationThreshold))
            {
                writer.WritePropertyName("scale-down-utilization-threshold"u8);
                writer.WriteStringValue(ScaleDownUtilizationThreshold);
            }
            if (Optional.IsDefined(SkipNodesWithLocalStorage))
            {
                writer.WritePropertyName("skip-nodes-with-local-storage"u8);
                writer.WriteStringValue(SkipNodesWithLocalStorage);
            }
            if (Optional.IsDefined(SkipNodesWithSystemPods))
            {
                writer.WritePropertyName("skip-nodes-with-system-pods"u8);
                writer.WriteStringValue(SkipNodesWithSystemPods);
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

        ManagedClusterAutoScalerProfile IJsonModel<ManagedClusterAutoScalerProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAutoScalerProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterAutoScalerProfile(document.RootElement, options);
        }

        internal static ManagedClusterAutoScalerProfile DeserializeManagedClusterAutoScalerProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string balanceSimilarNodeGroups = default;
            AutoScaleExpander? expander = default;
            string maxEmptyBulkDelete = default;
            string maxGracefulTerminationSec = default;
            string maxNodeProvisionTime = default;
            string maxTotalUnreadyPercentage = default;
            string newPodScaleUpDelay = default;
            string okTotalUnreadyCount = default;
            string scanInterval = default;
            string scaleDownDelayAfterAdd = default;
            string scaleDownDelayAfterDelete = default;
            string scaleDownDelayAfterFailure = default;
            string scaleDownUnneededTime = default;
            string scaleDownUnreadyTime = default;
            string scaleDownUtilizationThreshold = default;
            string skipNodesWithLocalStorage = default;
            string skipNodesWithSystemPods = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("balance-similar-node-groups"u8))
                {
                    balanceSimilarNodeGroups = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expander"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expander = new AutoScaleExpander(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("max-empty-bulk-delete"u8))
                {
                    maxEmptyBulkDelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-graceful-termination-sec"u8))
                {
                    maxGracefulTerminationSec = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-node-provision-time"u8))
                {
                    maxNodeProvisionTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-total-unready-percentage"u8))
                {
                    maxTotalUnreadyPercentage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("new-pod-scale-up-delay"u8))
                {
                    newPodScaleUpDelay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ok-total-unready-count"u8))
                {
                    okTotalUnreadyCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scan-interval"u8))
                {
                    scanInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-add"u8))
                {
                    scaleDownDelayAfterAdd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-delete"u8))
                {
                    scaleDownDelayAfterDelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-failure"u8))
                {
                    scaleDownDelayAfterFailure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-unneeded-time"u8))
                {
                    scaleDownUnneededTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-unready-time"u8))
                {
                    scaleDownUnreadyTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-utilization-threshold"u8))
                {
                    scaleDownUtilizationThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip-nodes-with-local-storage"u8))
                {
                    skipNodesWithLocalStorage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip-nodes-with-system-pods"u8))
                {
                    skipNodesWithSystemPods = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterAutoScalerProfile(
                balanceSimilarNodeGroups,
                expander,
                maxEmptyBulkDelete,
                maxGracefulTerminationSec,
                maxNodeProvisionTime,
                maxTotalUnreadyPercentage,
                newPodScaleUpDelay,
                okTotalUnreadyCount,
                scanInterval,
                scaleDownDelayAfterAdd,
                scaleDownDelayAfterDelete,
                scaleDownDelayAfterFailure,
                scaleDownUnneededTime,
                scaleDownUnreadyTime,
                scaleDownUtilizationThreshold,
                skipNodesWithLocalStorage,
                skipNodesWithSystemPods,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterAutoScalerProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAutoScalerProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterAutoScalerProfile IPersistableModel<ManagedClusterAutoScalerProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterAutoScalerProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAutoScalerProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterAutoScalerProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
