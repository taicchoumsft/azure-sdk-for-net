// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalContactEndpoint : IUtf8JsonSerializable, IJsonModel<OrbitalContactEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrbitalContactEndpoint>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OrbitalContactEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalContactEndpoint)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ipAddress"u8);
            writer.WriteStringValue(IPAddress.ToString());
            writer.WritePropertyName("endPointName"u8);
            writer.WriteStringValue(EndPointName);
            writer.WritePropertyName("port"u8);
            writer.WriteStringValue(Port);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
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

        OrbitalContactEndpoint IJsonModel<OrbitalContactEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalContactEndpoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrbitalContactEndpoint(document.RootElement, options);
        }

        internal static OrbitalContactEndpoint DeserializeOrbitalContactEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress ipAddress = default;
            string endPointName = default;
            string port = default;
            OrbitalContactProtocol protocol = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endPointName"u8))
                {
                    endPointName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new OrbitalContactProtocol(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OrbitalContactEndpoint(ipAddress, endPointName, port, protocol, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OrbitalContactEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OrbitalContactEndpoint)} does not support writing '{options.Format}' format.");
            }
        }

        OrbitalContactEndpoint IPersistableModel<OrbitalContactEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOrbitalContactEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OrbitalContactEndpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OrbitalContactEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
