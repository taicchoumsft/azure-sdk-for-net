// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class NSDArtifactProfile : IUtf8JsonSerializable, IJsonModel<NSDArtifactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NSDArtifactProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NSDArtifactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NSDArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NSDArtifactProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactStoreReference))
            {
                writer.WritePropertyName("artifactStoreReference"u8);
                JsonSerializer.Serialize(writer, ArtifactStoreReference);
            }
            if (Optional.IsDefined(ArtifactName))
            {
                writer.WritePropertyName("artifactName"u8);
                writer.WriteStringValue(ArtifactName);
            }
            if (Optional.IsDefined(ArtifactVersion))
            {
                writer.WritePropertyName("artifactVersion"u8);
                writer.WriteStringValue(ArtifactVersion);
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

        NSDArtifactProfile IJsonModel<NSDArtifactProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NSDArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NSDArtifactProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNSDArtifactProfile(document.RootElement, options);
        }

        internal static NSDArtifactProfile DeserializeNSDArtifactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource artifactStoreReference = default;
            string artifactName = default;
            string artifactVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactStoreReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactStoreReference = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("artifactName"u8))
                {
                    artifactName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactVersion"u8))
                {
                    artifactVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NSDArtifactProfile(artifactStoreReference, artifactName, artifactVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NSDArtifactProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NSDArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NSDArtifactProfile)} does not support writing '{options.Format}' format.");
            }
        }

        NSDArtifactProfile IPersistableModel<NSDArtifactProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NSDArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNSDArtifactProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NSDArtifactProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NSDArtifactProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
