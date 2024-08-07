// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class DesktopVirtualizationStartMenuItem : IUtf8JsonSerializable, IJsonModel<DesktopVirtualizationStartMenuItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DesktopVirtualizationStartMenuItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DesktopVirtualizationStartMenuItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DesktopVirtualizationStartMenuItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DesktopVirtualizationStartMenuItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AppAlias))
            {
                writer.WritePropertyName("appAlias"u8);
                writer.WriteStringValue(AppAlias);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath"u8);
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(CommandLineArguments))
            {
                writer.WritePropertyName("commandLineArguments"u8);
                writer.WriteStringValue(CommandLineArguments);
            }
            if (Optional.IsDefined(IconPath))
            {
                writer.WritePropertyName("iconPath"u8);
                writer.WriteStringValue(IconPath);
            }
            if (Optional.IsDefined(IconIndex))
            {
                writer.WritePropertyName("iconIndex"u8);
                writer.WriteNumberValue(IconIndex.Value);
            }
            writer.WriteEndObject();
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

        DesktopVirtualizationStartMenuItem IJsonModel<DesktopVirtualizationStartMenuItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DesktopVirtualizationStartMenuItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DesktopVirtualizationStartMenuItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDesktopVirtualizationStartMenuItem(document.RootElement, options);
        }

        internal static DesktopVirtualizationStartMenuItem DeserializeDesktopVirtualizationStartMenuItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string appAlias = default;
            string filePath = default;
            string commandLineArguments = default;
            string iconPath = default;
            int? iconIndex = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("appAlias"u8))
                        {
                            appAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("filePath"u8))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("commandLineArguments"u8))
                        {
                            commandLineArguments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconPath"u8))
                        {
                            iconPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconIndex"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iconIndex = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DesktopVirtualizationStartMenuItem(
                id,
                name,
                type,
                systemData,
                appAlias,
                filePath,
                commandLineArguments,
                iconPath,
                iconIndex,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DesktopVirtualizationStartMenuItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DesktopVirtualizationStartMenuItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DesktopVirtualizationStartMenuItem)} does not support writing '{options.Format}' format.");
            }
        }

        DesktopVirtualizationStartMenuItem IPersistableModel<DesktopVirtualizationStartMenuItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DesktopVirtualizationStartMenuItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDesktopVirtualizationStartMenuItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DesktopVirtualizationStartMenuItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DesktopVirtualizationStartMenuItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
