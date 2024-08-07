// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class LinkedIntegrationRuntimeRbacAuthorization : IUtf8JsonSerializable, IJsonModel<LinkedIntegrationRuntimeRbacAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkedIntegrationRuntimeRbacAuthorization>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LinkedIntegrationRuntimeRbacAuthorization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedIntegrationRuntimeRbacAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeRbacAuthorization)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential, options);
            }
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
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

        LinkedIntegrationRuntimeRbacAuthorization IJsonModel<LinkedIntegrationRuntimeRbacAuthorization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedIntegrationRuntimeRbacAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeRbacAuthorization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedIntegrationRuntimeRbacAuthorization(document.RootElement, options);
        }

        internal static LinkedIntegrationRuntimeRbacAuthorization DeserializeLinkedIntegrationRuntimeRbacAuthorization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            DataFactoryCredentialReference credential = default;
            string authorizationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LinkedIntegrationRuntimeRbacAuthorization(authorizationType, serializedAdditionalRawData, resourceId, credential);
        }

        BinaryData IPersistableModel<LinkedIntegrationRuntimeRbacAuthorization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedIntegrationRuntimeRbacAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeRbacAuthorization)} does not support writing '{options.Format}' format.");
            }
        }

        LinkedIntegrationRuntimeRbacAuthorization IPersistableModel<LinkedIntegrationRuntimeRbacAuthorization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedIntegrationRuntimeRbacAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkedIntegrationRuntimeRbacAuthorization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeRbacAuthorization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkedIntegrationRuntimeRbacAuthorization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
