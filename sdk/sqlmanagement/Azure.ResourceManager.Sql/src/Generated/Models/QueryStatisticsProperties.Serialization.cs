// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class QueryStatisticsProperties : IUtf8JsonSerializable, IJsonModel<QueryStatisticsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryStatisticsProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<QueryStatisticsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatisticsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryStatisticsProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(QueryId))
            {
                writer.WritePropertyName("queryId"u8);
                writer.WriteStringValue(QueryId);
            }
            if (options.Format != "W" && Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartTime);
            }
            if (options.Format != "W" && Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndTime);
            }
            if (Optional.IsCollectionDefined(Intervals))
            {
                writer.WritePropertyName("intervals"u8);
                writer.WriteStartArray();
                foreach (var item in Intervals)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        QueryStatisticsProperties IJsonModel<QueryStatisticsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatisticsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryStatisticsProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryStatisticsProperties(document.RootElement, options);
        }

        internal static QueryStatisticsProperties DeserializeQueryStatisticsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            string queryId = default;
            string startTime = default;
            string endTime = default;
            IReadOnlyList<QueryMetricInterval> intervals = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryId"u8))
                {
                    queryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("intervals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryMetricInterval> array = new List<QueryMetricInterval>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryMetricInterval.DeserializeQueryMetricInterval(item, options));
                    }
                    intervals = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new QueryStatisticsProperties(
                databaseName,
                queryId,
                startTime,
                endTime,
                intervals ?? new ChangeTrackingList<QueryMetricInterval>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  databaseName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DatabaseName))
                {
                    builder.Append("  databaseName: ");
                    if (DatabaseName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DatabaseName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DatabaseName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryId))
                {
                    builder.Append("  queryId: ");
                    if (QueryId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartTime))
                {
                    builder.Append("  startTime: ");
                    if (StartTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StartTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StartTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndTime))
                {
                    builder.Append("  endTime: ");
                    if (EndTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EndTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EndTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Intervals), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  intervals: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Intervals))
                {
                    if (Intervals.Any())
                    {
                        builder.Append("  intervals: ");
                        builder.AppendLine("[");
                        foreach (var item in Intervals)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  intervals: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<QueryStatisticsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatisticsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(QueryStatisticsProperties)} does not support writing '{options.Format}' format.");
            }
        }

        QueryStatisticsProperties IPersistableModel<QueryStatisticsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatisticsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryStatisticsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryStatisticsProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryStatisticsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
