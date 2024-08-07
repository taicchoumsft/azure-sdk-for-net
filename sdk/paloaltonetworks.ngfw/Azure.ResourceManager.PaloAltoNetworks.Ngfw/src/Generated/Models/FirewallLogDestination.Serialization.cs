// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallLogDestination : IUtf8JsonSerializable, IJsonModel<FirewallLogDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallLogDestination>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FirewallLogDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallLogDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallLogDestination)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageConfiguration))
            {
                writer.WritePropertyName("storageConfigurations"u8);
                writer.WriteObjectValue(StorageConfiguration, options);
            }
            if (Optional.IsDefined(EventHubConfiguration))
            {
                writer.WritePropertyName("eventHubConfigurations"u8);
                writer.WriteObjectValue(EventHubConfiguration, options);
            }
            if (Optional.IsDefined(MonitorConfiguration))
            {
                writer.WritePropertyName("monitorConfigurations"u8);
                writer.WriteObjectValue(MonitorConfiguration, options);
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

        FirewallLogDestination IJsonModel<FirewallLogDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallLogDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallLogDestination)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallLogDestination(document.RootElement, options);
        }

        internal static FirewallLogDestination DeserializeFirewallLogDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageAccountConfiguration storageConfigurations = default;
            EventHubConfiguration eventHubConfigurations = default;
            MonitorLogConfiguration monitorConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageConfigurations = StorageAccountConfiguration.DeserializeStorageAccountConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("eventHubConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventHubConfigurations = EventHubConfiguration.DeserializeEventHubConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("monitorConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorConfigurations = MonitorLogConfiguration.DeserializeMonitorLogConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FirewallLogDestination(storageConfigurations, eventHubConfigurations, monitorConfigurations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallLogDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallLogDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallLogDestination)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallLogDestination IPersistableModel<FirewallLogDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallLogDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallLogDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallLogDestination)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallLogDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
