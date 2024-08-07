// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxShipmentPickUpResult : IUtf8JsonSerializable, IJsonModel<DataBoxShipmentPickUpResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxShipmentPickUpResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxShipmentPickUpResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxShipmentPickUpResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxShipmentPickUpResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ConfirmationNumber))
            {
                writer.WritePropertyName("confirmationNumber"u8);
                writer.WriteStringValue(ConfirmationNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(ReadyBy))
            {
                writer.WritePropertyName("readyByTime"u8);
                writer.WriteStringValue(ReadyBy.Value, "O");
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

        DataBoxShipmentPickUpResult IJsonModel<DataBoxShipmentPickUpResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxShipmentPickUpResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxShipmentPickUpResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxShipmentPickUpResult(document.RootElement, options);
        }

        internal static DataBoxShipmentPickUpResult DeserializeDataBoxShipmentPickUpResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string confirmationNumber = default;
            DateTimeOffset? readyByTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confirmationNumber"u8))
                {
                    confirmationNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readyByTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readyByTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxShipmentPickUpResult(confirmationNumber, readyByTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxShipmentPickUpResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxShipmentPickUpResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxShipmentPickUpResult)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxShipmentPickUpResult IPersistableModel<DataBoxShipmentPickUpResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxShipmentPickUpResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxShipmentPickUpResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxShipmentPickUpResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxShipmentPickUpResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
