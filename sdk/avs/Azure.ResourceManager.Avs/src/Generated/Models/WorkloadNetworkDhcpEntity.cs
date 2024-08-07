// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary>
    /// Base class for WorkloadNetworkDhcpServer and WorkloadNetworkDhcpRelay to inherit from
    /// Please note <see cref="WorkloadNetworkDhcpEntity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WorkloadNetworkDhcpRelay"/> and <see cref="WorkloadNetworkDhcpServer"/>.
    /// </summary>
    public abstract partial class WorkloadNetworkDhcpEntity
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDhcpEntity"/>. </summary>
        protected WorkloadNetworkDhcpEntity()
        {
            Segments = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDhcpEntity"/>. </summary>
        /// <param name="dhcpType"> Type of DHCP: SERVER or RELAY. </param>
        /// <param name="displayName"> Display name of the DHCP entity. </param>
        /// <param name="segments"> NSX Segments consuming DHCP. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="revision"> NSX revision number. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkDhcpEntity(DhcpTypeEnum dhcpType, string displayName, IReadOnlyList<string> segments, WorkloadNetworkDhcpProvisioningState? provisioningState, long? revision, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DhcpType = dhcpType;
            DisplayName = displayName;
            Segments = segments;
            ProvisioningState = provisioningState;
            Revision = revision;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of DHCP: SERVER or RELAY. </summary>
        internal DhcpTypeEnum DhcpType { get; set; }
        /// <summary> Display name of the DHCP entity. </summary>
        public string DisplayName { get; set; }
        /// <summary> NSX Segments consuming DHCP. </summary>
        public IReadOnlyList<string> Segments { get; }
        /// <summary> The provisioning state. </summary>
        public WorkloadNetworkDhcpProvisioningState? ProvisioningState { get; }
        /// <summary> NSX revision number. </summary>
        public long? Revision { get; set; }
    }
}
