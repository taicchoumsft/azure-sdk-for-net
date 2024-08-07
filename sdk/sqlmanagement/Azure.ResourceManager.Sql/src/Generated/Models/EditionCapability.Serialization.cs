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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class EditionCapability : IUtf8JsonSerializable, IJsonModel<EditionCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EditionCapability>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EditionCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EditionCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EditionCapability)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedServiceLevelObjectives))
            {
                writer.WritePropertyName("supportedServiceLevelObjectives"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedServiceLevelObjectives)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReadScale))
            {
                writer.WritePropertyName("readScale"u8);
                writer.WriteObjectValue(ReadScale, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedStorageCapabilities))
            {
                writer.WritePropertyName("supportedStorageCapabilities"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedStorageCapabilities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        EditionCapability IJsonModel<EditionCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EditionCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EditionCapability)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEditionCapability(document.RootElement, options);
        }

        internal static EditionCapability DeserializeEditionCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IReadOnlyList<ServiceObjectiveCapability> supportedServiceLevelObjectives = default;
            bool? zoneRedundant = default;
            ReadScaleCapability readScale = default;
            IReadOnlyList<StorageCapability> supportedStorageCapabilities = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedServiceLevelObjectives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceObjectiveCapability> array = new List<ServiceObjectiveCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceObjectiveCapability.DeserializeServiceObjectiveCapability(item, options));
                    }
                    supportedServiceLevelObjectives = array;
                    continue;
                }
                if (property.NameEquals("zoneRedundant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readScale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readScale = ReadScaleCapability.DeserializeReadScaleCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("supportedStorageCapabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageCapability> array = new List<StorageCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageCapability.DeserializeStorageCapability(item, options));
                    }
                    supportedStorageCapabilities = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EditionCapability(
                name,
                supportedServiceLevelObjectives ?? new ChangeTrackingList<ServiceObjectiveCapability>(),
                zoneRedundant,
                readScale,
                supportedStorageCapabilities ?? new ChangeTrackingList<StorageCapability>(),
                status,
                reason,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedServiceLevelObjectives), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedServiceLevelObjectives: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedServiceLevelObjectives))
                {
                    if (SupportedServiceLevelObjectives.Any())
                    {
                        builder.Append("  supportedServiceLevelObjectives: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedServiceLevelObjectives)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedServiceLevelObjectives: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsZoneRedundant), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  zoneRedundant: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsZoneRedundant))
                {
                    builder.Append("  zoneRedundant: ");
                    var boolValue = IsZoneRedundant.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReadScale), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  readScale: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReadScale))
                {
                    builder.Append("  readScale: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ReadScale, options, 2, false, "  readScale: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedStorageCapabilities), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedStorageCapabilities: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedStorageCapabilities))
                {
                    if (SupportedStorageCapabilities.Any())
                    {
                        builder.Append("  supportedStorageCapabilities: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedStorageCapabilities)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedStorageCapabilities: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reason), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  reason: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Reason))
                {
                    builder.Append("  reason: ");
                    if (Reason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Reason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Reason}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EditionCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EditionCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EditionCapability)} does not support writing '{options.Format}' format.");
            }
        }

        EditionCapability IPersistableModel<EditionCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EditionCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEditionCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EditionCapability)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EditionCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
