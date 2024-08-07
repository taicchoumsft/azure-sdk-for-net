// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    public partial class ServerlessRuntimeDependency : IUtf8JsonSerializable, IJsonModel<ServerlessRuntimeDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerlessRuntimeDependency>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServerlessRuntimeDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessRuntimeDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessRuntimeDependency)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("appContextId"u8);
            writer.WriteStringValue(AppContextId);
            writer.WritePropertyName("path"u8);
            writer.WriteStringValue(Path);
            writer.WritePropertyName("documentType"u8);
            writer.WriteStringValue(DocumentType);
            writer.WritePropertyName("description"u8);
            writer.WriteStringValue(Description);
            writer.WritePropertyName("lastUpdatedTime"u8);
            writer.WriteStringValue(LastUpdatedTime);
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

        ServerlessRuntimeDependency IJsonModel<ServerlessRuntimeDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessRuntimeDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessRuntimeDependency)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerlessRuntimeDependency(document.RootElement, options);
        }

        internal static ServerlessRuntimeDependency DeserializeServerlessRuntimeDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string appContextId = default;
            string path = default;
            string documentType = default;
            string description = default;
            string lastUpdatedTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appContextId"u8))
                {
                    appContextId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentType"u8))
                {
                    documentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdatedTime"u8))
                {
                    lastUpdatedTime = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServerlessRuntimeDependency(
                id,
                appContextId,
                path,
                documentType,
                description,
                lastUpdatedTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerlessRuntimeDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessRuntimeDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerlessRuntimeDependency)} does not support writing '{options.Format}' format.");
            }
        }

        ServerlessRuntimeDependency IPersistableModel<ServerlessRuntimeDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessRuntimeDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerlessRuntimeDependency(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerlessRuntimeDependency)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerlessRuntimeDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
