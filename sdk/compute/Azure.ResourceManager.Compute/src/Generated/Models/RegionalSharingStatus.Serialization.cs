// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RegionalSharingStatus : IUtf8JsonSerializable, IJsonModel<RegionalSharingStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegionalSharingStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RegionalSharingStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionalSharingStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegionalSharingStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStringValue(Details);
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

        RegionalSharingStatus IJsonModel<RegionalSharingStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionalSharingStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegionalSharingStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegionalSharingStatus(document.RootElement, options);
        }

        internal static RegionalSharingStatus DeserializeRegionalSharingStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string region = default;
            SharingState? state = default;
            string details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SharingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RegionalSharingStatus(region, state, details, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RegionalSharingStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionalSharingStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegionalSharingStatus)} does not support writing '{options.Format}' format.");
            }
        }

        RegionalSharingStatus IPersistableModel<RegionalSharingStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionalSharingStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegionalSharingStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegionalSharingStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegionalSharingStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
