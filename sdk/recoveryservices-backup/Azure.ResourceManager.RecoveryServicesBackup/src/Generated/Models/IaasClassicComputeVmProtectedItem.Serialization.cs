// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasClassicComputeVmProtectedItem : IUtf8JsonSerializable, IJsonModel<IaasClassicComputeVmProtectedItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasClassicComputeVmProtectedItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IaasClassicComputeVmProtectedItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasClassicComputeVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasClassicComputeVmProtectedItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (Optional.IsDefined(ProtectionStatus))
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus.Value.ToString());
            }
            if (Optional.IsCollectionDefined(HealthDetails))
            {
                writer.WritePropertyName("healthDetails"u8);
                writer.WriteStartArray();
                foreach (var item in HealthDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KpisHealths))
            {
                writer.WritePropertyName("kpisHealths"u8);
                writer.WriteStartObject();
                foreach (var item in KpisHealths)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(LastBackupStatus))
            {
                writer.WritePropertyName("lastBackupStatus"u8);
                writer.WriteStringValue(LastBackupStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(LastBackupOn))
            {
                writer.WritePropertyName("lastBackupTime"u8);
                writer.WriteStringValue(LastBackupOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectedItemDataId))
            {
                writer.WritePropertyName("protectedItemDataId"u8);
                writer.WriteStringValue(ProtectedItemDataId);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo, options);
            }
            if (Optional.IsDefined(ExtendedProperties))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteObjectValue(ExtendedProperties, options);
            }
            writer.WritePropertyName("protectedItemType"u8);
            writer.WriteStringValue(ProtectedItemType);
            if (options.Format != "W" && Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType.Value.ToString());
            }
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(LastRecoverOn))
            {
                writer.WritePropertyName("lastRecoveryPoint"u8);
                writer.WriteStringValue(LastRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(BackupSetName))
            {
                writer.WritePropertyName("backupSetName"u8);
                writer.WriteStringValue(BackupSetName);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(DeferredDeletedOn))
            {
                writer.WritePropertyName("deferredDeleteTimeInUTC"u8);
                writer.WriteStringValue(DeferredDeletedOn.Value, "O");
            }
            if (Optional.IsDefined(IsScheduledForDeferredDelete))
            {
                writer.WritePropertyName("isScheduledForDeferredDelete"u8);
                writer.WriteBooleanValue(IsScheduledForDeferredDelete.Value);
            }
            if (Optional.IsDefined(DeferredDeleteTimeRemaining))
            {
                writer.WritePropertyName("deferredDeleteTimeRemaining"u8);
                writer.WriteStringValue(DeferredDeleteTimeRemaining);
            }
            if (Optional.IsDefined(IsDeferredDeleteScheduleUpcoming))
            {
                writer.WritePropertyName("isDeferredDeleteScheduleUpcoming"u8);
                writer.WriteBooleanValue(IsDeferredDeleteScheduleUpcoming.Value);
            }
            if (Optional.IsDefined(IsRehydrate))
            {
                writer.WritePropertyName("isRehydrate"u8);
                writer.WriteBooleanValue(IsRehydrate.Value);
            }
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (Optional.IsDefined(SoftDeleteRetentionPeriodInDays))
            {
                writer.WritePropertyName("softDeleteRetentionPeriodInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionPeriodInDays.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(VaultId))
            {
                writer.WritePropertyName("vaultId"u8);
                writer.WriteStringValue(VaultId);
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

        IaasClassicComputeVmProtectedItem IJsonModel<IaasClassicComputeVmProtectedItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasClassicComputeVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasClassicComputeVmProtectedItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasClassicComputeVmProtectedItem(document.RootElement, options);
        }

        internal static IaasClassicComputeVmProtectedItem DeserializeIaasClassicComputeVmProtectedItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            ResourceIdentifier virtualMachineId = default;
            string protectionStatus = default;
            BackupProtectionState? protectionState = default;
            IaasVmProtectedItemHealthStatus? healthStatus = default;
            IList<IaasVmHealthDetails> healthDetails = default;
            IDictionary<string, KpiResourceHealthDetails> kpisHealths = default;
            string lastBackupStatus = default;
            DateTimeOffset? lastBackupTime = default;
            string protectedItemDataId = default;
            IaasVmProtectedItemExtendedInfo extendedInfo = default;
            IaasVmBackupExtendedProperties extendedProperties = default;
            string protectedItemType = default;
            BackupManagementType? backupManagementType = default;
            BackupDataSourceType? workloadType = default;
            string containerName = default;
            ResourceIdentifier sourceResourceId = default;
            ResourceIdentifier policyId = default;
            DateTimeOffset? lastRecoveryPoint = default;
            string backupSetName = default;
            BackupCreateMode? createMode = default;
            DateTimeOffset? deferredDeleteTimeInUTC = default;
            bool? isScheduledForDeferredDelete = default;
            string deferredDeleteTimeRemaining = default;
            bool? isDeferredDeleteScheduleUpcoming = default;
            bool? isRehydrate = default;
            IList<string> resourceGuardOperationRequests = default;
            bool? isArchiveEnabled = default;
            string policyName = default;
            int? softDeleteRetentionPeriodInDays = default;
            string vaultId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthStatus = new IaasVmProtectedItemHealthStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IaasVmHealthDetails> array = new List<IaasVmHealthDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IaasVmHealthDetails.DeserializeIaasVmHealthDetails(item, options));
                    }
                    healthDetails = array;
                    continue;
                }
                if (property.NameEquals("kpisHealths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, KpiResourceHealthDetails> dictionary = new Dictionary<string, KpiResourceHealthDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, KpiResourceHealthDetails.DeserializeKpiResourceHealthDetails(property0.Value, options));
                    }
                    kpisHealths = dictionary;
                    continue;
                }
                if (property.NameEquals("lastBackupStatus"u8))
                {
                    lastBackupStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastBackupTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastBackupTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("protectedItemDataId"u8))
                {
                    protectedItemDataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = IaasVmProtectedItemExtendedInfo.DeserializeIaasVmProtectedItemExtendedInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extendedProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedProperties = IaasVmBackupExtendedProperties.DeserializeIaasVmBackupExtendedProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protectedItemType"u8))
                {
                    protectedItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadType = new BackupDataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupSetName"u8))
                {
                    backupSetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new BackupCreateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deferredDeleteTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isScheduledForDeferredDelete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isScheduledForDeferredDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeRemaining"u8))
                {
                    deferredDeleteTimeRemaining = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDeferredDeleteScheduleUpcoming"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeferredDeleteScheduleUpcoming = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRehydrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRehydrate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
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
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionPeriodInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionPeriodInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vaultId"u8))
                {
                    vaultId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IaasClassicComputeVmProtectedItem(
                protectedItemType,
                backupManagementType,
                workloadType,
                containerName,
                sourceResourceId,
                policyId,
                lastRecoveryPoint,
                backupSetName,
                createMode,
                deferredDeleteTimeInUTC,
                isScheduledForDeferredDelete,
                deferredDeleteTimeRemaining,
                isDeferredDeleteScheduleUpcoming,
                isRehydrate,
                resourceGuardOperationRequests ?? new ChangeTrackingList<string>(),
                isArchiveEnabled,
                policyName,
                softDeleteRetentionPeriodInDays,
                vaultId,
                serializedAdditionalRawData,
                friendlyName,
                virtualMachineId,
                protectionStatus,
                protectionState,
                healthStatus,
                healthDetails ?? new ChangeTrackingList<IaasVmHealthDetails>(),
                kpisHealths ?? new ChangeTrackingDictionary<string, KpiResourceHealthDetails>(),
                lastBackupStatus,
                lastBackupTime,
                protectedItemDataId,
                extendedInfo,
                extendedProperties);
        }

        BinaryData IPersistableModel<IaasClassicComputeVmProtectedItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasClassicComputeVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IaasClassicComputeVmProtectedItem)} does not support writing '{options.Format}' format.");
            }
        }

        IaasClassicComputeVmProtectedItem IPersistableModel<IaasClassicComputeVmProtectedItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasClassicComputeVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasClassicComputeVmProtectedItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IaasClassicComputeVmProtectedItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasClassicComputeVmProtectedItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
