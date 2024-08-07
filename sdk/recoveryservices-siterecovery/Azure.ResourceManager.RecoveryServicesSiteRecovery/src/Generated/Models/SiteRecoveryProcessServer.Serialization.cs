// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryProcessServer : IUtf8JsonSerializable, IJsonModel<SiteRecoveryProcessServer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryProcessServer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryProcessServer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProcessServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProcessServer)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress.ToString());
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                writer.WritePropertyName("lastHeartbeat"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (Optional.IsDefined(VersionStatus))
            {
                writer.WritePropertyName("versionStatus"u8);
                writer.WriteStringValue(VersionStatus);
            }
            if (Optional.IsCollectionDefined(MobilityServiceUpdates))
            {
                writer.WritePropertyName("mobilityServiceUpdates"u8);
                writer.WriteStartArray();
                foreach (var item in MobilityServiceUpdates)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HostId))
            {
                writer.WritePropertyName("hostId"u8);
                writer.WriteStringValue(HostId);
            }
            if (Optional.IsDefined(MachineCount))
            {
                writer.WritePropertyName("machineCount"u8);
                writer.WriteStringValue(MachineCount);
            }
            if (Optional.IsDefined(ReplicationPairCount))
            {
                writer.WritePropertyName("replicationPairCount"u8);
                writer.WriteStringValue(ReplicationPairCount);
            }
            if (Optional.IsDefined(SystemLoad))
            {
                writer.WritePropertyName("systemLoad"u8);
                writer.WriteStringValue(SystemLoad);
            }
            if (Optional.IsDefined(SystemLoadStatus))
            {
                writer.WritePropertyName("systemLoadStatus"u8);
                writer.WriteStringValue(SystemLoadStatus);
            }
            if (Optional.IsDefined(CpuLoad))
            {
                writer.WritePropertyName("cpuLoad"u8);
                writer.WriteStringValue(CpuLoad);
            }
            if (Optional.IsDefined(CpuLoadStatus))
            {
                writer.WritePropertyName("cpuLoadStatus"u8);
                writer.WriteStringValue(CpuLoadStatus);
            }
            if (Optional.IsDefined(TotalMemoryInBytes))
            {
                writer.WritePropertyName("totalMemoryInBytes"u8);
                writer.WriteNumberValue(TotalMemoryInBytes.Value);
            }
            if (Optional.IsDefined(AvailableMemoryInBytes))
            {
                writer.WritePropertyName("availableMemoryInBytes"u8);
                writer.WriteNumberValue(AvailableMemoryInBytes.Value);
            }
            if (Optional.IsDefined(MemoryUsageStatus))
            {
                writer.WritePropertyName("memoryUsageStatus"u8);
                writer.WriteStringValue(MemoryUsageStatus);
            }
            if (Optional.IsDefined(TotalSpaceInBytes))
            {
                writer.WritePropertyName("totalSpaceInBytes"u8);
                writer.WriteNumberValue(TotalSpaceInBytes.Value);
            }
            if (Optional.IsDefined(AvailableSpaceInBytes))
            {
                writer.WritePropertyName("availableSpaceInBytes"u8);
                writer.WriteNumberValue(AvailableSpaceInBytes.Value);
            }
            if (Optional.IsDefined(SpaceUsageStatus))
            {
                writer.WritePropertyName("spaceUsageStatus"u8);
                writer.WriteStringValue(SpaceUsageStatus);
            }
            if (Optional.IsDefined(PsServiceStatus))
            {
                writer.WritePropertyName("psServiceStatus"u8);
                writer.WriteStringValue(PsServiceStatus);
            }
            if (Optional.IsDefined(SslCertExpireOn))
            {
                writer.WritePropertyName("sslCertExpiryDate"u8);
                writer.WriteStringValue(SslCertExpireOn.Value, "O");
            }
            if (Optional.IsDefined(SslCertExpiryRemainingDays))
            {
                writer.WritePropertyName("sslCertExpiryRemainingDays"u8);
                writer.WriteNumberValue(SslCertExpiryRemainingDays.Value);
            }
            if (Optional.IsDefined(OSVersion))
            {
                writer.WritePropertyName("osVersion"u8);
                writer.WriteStringValue(OSVersion);
            }
            if (Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AgentExpireOn))
            {
                writer.WritePropertyName("agentExpiryDate"u8);
                writer.WriteStringValue(AgentExpireOn.Value, "O");
            }
            if (Optional.IsDefined(AgentVersionDetails))
            {
                writer.WritePropertyName("agentVersionDetails"u8);
                writer.WriteObjectValue(AgentVersionDetails, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PsStatsRefreshOn))
            {
                writer.WritePropertyName("psStatsRefreshTime"u8);
                writer.WriteStringValue(PsStatsRefreshOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ThroughputUploadPendingDataInBytes))
            {
                writer.WritePropertyName("throughputUploadPendingDataInBytes"u8);
                writer.WriteNumberValue(ThroughputUploadPendingDataInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ThroughputInMBps))
            {
                writer.WritePropertyName("throughputInMBps"u8);
                writer.WriteNumberValue(ThroughputInMBps.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ThroughputInBytes))
            {
                writer.WritePropertyName("throughputInBytes"u8);
                writer.WriteNumberValue(ThroughputInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ThroughputStatus))
            {
                writer.WritePropertyName("throughputStatus"u8);
                writer.WriteStringValue(ThroughputStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(MarsCommunicationStatus))
            {
                writer.WritePropertyName("marsCommunicationStatus"u8);
                writer.WriteStringValue(MarsCommunicationStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(MarsRegistrationStatus))
            {
                writer.WritePropertyName("marsRegistrationStatus"u8);
                writer.WriteStringValue(MarsRegistrationStatus);
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

        SiteRecoveryProcessServer IJsonModel<SiteRecoveryProcessServer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProcessServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProcessServer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryProcessServer(document.RootElement, options);
        }

        internal static SiteRecoveryProcessServer DeserializeSiteRecoveryProcessServer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            string id = default;
            IPAddress ipAddress = default;
            string osType = default;
            string agentVersion = default;
            DateTimeOffset? lastHeartbeat = default;
            string versionStatus = default;
            IReadOnlyList<MobilityServiceUpdate> mobilityServiceUpdates = default;
            string hostId = default;
            string machineCount = default;
            string replicationPairCount = default;
            string systemLoad = default;
            string systemLoadStatus = default;
            string cpuLoad = default;
            string cpuLoadStatus = default;
            long? totalMemoryInBytes = default;
            long? availableMemoryInBytes = default;
            string memoryUsageStatus = default;
            long? totalSpaceInBytes = default;
            long? availableSpaceInBytes = default;
            string spaceUsageStatus = default;
            string psServiceStatus = default;
            DateTimeOffset? sslCertExpireOn = default;
            int? sslCertExpiryRemainingDays = default;
            string osVersion = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrors = default;
            DateTimeOffset? agentExpireOn = default;
            SiteRecoveryVersionDetails agentVersionDetails = default;
            SiteRecoveryProtectionHealth? health = default;
            DateTimeOffset? psStatsRefreshTime = default;
            long? throughputUploadPendingDataInBytes = default;
            long? throughputInMBps = default;
            long? throughputInBytes = default;
            string throughputStatus = default;
            string marsCommunicationStatus = default;
            string marsRegistrationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("versionStatus"u8))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mobilityServiceUpdates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MobilityServiceUpdate> array = new List<MobilityServiceUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MobilityServiceUpdate.DeserializeMobilityServiceUpdate(item, options));
                    }
                    mobilityServiceUpdates = array;
                    continue;
                }
                if (property.NameEquals("hostId"u8))
                {
                    hostId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineCount"u8))
                {
                    machineCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationPairCount"u8))
                {
                    replicationPairCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemLoad"u8))
                {
                    systemLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemLoadStatus"u8))
                {
                    systemLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuLoad"u8))
                {
                    cpuLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuLoadStatus"u8))
                {
                    cpuLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryUsageStatus"u8))
                {
                    memoryUsageStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spaceUsageStatus"u8))
                {
                    spaceUsageStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("psServiceStatus"u8))
                {
                    psServiceStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslCertExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sslCertExpiryRemainingDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertExpiryRemainingDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osVersion"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("agentExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("agentVersionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVersionDetails = SiteRecoveryVersionDetails.DeserializeSiteRecoveryVersionDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("psStatsRefreshTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    psStatsRefreshTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("throughputUploadPendingDataInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputUploadPendingDataInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throughputInMBps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputInMBps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throughputInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throughputStatus"u8))
                {
                    throughputStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marsCommunicationStatus"u8))
                {
                    marsCommunicationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marsRegistrationStatus"u8))
                {
                    marsRegistrationStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryProcessServer(
                friendlyName,
                id,
                ipAddress,
                osType,
                agentVersion,
                lastHeartbeat,
                versionStatus,
                mobilityServiceUpdates ?? new ChangeTrackingList<MobilityServiceUpdate>(),
                hostId,
                machineCount,
                replicationPairCount,
                systemLoad,
                systemLoadStatus,
                cpuLoad,
                cpuLoadStatus,
                totalMemoryInBytes,
                availableMemoryInBytes,
                memoryUsageStatus,
                totalSpaceInBytes,
                availableSpaceInBytes,
                spaceUsageStatus,
                psServiceStatus,
                sslCertExpireOn,
                sslCertExpiryRemainingDays,
                osVersion,
                healthErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                agentExpireOn,
                agentVersionDetails,
                health,
                psStatsRefreshTime,
                throughputUploadPendingDataInBytes,
                throughputInMBps,
                throughputInBytes,
                throughputStatus,
                marsCommunicationStatus,
                marsRegistrationStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryProcessServer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProcessServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryProcessServer)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryProcessServer IPersistableModel<SiteRecoveryProcessServer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProcessServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryProcessServer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryProcessServer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryProcessServer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
