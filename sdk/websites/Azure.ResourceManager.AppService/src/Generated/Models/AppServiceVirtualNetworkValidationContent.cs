// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The required set of inputs to validate a VNET. </summary>
    public partial class AppServiceVirtualNetworkValidationContent : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AppServiceVirtualNetworkValidationContent"/>. </summary>
        public AppServiceVirtualNetworkValidationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceVirtualNetworkValidationContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vnetResourceGroup"> The Resource Group of the VNET to be validated. </param>
        /// <param name="vnetName"> The name of the VNET to be validated. </param>
        /// <param name="vnetSubnetName"> The subnet name to be validated. </param>
        /// <param name="subnetResourceId"> The ARM Resource ID of the subnet to validate. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceVirtualNetworkValidationContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string vnetResourceGroup, string vnetName, string vnetSubnetName, ResourceIdentifier subnetResourceId, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            VnetResourceGroup = vnetResourceGroup;
            VnetName = vnetName;
            VnetSubnetName = vnetSubnetName;
            SubnetResourceId = subnetResourceId;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Resource Group of the VNET to be validated. </summary>
        [WirePath("properties.vnetResourceGroup")]
        public string VnetResourceGroup { get; set; }
        /// <summary> The name of the VNET to be validated. </summary>
        [WirePath("properties.vnetName")]
        public string VnetName { get; set; }
        /// <summary> The subnet name to be validated. </summary>
        [WirePath("properties.vnetSubnetName")]
        public string VnetSubnetName { get; set; }
        /// <summary> The ARM Resource ID of the subnet to validate. </summary>
        [WirePath("properties.subnetResourceId")]
        public ResourceIdentifier SubnetResourceId { get; set; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
