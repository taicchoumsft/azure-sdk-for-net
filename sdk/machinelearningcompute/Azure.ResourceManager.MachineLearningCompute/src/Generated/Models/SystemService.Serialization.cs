// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class SystemService : IUtf8JsonSerializable, IJsonModel<SystemService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SystemService>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SystemService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SystemService)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("systemServiceType"u8);
            writer.WriteStringValue(SystemServiceType.ToString());
            if (options.Format != "W" && Optional.IsDefined(PublicIPAddress))
            {
                writer.WritePropertyName("publicIpAddress"u8);
                writer.WriteStringValue(PublicIPAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        SystemService IJsonModel<SystemService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SystemService)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSystemService(document.RootElement, options);
        }

        internal static SystemService DeserializeSystemService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SystemServiceType systemServiceType = default;
            string publicIPAddress = default;
            string version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemServiceType"u8))
                {
                    systemServiceType = new SystemServiceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIpAddress"u8))
                {
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SystemService(systemServiceType, publicIPAddress, version, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SystemService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SystemService)} does not support writing '{options.Format}' format.");
            }
        }

        SystemService IPersistableModel<SystemService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSystemService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SystemService)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SystemService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
