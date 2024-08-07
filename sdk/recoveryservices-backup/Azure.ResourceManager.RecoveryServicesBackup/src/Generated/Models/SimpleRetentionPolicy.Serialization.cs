// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SimpleRetentionPolicy : IUtf8JsonSerializable, IJsonModel<SimpleRetentionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SimpleRetentionPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SimpleRetentionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimpleRetentionPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RetentionDuration))
            {
                writer.WritePropertyName("retentionDuration"u8);
                writer.WriteObjectValue(RetentionDuration, options);
            }
            writer.WritePropertyName("retentionPolicyType"u8);
            writer.WriteStringValue(RetentionPolicyType);
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

        SimpleRetentionPolicy IJsonModel<SimpleRetentionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimpleRetentionPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSimpleRetentionPolicy(document.RootElement, options);
        }

        internal static SimpleRetentionPolicy DeserializeSimpleRetentionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RetentionDuration retentionDuration = default;
            string retentionPolicyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionDuration = RetentionDuration.DeserializeRetentionDuration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retentionPolicyType"u8))
                {
                    retentionPolicyType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SimpleRetentionPolicy(retentionPolicyType, serializedAdditionalRawData, retentionDuration);
        }

        BinaryData IPersistableModel<SimpleRetentionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SimpleRetentionPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        SimpleRetentionPolicy IPersistableModel<SimpleRetentionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSimpleRetentionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SimpleRetentionPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SimpleRetentionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
