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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AutoHealTriggers : IUtf8JsonSerializable, IJsonModel<AutoHealTriggers>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoHealTriggers>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutoHealTriggers>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealTriggers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoHealTriggers)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Requests))
            {
                writer.WritePropertyName("requests"u8);
                writer.WriteObjectValue(Requests, options);
            }
            if (Optional.IsDefined(PrivateBytesInKB))
            {
                writer.WritePropertyName("privateBytesInKB"u8);
                writer.WriteNumberValue(PrivateBytesInKB.Value);
            }
            if (Optional.IsCollectionDefined(StatusCodes))
            {
                writer.WritePropertyName("statusCodes"u8);
                writer.WriteStartArray();
                foreach (var item in StatusCodes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SlowRequests))
            {
                writer.WritePropertyName("slowRequests"u8);
                writer.WriteObjectValue(SlowRequests, options);
            }
            if (Optional.IsCollectionDefined(SlowRequestsWithPath))
            {
                writer.WritePropertyName("slowRequestsWithPath"u8);
                writer.WriteStartArray();
                foreach (var item in SlowRequestsWithPath)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StatusCodesRange))
            {
                writer.WritePropertyName("statusCodesRange"u8);
                writer.WriteStartArray();
                foreach (var item in StatusCodesRange)
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

        AutoHealTriggers IJsonModel<AutoHealTriggers>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealTriggers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoHealTriggers)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoHealTriggers(document.RootElement, options);
        }

        internal static AutoHealTriggers DeserializeAutoHealTriggers(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RequestsBasedTrigger requests = default;
            int? privateBytesInKB = default;
            IList<StatusCodesBasedTrigger> statusCodes = default;
            SlowRequestsBasedTrigger slowRequests = default;
            IList<SlowRequestsBasedTrigger> slowRequestsWithPath = default;
            IList<StatusCodesRangeBasedTrigger> statusCodesRange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requests = RequestsBasedTrigger.DeserializeRequestsBasedTrigger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateBytesInKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateBytesInKB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statusCodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StatusCodesBasedTrigger> array = new List<StatusCodesBasedTrigger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StatusCodesBasedTrigger.DeserializeStatusCodesBasedTrigger(item, options));
                    }
                    statusCodes = array;
                    continue;
                }
                if (property.NameEquals("slowRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slowRequests = SlowRequestsBasedTrigger.DeserializeSlowRequestsBasedTrigger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("slowRequestsWithPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SlowRequestsBasedTrigger> array = new List<SlowRequestsBasedTrigger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SlowRequestsBasedTrigger.DeserializeSlowRequestsBasedTrigger(item, options));
                    }
                    slowRequestsWithPath = array;
                    continue;
                }
                if (property.NameEquals("statusCodesRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StatusCodesRangeBasedTrigger> array = new List<StatusCodesRangeBasedTrigger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StatusCodesRangeBasedTrigger.DeserializeStatusCodesRangeBasedTrigger(item, options));
                    }
                    statusCodesRange = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutoHealTriggers(
                requests,
                privateBytesInKB,
                statusCodes ?? new ChangeTrackingList<StatusCodesBasedTrigger>(),
                slowRequests,
                slowRequestsWithPath ?? new ChangeTrackingList<SlowRequestsBasedTrigger>(),
                statusCodesRange ?? new ChangeTrackingList<StatusCodesRangeBasedTrigger>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Requests), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  requests: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Requests))
                {
                    builder.Append("  requests: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Requests, options, 2, false, "  requests: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateBytesInKB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  privateBytesInKB: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateBytesInKB))
                {
                    builder.Append("  privateBytesInKB: ");
                    builder.AppendLine($"{PrivateBytesInKB.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatusCodes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  statusCodes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(StatusCodes))
                {
                    if (StatusCodes.Any())
                    {
                        builder.Append("  statusCodes: ");
                        builder.AppendLine("[");
                        foreach (var item in StatusCodes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  statusCodes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SlowRequests), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  slowRequests: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SlowRequests))
                {
                    builder.Append("  slowRequests: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SlowRequests, options, 2, false, "  slowRequests: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SlowRequestsWithPath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  slowRequestsWithPath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SlowRequestsWithPath))
                {
                    if (SlowRequestsWithPath.Any())
                    {
                        builder.Append("  slowRequestsWithPath: ");
                        builder.AppendLine("[");
                        foreach (var item in SlowRequestsWithPath)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  slowRequestsWithPath: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatusCodesRange), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  statusCodesRange: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(StatusCodesRange))
                {
                    if (StatusCodesRange.Any())
                    {
                        builder.Append("  statusCodesRange: ");
                        builder.AppendLine("[");
                        foreach (var item in StatusCodesRange)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  statusCodesRange: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AutoHealTriggers>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealTriggers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AutoHealTriggers)} does not support writing '{options.Format}' format.");
            }
        }

        AutoHealTriggers IPersistableModel<AutoHealTriggers>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealTriggers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoHealTriggers(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoHealTriggers)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoHealTriggers>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
