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
    public partial class YearlyRetentionSchedule : IUtf8JsonSerializable, IJsonModel<YearlyRetentionSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<YearlyRetentionSchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<YearlyRetentionSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<YearlyRetentionSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(YearlyRetentionSchedule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RetentionScheduleFormatType))
            {
                writer.WritePropertyName("retentionScheduleFormatType"u8);
                writer.WriteStringValue(RetentionScheduleFormatType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MonthsOfYear))
            {
                writer.WritePropertyName("monthsOfYear"u8);
                writer.WriteStartArray();
                foreach (var item in MonthsOfYear)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RetentionScheduleDaily))
            {
                writer.WritePropertyName("retentionScheduleDaily"u8);
                writer.WriteObjectValue(RetentionScheduleDaily, options);
            }
            if (Optional.IsDefined(RetentionScheduleWeekly))
            {
                writer.WritePropertyName("retentionScheduleWeekly"u8);
                writer.WriteObjectValue(RetentionScheduleWeekly, options);
            }
            if (Optional.IsCollectionDefined(RetentionTimes))
            {
                writer.WritePropertyName("retentionTimes"u8);
                writer.WriteStartArray();
                foreach (var item in RetentionTimes)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RetentionDuration))
            {
                writer.WritePropertyName("retentionDuration"u8);
                writer.WriteObjectValue(RetentionDuration, options);
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

        YearlyRetentionSchedule IJsonModel<YearlyRetentionSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<YearlyRetentionSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(YearlyRetentionSchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeYearlyRetentionSchedule(document.RootElement, options);
        }

        internal static YearlyRetentionSchedule DeserializeYearlyRetentionSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RetentionScheduleFormat? retentionScheduleFormatType = default;
            IList<BackupMonthOfYear> monthsOfYear = default;
            DailyRetentionFormat retentionScheduleDaily = default;
            WeeklyRetentionFormat retentionScheduleWeekly = default;
            IList<DateTimeOffset> retentionTimes = default;
            RetentionDuration retentionDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionScheduleFormatType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleFormatType = new RetentionScheduleFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monthsOfYear"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupMonthOfYear> array = new List<BackupMonthOfYear>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBackupMonthOfYear());
                    }
                    monthsOfYear = array;
                    continue;
                }
                if (property.NameEquals("retentionScheduleDaily"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleDaily = DailyRetentionFormat.DeserializeDailyRetentionFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retentionScheduleWeekly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleWeekly = WeeklyRetentionFormat.DeserializeWeeklyRetentionFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retentionTimes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    retentionTimes = array;
                    continue;
                }
                if (property.NameEquals("retentionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionDuration = RetentionDuration.DeserializeRetentionDuration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new YearlyRetentionSchedule(
                retentionScheduleFormatType,
                monthsOfYear ?? new ChangeTrackingList<BackupMonthOfYear>(),
                retentionScheduleDaily,
                retentionScheduleWeekly,
                retentionTimes ?? new ChangeTrackingList<DateTimeOffset>(),
                retentionDuration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<YearlyRetentionSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<YearlyRetentionSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(YearlyRetentionSchedule)} does not support writing '{options.Format}' format.");
            }
        }

        YearlyRetentionSchedule IPersistableModel<YearlyRetentionSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<YearlyRetentionSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeYearlyRetentionSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(YearlyRetentionSchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<YearlyRetentionSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
