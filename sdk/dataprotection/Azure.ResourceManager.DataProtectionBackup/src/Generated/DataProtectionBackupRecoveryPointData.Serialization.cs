// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    public partial class DataProtectionBackupRecoveryPointData : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupRecoveryPointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupRecoveryPointData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataProtectionBackupRecoveryPointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupRecoveryPointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupRecoveryPointData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
            }
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

        DataProtectionBackupRecoveryPointData IJsonModel<DataProtectionBackupRecoveryPointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupRecoveryPointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupRecoveryPointData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupRecoveryPointData(document.RootElement, options);
        }

        internal static DataProtectionBackupRecoveryPointData DeserializeDataProtectionBackupRecoveryPointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupRecoveryPointProperties properties = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = DataProtectionBackupRecoveryPointProperties.DeserializeDataProtectionBackupRecoveryPointProperties(property.Value, options);
                    continue;
                }
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
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataProtectionBackupRecoveryPointData(
                id,
                name,
                type,
                systemData,
                properties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProtectionBackupRecoveryPointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupRecoveryPointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupRecoveryPointData)} does not support writing '{options.Format}' format.");
            }
        }

        DataProtectionBackupRecoveryPointData IPersistableModel<DataProtectionBackupRecoveryPointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupRecoveryPointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupRecoveryPointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupRecoveryPointData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupRecoveryPointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
