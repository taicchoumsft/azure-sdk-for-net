// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    public partial class IntegrationServiceEnvironmentManagedApiData : IUtf8JsonSerializable, IJsonModel<IntegrationServiceEnvironmentManagedApiData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationServiceEnvironmentManagedApiData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationServiceEnvironmentManagedApiData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentManagedApiData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentManagedApiData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamePropertiesName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ConnectionParameters))
            {
                writer.WritePropertyName("connectionParameters"u8);
                writer.WriteStartObject();
                foreach (var item in ConnectionParameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RuntimeUris))
            {
                writer.WritePropertyName("runtimeUrls"u8);
                writer.WriteStartArray();
                foreach (var item in RuntimeUris)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(GeneralInformation))
            {
                writer.WritePropertyName("generalInformation"u8);
                writer.WriteObjectValue(GeneralInformation, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(BackendService))
            {
                writer.WritePropertyName("backendService"u8);
                writer.WriteObjectValue(BackendService, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteObjectValue(Policies, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ApiDefinitionUri))
            {
                writer.WritePropertyName("apiDefinitionUrl"u8);
                writer.WriteStringValue(ApiDefinitionUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(ApiDefinitions))
            {
                writer.WritePropertyName("apiDefinitions"u8);
                writer.WriteObjectValue(ApiDefinitions, options);
            }
            if (Optional.IsDefined(IntegrationServiceEnvironment))
            {
                writer.WritePropertyName("integrationServiceEnvironment"u8);
                writer.WriteObjectValue(IntegrationServiceEnvironment, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(DeploymentParameters))
            {
                writer.WritePropertyName("deploymentParameters"u8);
                writer.WriteObjectValue(DeploymentParameters, options);
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

        IntegrationServiceEnvironmentManagedApiData IJsonModel<IntegrationServiceEnvironmentManagedApiData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentManagedApiData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentManagedApiData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentManagedApiData(document.RootElement, options);
        }

        internal static IntegrationServiceEnvironmentManagedApiData DeserializeIntegrationServiceEnvironmentManagedApiData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string name0 = default;
            IReadOnlyDictionary<string, BinaryData> connectionParameters = default;
            LogicApiResourceMetadata metadata = default;
            IReadOnlyList<Uri> runtimeUrls = default;
            LogicApiResourceGeneralInformation generalInformation = default;
            IReadOnlyList<string> capabilities = default;
            LogicApiResourceBackendService backendService = default;
            LogicApiResourcePolicies policies = default;
            Uri apiDefinitionUrl = default;
            LogicApiResourceDefinitions apiDefinitions = default;
            LogicResourceReference integrationServiceEnvironment = default;
            LogicWorkflowProvisioningState? provisioningState = default;
            LogicApiTier? category = default;
            IntegrationServiceEnvironmentManagedApiDeploymentParameters deploymentParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            connectionParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = LogicApiResourceMetadata.DeserializeLogicApiResourceMetadata(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("runtimeUrls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Uri> array = new List<Uri>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new Uri(item.GetString()));
                                }
                            }
                            runtimeUrls = array;
                            continue;
                        }
                        if (property0.NameEquals("generalInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            generalInformation = LogicApiResourceGeneralInformation.DeserializeLogicApiResourceGeneralInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            capabilities = array;
                            continue;
                        }
                        if (property0.NameEquals("backendService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendService = LogicApiResourceBackendService.DeserializeLogicApiResourceBackendService(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("policies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policies = LogicApiResourcePolicies.DeserializeLogicApiResourcePolicies(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("apiDefinitionUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiDefinitionUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("apiDefinitions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiDefinitions = LogicApiResourceDefinitions.DeserializeLogicApiResourceDefinitions(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("integrationServiceEnvironment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            integrationServiceEnvironment = LogicResourceReference.DeserializeLogicResourceReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new LogicWorkflowProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("category"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            category = new LogicApiTier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentParameters = IntegrationServiceEnvironmentManagedApiDeploymentParameters.DeserializeIntegrationServiceEnvironmentManagedApiDeploymentParameters(property0.Value, options);
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
            return new IntegrationServiceEnvironmentManagedApiData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                name0,
                connectionParameters ?? new ChangeTrackingDictionary<string, BinaryData>(),
                metadata,
                runtimeUrls ?? new ChangeTrackingList<Uri>(),
                generalInformation,
                capabilities ?? new ChangeTrackingList<string>(),
                backendService,
                policies,
                apiDefinitionUrl,
                apiDefinitions,
                integrationServiceEnvironment,
                provisioningState,
                category,
                deploymentParameters,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationServiceEnvironmentManagedApiData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentManagedApiData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentManagedApiData)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationServiceEnvironmentManagedApiData IPersistableModel<IntegrationServiceEnvironmentManagedApiData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentManagedApiData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationServiceEnvironmentManagedApiData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentManagedApiData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationServiceEnvironmentManagedApiData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
