// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    internal partial class AppliancePropertiesInfrastructureConfig : IUtf8JsonSerializable, IJsonModel<AppliancePropertiesInfrastructureConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppliancePropertiesInfrastructureConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppliancePropertiesInfrastructureConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppliancePropertiesInfrastructureConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppliancePropertiesInfrastructureConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider.Value.ToString());
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

        AppliancePropertiesInfrastructureConfig IJsonModel<AppliancePropertiesInfrastructureConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppliancePropertiesInfrastructureConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppliancePropertiesInfrastructureConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppliancePropertiesInfrastructureConfig(document.RootElement, options);
        }

        internal static AppliancePropertiesInfrastructureConfig DeserializeAppliancePropertiesInfrastructureConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApplianceProvider? provider = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provider = new ApplianceProvider(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppliancePropertiesInfrastructureConfig(provider, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppliancePropertiesInfrastructureConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppliancePropertiesInfrastructureConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppliancePropertiesInfrastructureConfig)} does not support writing '{options.Format}' format.");
            }
        }

        AppliancePropertiesInfrastructureConfig IPersistableModel<AppliancePropertiesInfrastructureConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppliancePropertiesInfrastructureConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppliancePropertiesInfrastructureConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppliancePropertiesInfrastructureConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppliancePropertiesInfrastructureConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
