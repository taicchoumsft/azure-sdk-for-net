// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkPacketBroker data model.
    /// The NetworkPacketBroker resource definition.
    /// </summary>
    public partial class NetworkPacketBrokerData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="NetworkPacketBrokerData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="networkFabricId"> ARM resource ID of the Network Fabric. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricId"/> is null. </exception>
        public NetworkPacketBrokerData(AzureLocation location, ResourceIdentifier networkFabricId) : base(location)
        {
            Argument.AssertNotNull(networkFabricId, nameof(networkFabricId));

            NetworkFabricId = networkFabricId;
            NetworkDeviceIds = new ChangeTrackingList<ResourceIdentifier>();
            SourceInterfaceIds = new ChangeTrackingList<ResourceIdentifier>();
            NetworkTapIds = new ChangeTrackingList<ResourceIdentifier>();
            NeighborGroupIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkPacketBrokerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="networkFabricId"> ARM resource ID of the Network Fabric. </param>
        /// <param name="networkDeviceIds"> List of ARM resource IDs of Network Devices [NPB]. </param>
        /// <param name="sourceInterfaceIds"> List of network interfaces across NPB devices that are used to mirror source traffic. </param>
        /// <param name="networkTapIds"> List of network Tap IDs configured on NPB. </param>
        /// <param name="neighborGroupIds"> List of neighbor group IDs configured on NPB. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkPacketBrokerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceIdentifier networkFabricId, IReadOnlyList<ResourceIdentifier> networkDeviceIds, IReadOnlyList<ResourceIdentifier> sourceInterfaceIds, IReadOnlyList<ResourceIdentifier> networkTapIds, IReadOnlyList<ResourceIdentifier> neighborGroupIds, NetworkFabricProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            NetworkFabricId = networkFabricId;
            NetworkDeviceIds = networkDeviceIds;
            SourceInterfaceIds = sourceInterfaceIds;
            NetworkTapIds = networkTapIds;
            NeighborGroupIds = neighborGroupIds;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkPacketBrokerData"/> for deserialization. </summary>
        internal NetworkPacketBrokerData()
        {
        }

        /// <summary> ARM resource ID of the Network Fabric. </summary>
        public ResourceIdentifier NetworkFabricId { get; set; }
        /// <summary> List of ARM resource IDs of Network Devices [NPB]. </summary>
        public IReadOnlyList<ResourceIdentifier> NetworkDeviceIds { get; }
        /// <summary> List of network interfaces across NPB devices that are used to mirror source traffic. </summary>
        public IReadOnlyList<ResourceIdentifier> SourceInterfaceIds { get; }
        /// <summary> List of network Tap IDs configured on NPB. </summary>
        public IReadOnlyList<ResourceIdentifier> NetworkTapIds { get; }
        /// <summary> List of neighbor group IDs configured on NPB. </summary>
        public IReadOnlyList<ResourceIdentifier> NeighborGroupIds { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
    }
}
