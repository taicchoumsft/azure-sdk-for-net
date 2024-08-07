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
    internal partial class UnknownMeterDetails : IUtf8JsonSerializable, IJsonModel<EdgeOrderProductMeterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderProductMeterDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeOrderProductMeterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductMeterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderProductMeterDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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

        EdgeOrderProductMeterDetails IJsonModel<EdgeOrderProductMeterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductMeterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderProductMeterDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderProductMeterDetails(document.RootElement, options);
        }

        internal static UnknownMeterDetails DeserializeUnknownMeterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingType billingType = "Unknown";
            double? multiplier = default;
            EdgeOrderProductChargingType? chargingType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new UnknownMeterDetails(billingType, multiplier, chargingType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderProductMeterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductMeterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderProductMeterDetails)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeOrderProductMeterDetails IPersistableModel<EdgeOrderProductMeterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductMeterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeOrderProductMeterDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderProductMeterDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderProductMeterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
