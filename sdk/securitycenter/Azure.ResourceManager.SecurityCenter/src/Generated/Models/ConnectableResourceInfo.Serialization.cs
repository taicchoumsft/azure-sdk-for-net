// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class ConnectableResourceInfo : IUtf8JsonSerializable, IJsonModel<ConnectableResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectableResourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectableResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectableResourceInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(InboundConnectedResources))
            {
                writer.WritePropertyName("inboundConnectedResources"u8);
                writer.WriteStartArray();
                foreach (var item in InboundConnectedResources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(OutboundConnectedResources))
            {
                writer.WritePropertyName("outboundConnectedResources"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundConnectedResources)
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

        ConnectableResourceInfo IJsonModel<ConnectableResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectableResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectableResourceInfo(document.RootElement, options);
        }

        internal static ConnectableResourceInfo DeserializeConnectableResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            IReadOnlyList<ConnectedResourceInfo> inboundConnectedResources = default;
            IReadOnlyList<ConnectedResourceInfo> outboundConnectedResources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inboundConnectedResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectedResourceInfo> array = new List<ConnectedResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectedResourceInfo.DeserializeConnectedResourceInfo(item, options));
                    }
                    inboundConnectedResources = array;
                    continue;
                }
                if (property.NameEquals("outboundConnectedResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectedResourceInfo> array = new List<ConnectedResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectedResourceInfo.DeserializeConnectedResourceInfo(item, options));
                    }
                    outboundConnectedResources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectableResourceInfo(id, inboundConnectedResources ?? new ChangeTrackingList<ConnectedResourceInfo>(), outboundConnectedResources ?? new ChangeTrackingList<ConnectedResourceInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectableResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectableResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectableResourceInfo IPersistableModel<ConnectableResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectableResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectableResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectableResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
