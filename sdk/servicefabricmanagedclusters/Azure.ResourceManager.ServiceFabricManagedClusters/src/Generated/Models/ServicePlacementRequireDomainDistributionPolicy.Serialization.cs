// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServicePlacementRequireDomainDistributionPolicy : IUtf8JsonSerializable, IJsonModel<ServicePlacementRequireDomainDistributionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServicePlacementRequireDomainDistributionPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServicePlacementRequireDomainDistributionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePlacementRequireDomainDistributionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServicePlacementRequireDomainDistributionPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ServicePlacementPolicyType.ToString());
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

        ServicePlacementRequireDomainDistributionPolicy IJsonModel<ServicePlacementRequireDomainDistributionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePlacementRequireDomainDistributionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServicePlacementRequireDomainDistributionPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePlacementRequireDomainDistributionPolicy(document.RootElement, options);
        }

        internal static ServicePlacementRequireDomainDistributionPolicy DeserializeServicePlacementRequireDomainDistributionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            ServicePlacementPolicyType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ServicePlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServicePlacementRequireDomainDistributionPolicy(type, serializedAdditionalRawData, domainName);
        }

        BinaryData IPersistableModel<ServicePlacementRequireDomainDistributionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePlacementRequireDomainDistributionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServicePlacementRequireDomainDistributionPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ServicePlacementRequireDomainDistributionPolicy IPersistableModel<ServicePlacementRequireDomainDistributionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePlacementRequireDomainDistributionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServicePlacementRequireDomainDistributionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServicePlacementRequireDomainDistributionPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServicePlacementRequireDomainDistributionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
