// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsExtendedStatusInfo : IUtf8JsonSerializable, IJsonModel<BillingBenefitsExtendedStatusInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingBenefitsExtendedStatusInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingBenefitsExtendedStatusInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsExtendedStatusInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsExtendedStatusInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StatusCode))
            {
                writer.WritePropertyName("statusCode"u8);
                writer.WriteStringValue(StatusCode);
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

        BillingBenefitsExtendedStatusInfo IJsonModel<BillingBenefitsExtendedStatusInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsExtendedStatusInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsExtendedStatusInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsExtendedStatusInfo(document.RootElement, options);
        }

        internal static BillingBenefitsExtendedStatusInfo DeserializeBillingBenefitsExtendedStatusInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string statusCode = default;
            string message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"u8))
                {
                    statusCode = property.Value.GetString();
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
            return new BillingBenefitsExtendedStatusInfo(statusCode, message, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingBenefitsExtendedStatusInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsExtendedStatusInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsExtendedStatusInfo)} does not support writing '{options.Format}' format.");
            }
        }

        BillingBenefitsExtendedStatusInfo IPersistableModel<BillingBenefitsExtendedStatusInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsExtendedStatusInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingBenefitsExtendedStatusInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsExtendedStatusInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingBenefitsExtendedStatusInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
