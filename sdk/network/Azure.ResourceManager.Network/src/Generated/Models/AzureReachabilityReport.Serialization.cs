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
    public partial class AzureReachabilityReport : IUtf8JsonSerializable, IJsonModel<AzureReachabilityReport>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureReachabilityReport>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureReachabilityReport>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReport>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureReachabilityReport)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("aggregationLevel"u8);
            writer.WriteStringValue(AggregationLevel);
            writer.WritePropertyName("providerLocation"u8);
            writer.WriteObjectValue(ProviderLocation, options);
            writer.WritePropertyName("reachabilityReport"u8);
            writer.WriteStartArray();
            foreach (var item in ReachabilityReport)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        AzureReachabilityReport IJsonModel<AzureReachabilityReport>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReport>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureReachabilityReport)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureReachabilityReport(document.RootElement, options);
        }

        internal static AzureReachabilityReport DeserializeAzureReachabilityReport(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string aggregationLevel = default;
            AzureReachabilityReportLocation providerLocation = default;
            IReadOnlyList<AzureReachabilityReportItem> reachabilityReport = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregationLevel"u8))
                {
                    aggregationLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerLocation"u8))
                {
                    providerLocation = AzureReachabilityReportLocation.DeserializeAzureReachabilityReportLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reachabilityReport"u8))
                {
                    List<AzureReachabilityReportItem> array = new List<AzureReachabilityReportItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureReachabilityReportItem.DeserializeAzureReachabilityReportItem(item, options));
                    }
                    reachabilityReport = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureReachabilityReport(aggregationLevel, providerLocation, reachabilityReport, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureReachabilityReport>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReport>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureReachabilityReport)} does not support writing '{options.Format}' format.");
            }
        }

        AzureReachabilityReport IPersistableModel<AzureReachabilityReport>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReport>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureReachabilityReport(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureReachabilityReport)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureReachabilityReport>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
