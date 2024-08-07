// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBackupDetail : IUtf8JsonSerializable, IJsonModel<NetAppVolumeBackupDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeBackupDetail>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetAppVolumeBackupDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupDetail)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VolumeName))
            {
                writer.WritePropertyName("volumeName"u8);
                writer.WriteStringValue(VolumeName);
            }
            if (Optional.IsDefined(VolumeResourceId))
            {
                writer.WritePropertyName("volumeResourceId"u8);
                writer.WriteStringValue(VolumeResourceId);
            }
            if (Optional.IsDefined(BackupsCount))
            {
                writer.WritePropertyName("backupsCount"u8);
                writer.WriteNumberValue(BackupsCount.Value);
            }
            if (Optional.IsDefined(IsPolicyEnabled))
            {
                writer.WritePropertyName("policyEnabled"u8);
                writer.WriteBooleanValue(IsPolicyEnabled.Value);
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

        NetAppVolumeBackupDetail IJsonModel<NetAppVolumeBackupDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBackupDetail(document.RootElement, options);
        }

        internal static NetAppVolumeBackupDetail DeserializeNetAppVolumeBackupDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string volumeName = default;
            ResourceIdentifier volumeResourceId = default;
            int? backupsCount = default;
            bool? policyEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeName"u8))
                {
                    volumeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("volumeResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volumeResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetAppVolumeBackupDetail(volumeName, volumeResourceId, backupsCount, policyEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeBackupDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBackupDetail)} does not support writing '{options.Format}' format.");
            }
        }

        NetAppVolumeBackupDetail IPersistableModel<NetAppVolumeBackupDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeBackupDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBackupDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeBackupDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
