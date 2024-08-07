// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Domain availability. </summary>
    public partial class CognitiveServicesDomainAvailabilityList
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesDomainAvailabilityList"/>. </summary>
        internal CognitiveServicesDomainAvailabilityList()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesDomainAvailabilityList"/>. </summary>
        /// <param name="isSubdomainAvailable"> Indicates the given SKU is available or not. </param>
        /// <param name="reason"> Reason why the SKU is not available. </param>
        /// <param name="subdomainName"> The subdomain name to use. </param>
        /// <param name="domainAvailabilityType"> The Type of the resource. </param>
        /// <param name="kind"> The Kind of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesDomainAvailabilityList(bool? isSubdomainAvailable, string reason, string subdomainName, string domainAvailabilityType, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsSubdomainAvailable = isSubdomainAvailable;
            Reason = reason;
            SubdomainName = subdomainName;
            DomainAvailabilityType = domainAvailabilityType;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates the given SKU is available or not. </summary>
        [WirePath("isSubdomainAvailable")]
        public bool? IsSubdomainAvailable { get; }
        /// <summary> Reason why the SKU is not available. </summary>
        [WirePath("reason")]
        public string Reason { get; }
        /// <summary> The subdomain name to use. </summary>
        [WirePath("subdomainName")]
        public string SubdomainName { get; }
        /// <summary> The Type of the resource. </summary>
        [WirePath("type")]
        public string DomainAvailabilityType { get; }
        /// <summary> The Kind of the resource. </summary>
        [WirePath("kind")]
        public string Kind { get; }
    }
}
