// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class DnsTlsaRecordInfo : IUtf8JsonSerializable, IJsonModel<DnsTlsaRecordInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DnsTlsaRecordInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DnsTlsaRecordInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsTlsaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DnsTlsaRecordInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteNumberValue(Usage.Value);
            }
            if (Optional.IsDefined(Selector))
            {
                writer.WritePropertyName("selector"u8);
                writer.WriteNumberValue(Selector.Value);
            }
            if (Optional.IsDefined(MatchingType))
            {
                writer.WritePropertyName("matchingType"u8);
                writer.WriteNumberValue(MatchingType.Value);
            }
            if (Optional.IsDefined(CertAssociationData))
            {
                writer.WritePropertyName("certAssociationData"u8);
                writer.WriteStringValue(CertAssociationData);
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

        DnsTlsaRecordInfo IJsonModel<DnsTlsaRecordInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsTlsaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DnsTlsaRecordInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDnsTlsaRecordInfo(document.RootElement, options);
        }

        internal static DnsTlsaRecordInfo DeserializeDnsTlsaRecordInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? usage = default;
            int? selector = default;
            int? matchingType = default;
            string certAssociationData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selector = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("matchingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchingType = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("certAssociationData"u8))
                {
                    certAssociationData = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DnsTlsaRecordInfo(usage, selector, matchingType, certAssociationData, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DnsTlsaRecordInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsTlsaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DnsTlsaRecordInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DnsTlsaRecordInfo IPersistableModel<DnsTlsaRecordInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsTlsaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDnsTlsaRecordInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DnsTlsaRecordInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DnsTlsaRecordInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
