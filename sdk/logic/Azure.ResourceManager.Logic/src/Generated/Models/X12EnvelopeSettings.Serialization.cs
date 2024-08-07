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
    public partial class X12EnvelopeSettings : IUtf8JsonSerializable, IJsonModel<X12EnvelopeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12EnvelopeSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<X12EnvelopeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12EnvelopeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12EnvelopeSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("controlStandardsId"u8);
            writer.WriteNumberValue(ControlStandardsId);
            writer.WritePropertyName("useControlStandardsIdAsRepetitionCharacter"u8);
            writer.WriteBooleanValue(UseControlStandardsIdAsRepetitionCharacter);
            writer.WritePropertyName("senderApplicationId"u8);
            writer.WriteStringValue(SenderApplicationId);
            writer.WritePropertyName("receiverApplicationId"u8);
            writer.WriteStringValue(ReceiverApplicationId);
            writer.WritePropertyName("controlVersionNumber"u8);
            writer.WriteStringValue(ControlVersionNumber);
            writer.WritePropertyName("interchangeControlNumberLowerBound"u8);
            writer.WriteNumberValue(InterchangeControlNumberLowerBound);
            writer.WritePropertyName("interchangeControlNumberUpperBound"u8);
            writer.WriteNumberValue(InterchangeControlNumberUpperBound);
            writer.WritePropertyName("rolloverInterchangeControlNumber"u8);
            writer.WriteBooleanValue(RolloverInterchangeControlNumber);
            writer.WritePropertyName("enableDefaultGroupHeaders"u8);
            writer.WriteBooleanValue(EnableDefaultGroupHeaders);
            if (Optional.IsDefined(FunctionalGroupId))
            {
                writer.WritePropertyName("functionalGroupId"u8);
                writer.WriteStringValue(FunctionalGroupId);
            }
            writer.WritePropertyName("groupControlNumberLowerBound"u8);
            writer.WriteNumberValue(GroupControlNumberLowerBound);
            writer.WritePropertyName("groupControlNumberUpperBound"u8);
            writer.WriteNumberValue(GroupControlNumberUpperBound);
            writer.WritePropertyName("rolloverGroupControlNumber"u8);
            writer.WriteBooleanValue(RolloverGroupControlNumber);
            writer.WritePropertyName("groupHeaderAgencyCode"u8);
            writer.WriteStringValue(GroupHeaderAgencyCode);
            writer.WritePropertyName("groupHeaderVersion"u8);
            writer.WriteStringValue(GroupHeaderVersion);
            writer.WritePropertyName("transactionSetControlNumberLowerBound"u8);
            writer.WriteNumberValue(TransactionSetControlNumberLowerBound);
            writer.WritePropertyName("transactionSetControlNumberUpperBound"u8);
            writer.WriteNumberValue(TransactionSetControlNumberUpperBound);
            writer.WritePropertyName("rolloverTransactionSetControlNumber"u8);
            writer.WriteBooleanValue(RolloverTransactionSetControlNumber);
            if (Optional.IsDefined(TransactionSetControlNumberPrefix))
            {
                writer.WritePropertyName("transactionSetControlNumberPrefix"u8);
                writer.WriteStringValue(TransactionSetControlNumberPrefix);
            }
            if (Optional.IsDefined(TransactionSetControlNumberSuffix))
            {
                writer.WritePropertyName("transactionSetControlNumberSuffix"u8);
                writer.WriteStringValue(TransactionSetControlNumberSuffix);
            }
            writer.WritePropertyName("overwriteExistingTransactionSetControlNumber"u8);
            writer.WriteBooleanValue(OverwriteExistingTransactionSetControlNumber);
            writer.WritePropertyName("groupHeaderDateFormat"u8);
            writer.WriteStringValue(GroupHeaderDateFormat.ToString());
            writer.WritePropertyName("groupHeaderTimeFormat"u8);
            writer.WriteStringValue(GroupHeaderTimeFormat.ToString());
            writer.WritePropertyName("usageIndicator"u8);
            writer.WriteStringValue(UsageIndicator.ToString());
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

        X12EnvelopeSettings IJsonModel<X12EnvelopeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12EnvelopeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12EnvelopeSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12EnvelopeSettings(document.RootElement, options);
        }

        internal static X12EnvelopeSettings DeserializeX12EnvelopeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int controlStandardsId = default;
            bool useControlStandardsIdAsRepetitionCharacter = default;
            string senderApplicationId = default;
            string receiverApplicationId = default;
            string controlVersionNumber = default;
            int interchangeControlNumberLowerBound = default;
            int interchangeControlNumberUpperBound = default;
            bool rolloverInterchangeControlNumber = default;
            bool enableDefaultGroupHeaders = default;
            string functionalGroupId = default;
            int groupControlNumberLowerBound = default;
            int groupControlNumberUpperBound = default;
            bool rolloverGroupControlNumber = default;
            string groupHeaderAgencyCode = default;
            string groupHeaderVersion = default;
            int transactionSetControlNumberLowerBound = default;
            int transactionSetControlNumberUpperBound = default;
            bool rolloverTransactionSetControlNumber = default;
            string transactionSetControlNumberPrefix = default;
            string transactionSetControlNumberSuffix = default;
            bool overwriteExistingTransactionSetControlNumber = default;
            X12DateFormat groupHeaderDateFormat = default;
            X12TimeFormat groupHeaderTimeFormat = default;
            UsageIndicator usageIndicator = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("controlStandardsId"u8))
                {
                    controlStandardsId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("useControlStandardsIdAsRepetitionCharacter"u8))
                {
                    useControlStandardsIdAsRepetitionCharacter = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("senderApplicationId"u8))
                {
                    senderApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverApplicationId"u8))
                {
                    receiverApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlVersionNumber"u8))
                {
                    controlVersionNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberLowerBound"u8))
                {
                    interchangeControlNumberLowerBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberUpperBound"u8))
                {
                    interchangeControlNumberUpperBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rolloverInterchangeControlNumber"u8))
                {
                    rolloverInterchangeControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableDefaultGroupHeaders"u8))
                {
                    enableDefaultGroupHeaders = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("functionalGroupId"u8))
                {
                    functionalGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupControlNumberLowerBound"u8))
                {
                    groupControlNumberLowerBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("groupControlNumberUpperBound"u8))
                {
                    groupControlNumberUpperBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rolloverGroupControlNumber"u8))
                {
                    rolloverGroupControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("groupHeaderAgencyCode"u8))
                {
                    groupHeaderAgencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupHeaderVersion"u8))
                {
                    groupHeaderVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberLowerBound"u8))
                {
                    transactionSetControlNumberLowerBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberUpperBound"u8))
                {
                    transactionSetControlNumberUpperBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rolloverTransactionSetControlNumber"u8))
                {
                    rolloverTransactionSetControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberPrefix"u8))
                {
                    transactionSetControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberSuffix"u8))
                {
                    transactionSetControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overwriteExistingTransactionSetControlNumber"u8))
                {
                    overwriteExistingTransactionSetControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("groupHeaderDateFormat"u8))
                {
                    groupHeaderDateFormat = new X12DateFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groupHeaderTimeFormat"u8))
                {
                    groupHeaderTimeFormat = new X12TimeFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usageIndicator"u8))
                {
                    usageIndicator = new UsageIndicator(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new X12EnvelopeSettings(
                controlStandardsId,
                useControlStandardsIdAsRepetitionCharacter,
                senderApplicationId,
                receiverApplicationId,
                controlVersionNumber,
                interchangeControlNumberLowerBound,
                interchangeControlNumberUpperBound,
                rolloverInterchangeControlNumber,
                enableDefaultGroupHeaders,
                functionalGroupId,
                groupControlNumberLowerBound,
                groupControlNumberUpperBound,
                rolloverGroupControlNumber,
                groupHeaderAgencyCode,
                groupHeaderVersion,
                transactionSetControlNumberLowerBound,
                transactionSetControlNumberUpperBound,
                rolloverTransactionSetControlNumber,
                transactionSetControlNumberPrefix,
                transactionSetControlNumberSuffix,
                overwriteExistingTransactionSetControlNumber,
                groupHeaderDateFormat,
                groupHeaderTimeFormat,
                usageIndicator,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<X12EnvelopeSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12EnvelopeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(X12EnvelopeSettings)} does not support writing '{options.Format}' format.");
            }
        }

        X12EnvelopeSettings IPersistableModel<X12EnvelopeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12EnvelopeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeX12EnvelopeSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(X12EnvelopeSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<X12EnvelopeSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
