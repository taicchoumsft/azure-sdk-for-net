// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class AssetEvent : IUtf8JsonSerializable, IJsonModel<AssetEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssetEvent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AssetEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetEvent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ObservabilityMode))
            {
                writer.WritePropertyName("observabilityMode"u8);
                writer.WriteStringValue(ObservabilityMode.Value.ToString());
            }
        }

        AssetEvent IJsonModel<AssetEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetEvent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssetEvent(document.RootElement, options);
        }

        internal static AssetEvent DeserializeAssetEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EventObservabilityMode? observabilityMode = default;
            string name = default;
            string eventNotifier = default;
            string eventConfiguration = default;
            Topic topic = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("observabilityMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    observabilityMode = new EventObservabilityMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventNotifier"u8))
                {
                    eventNotifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventConfiguration"u8))
                {
                    eventConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topic = Topic.DeserializeTopic(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssetEvent(
                name,
                eventNotifier,
                eventConfiguration,
                topic,
                serializedAdditionalRawData,
                observabilityMode);
        }

        BinaryData IPersistableModel<AssetEvent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssetEvent)} does not support writing '{options.Format}' format.");
            }
        }

        AssetEvent IPersistableModel<AssetEvent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssetEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssetEvent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssetEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
