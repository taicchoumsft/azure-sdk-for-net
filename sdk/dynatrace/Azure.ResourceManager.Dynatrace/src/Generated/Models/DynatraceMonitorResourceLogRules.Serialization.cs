// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceMonitorResourceLogRules : IUtf8JsonSerializable, IJsonModel<DynatraceMonitorResourceLogRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceMonitorResourceLogRules>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DynatraceMonitorResourceLogRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorResourceLogRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceMonitorResourceLogRules)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SendAadLogs))
            {
                writer.WritePropertyName("sendAadLogs"u8);
                writer.WriteStringValue(SendAadLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendSubscriptionLogs))
            {
                writer.WritePropertyName("sendSubscriptionLogs"u8);
                writer.WriteStringValue(SendSubscriptionLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendActivityLogs))
            {
                writer.WritePropertyName("sendActivityLogs"u8);
                writer.WriteStringValue(SendActivityLogs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
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

        DynatraceMonitorResourceLogRules IJsonModel<DynatraceMonitorResourceLogRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorResourceLogRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceMonitorResourceLogRules)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceMonitorResourceLogRules(document.RootElement, options);
        }

        internal static DynatraceMonitorResourceLogRules DeserializeDynatraceMonitorResourceLogRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AadLogsSendingStatus? sendAadLogs = default;
            SubscriptionLogsSendingStatus? sendSubscriptionLogs = default;
            ActivityLogsSendingStatus? sendActivityLogs = default;
            IList<DynatraceMonitorResourceFilteringTag> filteringTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendAadLogs = new AadLogsSendingStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendSubscriptionLogs = new SubscriptionLogsSendingStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendActivityLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendActivityLogs = new ActivityLogsSendingStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DynatraceMonitorResourceFilteringTag> array = new List<DynatraceMonitorResourceFilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DynatraceMonitorResourceFilteringTag.DeserializeDynatraceMonitorResourceFilteringTag(item, options));
                    }
                    filteringTags = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DynatraceMonitorResourceLogRules(sendAadLogs, sendSubscriptionLogs, sendActivityLogs, filteringTags ?? new ChangeTrackingList<DynatraceMonitorResourceFilteringTag>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceMonitorResourceLogRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorResourceLogRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynatraceMonitorResourceLogRules)} does not support writing '{options.Format}' format.");
            }
        }

        DynatraceMonitorResourceLogRules IPersistableModel<DynatraceMonitorResourceLogRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorResourceLogRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynatraceMonitorResourceLogRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceMonitorResourceLogRules)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceMonitorResourceLogRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
