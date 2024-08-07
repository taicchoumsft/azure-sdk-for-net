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
    public partial class ExistingProtectionProfile : IUtf8JsonSerializable, IJsonModel<ExistingProtectionProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExistingProtectionProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExistingProtectionProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExistingProtectionProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExistingProtectionProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("protectionProfileId"u8);
            writer.WriteStringValue(ProtectionProfileId);
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        ExistingProtectionProfile IJsonModel<ExistingProtectionProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExistingProtectionProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExistingProtectionProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExistingProtectionProfile(document.RootElement, options);
        }

        internal static ExistingProtectionProfile DeserializeExistingProtectionProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string protectionProfileId = default;
            string resourceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionProfileId"u8))
                {
                    protectionProfileId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExistingProtectionProfile(resourceType, serializedAdditionalRawData, protectionProfileId);
        }

        BinaryData IPersistableModel<ExistingProtectionProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExistingProtectionProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExistingProtectionProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ExistingProtectionProfile IPersistableModel<ExistingProtectionProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExistingProtectionProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExistingProtectionProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExistingProtectionProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExistingProtectionProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
