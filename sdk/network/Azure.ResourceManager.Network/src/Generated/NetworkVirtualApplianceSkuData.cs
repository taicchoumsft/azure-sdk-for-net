// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkVirtualApplianceSku data model.
    /// Definition of the NetworkVirtualApplianceSkus resource.
    /// </summary>
    public partial class NetworkVirtualApplianceSkuData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="NetworkVirtualApplianceSkuData"/>. </summary>
        public NetworkVirtualApplianceSkuData()
        {
            AvailableVersions = new ChangeTrackingList<string>();
            AvailableScaleUnits = new ChangeTrackingList<NetworkVirtualApplianceSkuInstances>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkVirtualApplianceSkuData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="vendor"> Network Virtual Appliance Sku vendor. </param>
        /// <param name="availableVersions"> Available Network Virtual Appliance versions. </param>
        /// <param name="availableScaleUnits"> The list of scale units available. </param>
        internal NetworkVirtualApplianceSkuData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, string vendor, IReadOnlyList<string> availableVersions, IList<NetworkVirtualApplianceSkuInstances> availableScaleUnits) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ETag = etag;
            Vendor = vendor;
            AvailableVersions = availableVersions;
            AvailableScaleUnits = availableScaleUnits;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Network Virtual Appliance Sku vendor. </summary>
        public string Vendor { get; }
        /// <summary> Available Network Virtual Appliance versions. </summary>
        public IReadOnlyList<string> AvailableVersions { get; }
        /// <summary> The list of scale units available. </summary>
        public IList<NetworkVirtualApplianceSkuInstances> AvailableScaleUnits { get; }
    }
}
