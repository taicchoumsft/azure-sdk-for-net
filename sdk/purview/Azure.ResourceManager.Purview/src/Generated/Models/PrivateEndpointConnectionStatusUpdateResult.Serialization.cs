// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PrivateEndpointConnectionStatusUpdateResult : IUtf8JsonSerializable, IJsonModel<PrivateEndpointConnectionStatusUpdateResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateEndpointConnectionStatusUpdateResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateEndpointConnectionStatusUpdateResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointConnectionStatusUpdateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointConnectionStatusUpdateResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpointId))
            {
                writer.WritePropertyName("privateEndpointId"u8);
                writer.WriteStringValue(PrivateEndpointId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        PrivateEndpointConnectionStatusUpdateResult IJsonModel<PrivateEndpointConnectionStatusUpdateResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointConnectionStatusUpdateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointConnectionStatusUpdateResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpointConnectionStatusUpdateResult(document.RootElement, options);
        }

        internal static PrivateEndpointConnectionStatusUpdateResult DeserializePrivateEndpointConnectionStatusUpdateResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string privateEndpointId = default;
            string status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpointId"u8))
                {
                    privateEndpointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateEndpointConnectionStatusUpdateResult(privateEndpointId, status, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateEndpointConnectionStatusUpdateResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointConnectionStatusUpdateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointConnectionStatusUpdateResult)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateEndpointConnectionStatusUpdateResult IPersistableModel<PrivateEndpointConnectionStatusUpdateResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointConnectionStatusUpdateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateEndpointConnectionStatusUpdateResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointConnectionStatusUpdateResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateEndpointConnectionStatusUpdateResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
