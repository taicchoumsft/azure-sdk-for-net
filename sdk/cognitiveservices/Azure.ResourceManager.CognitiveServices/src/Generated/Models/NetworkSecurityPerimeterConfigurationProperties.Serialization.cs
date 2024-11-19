// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class NetworkSecurityPerimeterConfigurationProperties : IUtf8JsonSerializable, IJsonModel<NetworkSecurityPerimeterConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityPerimeterConfigurationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkSecurityPerimeterConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsCollectionDefined(ProvisioningIssues))
            {
                writer.WritePropertyName("provisioningIssues"u8);
                writer.WriteStartArray();
                foreach (var item in ProvisioningIssues)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkSecurityPerimeter))
            {
                writer.WritePropertyName("networkSecurityPerimeter"u8);
                writer.WriteObjectValue(NetworkSecurityPerimeter, options);
            }
            if (Optional.IsDefined(ResourceAssociation))
            {
                writer.WritePropertyName("resourceAssociation"u8);
                writer.WriteObjectValue(ResourceAssociation, options);
            }
            if (Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteObjectValue(Profile, options);
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
        }

        NetworkSecurityPerimeterConfigurationProperties IJsonModel<NetworkSecurityPerimeterConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityPerimeterConfigurationProperties(document.RootElement, options);
        }

        internal static NetworkSecurityPerimeterConfigurationProperties DeserializeNetworkSecurityPerimeterConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisioningState = default;
            IList<NetworkSecurityPerimeterProvisioningIssue> provisioningIssues = default;
            CognitiveServicesNetworkSecurityPerimeter networkSecurityPerimeter = default;
            NetworkSecurityPerimeterConfigurationAssociationInfo resourceAssociation = default;
            NetworkSecurityPerimeterProfileInfo profile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningIssues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkSecurityPerimeterProvisioningIssue> array = new List<NetworkSecurityPerimeterProvisioningIssue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkSecurityPerimeterProvisioningIssue.DeserializeNetworkSecurityPerimeterProvisioningIssue(item, options));
                    }
                    provisioningIssues = array;
                    continue;
                }
                if (property.NameEquals("networkSecurityPerimeter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkSecurityPerimeter = CognitiveServicesNetworkSecurityPerimeter.DeserializeCognitiveServicesNetworkSecurityPerimeter(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceAssociation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceAssociation = NetworkSecurityPerimeterConfigurationAssociationInfo.DeserializeNetworkSecurityPerimeterConfigurationAssociationInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profile = NetworkSecurityPerimeterProfileInfo.DeserializeNetworkSecurityPerimeterProfileInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkSecurityPerimeterConfigurationProperties(
                provisioningState,
                provisioningIssues ?? new ChangeTrackingList<NetworkSecurityPerimeterProvisioningIssue>(),
                networkSecurityPerimeter,
                resourceAssociation,
                profile,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    if (ProvisioningState.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProvisioningState}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProvisioningState}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningIssues), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningIssues: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ProvisioningIssues))
                {
                    if (ProvisioningIssues.Any())
                    {
                        builder.Append("  provisioningIssues: ");
                        builder.AppendLine("[");
                        foreach (var item in ProvisioningIssues)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  provisioningIssues: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkSecurityPerimeter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  networkSecurityPerimeter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NetworkSecurityPerimeter))
                {
                    builder.Append("  networkSecurityPerimeter: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NetworkSecurityPerimeter, options, 2, false, "  networkSecurityPerimeter: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceAssociation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resourceAssociation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceAssociation))
                {
                    builder.Append("  resourceAssociation: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ResourceAssociation, options, 2, false, "  resourceAssociation: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Profile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  profile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Profile))
                {
                    builder.Append("  profile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Profile, options, 2, false, "  profile: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NetworkSecurityPerimeterConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSecurityPerimeterConfigurationProperties IPersistableModel<NetworkSecurityPerimeterConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkSecurityPerimeterConfigurationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityPerimeterConfigurationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
