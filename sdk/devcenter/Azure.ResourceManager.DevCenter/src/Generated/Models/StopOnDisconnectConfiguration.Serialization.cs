// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class StopOnDisconnectConfiguration : IUtf8JsonSerializable, IJsonModel<StopOnDisconnectConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StopOnDisconnectConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StopOnDisconnectConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopOnDisconnectConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StopOnDisconnectConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(GracePeriodMinutes))
            {
                writer.WritePropertyName("gracePeriodMinutes"u8);
                writer.WriteNumberValue(GracePeriodMinutes.Value);
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

        StopOnDisconnectConfiguration IJsonModel<StopOnDisconnectConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopOnDisconnectConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StopOnDisconnectConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStopOnDisconnectConfiguration(document.RootElement, options);
        }

        internal static StopOnDisconnectConfiguration DeserializeStopOnDisconnectConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StopOnDisconnectEnableStatus? status = default;
            int? gracePeriodMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new StopOnDisconnectEnableStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("gracePeriodMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gracePeriodMinutes = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StopOnDisconnectConfiguration(status, gracePeriodMinutes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StopOnDisconnectConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopOnDisconnectConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StopOnDisconnectConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        StopOnDisconnectConfiguration IPersistableModel<StopOnDisconnectConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopOnDisconnectConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStopOnDisconnectConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StopOnDisconnectConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StopOnDisconnectConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
