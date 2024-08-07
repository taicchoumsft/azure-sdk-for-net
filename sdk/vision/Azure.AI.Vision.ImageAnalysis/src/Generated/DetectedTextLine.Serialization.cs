// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    public partial class DetectedTextLine : IUtf8JsonSerializable, IJsonModel<DetectedTextLine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DetectedTextLine>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DetectedTextLine>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectedTextLine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DetectedTextLine)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("boundingPolygon"u8);
            writer.WriteStartArray();
            foreach (var item in BoundingPolygon)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("words"u8);
            writer.WriteStartArray();
            foreach (var item in Words)
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

        DetectedTextLine IJsonModel<DetectedTextLine>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectedTextLine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DetectedTextLine)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectedTextLine(document.RootElement, options);
        }

        internal static DetectedTextLine DeserializeDetectedTextLine(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            IReadOnlyList<ImagePoint> boundingPolygon = default;
            IReadOnlyList<DetectedTextWord> words = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingPolygon"u8))
                {
                    List<ImagePoint> array = new List<ImagePoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImagePoint.DeserializeImagePoint(item, options));
                    }
                    boundingPolygon = array;
                    continue;
                }
                if (property.NameEquals("words"u8))
                {
                    List<DetectedTextWord> array = new List<DetectedTextWord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DetectedTextWord.DeserializeDetectedTextWord(item, options));
                    }
                    words = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DetectedTextLine(text, boundingPolygon, words, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DetectedTextLine>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectedTextLine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DetectedTextLine)} does not support writing '{options.Format}' format.");
            }
        }

        DetectedTextLine IPersistableModel<DetectedTextLine>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectedTextLine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDetectedTextLine(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DetectedTextLine)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DetectedTextLine>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DetectedTextLine FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDetectedTextLine(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
