// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class PlannedFailoverProperties : IUtf8JsonSerializable, IJsonModel<PlannedFailoverProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlannedFailoverProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PlannedFailoverProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlannedFailoverProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FailoverDirection))
            {
                writer.WritePropertyName("failoverDirection"u8);
                writer.WriteStringValue(FailoverDirection);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails, options);
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

        PlannedFailoverProperties IJsonModel<PlannedFailoverProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlannedFailoverProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlannedFailoverProperties(document.RootElement, options);
        }

        internal static PlannedFailoverProperties DeserializePlannedFailoverProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string failoverDirection = default;
            PlannedFailoverProviderSpecificFailoverContent providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverDirection"u8))
                {
                    failoverDirection = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = PlannedFailoverProviderSpecificFailoverContent.DeserializePlannedFailoverProviderSpecificFailoverContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PlannedFailoverProperties(failoverDirection, providerSpecificDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PlannedFailoverProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PlannedFailoverProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PlannedFailoverProperties IPersistableModel<PlannedFailoverProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePlannedFailoverProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlannedFailoverProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlannedFailoverProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
