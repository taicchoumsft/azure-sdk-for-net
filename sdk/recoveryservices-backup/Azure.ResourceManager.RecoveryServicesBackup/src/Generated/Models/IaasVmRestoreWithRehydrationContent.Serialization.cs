// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmRestoreWithRehydrationContent : IUtf8JsonSerializable, IJsonModel<IaasVmRestoreWithRehydrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmRestoreWithRehydrationContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IaasVmRestoreWithRehydrationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmRestoreWithRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmRestoreWithRehydrationContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointRehydrationInfo))
            {
                writer.WritePropertyName("recoveryPointRehydrationInfo"u8);
                writer.WriteObjectValue(RecoveryPointRehydrationInfo, options);
            }
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            if (Optional.IsDefined(RecoveryType))
            {
                writer.WritePropertyName("recoveryType"u8);
                writer.WriteStringValue(RecoveryType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(TargetVirtualMachineId))
            {
                writer.WritePropertyName("targetVirtualMachineId"u8);
                writer.WriteStringValue(TargetVirtualMachineId);
            }
            if (Optional.IsDefined(TargetResourceGroupId))
            {
                writer.WritePropertyName("targetResourceGroupId"u8);
                writer.WriteStringValue(TargetResourceGroupId);
            }
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                writer.WriteStringValue(VirtualNetworkId);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(TargetDomainNameId))
            {
                writer.WritePropertyName("targetDomainNameId"u8);
                writer.WriteStringValue(TargetDomainNameId);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region.Value);
            }
            if (Optional.IsDefined(AffinityGroup))
            {
                writer.WritePropertyName("affinityGroup"u8);
                writer.WriteStringValue(AffinityGroup);
            }
            if (Optional.IsDefined(DoesCreateNewCloudService))
            {
                writer.WritePropertyName("createNewCloudService"u8);
                writer.WriteBooleanValue(DoesCreateNewCloudService.Value);
            }
            if (Optional.IsDefined(OriginalStorageAccountOption))
            {
                writer.WritePropertyName("originalStorageAccountOption"u8);
                writer.WriteBooleanValue(OriginalStorageAccountOption.Value);
            }
            if (Optional.IsDefined(EncryptionDetails))
            {
                writer.WritePropertyName("encryptionDetails"u8);
                writer.WriteObjectValue(EncryptionDetails, options);
            }
            if (Optional.IsCollectionDefined(RestoreDiskLunList))
            {
                writer.WritePropertyName("restoreDiskLunList"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreDiskLunList)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DoesRestoreWithManagedDisks))
            {
                writer.WritePropertyName("restoreWithManagedDisks"u8);
                writer.WriteBooleanValue(DoesRestoreWithManagedDisks.Value);
            }
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IdentityInfo))
            {
                writer.WritePropertyName("identityInfo"u8);
                writer.WriteObjectValue(IdentityInfo, options);
            }
            if (Optional.IsDefined(IdentityBasedRestoreDetails))
            {
                writer.WritePropertyName("identityBasedRestoreDetails"u8);
                writer.WriteObjectValue(IdentityBasedRestoreDetails, options);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(SecuredVmDetails))
            {
                writer.WritePropertyName("securedVMDetails"u8);
                writer.WriteObjectValue(SecuredVmDetails, options);
            }
            if (Optional.IsDefined(TargetDiskNetworkAccessSettings))
            {
                writer.WritePropertyName("targetDiskNetworkAccessSettings"u8);
                writer.WriteObjectValue(TargetDiskNetworkAccessSettings, options);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        IaasVmRestoreWithRehydrationContent IJsonModel<IaasVmRestoreWithRehydrationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmRestoreWithRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmRestoreWithRehydrationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmRestoreWithRehydrationContent(document.RootElement, options);
        }

        internal static IaasVmRestoreWithRehydrationContent DeserializeIaasVmRestoreWithRehydrationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryPointRehydrationInfo recoveryPointRehydrationInfo = default;
            string recoveryPointId = default;
            FileShareRecoveryType? recoveryType = default;
            ResourceIdentifier sourceResourceId = default;
            ResourceIdentifier targetVirtualMachineId = default;
            ResourceIdentifier targetResourceGroupId = default;
            ResourceIdentifier storageAccountId = default;
            ResourceIdentifier virtualNetworkId = default;
            ResourceIdentifier subnetId = default;
            ResourceIdentifier targetDomainNameId = default;
            AzureLocation? region = default;
            string affinityGroup = default;
            bool? createNewCloudService = default;
            bool? originalStorageAccountOption = default;
            VmEncryptionDetails encryptionDetails = default;
            IList<int> restoreDiskLunList = default;
            bool? restoreWithManagedDisks = default;
            string diskEncryptionSetId = default;
            IList<string> zones = default;
            BackupIdentityInfo identityInfo = default;
            IdentityBasedRestoreDetails identityBasedRestoreDetails = default;
            ExtendedLocation extendedLocation = default;
            SecuredVmDetails securedVmDetails = default;
            BackupTargetDiskNetworkAccessSettings targetDiskNetworkAccessSettings = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointRehydrationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointRehydrationInfo = RecoveryPointRehydrationInfo.DeserializeRecoveryPointRehydrationInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryType = new FileShareRecoveryType(property.Value.GetString());
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
                if (property.NameEquals("targetVirtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVirtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetDomainNameId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDomainNameId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    region = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("affinityGroup"u8))
                {
                    affinityGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createNewCloudService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createNewCloudService = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("originalStorageAccountOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    originalStorageAccountOption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionDetails = VmEncryptionDetails.DeserializeVmEncryptionDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("restoreDiskLunList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    restoreDiskLunList = array;
                    continue;
                }
                if (property.NameEquals("restoreWithManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreWithManagedDisks = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    diskEncryptionSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("identityInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityInfo = BackupIdentityInfo.DeserializeBackupIdentityInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identityBasedRestoreDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityBasedRestoreDetails = IdentityBasedRestoreDetails.DeserializeIdentityBasedRestoreDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("securedVMDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securedVmDetails = SecuredVmDetails.DeserializeSecuredVmDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetDiskNetworkAccessSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDiskNetworkAccessSettings = BackupTargetDiskNetworkAccessSettings.DeserializeBackupTargetDiskNetworkAccessSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IaasVmRestoreWithRehydrationContent(
                objectType,
                serializedAdditionalRawData,
                recoveryPointId,
                recoveryType,
                sourceResourceId,
                targetVirtualMachineId,
                targetResourceGroupId,
                storageAccountId,
                virtualNetworkId,
                subnetId,
                targetDomainNameId,
                region,
                affinityGroup,
                createNewCloudService,
                originalStorageAccountOption,
                encryptionDetails,
                restoreDiskLunList ?? new ChangeTrackingList<int>(),
                restoreWithManagedDisks,
                diskEncryptionSetId,
                zones ?? new ChangeTrackingList<string>(),
                identityInfo,
                identityBasedRestoreDetails,
                extendedLocation,
                securedVmDetails,
                targetDiskNetworkAccessSettings,
                recoveryPointRehydrationInfo);
        }

        BinaryData IPersistableModel<IaasVmRestoreWithRehydrationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmRestoreWithRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmRestoreWithRehydrationContent)} does not support writing '{options.Format}' format.");
            }
        }

        IaasVmRestoreWithRehydrationContent IPersistableModel<IaasVmRestoreWithRehydrationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmRestoreWithRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasVmRestoreWithRehydrationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IaasVmRestoreWithRehydrationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmRestoreWithRehydrationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
