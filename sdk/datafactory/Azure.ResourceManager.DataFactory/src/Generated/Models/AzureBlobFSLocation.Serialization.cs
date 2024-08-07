// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureBlobFSLocation : IUtf8JsonSerializable, IJsonModel<AzureBlobFSLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureBlobFSLocation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureBlobFSLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobFSLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureBlobFSLocation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FileSystem))
            {
                writer.WritePropertyName("fileSystem"u8);
                JsonSerializer.Serialize(writer, FileSystem);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetLocationType);
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath"u8);
                JsonSerializer.Serialize(writer, FolderPath);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                JsonSerializer.Serialize(writer, FileName);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        AzureBlobFSLocation IJsonModel<AzureBlobFSLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobFSLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureBlobFSLocation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureBlobFSLocation(document.RootElement, options);
        }

        internal static AzureBlobFSLocation DeserializeAzureBlobFSLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> fileSystem = default;
            string type = default;
            DataFactoryElement<string> folderPath = default;
            DataFactoryElement<string> fileName = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileSystem"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileSystem = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("folderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureBlobFSLocation(type, folderPath, fileName, additionalProperties, fileSystem);
        }

        BinaryData IPersistableModel<AzureBlobFSLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobFSLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureBlobFSLocation)} does not support writing '{options.Format}' format.");
            }
        }

        AzureBlobFSLocation IPersistableModel<AzureBlobFSLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobFSLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureBlobFSLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureBlobFSLocation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureBlobFSLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
