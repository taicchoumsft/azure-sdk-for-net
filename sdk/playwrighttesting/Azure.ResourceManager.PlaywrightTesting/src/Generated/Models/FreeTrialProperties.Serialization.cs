// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PlaywrightTesting.Models
{
    public partial class FreeTrialProperties : IUtf8JsonSerializable, IJsonModel<FreeTrialProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FreeTrialProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FreeTrialProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FreeTrialProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FreeTrialProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn, "O");
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("expiryAt"u8);
                writer.WriteStringValue(ExpiryOn, "O");
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("allocatedValue"u8);
                writer.WriteNumberValue(AllocatedValue);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("usedValue"u8);
                writer.WriteNumberValue(UsedValue);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("percentageUsed"u8);
                writer.WriteNumberValue(PercentageUsed);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.ToString());
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

        FreeTrialProperties IJsonModel<FreeTrialProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FreeTrialProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FreeTrialProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFreeTrialProperties(document.RootElement, options);
        }

        internal static FreeTrialProperties DeserializeFreeTrialProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountId = default;
            DateTimeOffset createdAt = default;
            DateTimeOffset expiryAt = default;
            int allocatedValue = default;
            int usedValue = default;
            decimal percentageUsed = default;
            FreeTrialState state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountId"u8))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryAt"u8))
                {
                    expiryAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("allocatedValue"u8))
                {
                    allocatedValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedValue"u8))
                {
                    usedValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("percentageUsed"u8))
                {
                    percentageUsed = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = new FreeTrialState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FreeTrialProperties(
                accountId,
                createdAt,
                expiryAt,
                allocatedValue,
                usedValue,
                percentageUsed,
                state,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FreeTrialProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FreeTrialProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FreeTrialProperties)} does not support writing '{options.Format}' format.");
            }
        }

        FreeTrialProperties IPersistableModel<FreeTrialProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FreeTrialProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFreeTrialProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FreeTrialProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FreeTrialProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
