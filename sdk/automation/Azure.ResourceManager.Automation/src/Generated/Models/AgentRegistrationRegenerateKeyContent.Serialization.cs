// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AgentRegistrationRegenerateKeyContent : IUtf8JsonSerializable, IJsonModel<AgentRegistrationRegenerateKeyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentRegistrationRegenerateKeyContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AgentRegistrationRegenerateKeyContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentRegistrationRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentRegistrationRegenerateKeyContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName.ToString());
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

        AgentRegistrationRegenerateKeyContent IJsonModel<AgentRegistrationRegenerateKeyContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentRegistrationRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentRegistrationRegenerateKeyContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentRegistrationRegenerateKeyContent(document.RootElement, options);
        }

        internal static AgentRegistrationRegenerateKeyContent DeserializeAgentRegistrationRegenerateKeyContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AgentRegistrationKeyName keyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = new AgentRegistrationKeyName(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AgentRegistrationRegenerateKeyContent(keyName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentRegistrationRegenerateKeyContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentRegistrationRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AgentRegistrationRegenerateKeyContent)} does not support writing '{options.Format}' format.");
            }
        }

        AgentRegistrationRegenerateKeyContent IPersistableModel<AgentRegistrationRegenerateKeyContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentRegistrationRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentRegistrationRegenerateKeyContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentRegistrationRegenerateKeyContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentRegistrationRegenerateKeyContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
