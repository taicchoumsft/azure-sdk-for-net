// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountThrottlingRule : IUtf8JsonSerializable, IJsonModel<ServiceAccountThrottlingRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAccountThrottlingRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceAccountThrottlingRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountThrottlingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAccountThrottlingRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
            }
            if (Optional.IsDefined(RenewalPeriod))
            {
                writer.WritePropertyName("renewalPeriod"u8);
                writer.WriteNumberValue(RenewalPeriod.Value);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount"u8);
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(IsDynamicThrottlingEnabled))
            {
                writer.WritePropertyName("dynamicThrottlingEnabled"u8);
                writer.WriteBooleanValue(IsDynamicThrottlingEnabled.Value);
            }
            if (Optional.IsCollectionDefined(MatchPatterns))
            {
                writer.WritePropertyName("matchPatterns"u8);
                writer.WriteStartArray();
                foreach (var item in MatchPatterns)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ServiceAccountThrottlingRule IJsonModel<ServiceAccountThrottlingRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountThrottlingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAccountThrottlingRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAccountThrottlingRule(document.RootElement, options);
        }

        internal static ServiceAccountThrottlingRule DeserializeServiceAccountThrottlingRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            float? renewalPeriod = default;
            float? count = default;
            float? minCount = default;
            bool? dynamicThrottlingEnabled = default;
            IReadOnlyList<ServiceAccountThrottlingMatchPattern> matchPatterns = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewalPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewalPeriod = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("minCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("dynamicThrottlingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicThrottlingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchPatterns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAccountThrottlingMatchPattern> array = new List<ServiceAccountThrottlingMatchPattern>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountThrottlingMatchPattern.DeserializeServiceAccountThrottlingMatchPattern(item, options));
                    }
                    matchPatterns = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServiceAccountThrottlingRule(
                key,
                renewalPeriod,
                count,
                minCount,
                dynamicThrottlingEnabled,
                matchPatterns ?? new ChangeTrackingList<ServiceAccountThrottlingMatchPattern>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Key), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  key: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Key))
                {
                    builder.Append("  key: ");
                    if (Key.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Key}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Key}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RenewalPeriod), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  renewalPeriod: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RenewalPeriod))
                {
                    builder.Append("  renewalPeriod: ");
                    builder.AppendLine($"'{RenewalPeriod.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Count), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  count: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Count))
                {
                    builder.Append("  count: ");
                    builder.AppendLine($"'{Count.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  minCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MinCount))
                {
                    builder.Append("  minCount: ");
                    builder.AppendLine($"'{MinCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDynamicThrottlingEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dynamicThrottlingEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDynamicThrottlingEnabled))
                {
                    builder.Append("  dynamicThrottlingEnabled: ");
                    var boolValue = IsDynamicThrottlingEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MatchPatterns), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  matchPatterns: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(MatchPatterns))
                {
                    if (MatchPatterns.Any())
                    {
                        builder.Append("  matchPatterns: ");
                        builder.AppendLine("[");
                        foreach (var item in MatchPatterns)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  matchPatterns: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ServiceAccountThrottlingRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountThrottlingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAccountThrottlingRule)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceAccountThrottlingRule IPersistableModel<ServiceAccountThrottlingRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountThrottlingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAccountThrottlingRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAccountThrottlingRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAccountThrottlingRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
