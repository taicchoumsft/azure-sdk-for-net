// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing the DnsResolver data model.
    /// Describes a DNS resolver.
    /// </summary>
    public partial class DnsResolverData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DnsResolverData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="virtualNetwork"> The reference to the virtual network. This cannot be changed after creation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetwork"/> is null. </exception>
        public DnsResolverData(AzureLocation location, WritableSubResource virtualNetwork) : base(location)
        {
            Argument.AssertNotNull(virtualNetwork, nameof(virtualNetwork));

            VirtualNetwork = virtualNetwork;
        }

        /// <summary> Initializes a new instance of <see cref="DnsResolverData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> ETag of the DNS resolver. </param>
        /// <param name="virtualNetwork"> The reference to the virtual network. This cannot be changed after creation. </param>
        /// <param name="dnsResolverState"> The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="provisioningState"> The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="resourceGuid"> The resourceGuid property of the DNS resolver resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsResolverData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, WritableSubResource virtualNetwork, DnsResolverState? dnsResolverState, DnsResolverProvisioningState? provisioningState, Guid? resourceGuid, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            VirtualNetwork = virtualNetwork;
            DnsResolverState = dnsResolverState;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DnsResolverData"/> for deserialization. </summary>
        internal DnsResolverData()
        {
        }

        /// <summary> ETag of the DNS resolver. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to the virtual network. This cannot be changed after creation. </summary>
        internal WritableSubResource VirtualNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkId
        {
            get => VirtualNetwork is null ? default : VirtualNetwork.Id;
            set
            {
                if (VirtualNetwork is null)
                    VirtualNetwork = new WritableSubResource();
                VirtualNetwork.Id = value;
            }
        }

        /// <summary> The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public DnsResolverState? DnsResolverState { get; }
        /// <summary> The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public DnsResolverProvisioningState? ProvisioningState { get; }
        /// <summary> The resourceGuid property of the DNS resolver resource. </summary>
        public Guid? ResourceGuid { get; }
    }
}
