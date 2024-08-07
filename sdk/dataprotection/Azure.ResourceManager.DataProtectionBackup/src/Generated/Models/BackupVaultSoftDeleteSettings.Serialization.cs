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
    public partial class BackupVaultSoftDeleteSettings : IUtf8JsonSerializable, IJsonModel<BackupVaultSoftDeleteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupVaultSoftDeleteSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupVaultSoftDeleteSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupVaultSoftDeleteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupVaultSoftDeleteSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(RetentionDurationInDays))
            {
                writer.WritePropertyName("retentionDurationInDays"u8);
                writer.WriteNumberValue(RetentionDurationInDays.Value);
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

        BackupVaultSoftDeleteSettings IJsonModel<BackupVaultSoftDeleteSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupVaultSoftDeleteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupVaultSoftDeleteSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupVaultSoftDeleteSettings(document.RootElement, options);
        }

        internal static BackupVaultSoftDeleteSettings DeserializeBackupVaultSoftDeleteSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BackupVaultSoftDeleteState? state = default;
            double? retentionDurationInDays = default;
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
                    state = new BackupVaultSoftDeleteState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("retentionDurationInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionDurationInDays = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackupVaultSoftDeleteSettings(state, retentionDurationInDays, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupVaultSoftDeleteSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupVaultSoftDeleteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupVaultSoftDeleteSettings)} does not support writing '{options.Format}' format.");
            }
        }

        BackupVaultSoftDeleteSettings IPersistableModel<BackupVaultSoftDeleteSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupVaultSoftDeleteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupVaultSoftDeleteSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupVaultSoftDeleteSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupVaultSoftDeleteSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
