// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class UnknownAzureArcKubernetesNetworkFunctionApplication : IUtf8JsonSerializable, IJsonModel<AzureArcKubernetesNetworkFunctionApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureArcKubernetesNetworkFunctionApplication>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureArcKubernetesNetworkFunctionApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionApplication)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DependsOnProfile))
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile, options);
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

        AzureArcKubernetesNetworkFunctionApplication IJsonModel<AzureArcKubernetesNetworkFunctionApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionApplication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureArcKubernetesNetworkFunctionApplication(document.RootElement, options);
        }

        internal static UnknownAzureArcKubernetesNetworkFunctionApplication DeserializeUnknownAzureArcKubernetesNetworkFunctionApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureArcKubernetesArtifactType artifactType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            string name = default;
            DependsOnProfile dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new AzureArcKubernetesArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOnProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependsOnProfile = DependsOnProfile.DeserializeDependsOnProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownAzureArcKubernetesNetworkFunctionApplication(name, dependsOnProfile, serializedAdditionalRawData, artifactType);
        }

        BinaryData IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionApplication)} does not support writing '{options.Format}' format.");
            }
        }

        AzureArcKubernetesNetworkFunctionApplication IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureArcKubernetesNetworkFunctionApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionApplication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
