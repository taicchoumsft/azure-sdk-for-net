// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownEventProviderSpecificDetails))]
    public partial class SiteRecoveryEventProviderSpecificDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryEventProviderSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryEventProviderSpecificDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryEventProviderSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryEventProviderSpecificDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        SiteRecoveryEventProviderSpecificDetails IJsonModel<SiteRecoveryEventProviderSpecificDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryEventProviderSpecificDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryEventProviderSpecificDetails(document.RootElement, options);
        }

        internal static SiteRecoveryEventProviderSpecificDetails DeserializeSiteRecoveryEventProviderSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AEventDetails.DeserializeA2AEventDetails(element, options);
                    case "HyperVReplica2012": return HyperVReplica2012EventDetails.DeserializeHyperVReplica2012EventDetails(element, options);
                    case "HyperVReplica2012R2": return HyperVReplica2012R2EventDetails.DeserializeHyperVReplica2012R2EventDetails(element, options);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureEventDetails.DeserializeHyperVReplicaAzureEventDetails(element, options);
                    case "HyperVReplicaBaseEventDetails": return HyperVReplicaBaseEventDetails.DeserializeHyperVReplicaBaseEventDetails(element, options);
                    case "InMageAzureV2": return InMageAzureV2EventDetails.DeserializeInMageAzureV2EventDetails(element, options);
                    case "InMageRcm": return InMageRcmEventDetails.DeserializeInMageRcmEventDetails(element, options);
                    case "InMageRcmFailback": return InMageRcmFailbackEventDetails.DeserializeInMageRcmFailbackEventDetails(element, options);
                    case "VMwareCbt": return VMwareCbtEventDetails.DeserializeVMwareCbtEventDetails(element, options);
                }
            }
            return UnknownEventProviderSpecificDetails.DeserializeUnknownEventProviderSpecificDetails(element, options);
        }

        BinaryData IPersistableModel<SiteRecoveryEventProviderSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryEventProviderSpecificDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryEventProviderSpecificDetails IPersistableModel<SiteRecoveryEventProviderSpecificDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryEventProviderSpecificDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryEventProviderSpecificDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryEventProviderSpecificDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
