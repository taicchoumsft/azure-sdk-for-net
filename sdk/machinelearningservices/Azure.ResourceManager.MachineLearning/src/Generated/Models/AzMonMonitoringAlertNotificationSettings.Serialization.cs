// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AzMonMonitoringAlertNotificationSettings : IUtf8JsonSerializable, IJsonModel<AzMonMonitoringAlertNotificationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzMonMonitoringAlertNotificationSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzMonMonitoringAlertNotificationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzMonMonitoringAlertNotificationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzMonMonitoringAlertNotificationSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("alertNotificationType"u8);
            writer.WriteStringValue(AlertNotificationType.ToString());
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

        AzMonMonitoringAlertNotificationSettings IJsonModel<AzMonMonitoringAlertNotificationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzMonMonitoringAlertNotificationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzMonMonitoringAlertNotificationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzMonMonitoringAlertNotificationSettings(document.RootElement, options);
        }

        internal static AzMonMonitoringAlertNotificationSettings DeserializeAzMonMonitoringAlertNotificationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitoringAlertNotificationType alertNotificationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertNotificationType"u8))
                {
                    alertNotificationType = new MonitoringAlertNotificationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzMonMonitoringAlertNotificationSettings(alertNotificationType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzMonMonitoringAlertNotificationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzMonMonitoringAlertNotificationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzMonMonitoringAlertNotificationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AzMonMonitoringAlertNotificationSettings IPersistableModel<AzMonMonitoringAlertNotificationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzMonMonitoringAlertNotificationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzMonMonitoringAlertNotificationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzMonMonitoringAlertNotificationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzMonMonitoringAlertNotificationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
