// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeAuthKeys : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeAuthKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeAuthKeys>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationRuntimeAuthKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeAuthKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeAuthKeys)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthKey1))
            {
                writer.WritePropertyName("authKey1"u8);
                writer.WriteStringValue(AuthKey1);
            }
            if (Optional.IsDefined(AuthKey2))
            {
                writer.WritePropertyName("authKey2"u8);
                writer.WriteStringValue(AuthKey2);
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

        IntegrationRuntimeAuthKeys IJsonModel<IntegrationRuntimeAuthKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeAuthKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeAuthKeys)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeAuthKeys(document.RootElement, options);
        }

        internal static IntegrationRuntimeAuthKeys DeserializeIntegrationRuntimeAuthKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authKey1 = default;
            string authKey2 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authKey1"u8))
                {
                    authKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authKey2"u8))
                {
                    authKey2 = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntegrationRuntimeAuthKeys(authKey1, authKey2, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationRuntimeAuthKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeAuthKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeAuthKeys)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationRuntimeAuthKeys IPersistableModel<IntegrationRuntimeAuthKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeAuthKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationRuntimeAuthKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeAuthKeys)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeAuthKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
