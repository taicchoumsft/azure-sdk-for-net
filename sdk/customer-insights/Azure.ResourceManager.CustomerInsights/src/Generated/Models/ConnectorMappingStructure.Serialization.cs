// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ConnectorMappingStructure : IUtf8JsonSerializable, IJsonModel<ConnectorMappingStructure>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectorMappingStructure>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectorMappingStructure>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingStructure>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorMappingStructure)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("propertyName"u8);
            writer.WriteStringValue(PropertyName);
            writer.WritePropertyName("columnName"u8);
            writer.WriteStringValue(ColumnName);
            if (Optional.IsDefined(CustomFormatSpecifier))
            {
                writer.WritePropertyName("customFormatSpecifier"u8);
                writer.WriteStringValue(CustomFormatSpecifier);
            }
            if (Optional.IsDefined(IsEncrypted))
            {
                writer.WritePropertyName("isEncrypted"u8);
                writer.WriteBooleanValue(IsEncrypted.Value);
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

        ConnectorMappingStructure IJsonModel<ConnectorMappingStructure>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingStructure>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorMappingStructure)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectorMappingStructure(document.RootElement, options);
        }

        internal static ConnectorMappingStructure DeserializeConnectorMappingStructure(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string propertyName = default;
            string columnName = default;
            string customFormatSpecifier = default;
            bool? isEncrypted = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propertyName"u8))
                {
                    propertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("columnName"u8))
                {
                    columnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customFormatSpecifier"u8))
                {
                    customFormatSpecifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectorMappingStructure(propertyName, columnName, customFormatSpecifier, isEncrypted, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectorMappingStructure>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingStructure>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectorMappingStructure)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectorMappingStructure IPersistableModel<ConnectorMappingStructure>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingStructure>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectorMappingStructure(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectorMappingStructure)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectorMappingStructure>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
