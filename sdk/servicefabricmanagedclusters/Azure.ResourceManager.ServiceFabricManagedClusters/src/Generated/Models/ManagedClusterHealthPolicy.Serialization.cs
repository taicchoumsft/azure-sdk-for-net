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
    public partial class ManagedClusterHealthPolicy : IUtf8JsonSerializable, IJsonModel<ManagedClusterHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterHealthPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterHealthPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("maxPercentUnhealthyNodes"u8);
            writer.WriteNumberValue(MaxPercentUnhealthyNodes);
            writer.WritePropertyName("maxPercentUnhealthyApplications"u8);
            writer.WriteNumberValue(MaxPercentUnhealthyApplications);
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

        ManagedClusterHealthPolicy IJsonModel<ManagedClusterHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterHealthPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterHealthPolicy(document.RootElement, options);
        }

        internal static ManagedClusterHealthPolicy DeserializeManagedClusterHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int maxPercentUnhealthyNodes = default;
            int maxPercentUnhealthyApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentUnhealthyNodes"u8))
                {
                    maxPercentUnhealthyNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyApplications"u8))
                {
                    maxPercentUnhealthyApplications = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterHealthPolicy(maxPercentUnhealthyNodes, maxPercentUnhealthyApplications, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterHealthPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterHealthPolicy IPersistableModel<ManagedClusterHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterHealthPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
