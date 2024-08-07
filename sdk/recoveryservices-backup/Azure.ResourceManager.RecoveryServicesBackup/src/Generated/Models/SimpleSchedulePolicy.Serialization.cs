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
    public partial class SimpleSchedulePolicy : IUtf8JsonSerializable, IJsonModel<SimpleSchedulePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SimpleSchedulePolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SimpleSchedulePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleRunFrequency))
            {
                writer.WritePropertyName("scheduleRunFrequency"u8);
                writer.WriteStringValue(ScheduleRunFrequency.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ScheduleRunDays))
            {
                writer.WritePropertyName("scheduleRunDays"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleRunDays)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScheduleRunTimes))
            {
                writer.WritePropertyName("scheduleRunTimes"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleRunTimes)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HourlySchedule))
            {
                writer.WritePropertyName("hourlySchedule"u8);
                writer.WriteObjectValue(HourlySchedule, options);
            }
            if (Optional.IsDefined(ScheduleWeeklyFrequency))
            {
                writer.WritePropertyName("scheduleWeeklyFrequency"u8);
                writer.WriteNumberValue(ScheduleWeeklyFrequency.Value);
            }
            writer.WritePropertyName("schedulePolicyType"u8);
            writer.WriteStringValue(SchedulePolicyType);
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

        SimpleSchedulePolicy IJsonModel<SimpleSchedulePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSimpleSchedulePolicy(document.RootElement, options);
        }

        internal static SimpleSchedulePolicy DeserializeSimpleSchedulePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScheduleRunType? scheduleRunFrequency = default;
            IList<BackupDayOfWeek> scheduleRunDays = default;
            IList<DateTimeOffset> scheduleRunTimes = default;
            BackupHourlySchedule hourlySchedule = default;
            int? scheduleWeeklyFrequency = default;
            string schedulePolicyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleRunFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleRunFrequency = new ScheduleRunType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduleRunDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupDayOfWeek> array = new List<BackupDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBackupDayOfWeek());
                    }
                    scheduleRunDays = array;
                    continue;
                }
                if (property.NameEquals("scheduleRunTimes"u8))
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
                    scheduleRunTimes = array;
                    continue;
                }
                if (property.NameEquals("hourlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hourlySchedule = BackupHourlySchedule.DeserializeBackupHourlySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scheduleWeeklyFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleWeeklyFrequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("schedulePolicyType"u8))
                {
                    schedulePolicyType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SimpleSchedulePolicy(
                schedulePolicyType,
                serializedAdditionalRawData,
                scheduleRunFrequency,
                scheduleRunDays ?? new ChangeTrackingList<BackupDayOfWeek>(),
                scheduleRunTimes ?? new ChangeTrackingList<DateTimeOffset>(),
                hourlySchedule,
                scheduleWeeklyFrequency);
        }

        BinaryData IPersistableModel<SimpleSchedulePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SimpleSchedulePolicy)} does not support writing '{options.Format}' format.");
            }
        }

        SimpleSchedulePolicy IPersistableModel<SimpleSchedulePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSimpleSchedulePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SimpleSchedulePolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SimpleSchedulePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
