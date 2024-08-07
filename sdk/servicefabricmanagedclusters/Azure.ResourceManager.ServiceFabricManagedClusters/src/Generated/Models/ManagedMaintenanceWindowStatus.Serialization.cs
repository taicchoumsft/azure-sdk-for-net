// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedMaintenanceWindowStatus : IUtf8JsonSerializable, IJsonModel<ManagedMaintenanceWindowStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedMaintenanceWindowStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedMaintenanceWindowStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedMaintenanceWindowStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedMaintenanceWindowStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IsWindowEnabled))
            {
                writer.WritePropertyName("isWindowEnabled"u8);
                writer.WriteBooleanValue(IsWindowEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsRegionReady))
            {
                writer.WritePropertyName("isRegionReady"u8);
                writer.WriteBooleanValue(IsRegionReady.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsWindowActive))
            {
                writer.WritePropertyName("isWindowActive"u8);
                writer.WriteBooleanValue(IsWindowActive.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CanApplyUpdates))
            {
                writer.WritePropertyName("canApplyUpdates"u8);
                writer.WriteBooleanValue(CanApplyUpdates.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastWindowStatusUpdatedOn))
            {
                writer.WritePropertyName("lastWindowStatusUpdateAtUTC"u8);
                writer.WriteStringValue(LastWindowStatusUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastWindowStartOn))
            {
                writer.WritePropertyName("lastWindowStartTimeUTC"u8);
                writer.WriteStringValue(LastWindowStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastWindowEndOn))
            {
                writer.WritePropertyName("lastWindowEndTimeUTC"u8);
                writer.WriteStringValue(LastWindowEndOn.Value, "O");
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

        ManagedMaintenanceWindowStatus IJsonModel<ManagedMaintenanceWindowStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedMaintenanceWindowStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedMaintenanceWindowStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedMaintenanceWindowStatus(document.RootElement, options);
        }

        internal static ManagedMaintenanceWindowStatus DeserializeManagedMaintenanceWindowStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isWindowEnabled = default;
            bool? isRegionReady = default;
            bool? isWindowActive = default;
            bool? canApplyUpdates = default;
            DateTimeOffset? lastWindowStatusUpdateAtUTC = default;
            DateTimeOffset? lastWindowStartTimeUTC = default;
            DateTimeOffset? lastWindowEndTimeUTC = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isWindowEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWindowEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRegionReady"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRegionReady = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isWindowActive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWindowActive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("canApplyUpdates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canApplyUpdates = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastWindowStatusUpdateAtUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastWindowStatusUpdateAtUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastWindowStartTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastWindowStartTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastWindowEndTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastWindowEndTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedMaintenanceWindowStatus(
                isWindowEnabled,
                isRegionReady,
                isWindowActive,
                canApplyUpdates,
                lastWindowStatusUpdateAtUTC,
                lastWindowStartTimeUTC,
                lastWindowEndTimeUTC,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedMaintenanceWindowStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedMaintenanceWindowStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedMaintenanceWindowStatus)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedMaintenanceWindowStatus IPersistableModel<ManagedMaintenanceWindowStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedMaintenanceWindowStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedMaintenanceWindowStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedMaintenanceWindowStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedMaintenanceWindowStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
