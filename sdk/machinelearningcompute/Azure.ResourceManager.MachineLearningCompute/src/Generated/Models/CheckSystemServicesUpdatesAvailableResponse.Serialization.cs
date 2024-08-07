// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class CheckSystemServicesUpdatesAvailableResponse : IUtf8JsonSerializable, IJsonModel<CheckSystemServicesUpdatesAvailableResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CheckSystemServicesUpdatesAvailableResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CheckSystemServicesUpdatesAvailableResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckSystemServicesUpdatesAvailableResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckSystemServicesUpdatesAvailableResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(UpdatesAvailable))
            {
                writer.WritePropertyName("updatesAvailable"u8);
                writer.WriteStringValue(UpdatesAvailable.Value.ToString());
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

        CheckSystemServicesUpdatesAvailableResponse IJsonModel<CheckSystemServicesUpdatesAvailableResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckSystemServicesUpdatesAvailableResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckSystemServicesUpdatesAvailableResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckSystemServicesUpdatesAvailableResponse(document.RootElement, options);
        }

        internal static CheckSystemServicesUpdatesAvailableResponse DeserializeCheckSystemServicesUpdatesAvailableResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpdatesAvailable? updatesAvailable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("updatesAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatesAvailable = new UpdatesAvailable(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CheckSystemServicesUpdatesAvailableResponse(updatesAvailable, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CheckSystemServicesUpdatesAvailableResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckSystemServicesUpdatesAvailableResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CheckSystemServicesUpdatesAvailableResponse)} does not support writing '{options.Format}' format.");
            }
        }

        CheckSystemServicesUpdatesAvailableResponse IPersistableModel<CheckSystemServicesUpdatesAvailableResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckSystemServicesUpdatesAvailableResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCheckSystemServicesUpdatesAvailableResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CheckSystemServicesUpdatesAvailableResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CheckSystemServicesUpdatesAvailableResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
