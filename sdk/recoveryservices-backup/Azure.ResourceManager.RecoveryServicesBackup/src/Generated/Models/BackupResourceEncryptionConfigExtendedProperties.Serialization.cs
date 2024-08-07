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
    public partial class BackupResourceEncryptionConfigExtendedProperties : IUtf8JsonSerializable, IJsonModel<BackupResourceEncryptionConfigExtendedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupResourceEncryptionConfigExtendedProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupResourceEncryptionConfigExtendedProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceEncryptionConfigExtendedProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity"u8);
                writer.WriteStringValue(UserAssignedIdentity);
            }
            if (Optional.IsDefined(UseSystemAssignedIdentity))
            {
                writer.WritePropertyName("useSystemAssignedIdentity"u8);
                writer.WriteBooleanValue(UseSystemAssignedIdentity.Value);
            }
            if (Optional.IsDefined(EncryptionAtRestType))
            {
                writer.WritePropertyName("encryptionAtRestType"u8);
                writer.WriteStringValue(EncryptionAtRestType.Value.ToString());
            }
            if (Optional.IsDefined(KeyUri))
            {
                writer.WritePropertyName("keyUri"u8);
                writer.WriteStringValue(KeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(LastUpdateStatus))
            {
                writer.WritePropertyName("lastUpdateStatus"u8);
                writer.WriteStringValue(LastUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryptionState))
            {
                writer.WritePropertyName("infrastructureEncryptionState"u8);
                writer.WriteStringValue(InfrastructureEncryptionState.Value.ToString());
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

        BackupResourceEncryptionConfigExtendedProperties IJsonModel<BackupResourceEncryptionConfigExtendedProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceEncryptionConfigExtendedProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupResourceEncryptionConfigExtendedProperties(document.RootElement, options);
        }

        internal static BackupResourceEncryptionConfigExtendedProperties DeserializeBackupResourceEncryptionConfigExtendedProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier userAssignedIdentity = default;
            bool? useSystemAssignedIdentity = default;
            BackupEncryptionAtRestType? encryptionAtRestType = default;
            Uri keyUri = default;
            string subscriptionId = default;
            LastUpdateStatus? lastUpdateStatus = default;
            InfrastructureEncryptionState? infrastructureEncryptionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentity = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useSystemAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useSystemAssignedIdentity = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionAtRestType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionAtRestType = new BackupEncryptionAtRestType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateStatus = new LastUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureEncryptionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryptionState = new InfrastructureEncryptionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackupResourceEncryptionConfigExtendedProperties(
                encryptionAtRestType,
                keyUri,
                subscriptionId,
                lastUpdateStatus,
                infrastructureEncryptionState,
                serializedAdditionalRawData,
                userAssignedIdentity,
                useSystemAssignedIdentity);
        }

        BinaryData IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupResourceEncryptionConfigExtendedProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BackupResourceEncryptionConfigExtendedProperties IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupResourceEncryptionConfigExtendedProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupResourceEncryptionConfigExtendedProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
