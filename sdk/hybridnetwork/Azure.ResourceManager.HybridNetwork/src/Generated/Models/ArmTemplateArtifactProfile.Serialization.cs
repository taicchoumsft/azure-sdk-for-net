// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ArmTemplateArtifactProfile : IUtf8JsonSerializable, IJsonModel<ArmTemplateArtifactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmTemplateArtifactProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArmTemplateArtifactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmTemplateArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmTemplateArtifactProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateName))
            {
                writer.WritePropertyName("templateName"u8);
                writer.WriteStringValue(TemplateName);
            }
            if (Optional.IsDefined(TemplateVersion))
            {
                writer.WritePropertyName("templateVersion"u8);
                writer.WriteStringValue(TemplateVersion);
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

        ArmTemplateArtifactProfile IJsonModel<ArmTemplateArtifactProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmTemplateArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmTemplateArtifactProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmTemplateArtifactProfile(document.RootElement, options);
        }

        internal static ArmTemplateArtifactProfile DeserializeArmTemplateArtifactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string templateName = default;
            string templateVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateName"u8))
                {
                    templateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("templateVersion"u8))
                {
                    templateVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArmTemplateArtifactProfile(templateName, templateVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmTemplateArtifactProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmTemplateArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmTemplateArtifactProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ArmTemplateArtifactProfile IPersistableModel<ArmTemplateArtifactProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmTemplateArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmTemplateArtifactProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmTemplateArtifactProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmTemplateArtifactProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
