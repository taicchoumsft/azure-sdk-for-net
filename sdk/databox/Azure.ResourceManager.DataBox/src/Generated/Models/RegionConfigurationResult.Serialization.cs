// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class RegionConfigurationResult : IUtf8JsonSerializable, IJsonModel<RegionConfigurationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegionConfigurationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RegionConfigurationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionConfigurationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegionConfigurationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ScheduleAvailabilityResponse))
            {
                writer.WritePropertyName("scheduleAvailabilityResponse"u8);
                writer.WriteObjectValue(ScheduleAvailabilityResponse, options);
            }
            if (options.Format != "W" && Optional.IsDefined(TransportAvailabilityResponse))
            {
                writer.WritePropertyName("transportAvailabilityResponse"u8);
                writer.WriteObjectValue(TransportAvailabilityResponse, options);
            }
            if (options.Format != "W" && Optional.IsDefined(DataCenterAddressResponse))
            {
                writer.WritePropertyName("datacenterAddressResponse"u8);
                writer.WriteObjectValue(DataCenterAddressResponse, options);
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

        RegionConfigurationResult IJsonModel<RegionConfigurationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionConfigurationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegionConfigurationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegionConfigurationResult(document.RootElement, options);
        }

        internal static RegionConfigurationResult DeserializeRegionConfigurationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScheduleAvailabilityResponse scheduleAvailabilityResponse = default;
            TransportAvailabilityResponse transportAvailabilityResponse = default;
            DataCenterAddressResult dataCenterAddressResponse = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleAvailabilityResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleAvailabilityResponse = ScheduleAvailabilityResponse.DeserializeScheduleAvailabilityResponse(property.Value, options);
                    continue;
                }
                if (property.NameEquals("transportAvailabilityResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportAvailabilityResponse = TransportAvailabilityResponse.DeserializeTransportAvailabilityResponse(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datacenterAddressResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddressResponse = DataCenterAddressResult.DeserializeDataCenterAddressResult(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RegionConfigurationResult(scheduleAvailabilityResponse, transportAvailabilityResponse, dataCenterAddressResponse, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RegionConfigurationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionConfigurationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegionConfigurationResult)} does not support writing '{options.Format}' format.");
            }
        }

        RegionConfigurationResult IPersistableModel<RegionConfigurationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionConfigurationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegionConfigurationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegionConfigurationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegionConfigurationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
