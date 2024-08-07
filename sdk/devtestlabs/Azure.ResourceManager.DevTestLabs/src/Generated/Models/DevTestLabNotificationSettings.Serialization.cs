// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabNotificationSettings : IUtf8JsonSerializable, IJsonModel<DevTestLabNotificationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabNotificationSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabNotificationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabNotificationSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(TimeInMinutes))
            {
                writer.WritePropertyName("timeInMinutes"u8);
                writer.WriteNumberValue(TimeInMinutes.Value);
            }
            if (Optional.IsDefined(WebhookUri))
            {
                writer.WritePropertyName("webhookUrl"u8);
                writer.WriteStringValue(WebhookUri.AbsoluteUri);
            }
            if (Optional.IsDefined(EmailRecipient))
            {
                writer.WritePropertyName("emailRecipient"u8);
                writer.WriteStringValue(EmailRecipient);
            }
            if (Optional.IsDefined(NotificationLocale))
            {
                writer.WritePropertyName("notificationLocale"u8);
                writer.WriteStringValue(NotificationLocale);
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

        DevTestLabNotificationSettings IJsonModel<DevTestLabNotificationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabNotificationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabNotificationSettings(document.RootElement, options);
        }

        internal static DevTestLabNotificationSettings DeserializeDevTestLabNotificationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DevTestLabEnableStatus? status = default;
            int? timeInMinutes = default;
            Uri webhookUrl = default;
            string emailRecipient = default;
            string notificationLocale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DevTestLabEnableStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("webhookUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webhookUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("emailRecipient"u8))
                {
                    emailRecipient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notificationLocale"u8))
                {
                    notificationLocale = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabNotificationSettings(
                status,
                timeInMinutes,
                webhookUrl,
                emailRecipient,
                notificationLocale,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabNotificationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabNotificationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabNotificationSettings IPersistableModel<DevTestLabNotificationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabNotificationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabNotificationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabNotificationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
