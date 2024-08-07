// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Describes the properties of a resource type that has been onboarded to private link service. </summary>
    public partial class ShareablePrivateLinkProperties
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

        /// <summary> Initializes a new instance of <see cref="ShareablePrivateLinkProperties"/>. </summary>
        public ShareablePrivateLinkProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ShareablePrivateLinkProperties"/>. </summary>
        /// <param name="description"> The description of the resource type that has been onboarded to private link service. </param>
        /// <param name="groupId"> The resource provider group id for the resource that has been onboarded to private link service. </param>
        /// <param name="shareablePrivateLinkPropertiesType"> The resource provider type for the resource that has been onboarded to private link service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareablePrivateLinkProperties(string description, string groupId, string shareablePrivateLinkPropertiesType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            GroupId = groupId;
            ShareablePrivateLinkPropertiesType = shareablePrivateLinkPropertiesType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The description of the resource type that has been onboarded to private link service. </summary>
        [WirePath("description")]
        public string Description { get; set; }
        /// <summary> The resource provider group id for the resource that has been onboarded to private link service. </summary>
        [WirePath("groupId")]
        public string GroupId { get; set; }
        /// <summary> The resource provider type for the resource that has been onboarded to private link service. </summary>
        [WirePath("type")]
        public string ShareablePrivateLinkPropertiesType { get; set; }
    }
}
