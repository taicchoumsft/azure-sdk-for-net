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
    public partial class AzureMLOnlineInferencingServer : IUtf8JsonSerializable, IJsonModel<AzureMLOnlineInferencingServer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureMLOnlineInferencingServer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureMLOnlineInferencingServer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLOnlineInferencingServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMLOnlineInferencingServer)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CodeConfiguration))
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration"u8);
                    writer.WriteObjectValue(CodeConfiguration, options);
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
            }
            writer.WritePropertyName("serverType"u8);
            writer.WriteStringValue(ServerType.ToString());
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

        AzureMLOnlineInferencingServer IJsonModel<AzureMLOnlineInferencingServer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLOnlineInferencingServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMLOnlineInferencingServer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureMLOnlineInferencingServer(document.RootElement, options);
        }

        internal static AzureMLOnlineInferencingServer DeserializeAzureMLOnlineInferencingServer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningCodeConfiguration codeConfiguration = default;
            InferencingServerType serverType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = MachineLearningCodeConfiguration.DeserializeMachineLearningCodeConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serverType"u8))
                {
                    serverType = new InferencingServerType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureMLOnlineInferencingServer(serverType, serializedAdditionalRawData, codeConfiguration);
        }

        BinaryData IPersistableModel<AzureMLOnlineInferencingServer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLOnlineInferencingServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureMLOnlineInferencingServer)} does not support writing '{options.Format}' format.");
            }
        }

        AzureMLOnlineInferencingServer IPersistableModel<AzureMLOnlineInferencingServer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLOnlineInferencingServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureMLOnlineInferencingServer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureMLOnlineInferencingServer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureMLOnlineInferencingServer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
