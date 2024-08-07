// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Vision.Face
{
    public partial class FaceAttributes : IUtf8JsonSerializable, IJsonModel<FaceAttributes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FaceAttributes>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FaceAttributes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FaceAttributes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FaceAttributes)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Age))
            {
                writer.WritePropertyName("age"u8);
                writer.WriteNumberValue(Age.Value);
            }
            if (Optional.IsDefined(Smile))
            {
                writer.WritePropertyName("smile"u8);
                writer.WriteNumberValue(Smile.Value);
            }
            if (Optional.IsDefined(FacialHair))
            {
                writer.WritePropertyName("facialHair"u8);
                writer.WriteObjectValue(FacialHair, options);
            }
            if (Optional.IsDefined(Glasses))
            {
                writer.WritePropertyName("glasses"u8);
                writer.WriteStringValue(Glasses.Value.ToString());
            }
            if (Optional.IsDefined(HeadPose))
            {
                writer.WritePropertyName("headPose"u8);
                writer.WriteObjectValue(HeadPose, options);
            }
            if (Optional.IsDefined(Hair))
            {
                writer.WritePropertyName("hair"u8);
                writer.WriteObjectValue(Hair, options);
            }
            if (Optional.IsDefined(Occlusion))
            {
                writer.WritePropertyName("occlusion"u8);
                writer.WriteObjectValue(Occlusion, options);
            }
            if (Optional.IsCollectionDefined(Accessories))
            {
                writer.WritePropertyName("accessories"u8);
                writer.WriteStartArray();
                foreach (var item in Accessories)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Blur))
            {
                writer.WritePropertyName("blur"u8);
                writer.WriteObjectValue(Blur, options);
            }
            if (Optional.IsDefined(Exposure))
            {
                writer.WritePropertyName("exposure"u8);
                writer.WriteObjectValue(Exposure, options);
            }
            if (Optional.IsDefined(Noise))
            {
                writer.WritePropertyName("noise"u8);
                writer.WriteObjectValue(Noise, options);
            }
            if (Optional.IsDefined(Mask))
            {
                writer.WritePropertyName("mask"u8);
                writer.WriteObjectValue(Mask, options);
            }
            if (Optional.IsDefined(QualityForRecognition))
            {
                writer.WritePropertyName("qualityForRecognition"u8);
                writer.WriteStringValue(QualityForRecognition.Value.ToString());
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

        FaceAttributes IJsonModel<FaceAttributes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FaceAttributes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FaceAttributes)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFaceAttributes(document.RootElement, options);
        }

        internal static FaceAttributes DeserializeFaceAttributes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? age = default;
            float? smile = default;
            FacialHair facialHair = default;
            GlassesType? glasses = default;
            HeadPose headPose = default;
            HairProperties hair = default;
            OcclusionProperties occlusion = default;
            IReadOnlyList<AccessoryItem> accessories = default;
            BlurProperties blur = default;
            ExposureProperties exposure = default;
            NoiseProperties noise = default;
            MaskProperties mask = default;
            QualityForRecognition? qualityForRecognition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("age"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    age = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("smile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smile = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("facialHair"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    facialHair = FacialHair.DeserializeFacialHair(property.Value, options);
                    continue;
                }
                if (property.NameEquals("glasses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    glasses = new GlassesType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("headPose"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    headPose = HeadPose.DeserializeHeadPose(property.Value, options);
                    continue;
                }
                if (property.NameEquals("hair"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hair = HairProperties.DeserializeHairProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("occlusion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    occlusion = OcclusionProperties.DeserializeOcclusionProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("accessories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AccessoryItem> array = new List<AccessoryItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessoryItem.DeserializeAccessoryItem(item, options));
                    }
                    accessories = array;
                    continue;
                }
                if (property.NameEquals("blur"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blur = BlurProperties.DeserializeBlurProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("exposure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exposure = ExposureProperties.DeserializeExposureProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("noise"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noise = NoiseProperties.DeserializeNoiseProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mask = MaskProperties.DeserializeMaskProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("qualityForRecognition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    qualityForRecognition = new QualityForRecognition(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FaceAttributes(
                age,
                smile,
                facialHair,
                glasses,
                headPose,
                hair,
                occlusion,
                accessories ?? new ChangeTrackingList<AccessoryItem>(),
                blur,
                exposure,
                noise,
                mask,
                qualityForRecognition,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FaceAttributes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FaceAttributes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FaceAttributes)} does not support writing '{options.Format}' format.");
            }
        }

        FaceAttributes IPersistableModel<FaceAttributes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FaceAttributes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFaceAttributes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FaceAttributes)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FaceAttributes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FaceAttributes FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFaceAttributes(document.RootElement);
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
