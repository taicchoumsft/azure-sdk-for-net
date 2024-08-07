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
    internal partial class ExpressRouteGatewayPropertiesAutoScaleConfiguration : IUtf8JsonSerializable, IJsonModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteGatewayPropertiesAutoScaleConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Bounds))
            {
                writer.WritePropertyName("bounds"u8);
                writer.WriteObjectValue(Bounds, options);
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

        ExpressRouteGatewayPropertiesAutoScaleConfiguration IJsonModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteGatewayPropertiesAutoScaleConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteGatewayPropertiesAutoScaleConfiguration(document.RootElement, options);
        }

        internal static ExpressRouteGatewayPropertiesAutoScaleConfiguration DeserializeExpressRouteGatewayPropertiesAutoScaleConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds bounds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bounds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bounds = ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds.DeserializeExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExpressRouteGatewayPropertiesAutoScaleConfiguration(bounds, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteGatewayPropertiesAutoScaleConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteGatewayPropertiesAutoScaleConfiguration IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteGatewayPropertiesAutoScaleConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteGatewayPropertiesAutoScaleConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
