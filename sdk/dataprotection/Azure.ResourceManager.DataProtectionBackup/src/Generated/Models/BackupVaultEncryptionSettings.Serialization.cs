// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupVaultEncryptionSettings : IUtf8JsonSerializable, IJsonModel<BackupVaultEncryptionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupVaultEncryptionSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupVaultEncryptionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupVaultEncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupVaultEncryptionSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteObjectValue(KeyVaultProperties, options);
            }
            if (Optional.IsDefined(KekIdentity))
            {
                writer.WritePropertyName("kekIdentity"u8);
                writer.WriteObjectValue(KekIdentity, options);
            }
            if (Optional.IsDefined(InfrastructureEncryption))
            {
                writer.WritePropertyName("infrastructureEncryption"u8);
                writer.WriteStringValue(InfrastructureEncryption.Value.ToString());
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

        BackupVaultEncryptionSettings IJsonModel<BackupVaultEncryptionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupVaultEncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupVaultEncryptionSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupVaultEncryptionSettings(document.RootElement, options);
        }

        internal static BackupVaultEncryptionSettings DeserializeBackupVaultEncryptionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BackupVaultEncryptionState? state = default;
            CmkKeyVaultProperties keyVaultProperties = default;
            BackupVaultCmkKekIdentity kekIdentity = default;
            BackupVaultInfrastructureEncryptionState? infrastructureEncryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new BackupVaultEncryptionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultProperties = CmkKeyVaultProperties.DeserializeCmkKeyVaultProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kekIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekIdentity = BackupVaultCmkKekIdentity.DeserializeBackupVaultCmkKekIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("infrastructureEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryption = new BackupVaultInfrastructureEncryptionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackupVaultEncryptionSettings(state, keyVaultProperties, kekIdentity, infrastructureEncryption, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupVaultEncryptionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupVaultEncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupVaultEncryptionSettings)} does not support writing '{options.Format}' format.");
            }
        }

        BackupVaultEncryptionSettings IPersistableModel<BackupVaultEncryptionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupVaultEncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupVaultEncryptionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupVaultEncryptionSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupVaultEncryptionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
