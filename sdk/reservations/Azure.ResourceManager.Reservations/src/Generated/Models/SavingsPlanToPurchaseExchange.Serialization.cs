// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class SavingsPlanToPurchaseExchange : IUtf8JsonSerializable, IJsonModel<SavingsPlanToPurchaseExchange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanToPurchaseExchange>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SavingsPlanToPurchaseExchange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanToPurchaseExchange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanToPurchaseExchange)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SavingsPlanOrderId))
            {
                writer.WritePropertyName("savingsPlanOrderId"u8);
                writer.WriteStringValue(SavingsPlanOrderId);
            }
            if (Optional.IsDefined(SavingsPlanId))
            {
                writer.WritePropertyName("savingsPlanId"u8);
                writer.WriteStringValue(SavingsPlanId);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
            }
            if (Optional.IsDefined(BillingCurrencyTotal))
            {
                writer.WritePropertyName("billingCurrencyTotal"u8);
                writer.WriteObjectValue(BillingCurrencyTotal, options);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        SavingsPlanToPurchaseExchange IJsonModel<SavingsPlanToPurchaseExchange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanToPurchaseExchange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanToPurchaseExchange)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanToPurchaseExchange(document.RootElement, options);
        }

        internal static SavingsPlanToPurchaseExchange DeserializeSavingsPlanToPurchaseExchange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string savingsPlanOrderId = default;
            string savingsPlanId = default;
            SavingsPlanPurchase properties = default;
            PurchasePrice billingCurrencyTotal = default;
            ReservationOperationStatus? status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("savingsPlanOrderId"u8))
                {
                    savingsPlanOrderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("savingsPlanId"u8))
                {
                    savingsPlanId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SavingsPlanPurchase.DeserializeSavingsPlanPurchase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotal = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ReservationOperationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SavingsPlanToPurchaseExchange(
                savingsPlanOrderId,
                savingsPlanId,
                properties,
                billingCurrencyTotal,
                status,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SavingsPlanToPurchaseExchange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanToPurchaseExchange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanToPurchaseExchange)} does not support writing '{options.Format}' format.");
            }
        }

        SavingsPlanToPurchaseExchange IPersistableModel<SavingsPlanToPurchaseExchange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanToPurchaseExchange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSavingsPlanToPurchaseExchange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanToPurchaseExchange)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanToPurchaseExchange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
