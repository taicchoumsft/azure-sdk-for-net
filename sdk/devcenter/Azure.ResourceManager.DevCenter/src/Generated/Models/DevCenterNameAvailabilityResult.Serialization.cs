// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterNameAvailabilityResult : IUtf8JsonSerializable, IJsonModel<DevCenterNameAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterNameAvailabilityResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevCenterNameAvailabilityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterNameAvailabilityResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsNameAvailable))
            {
                writer.WritePropertyName("nameAvailable"u8);
                writer.WriteBooleanValue(IsNameAvailable.Value);
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        DevCenterNameAvailabilityResult IJsonModel<DevCenterNameAvailabilityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterNameAvailabilityResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterNameAvailabilityResult(document.RootElement, options);
        }

        internal static DevCenterNameAvailabilityResult DeserializeDevCenterNameAvailabilityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? nameAvailable = default;
            DevCenterNameUnavailableReason? reason = default;
            string message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = new DevCenterNameUnavailableReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevCenterNameAvailabilityResult(nameAvailable, reason, message, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevCenterNameAvailabilityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevCenterNameAvailabilityResult)} does not support writing '{options.Format}' format.");
            }
        }

        DevCenterNameAvailabilityResult IPersistableModel<DevCenterNameAvailabilityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevCenterNameAvailabilityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterNameAvailabilityResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterNameAvailabilityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
