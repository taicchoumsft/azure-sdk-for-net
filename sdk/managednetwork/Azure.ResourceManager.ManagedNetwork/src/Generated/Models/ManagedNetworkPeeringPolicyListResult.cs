// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> Result of the request to list Managed Network Peering Policies. It contains a list of policies and a URL link to get the next set of results. </summary>
    internal partial class ManagedNetworkPeeringPolicyListResult
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

        /// <summary> Initializes a new instance of <see cref="ManagedNetworkPeeringPolicyListResult"/>. </summary>
        internal ManagedNetworkPeeringPolicyListResult()
        {
            Value = new ChangeTrackingList<ManagedNetworkPeeringPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedNetworkPeeringPolicyListResult"/>. </summary>
        /// <param name="value"> Gets a page of Peering Policies. </param>
        /// <param name="nextLink"> Gets the URL to get the next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedNetworkPeeringPolicyListResult(IReadOnlyList<ManagedNetworkPeeringPolicyData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets a page of Peering Policies. </summary>
        public IReadOnlyList<ManagedNetworkPeeringPolicyData> Value { get; }
        /// <summary> Gets the URL to get the next page of results. </summary>
        public string NextLink { get; }
    }
}
