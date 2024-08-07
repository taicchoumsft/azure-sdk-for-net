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
    public partial class CrossRegionRestoreJobContent : IUtf8JsonSerializable, IJsonModel<CrossRegionRestoreJobContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CrossRegionRestoreJobContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CrossRegionRestoreJobContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CrossRegionRestoreJobContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CrossRegionRestoreJobContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceRegion"u8);
            writer.WriteStringValue(SourceRegion);
            writer.WritePropertyName("sourceBackupVaultId"u8);
            writer.WriteStringValue(SourceBackupVaultId);
            writer.WritePropertyName("jobId"u8);
            writer.WriteStringValue(JobId);
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

        CrossRegionRestoreJobContent IJsonModel<CrossRegionRestoreJobContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CrossRegionRestoreJobContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CrossRegionRestoreJobContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCrossRegionRestoreJobContent(document.RootElement, options);
        }

        internal static CrossRegionRestoreJobContent DeserializeCrossRegionRestoreJobContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation sourceRegion = default;
            ResourceIdentifier sourceBackupVaultId = default;
            Guid jobId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceRegion"u8))
                {
                    sourceRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceBackupVaultId"u8))
                {
                    sourceBackupVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CrossRegionRestoreJobContent(sourceRegion, sourceBackupVaultId, jobId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CrossRegionRestoreJobContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CrossRegionRestoreJobContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CrossRegionRestoreJobContent)} does not support writing '{options.Format}' format.");
            }
        }

        CrossRegionRestoreJobContent IPersistableModel<CrossRegionRestoreJobContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CrossRegionRestoreJobContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCrossRegionRestoreJobContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CrossRegionRestoreJobContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CrossRegionRestoreJobContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
