// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningServicePrincipalDatastoreSecrets : IUtf8JsonSerializable, IJsonModel<MachineLearningServicePrincipalDatastoreSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServicePrincipalDatastoreSecrets>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningServicePrincipalDatastoreSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreSecrets)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientSecret))
            {
                if (ClientSecret != null)
                {
                    writer.WritePropertyName("clientSecret"u8);
                    writer.WriteStringValue(ClientSecret);
                }
                else
                {
                    writer.WriteNull("clientSecret");
                }
            }
            writer.WritePropertyName("secretsType"u8);
            writer.WriteStringValue(SecretsType.ToString());
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

        MachineLearningServicePrincipalDatastoreSecrets IJsonModel<MachineLearningServicePrincipalDatastoreSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreSecrets)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServicePrincipalDatastoreSecrets(document.RootElement, options);
        }

        internal static MachineLearningServicePrincipalDatastoreSecrets DeserializeMachineLearningServicePrincipalDatastoreSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientSecret = default;
            SecretsType secretsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientSecret = null;
                        continue;
                    }
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"u8))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningServicePrincipalDatastoreSecrets(secretsType, serializedAdditionalRawData, clientSecret);
        }

        BinaryData IPersistableModel<MachineLearningServicePrincipalDatastoreSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreSecrets)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningServicePrincipalDatastoreSecrets IPersistableModel<MachineLearningServicePrincipalDatastoreSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningServicePrincipalDatastoreSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreSecrets)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningServicePrincipalDatastoreSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
