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
    public partial class LastMitigationActionOnJob : IUtf8JsonSerializable, IJsonModel<LastMitigationActionOnJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LastMitigationActionOnJob>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LastMitigationActionOnJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LastMitigationActionOnJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LastMitigationActionOnJob)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionPerformedOn))
            {
                writer.WritePropertyName("actionDateTimeInUtc"u8);
                writer.WriteStringValue(ActionPerformedOn.Value, "O");
            }
            if (Optional.IsDefined(IsPerformedByCustomer))
            {
                writer.WritePropertyName("isPerformedByCustomer"u8);
                writer.WriteBooleanValue(IsPerformedByCustomer.Value);
            }
            if (Optional.IsDefined(CustomerResolution))
            {
                writer.WritePropertyName("customerResolution"u8);
                writer.WriteStringValue(CustomerResolution.Value.ToSerialString());
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

        LastMitigationActionOnJob IJsonModel<LastMitigationActionOnJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LastMitigationActionOnJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LastMitigationActionOnJob)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLastMitigationActionOnJob(document.RootElement, options);
        }

        internal static LastMitigationActionOnJob DeserializeLastMitigationActionOnJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? actionDateTimeInUtc = default;
            bool? isPerformedByCustomer = default;
            CustomerResolutionCode? customerResolution = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionDateTimeInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionDateTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isPerformedByCustomer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPerformedByCustomer = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customerResolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customerResolution = property.Value.GetString().ToCustomerResolutionCode();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LastMitigationActionOnJob(actionDateTimeInUtc, isPerformedByCustomer, customerResolution, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LastMitigationActionOnJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LastMitigationActionOnJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LastMitigationActionOnJob)} does not support writing '{options.Format}' format.");
            }
        }

        LastMitigationActionOnJob IPersistableModel<LastMitigationActionOnJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LastMitigationActionOnJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLastMitigationActionOnJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LastMitigationActionOnJob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LastMitigationActionOnJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
