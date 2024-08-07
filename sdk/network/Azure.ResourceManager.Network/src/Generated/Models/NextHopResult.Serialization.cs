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
    public partial class NextHopResult : IUtf8JsonSerializable, IJsonModel<NextHopResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NextHopResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NextHopResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NextHopResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NextHopResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextHopType))
            {
                writer.WritePropertyName("nextHopType"u8);
                writer.WriteStringValue(NextHopType.Value.ToString());
            }
            if (Optional.IsDefined(NextHopIPAddress))
            {
                writer.WritePropertyName("nextHopIpAddress"u8);
                writer.WriteStringValue(NextHopIPAddress);
            }
            if (Optional.IsDefined(RouteTableId))
            {
                writer.WritePropertyName("routeTableId"u8);
                writer.WriteStringValue(RouteTableId);
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

        NextHopResult IJsonModel<NextHopResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NextHopResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NextHopResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNextHopResult(document.RootElement, options);
        }

        internal static NextHopResult DeserializeNextHopResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NextHopType? nextHopType = default;
            string nextHopIPAddress = default;
            ResourceIdentifier routeTableId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextHopType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextHopType = new NextHopType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextHopIpAddress"u8))
                {
                    nextHopIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routeTableId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routeTableId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NextHopResult(nextHopType, nextHopIPAddress, routeTableId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NextHopResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NextHopResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NextHopResult)} does not support writing '{options.Format}' format.");
            }
        }

        NextHopResult IPersistableModel<NextHopResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NextHopResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNextHopResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NextHopResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NextHopResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
