// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthBot.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmHealthBotModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="HealthBot.HealthBotData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="skuName"> SKU of the Azure Health Bot. </param>
        /// <param name="identity"> The identity of the Azure Health Bot. </param>
        /// <param name="properties"> The set of properties specific to Azure Health Bot resource. </param>
        /// <returns> A new <see cref="HealthBot.HealthBotData"/> instance for mocking. </returns>
        public static HealthBotData HealthBotData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HealthBotSkuName? skuName = null, ManagedServiceIdentity identity = null, HealthBotProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new HealthBotData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                skuName.HasValue ? new HealthBotSku(skuName.Value, serializedAdditionalRawData: null) : null,
                identity,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HealthBotProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the Azure Health Bot resource. </param>
        /// <param name="botManagementPortalLink"> The link. </param>
        /// <param name="keyVaultProperties"> KeyVault properties for the resource encryption. </param>
        /// <returns> A new <see cref="Models.HealthBotProperties"/> instance for mocking. </returns>
        public static HealthBotProperties HealthBotProperties(string provisioningState = null, Uri botManagementPortalLink = null, HealthBotKeyVaultProperties keyVaultProperties = null)
        {
            return new HealthBotProperties(provisioningState, botManagementPortalLink, keyVaultProperties, serializedAdditionalRawData: null);
        }
    }
}
