// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertSummaryGroupItemInfo : IUtf8JsonSerializable, IJsonModel<ServiceAlertSummaryGroupItemInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAlertSummaryGroupItemInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceAlertSummaryGroupItemInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertSummaryGroupItemInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertSummaryGroupItemInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(GroupedBy))
            {
                writer.WritePropertyName("groupedby"u8);
                writer.WriteStringValue(GroupedBy);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
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

        ServiceAlertSummaryGroupItemInfo IJsonModel<ServiceAlertSummaryGroupItemInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertSummaryGroupItemInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertSummaryGroupItemInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertSummaryGroupItemInfo(document.RootElement, options);
        }

        internal static ServiceAlertSummaryGroupItemInfo DeserializeServiceAlertSummaryGroupItemInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            long? count = default;
            string groupedby = default;
            IList<ServiceAlertSummaryGroupItemInfo> values = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("groupedby"u8))
                {
                    groupedby = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAlertSummaryGroupItemInfo> array = new List<ServiceAlertSummaryGroupItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeServiceAlertSummaryGroupItemInfo(item, options));
                    }
                    values = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServiceAlertSummaryGroupItemInfo(name, count, groupedby, values ?? new ChangeTrackingList<ServiceAlertSummaryGroupItemInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceAlertSummaryGroupItemInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertSummaryGroupItemInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertSummaryGroupItemInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceAlertSummaryGroupItemInfo IPersistableModel<ServiceAlertSummaryGroupItemInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertSummaryGroupItemInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAlertSummaryGroupItemInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertSummaryGroupItemInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAlertSummaryGroupItemInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
