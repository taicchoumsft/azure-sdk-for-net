// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    public partial class DomainVerificationStatusRecord : IUtf8JsonSerializable, IJsonModel<DomainVerificationStatusRecord>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DomainVerificationStatusRecord>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DomainVerificationStatusRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainVerificationStatusRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainVerificationStatusRecord)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
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

        DomainVerificationStatusRecord IJsonModel<DomainVerificationStatusRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainVerificationStatusRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainVerificationStatusRecord)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainVerificationStatusRecord(document.RootElement, options);
        }

        internal static DomainVerificationStatusRecord DeserializeDomainVerificationStatusRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DomainRecordVerificationStatus? status = default;
            string errorCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DomainRecordVerificationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DomainVerificationStatusRecord(status, errorCode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DomainVerificationStatusRecord>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainVerificationStatusRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DomainVerificationStatusRecord)} does not support writing '{options.Format}' format.");
            }
        }

        DomainVerificationStatusRecord IPersistableModel<DomainVerificationStatusRecord>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainVerificationStatusRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDomainVerificationStatusRecord(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DomainVerificationStatusRecord)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DomainVerificationStatusRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
