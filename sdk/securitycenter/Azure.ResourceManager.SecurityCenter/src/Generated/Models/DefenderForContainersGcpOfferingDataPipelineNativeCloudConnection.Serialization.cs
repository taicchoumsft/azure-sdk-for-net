// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection : IUtf8JsonSerializable, IJsonModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
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

        DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection IJsonModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(document.RootElement, options);
        }

        internal static DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceAccountEmailAddress = default;
            string workloadIdentityProviderId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(serviceAccountEmailAddress, workloadIdentityProviderId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection IPersistableModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
