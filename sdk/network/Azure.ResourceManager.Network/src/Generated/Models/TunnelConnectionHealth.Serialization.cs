// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TunnelConnectionHealth : IUtf8JsonSerializable, IJsonModel<TunnelConnectionHealth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TunnelConnectionHealth>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TunnelConnectionHealth>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TunnelConnectionHealth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TunnelConnectionHealth)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Tunnel))
            {
                writer.WritePropertyName("tunnel"u8);
                writer.WriteStringValue(Tunnel);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectionStatus))
            {
                writer.WritePropertyName("connectionStatus"u8);
                writer.WriteStringValue(ConnectionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IngressBytesTransferred))
            {
                writer.WritePropertyName("ingressBytesTransferred"u8);
                writer.WriteNumberValue(IngressBytesTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EgressBytesTransferred))
            {
                writer.WritePropertyName("egressBytesTransferred"u8);
                writer.WriteNumberValue(EgressBytesTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastConnectionEstablishedOn))
            {
                writer.WritePropertyName("lastConnectionEstablishedUtcTime"u8);
                writer.WriteStringValue(LastConnectionEstablishedOn);
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

        TunnelConnectionHealth IJsonModel<TunnelConnectionHealth>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TunnelConnectionHealth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TunnelConnectionHealth)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTunnelConnectionHealth(document.RootElement, options);
        }

        internal static TunnelConnectionHealth DeserializeTunnelConnectionHealth(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tunnel = default;
            VirtualNetworkGatewayConnectionStatus? connectionStatus = default;
            long? ingressBytesTransferred = default;
            long? egressBytesTransferred = default;
            string lastConnectionEstablishedUtcTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tunnel"u8))
                {
                    tunnel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStatus = new VirtualNetworkGatewayConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingressBytesTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("egressBytesTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastConnectionEstablishedUtcTime"u8))
                {
                    lastConnectionEstablishedUtcTime = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TunnelConnectionHealth(
                tunnel,
                connectionStatus,
                ingressBytesTransferred,
                egressBytesTransferred,
                lastConnectionEstablishedUtcTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TunnelConnectionHealth>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TunnelConnectionHealth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TunnelConnectionHealth)} does not support writing '{options.Format}' format.");
            }
        }

        TunnelConnectionHealth IPersistableModel<TunnelConnectionHealth>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TunnelConnectionHealth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTunnelConnectionHealth(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TunnelConnectionHealth)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TunnelConnectionHealth>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
