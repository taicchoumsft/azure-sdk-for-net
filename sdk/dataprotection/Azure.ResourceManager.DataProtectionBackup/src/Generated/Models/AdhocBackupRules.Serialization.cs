// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class AdhocBackupRules : IUtf8JsonSerializable, IJsonModel<AdhocBackupRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdhocBackupRules>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AdhocBackupRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBackupRules)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ruleName"u8);
            writer.WriteStringValue(RuleName);
            writer.WritePropertyName("triggerOption"u8);
            writer.WriteObjectValue(BackupTrigger, options);
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

        AdhocBackupRules IJsonModel<AdhocBackupRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBackupRules)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdhocBackupRules(document.RootElement, options);
        }

        internal static AdhocBackupRules DeserializeAdhocBackupRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleName = default;
            AdhocBackupTriggerSetting triggerOption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleName"u8))
                {
                    ruleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerOption"u8))
                {
                    triggerOption = AdhocBackupTriggerSetting.DeserializeAdhocBackupTriggerSetting(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AdhocBackupRules(ruleName, triggerOption, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdhocBackupRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdhocBackupRules)} does not support writing '{options.Format}' format.");
            }
        }

        AdhocBackupRules IPersistableModel<AdhocBackupRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdhocBackupRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdhocBackupRules)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdhocBackupRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
