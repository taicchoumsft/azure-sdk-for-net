// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12AgreementContent : IUtf8JsonSerializable, IJsonModel<X12AgreementContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12AgreementContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<X12AgreementContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12AgreementContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12AgreementContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("receiveAgreement"u8);
            writer.WriteObjectValue(ReceiveAgreement, options);
            writer.WritePropertyName("sendAgreement"u8);
            writer.WriteObjectValue(SendAgreement, options);
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

        X12AgreementContent IJsonModel<X12AgreementContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12AgreementContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12AgreementContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12AgreementContent(document.RootElement, options);
        }

        internal static X12AgreementContent DeserializeX12AgreementContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            X12OneWayAgreement receiveAgreement = default;
            X12OneWayAgreement sendAgreement = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("receiveAgreement"u8))
                {
                    receiveAgreement = X12OneWayAgreement.DeserializeX12OneWayAgreement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sendAgreement"u8))
                {
                    sendAgreement = X12OneWayAgreement.DeserializeX12OneWayAgreement(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new X12AgreementContent(receiveAgreement, sendAgreement, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<X12AgreementContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12AgreementContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(X12AgreementContent)} does not support writing '{options.Format}' format.");
            }
        }

        X12AgreementContent IPersistableModel<X12AgreementContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12AgreementContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeX12AgreementContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(X12AgreementContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<X12AgreementContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
