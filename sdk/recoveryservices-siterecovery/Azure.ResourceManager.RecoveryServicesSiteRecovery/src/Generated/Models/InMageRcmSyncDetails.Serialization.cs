// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmSyncDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmSyncDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmSyncDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InMageRcmSyncDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmSyncDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmSyncDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProgressHealth))
            {
                writer.WritePropertyName("progressHealth"u8);
                writer.WriteStringValue(ProgressHealth.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TransferredBytes))
            {
                writer.WritePropertyName("transferredBytes"u8);
                writer.WriteNumberValue(TransferredBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Last15MinutesTransferredBytes))
            {
                writer.WritePropertyName("last15MinutesTransferredBytes"u8);
                writer.WriteNumberValue(Last15MinutesTransferredBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastDataTransferTimeUtc))
            {
                writer.WritePropertyName("lastDataTransferTimeUtc"u8);
                writer.WriteStringValue(LastDataTransferTimeUtc);
            }
            if (options.Format != "W" && Optional.IsDefined(ProcessedBytes))
            {
                writer.WritePropertyName("processedBytes"u8);
                writer.WriteNumberValue(ProcessedBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StaStartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StaStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastRefreshedOn))
            {
                writer.WritePropertyName("lastRefreshTime"u8);
                writer.WriteStringValue(LastRefreshedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProgressPercentage))
            {
                writer.WritePropertyName("progressPercentage"u8);
                writer.WriteNumberValue(ProgressPercentage.Value);
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

        InMageRcmSyncDetails IJsonModel<InMageRcmSyncDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmSyncDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmSyncDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmSyncDetails(document.RootElement, options);
        }

        internal static InMageRcmSyncDetails DeserializeInMageRcmSyncDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SiteRecoveryDiskReplicationProgressHealth? progressHealth = default;
            long? transferredBytes = default;
            long? last15MinutesTransferredBytes = default;
            string lastDataTransferTimeUtc = default;
            long? processedBytes = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? lastRefreshTime = default;
            int? progressPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("progressHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressHealth = new SiteRecoveryDiskReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("transferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("last15MinutesTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    last15MinutesTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastDataTransferTimeUtc"u8))
                {
                    lastDataTransferTimeUtc = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastRefreshTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRefreshTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("progressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InMageRcmSyncDetails(
                progressHealth,
                transferredBytes,
                last15MinutesTransferredBytes,
                lastDataTransferTimeUtc,
                processedBytes,
                startTime,
                lastRefreshTime,
                progressPercentage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmSyncDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmSyncDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmSyncDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InMageRcmSyncDetails IPersistableModel<InMageRcmSyncDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmSyncDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmSyncDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmSyncDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmSyncDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
