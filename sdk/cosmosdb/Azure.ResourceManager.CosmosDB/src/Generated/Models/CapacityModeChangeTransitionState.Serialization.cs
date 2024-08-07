// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CapacityModeChangeTransitionState : IUtf8JsonSerializable, IJsonModel<CapacityModeChangeTransitionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CapacityModeChangeTransitionState>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CapacityModeChangeTransitionState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityModeChangeTransitionState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CapacityModeChangeTransitionState)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CapacityModeTransitionStatus))
            {
                writer.WritePropertyName("capacityModeTransitionStatus"u8);
                writer.WriteStringValue(CapacityModeTransitionStatus.Value.ToString());
            }
            if (Optional.IsDefined(CurrentCapacityMode))
            {
                writer.WritePropertyName("currentCapacityMode"u8);
                writer.WriteStringValue(CurrentCapacityMode.Value.ToString());
            }
            if (Optional.IsDefined(PreviousCapacityMode))
            {
                writer.WritePropertyName("previousCapacityMode"u8);
                writer.WriteStringValue(PreviousCapacityMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CapacityModeTransitionBeginTimestamp))
            {
                writer.WritePropertyName("capacityModeTransitionBeginTimestamp"u8);
                writer.WriteStringValue(CapacityModeTransitionBeginTimestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CapacityModeTransitionEndTimestamp))
            {
                writer.WritePropertyName("capacityModeTransitionEndTimestamp"u8);
                writer.WriteStringValue(CapacityModeTransitionEndTimestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CapacityModeLastSuccessfulTransitionEndTimestamp))
            {
                writer.WritePropertyName("capacityModeLastSuccessfulTransitionEndTimestamp"u8);
                writer.WriteStringValue(CapacityModeLastSuccessfulTransitionEndTimestamp.Value, "O");
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

        CapacityModeChangeTransitionState IJsonModel<CapacityModeChangeTransitionState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityModeChangeTransitionState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CapacityModeChangeTransitionState)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCapacityModeChangeTransitionState(document.RootElement, options);
        }

        internal static CapacityModeChangeTransitionState DeserializeCapacityModeChangeTransitionState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CapacityModeTransitionStatus? capacityModeTransitionStatus = default;
            CapacityMode? currentCapacityMode = default;
            CapacityMode? previousCapacityMode = default;
            DateTimeOffset? capacityModeTransitionBeginTimestamp = default;
            DateTimeOffset? capacityModeTransitionEndTimestamp = default;
            DateTimeOffset? capacityModeLastSuccessfulTransitionEndTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacityModeTransitionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityModeTransitionStatus = new CapacityModeTransitionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentCapacityMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentCapacityMode = new CapacityMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("previousCapacityMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousCapacityMode = new CapacityMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacityModeTransitionBeginTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityModeTransitionBeginTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("capacityModeTransitionEndTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityModeTransitionEndTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("capacityModeLastSuccessfulTransitionEndTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityModeLastSuccessfulTransitionEndTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CapacityModeChangeTransitionState(
                capacityModeTransitionStatus,
                currentCapacityMode,
                previousCapacityMode,
                capacityModeTransitionBeginTimestamp,
                capacityModeTransitionEndTimestamp,
                capacityModeLastSuccessfulTransitionEndTimestamp,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CapacityModeTransitionStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  capacityModeTransitionStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CapacityModeTransitionStatus))
                {
                    builder.Append("  capacityModeTransitionStatus: ");
                    builder.AppendLine($"'{CapacityModeTransitionStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentCapacityMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  currentCapacityMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CurrentCapacityMode))
                {
                    builder.Append("  currentCapacityMode: ");
                    builder.AppendLine($"'{CurrentCapacityMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PreviousCapacityMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  previousCapacityMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PreviousCapacityMode))
                {
                    builder.Append("  previousCapacityMode: ");
                    builder.AppendLine($"'{PreviousCapacityMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CapacityModeTransitionBeginTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  capacityModeTransitionBeginTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CapacityModeTransitionBeginTimestamp))
                {
                    builder.Append("  capacityModeTransitionBeginTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CapacityModeTransitionBeginTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CapacityModeTransitionEndTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  capacityModeTransitionEndTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CapacityModeTransitionEndTimestamp))
                {
                    builder.Append("  capacityModeTransitionEndTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CapacityModeTransitionEndTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CapacityModeLastSuccessfulTransitionEndTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  capacityModeLastSuccessfulTransitionEndTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CapacityModeLastSuccessfulTransitionEndTimestamp))
                {
                    builder.Append("  capacityModeLastSuccessfulTransitionEndTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CapacityModeLastSuccessfulTransitionEndTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CapacityModeChangeTransitionState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityModeChangeTransitionState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CapacityModeChangeTransitionState)} does not support writing '{options.Format}' format.");
            }
        }

        CapacityModeChangeTransitionState IPersistableModel<CapacityModeChangeTransitionState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityModeChangeTransitionState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCapacityModeChangeTransitionState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CapacityModeChangeTransitionState)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CapacityModeChangeTransitionState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
