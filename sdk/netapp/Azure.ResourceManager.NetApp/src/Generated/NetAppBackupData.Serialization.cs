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
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppBackupData : IUtf8JsonSerializable, IJsonModel<NetAppBackupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppBackupData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetAppBackupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppBackupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppBackupData)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(BackupId))
            {
                writer.WritePropertyName("backupId"u8);
                writer.WriteStringValue(BackupId);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteNumberValue(Size.Value);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (options.Format != "W" && Optional.IsDefined(BackupType))
            {
                writer.WritePropertyName("backupType"u8);
                writer.WriteStringValue(BackupType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(FailureReason))
            {
                writer.WritePropertyName("failureReason"u8);
                writer.WriteStringValue(FailureReason);
            }
            writer.WritePropertyName("volumeResourceId"u8);
            writer.WriteStringValue(VolumeResourceId);
            if (Optional.IsDefined(UseExistingSnapshot))
            {
                writer.WritePropertyName("useExistingSnapshot"u8);
                writer.WriteBooleanValue(UseExistingSnapshot.Value);
            }
            if (Optional.IsDefined(SnapshotName))
            {
                writer.WritePropertyName("snapshotName"u8);
                writer.WriteStringValue(SnapshotName);
            }
            if (options.Format != "W" && Optional.IsDefined(BackupPolicyResourceId))
            {
                writer.WritePropertyName("backupPolicyResourceId"u8);
                writer.WriteStringValue(BackupPolicyResourceId);
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

        NetAppBackupData IJsonModel<NetAppBackupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppBackupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppBackupData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppBackupData(document.RootElement, options);
        }

        internal static NetAppBackupData DeserializeNetAppBackupData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string backupId = default;
            DateTimeOffset? creationDate = default;
            string provisioningState = default;
            long? size = default;
            string label = default;
            NetAppBackupType? backupType = default;
            string failureReason = default;
            ResourceIdentifier volumeResourceId = default;
            bool? useExistingSnapshot = default;
            string snapshotName = default;
            string backupPolicyResourceId = default;
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
                        if (property0.NameEquals("backupId"u8))
                        {
                            backupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            size = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("label"u8))
                        {
                            label = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("backupType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupType = new NetAppBackupType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("failureReason"u8))
                        {
                            failureReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("volumeResourceId"u8))
                        {
                            volumeResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("useExistingSnapshot"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useExistingSnapshot = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("snapshotName"u8))
                        {
                            snapshotName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("backupPolicyResourceId"u8))
                        {
                            backupPolicyResourceId = property0.Value.GetString();
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
            return new NetAppBackupData(
                id,
                name,
                type,
                systemData,
                backupId,
                creationDate,
                provisioningState,
                size,
                label,
                backupType,
                failureReason,
                volumeResourceId,
                useExistingSnapshot,
                snapshotName,
                backupPolicyResourceId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppBackupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppBackupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppBackupData)} does not support writing '{options.Format}' format.");
            }
        }

        NetAppBackupData IPersistableModel<NetAppBackupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppBackupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppBackupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppBackupData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppBackupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
