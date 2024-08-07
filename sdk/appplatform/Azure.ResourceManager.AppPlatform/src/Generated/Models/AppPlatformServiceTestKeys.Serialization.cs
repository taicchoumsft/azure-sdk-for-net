// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformServiceTestKeys : IUtf8JsonSerializable, IJsonModel<AppPlatformServiceTestKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformServiceTestKeys>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformServiceTestKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceTestKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceTestKeys)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            if (Optional.IsDefined(PrimaryTestEndpoint))
            {
                writer.WritePropertyName("primaryTestEndpoint"u8);
                writer.WriteStringValue(PrimaryTestEndpoint);
            }
            if (Optional.IsDefined(SecondaryTestEndpoint))
            {
                writer.WritePropertyName("secondaryTestEndpoint"u8);
                writer.WriteStringValue(SecondaryTestEndpoint);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
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

        AppPlatformServiceTestKeys IJsonModel<AppPlatformServiceTestKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceTestKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceTestKeys)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformServiceTestKeys(document.RootElement, options);
        }

        internal static AppPlatformServiceTestKeys DeserializeAppPlatformServiceTestKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryKey = default;
            string secondaryKey = default;
            string primaryTestEndpoint = default;
            string secondaryTestEndpoint = default;
            bool? enabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryTestEndpoint"u8))
                {
                    primaryTestEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryTestEndpoint"u8))
                {
                    secondaryTestEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformServiceTestKeys(
                primaryKey,
                secondaryKey,
                primaryTestEndpoint,
                secondaryTestEndpoint,
                enabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformServiceTestKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceTestKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformServiceTestKeys)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformServiceTestKeys IPersistableModel<AppPlatformServiceTestKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceTestKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformServiceTestKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformServiceTestKeys)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformServiceTestKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
