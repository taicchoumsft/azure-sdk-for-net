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
    public partial class MachineLearningEstimatedVmPrices : IUtf8JsonSerializable, IJsonModel<MachineLearningEstimatedVmPrices>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEstimatedVmPrices>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningEstimatedVmPrices>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEstimatedVmPrices>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEstimatedVmPrices)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("billingCurrency"u8);
            writer.WriteStringValue(BillingCurrency.ToString());
            writer.WritePropertyName("unitOfMeasure"u8);
            writer.WriteStringValue(UnitOfMeasure.ToString());
            writer.WritePropertyName("values"u8);
            writer.WriteStartArray();
            foreach (var item in Values)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        MachineLearningEstimatedVmPrices IJsonModel<MachineLearningEstimatedVmPrices>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEstimatedVmPrices>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEstimatedVmPrices)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEstimatedVmPrices(document.RootElement, options);
        }

        internal static MachineLearningEstimatedVmPrices DeserializeMachineLearningEstimatedVmPrices(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningBillingCurrency billingCurrency = default;
            MachineLearningUnitOfMeasure unitOfMeasure = default;
            IReadOnlyList<MachineLearningEstimatedVmPrice> values = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingCurrency"u8))
                {
                    billingCurrency = new MachineLearningBillingCurrency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unitOfMeasure"u8))
                {
                    unitOfMeasure = new MachineLearningUnitOfMeasure(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    List<MachineLearningEstimatedVmPrice> array = new List<MachineLearningEstimatedVmPrice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningEstimatedVmPrice.DeserializeMachineLearningEstimatedVmPrice(item, options));
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
            return new MachineLearningEstimatedVmPrices(billingCurrency, unitOfMeasure, values, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningEstimatedVmPrices>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEstimatedVmPrices>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEstimatedVmPrices)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningEstimatedVmPrices IPersistableModel<MachineLearningEstimatedVmPrices>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEstimatedVmPrices>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningEstimatedVmPrices(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEstimatedVmPrices)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningEstimatedVmPrices>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
