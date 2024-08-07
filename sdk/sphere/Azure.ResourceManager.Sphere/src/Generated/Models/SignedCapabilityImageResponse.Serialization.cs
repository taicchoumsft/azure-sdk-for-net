// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    public partial class SignedCapabilityImageResponse : IUtf8JsonSerializable, IJsonModel<SignedCapabilityImageResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignedCapabilityImageResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SignedCapabilityImageResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignedCapabilityImageResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignedCapabilityImageResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
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

        SignedCapabilityImageResponse IJsonModel<SignedCapabilityImageResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignedCapabilityImageResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignedCapabilityImageResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignedCapabilityImageResponse(document.RootElement, options);
        }

        internal static SignedCapabilityImageResponse DeserializeSignedCapabilityImageResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string image = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("image"u8))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SignedCapabilityImageResponse(image, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SignedCapabilityImageResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignedCapabilityImageResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SignedCapabilityImageResponse)} does not support writing '{options.Format}' format.");
            }
        }

        SignedCapabilityImageResponse IPersistableModel<SignedCapabilityImageResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignedCapabilityImageResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSignedCapabilityImageResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SignedCapabilityImageResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignedCapabilityImageResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
