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
    public partial class TransferConfiguration : IUtf8JsonSerializable, IJsonModel<TransferConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransferConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TransferConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("transferConfigurationType"u8);
            writer.WriteStringValue(TransferConfigurationType.ToSerialString());
            if (Optional.IsDefined(TransferFilterDetails))
            {
                writer.WritePropertyName("transferFilterDetails"u8);
                writer.WriteObjectValue(TransferFilterDetails, options);
            }
            if (Optional.IsDefined(TransferAllDetails))
            {
                writer.WritePropertyName("transferAllDetails"u8);
                writer.WriteObjectValue(TransferAllDetails, options);
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

        TransferConfiguration IJsonModel<TransferConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferConfiguration(document.RootElement, options);
        }

        internal static TransferConfiguration DeserializeTransferConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TransferConfigurationType transferConfigurationType = default;
            TransferConfigurationTransferFilterDetails transferFilterDetails = default;
            TransferConfigurationTransferAllDetails transferAllDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transferConfigurationType"u8))
                {
                    transferConfigurationType = property.Value.GetString().ToTransferConfigurationType();
                    continue;
                }
                if (property.NameEquals("transferFilterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferFilterDetails = TransferConfigurationTransferFilterDetails.DeserializeTransferConfigurationTransferFilterDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("transferAllDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferAllDetails = TransferConfigurationTransferAllDetails.DeserializeTransferConfigurationTransferAllDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TransferConfiguration(transferConfigurationType, transferFilterDetails, transferAllDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TransferConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TransferConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        TransferConfiguration IPersistableModel<TransferConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransferConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TransferConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransferConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
