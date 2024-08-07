// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownProtectedItem))]
    public partial class BackupGenericProtectedItem : IUtf8JsonSerializable, IJsonModel<BackupGenericProtectedItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupGenericProtectedItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupGenericProtectedItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectedItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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

        BackupGenericProtectedItem IJsonModel<BackupGenericProtectedItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectedItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericProtectedItem(document.RootElement, options);
        }

        internal static BackupGenericProtectedItem DeserializeBackupGenericProtectedItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectedItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShareProtectedItem": return FileshareProtectedItem.DeserializeFileshareProtectedItem(element, options);
                    case "AzureIaaSVMProtectedItem": return IaasVmProtectedItem.DeserializeIaasVmProtectedItem(element, options);
                    case "AzureVmWorkloadProtectedItem": return VmWorkloadProtectedItem.DeserializeVmWorkloadProtectedItem(element, options);
                    case "AzureVmWorkloadSAPAseDatabase": return VmWorkloadSapAseDatabaseProtectedItem.DeserializeVmWorkloadSapAseDatabaseProtectedItem(element, options);
                    case "AzureVmWorkloadSAPHanaDatabase": return VmWorkloadSapHanaDatabaseProtectedItem.DeserializeVmWorkloadSapHanaDatabaseProtectedItem(element, options);
                    case "AzureVmWorkloadSAPHanaDBInstance": return VmWorkloadSapHanaDBInstanceProtectedItem.DeserializeVmWorkloadSapHanaDBInstanceProtectedItem(element, options);
                    case "AzureVmWorkloadSQLDatabase": return VmWorkloadSqlDatabaseProtectedItem.DeserializeVmWorkloadSqlDatabaseProtectedItem(element, options);
                    case "DPMProtectedItem": return DpmProtectedItem.DeserializeDpmProtectedItem(element, options);
                    case "GenericProtectedItem": return GenericProtectedItem.DeserializeGenericProtectedItem(element, options);
                    case "MabFileFolderProtectedItem": return MabFileFolderProtectedItem.DeserializeMabFileFolderProtectedItem(element, options);
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmProtectedItem.DeserializeIaasClassicComputeVmProtectedItem(element, options);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmProtectedItem.DeserializeIaasComputeVmProtectedItem(element, options);
                    case "Microsoft.Sql/servers/databases": return SqlProtectedItem.DeserializeSqlProtectedItem(element, options);
                }
            }
            return UnknownProtectedItem.DeserializeUnknownProtectedItem(element, options);
        }

        BinaryData IPersistableModel<BackupGenericProtectedItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupGenericProtectedItem)} does not support writing '{options.Format}' format.");
            }
        }

        BackupGenericProtectedItem IPersistableModel<BackupGenericProtectedItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupGenericProtectedItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupGenericProtectedItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupGenericProtectedItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
