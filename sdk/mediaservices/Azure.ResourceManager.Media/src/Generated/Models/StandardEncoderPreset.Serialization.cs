// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class StandardEncoderPreset : IUtf8JsonSerializable, IJsonModel<StandardEncoderPreset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StandardEncoderPreset>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StandardEncoderPreset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandardEncoderPreset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandardEncoderPreset)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExperimentalOptions))
            {
                writer.WritePropertyName("experimentalOptions"u8);
                writer.WriteStartObject();
                foreach (var item in ExperimentalOptions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteObjectValue(Filters, options);
            }
            writer.WritePropertyName("codecs"u8);
            writer.WriteStartArray();
            foreach (var item in Codecs)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("formats"u8);
            writer.WriteStartArray();
            foreach (var item in Formats)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        StandardEncoderPreset IJsonModel<StandardEncoderPreset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandardEncoderPreset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandardEncoderPreset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStandardEncoderPreset(document.RootElement, options);
        }

        internal static StandardEncoderPreset DeserializeStandardEncoderPreset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> experimentalOptions = default;
            FilteringOperations filters = default;
            IList<MediaCodecBase> codecs = default;
            IList<MediaFormatBase> formats = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("experimentalOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    experimentalOptions = dictionary;
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filters = FilteringOperations.DeserializeFilteringOperations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("codecs"u8))
                {
                    List<MediaCodecBase> array = new List<MediaCodecBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaCodecBase.DeserializeMediaCodecBase(item, options));
                    }
                    codecs = array;
                    continue;
                }
                if (property.NameEquals("formats"u8))
                {
                    List<MediaFormatBase> array = new List<MediaFormatBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaFormatBase.DeserializeMediaFormatBase(item, options));
                    }
                    formats = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StandardEncoderPreset(
                odataType,
                serializedAdditionalRawData,
                experimentalOptions ?? new ChangeTrackingDictionary<string, string>(),
                filters,
                codecs,
                formats);
        }

        BinaryData IPersistableModel<StandardEncoderPreset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandardEncoderPreset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StandardEncoderPreset)} does not support writing '{options.Format}' format.");
            }
        }

        StandardEncoderPreset IPersistableModel<StandardEncoderPreset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandardEncoderPreset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStandardEncoderPreset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StandardEncoderPreset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StandardEncoderPreset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
