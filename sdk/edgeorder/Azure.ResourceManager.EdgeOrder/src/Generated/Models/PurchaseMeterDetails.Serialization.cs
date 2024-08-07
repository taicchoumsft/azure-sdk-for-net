// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class PurchaseMeterDetails : IUtf8JsonSerializable, IJsonModel<PurchaseMeterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurchaseMeterDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PurchaseMeterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurchaseMeterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurchaseMeterDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProductId))
            {
                writer.WritePropertyName("productId"u8);
                writer.WriteStringValue(ProductId);
            }
            if (options.Format != "W" && Optional.IsDefined(SkuId))
            {
                writer.WritePropertyName("skuId"u8);
                writer.WriteStringValue(SkuId);
            }
            if (options.Format != "W" && Optional.IsDefined(TermId))
            {
                writer.WritePropertyName("termId"u8);
                writer.WriteStringValue(TermId);
            }
            writer.WritePropertyName("billingType"u8);
            writer.WriteStringValue(BillingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Multiplier))
            {
                writer.WritePropertyName("multiplier"u8);
                writer.WriteNumberValue(Multiplier.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ChargingType))
            {
                writer.WritePropertyName("chargingType"u8);
                writer.WriteStringValue(ChargingType.Value.ToString());
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

        PurchaseMeterDetails IJsonModel<PurchaseMeterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurchaseMeterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurchaseMeterDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurchaseMeterDetails(document.RootElement, options);
        }

        internal static PurchaseMeterDetails DeserializePurchaseMeterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string productId = default;
            string skuId = default;
            string termId = default;
            BillingType billingType = default;
            double? multiplier = default;
            EdgeOrderProductChargingType? chargingType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productId"u8))
                {
                    productId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuId"u8))
                {
                    skuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termId"u8))
                {
                    termId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingType"u8))
                {
                    billingType = new BillingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiplier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiplier = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("chargingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    chargingType = new EdgeOrderProductChargingType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PurchaseMeterDetails(
                billingType,
                multiplier,
                chargingType,
                serializedAdditionalRawData,
                productId,
                skuId,
                termId);
        }

        BinaryData IPersistableModel<PurchaseMeterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurchaseMeterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PurchaseMeterDetails)} does not support writing '{options.Format}' format.");
            }
        }

        PurchaseMeterDetails IPersistableModel<PurchaseMeterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurchaseMeterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePurchaseMeterDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PurchaseMeterDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PurchaseMeterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
