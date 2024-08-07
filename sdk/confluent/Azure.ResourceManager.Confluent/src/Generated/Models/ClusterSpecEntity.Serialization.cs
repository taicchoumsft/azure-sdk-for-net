// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class ClusterSpecEntity : IUtf8JsonSerializable, IJsonModel<ClusterSpecEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterSpecEntity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterSpecEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterSpecEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterSpecEntity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("display_name"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Availability))
            {
                writer.WritePropertyName("availability"u8);
                writer.WriteStringValue(Availability);
            }
            if (Optional.IsDefined(Cloud))
            {
                writer.WritePropertyName("cloud"u8);
                writer.WriteStringValue(Cloud);
            }
            if (Optional.IsDefined(Zone))
            {
                writer.WritePropertyName("zone"u8);
                writer.WriteStringValue(Zone);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(KafkaBootstrapEndpoint))
            {
                writer.WritePropertyName("kafka_bootstrap_endpoint"u8);
                writer.WriteStringValue(KafkaBootstrapEndpoint);
            }
            if (Optional.IsDefined(HttpEndpoint))
            {
                writer.WritePropertyName("http_endpoint"u8);
                writer.WriteStringValue(HttpEndpoint);
            }
            if (Optional.IsDefined(ApiEndpoint))
            {
                writer.WritePropertyName("api_endpoint"u8);
                writer.WriteStringValue(ApiEndpoint);
            }
            if (Optional.IsDefined(Config))
            {
                writer.WritePropertyName("config"u8);
                writer.WriteObjectValue(Config, options);
            }
            if (Optional.IsDefined(Environment))
            {
                writer.WritePropertyName("environment"u8);
                writer.WriteObjectValue(Environment, options);
            }
            if (Optional.IsDefined(Network))
            {
                writer.WritePropertyName("network"u8);
                writer.WriteObjectValue(Network, options);
            }
            if (Optional.IsDefined(Byok))
            {
                writer.WritePropertyName("byok"u8);
                writer.WriteObjectValue(Byok, options);
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

        ClusterSpecEntity IJsonModel<ClusterSpecEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterSpecEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterSpecEntity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterSpecEntity(document.RootElement, options);
        }

        internal static ClusterSpecEntity DeserializeClusterSpecEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            string availability = default;
            string cloud = default;
            string zone = default;
            string region = default;
            string kafkaBootstrapEndpoint = default;
            string httpEndpoint = default;
            string apiEndpoint = default;
            ClusterConfigEntity config = default;
            ClusterEnvironmentEntity environment = default;
            ClusterNetworkEntity network = default;
            ClusterByokEntity byok = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("display_name"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availability"u8))
                {
                    availability = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    cloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zone"u8))
                {
                    zone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kafka_bootstrap_endpoint"u8))
                {
                    kafkaBootstrapEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("http_endpoint"u8))
                {
                    httpEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("api_endpoint"u8))
                {
                    apiEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("config"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    config = ClusterConfigEntity.DeserializeClusterConfigEntity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("environment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    environment = ClusterEnvironmentEntity.DeserializeClusterEnvironmentEntity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("network"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    network = ClusterNetworkEntity.DeserializeClusterNetworkEntity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("byok"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    byok = ClusterByokEntity.DeserializeClusterByokEntity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterSpecEntity(
                displayName,
                availability,
                cloud,
                zone,
                region,
                kafkaBootstrapEndpoint,
                httpEndpoint,
                apiEndpoint,
                config,
                environment,
                network,
                byok,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterSpecEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterSpecEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterSpecEntity)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterSpecEntity IPersistableModel<ClusterSpecEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterSpecEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterSpecEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterSpecEntity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterSpecEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
