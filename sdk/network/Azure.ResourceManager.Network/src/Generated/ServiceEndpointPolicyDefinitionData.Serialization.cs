// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ServiceEndpointPolicyDefinitionData : IUtf8JsonSerializable, IJsonModel<ServiceEndpointPolicyDefinitionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceEndpointPolicyDefinitionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceEndpointPolicyDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceEndpointPolicyDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceEndpointPolicyDefinitionData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Service))
            {
                writer.WritePropertyName("service"u8);
                writer.WriteStringValue(Service);
            }
            if (Optional.IsCollectionDefined(ServiceResources))
            {
                writer.WritePropertyName("serviceResources"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceResources)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
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

        ServiceEndpointPolicyDefinitionData IJsonModel<ServiceEndpointPolicyDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceEndpointPolicyDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceEndpointPolicyDefinitionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceEndpointPolicyDefinitionData(document.RootElement, options);
        }

        internal static ServiceEndpointPolicyDefinitionData DeserializeServiceEndpointPolicyDefinitionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            string description = default;
            string service = default;
            IList<ResourceIdentifier> serviceResources = default;
            NetworkProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("service"u8))
                        {
                            service = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            serviceResources = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServiceEndpointPolicyDefinitionData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                description,
                service,
                serviceResources ?? new ChangeTrackingList<ResourceIdentifier>(),
                provisioningState);
        }

        BinaryData IPersistableModel<ServiceEndpointPolicyDefinitionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceEndpointPolicyDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceEndpointPolicyDefinitionData)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceEndpointPolicyDefinitionData IPersistableModel<ServiceEndpointPolicyDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceEndpointPolicyDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceEndpointPolicyDefinitionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceEndpointPolicyDefinitionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceEndpointPolicyDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
