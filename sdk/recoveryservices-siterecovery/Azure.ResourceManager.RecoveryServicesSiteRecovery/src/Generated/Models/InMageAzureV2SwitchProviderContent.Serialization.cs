// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAzureV2SwitchProviderContent : IUtf8JsonSerializable, IJsonModel<InMageAzureV2SwitchProviderContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageAzureV2SwitchProviderContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InMageAzureV2SwitchProviderContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2SwitchProviderContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAzureV2SwitchProviderContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targetVaultID"u8);
            writer.WriteStringValue(TargetVaultId);
            writer.WritePropertyName("targetFabricID"u8);
            writer.WriteStringValue(TargetFabricId);
            writer.WritePropertyName("targetApplianceID"u8);
            writer.WriteStringValue(TargetApplianceId);
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

        InMageAzureV2SwitchProviderContent IJsonModel<InMageAzureV2SwitchProviderContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2SwitchProviderContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAzureV2SwitchProviderContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageAzureV2SwitchProviderContent(document.RootElement, options);
        }

        internal static InMageAzureV2SwitchProviderContent DeserializeInMageAzureV2SwitchProviderContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier targetVaultId = default;
            ResourceIdentifier targetFabricId = default;
            string targetApplianceId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetVaultID"u8))
                {
                    targetVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetFabricID"u8))
                {
                    targetFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetApplianceID"u8))
                {
                    targetApplianceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InMageAzureV2SwitchProviderContent(instanceType, serializedAdditionalRawData, targetVaultId, targetFabricId, targetApplianceId);
        }

        BinaryData IPersistableModel<InMageAzureV2SwitchProviderContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2SwitchProviderContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageAzureV2SwitchProviderContent)} does not support writing '{options.Format}' format.");
            }
        }

        InMageAzureV2SwitchProviderContent IPersistableModel<InMageAzureV2SwitchProviderContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2SwitchProviderContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageAzureV2SwitchProviderContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageAzureV2SwitchProviderContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageAzureV2SwitchProviderContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
