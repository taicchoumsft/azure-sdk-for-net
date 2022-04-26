// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary> A class representing the DataMigrationService data model. </summary>
    public partial class DataMigrationServiceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DataMigrationServiceData. </summary>
        /// <param name="location"> The location. </param>
        public DataMigrationServiceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of DataMigrationServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> HTTP strong entity tag value. Ignored if submitted. </param>
        /// <param name="kind"> The resource kind. Only &apos;vm&apos; (the default) is supported. </param>
        /// <param name="sku"> Service SKU. </param>
        /// <param name="provisioningState"> The resource&apos;s provisioning state. </param>
        /// <param name="publicKey"> The public key of the service, used to encrypt secrets sent to the service. </param>
        /// <param name="virtualSubnetId"> The ID of the Microsoft.Network/virtualNetworks/subnets resource to which the service should be joined. </param>
        /// <param name="virtualNicId"> The ID of the Microsoft.Network/networkInterfaces resource which the service have. </param>
        /// <param name="autoStopDelay"> The time delay before the service is auto-stopped when idle. </param>
        /// <param name="deleteResourcesOnStop"> Whether service resources should be deleted when stopped. (Turned on by default). </param>
        internal DataMigrationServiceData(ResourceIdentifier id, string name, Core.ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string etag, string kind, ServiceSku sku, ServiceProvisioningState? provisioningState, string publicKey, string virtualSubnetId, string virtualNicId, string autoStopDelay, bool? deleteResourcesOnStop) : base(id, name, resourceType, systemData, tags, location)
        {
            Etag = etag;
            Kind = kind;
            Sku = sku;
            ProvisioningState = provisioningState;
            PublicKey = publicKey;
            VirtualSubnetId = virtualSubnetId;
            VirtualNicId = virtualNicId;
            AutoStopDelay = autoStopDelay;
            DeleteResourcesOnStop = deleteResourcesOnStop;
        }

        /// <summary> HTTP strong entity tag value. Ignored if submitted. </summary>
        public string Etag { get; set; }
        /// <summary> The resource kind. Only &apos;vm&apos; (the default) is supported. </summary>
        public string Kind { get; set; }
        /// <summary> Service SKU. </summary>
        public ServiceSku Sku { get; set; }
        /// <summary> The resource&apos;s provisioning state. </summary>
        public ServiceProvisioningState? ProvisioningState { get; }
        /// <summary> The public key of the service, used to encrypt secrets sent to the service. </summary>
        public string PublicKey { get; set; }
        /// <summary> The ID of the Microsoft.Network/virtualNetworks/subnets resource to which the service should be joined. </summary>
        public string VirtualSubnetId { get; set; }
        /// <summary> The ID of the Microsoft.Network/networkInterfaces resource which the service have. </summary>
        public string VirtualNicId { get; set; }
        /// <summary> The time delay before the service is auto-stopped when idle. </summary>
        public string AutoStopDelay { get; set; }
        /// <summary> Whether service resources should be deleted when stopped. (Turned on by default). </summary>
        public bool? DeleteResourcesOnStop { get; set; }
    }
}
