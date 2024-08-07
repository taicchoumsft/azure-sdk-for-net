// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class ArcPasswordCredential : IUtf8JsonSerializable, IJsonModel<ArcPasswordCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArcPasswordCredential>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArcPasswordCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcPasswordCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcPasswordCredential)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SecretText))
            {
                writer.WritePropertyName("secretText"u8);
                writer.WriteStringValue(SecretText);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
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

        ArcPasswordCredential IJsonModel<ArcPasswordCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcPasswordCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcPasswordCredential)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArcPasswordCredential(document.RootElement, options);
        }

        internal static ArcPasswordCredential DeserializeArcPasswordCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string secretText = default;
            string keyId = default;
            DateTimeOffset? startDateTime = default;
            DateTimeOffset? endDateTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretText"u8))
                {
                    secretText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyId"u8))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArcPasswordCredential(secretText, keyId, startDateTime, endDateTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArcPasswordCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcPasswordCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArcPasswordCredential)} does not support writing '{options.Format}' format.");
            }
        }

        ArcPasswordCredential IPersistableModel<ArcPasswordCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcPasswordCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArcPasswordCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArcPasswordCredential)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArcPasswordCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
