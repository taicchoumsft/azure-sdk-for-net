// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionSavingsProperties : IUtf8JsonSerializable, IJsonModel<ConsumptionSavingsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionSavingsProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConsumptionSavingsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionSavingsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionSavingsProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CalculatedSavings))
            {
                writer.WritePropertyName("calculatedSavings"u8);
                writer.WriteStartArray();
                foreach (var item in CalculatedSavings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LookBackPeriod))
            {
                writer.WritePropertyName("lookBackPeriod"u8);
                writer.WriteNumberValue(LookBackPeriod.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RecommendedQuantity))
            {
                writer.WritePropertyName("recommendedQuantity"u8);
                writer.WriteNumberValue(RecommendedQuantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReservationOrderTerm))
            {
                writer.WritePropertyName("reservationOrderTerm"u8);
                writer.WriteStringValue(ReservationOrderTerm);
            }
            if (options.Format != "W" && Optional.IsDefined(SavingsType))
            {
                writer.WritePropertyName("savingsType"u8);
                writer.WriteStringValue(SavingsType);
            }
            if (options.Format != "W" && Optional.IsDefined(UnitOfMeasure))
            {
                writer.WritePropertyName("unitOfMeasure"u8);
                writer.WriteStringValue(UnitOfMeasure);
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

        ConsumptionSavingsProperties IJsonModel<ConsumptionSavingsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionSavingsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionSavingsProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionSavingsProperties(document.RootElement, options);
        }

        internal static ConsumptionSavingsProperties DeserializeConsumptionSavingsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ConsumptionCalculatedSavingsProperties> calculatedSavings = default;
            int? lookBackPeriod = default;
            float? recommendedQuantity = default;
            string reservationOrderTerm = default;
            string savingsType = default;
            string unitOfMeasure = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("calculatedSavings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConsumptionCalculatedSavingsProperties> array = new List<ConsumptionCalculatedSavingsProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConsumptionCalculatedSavingsProperties.DeserializeConsumptionCalculatedSavingsProperties(item, options));
                    }
                    calculatedSavings = array;
                    continue;
                }
                if (property.NameEquals("lookBackPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lookBackPeriod = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recommendedQuantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendedQuantity = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("reservationOrderTerm"u8))
                {
                    reservationOrderTerm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("savingsType"u8))
                {
                    savingsType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unitOfMeasure"u8))
                {
                    unitOfMeasure = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConsumptionSavingsProperties(
                calculatedSavings ?? new ChangeTrackingList<ConsumptionCalculatedSavingsProperties>(),
                lookBackPeriod,
                recommendedQuantity,
                reservationOrderTerm,
                savingsType,
                unitOfMeasure,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionSavingsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionSavingsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionSavingsProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ConsumptionSavingsProperties IPersistableModel<ConsumptionSavingsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionSavingsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionSavingsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionSavingsProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionSavingsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
