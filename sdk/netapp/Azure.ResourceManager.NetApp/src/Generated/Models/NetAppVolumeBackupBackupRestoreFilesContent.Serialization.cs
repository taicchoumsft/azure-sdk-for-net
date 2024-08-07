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
    public partial class NetAppVolumeBackupBackupRestoreFilesContent : IUtf8JsonSerializable, IJsonModel<NetAppVolumeBackupBackupRestoreFilesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeBackupBackupRestoreFilesContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetAppVolumeBackupBackupRestoreFilesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupBackupRestoreFilesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupBackupRestoreFilesContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fileList"u8);
            writer.WriteStartArray();
            foreach (var item in FileList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(RestoreFilePath))
            {
                writer.WritePropertyName("restoreFilePath"u8);
                writer.WriteStringValue(RestoreFilePath);
            }
            writer.WritePropertyName("destinationVolumeId"u8);
            writer.WriteStringValue(DestinationVolumeId);
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

        NetAppVolumeBackupBackupRestoreFilesContent IJsonModel<NetAppVolumeBackupBackupRestoreFilesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupBackupRestoreFilesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupBackupRestoreFilesContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBackupBackupRestoreFilesContent(document.RootElement, options);
        }

        internal static NetAppVolumeBackupBackupRestoreFilesContent DeserializeNetAppVolumeBackupBackupRestoreFilesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> fileList = default;
            string restoreFilePath = default;
            ResourceIdentifier destinationVolumeId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fileList = array;
                    continue;
                }
                if (property.NameEquals("restoreFilePath"u8))
                {
                    restoreFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationVolumeId"u8))
                {
                    destinationVolumeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetAppVolumeBackupBackupRestoreFilesContent(fileList, restoreFilePath, destinationVolumeId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeBackupBackupRestoreFilesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupBackupRestoreFilesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBackupBackupRestoreFilesContent)} does not support writing '{options.Format}' format.");
            }
        }

        NetAppVolumeBackupBackupRestoreFilesContent IPersistableModel<NetAppVolumeBackupBackupRestoreFilesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupBackupRestoreFilesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeBackupBackupRestoreFilesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBackupBackupRestoreFilesContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeBackupBackupRestoreFilesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
