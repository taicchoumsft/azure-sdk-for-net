// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing the PostgreSqlFirewallRule data model.
    /// Represents a server firewall rule.
    /// </summary>
    public partial class PostgreSqlFirewallRuleData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFirewallRuleData"/>. </summary>
        /// <param name="startIPAddress"> The start IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startIPAddress"/> or <paramref name="endIPAddress"/> is null. </exception>
        public PostgreSqlFirewallRuleData(IPAddress startIPAddress, IPAddress endIPAddress)
        {
            Argument.AssertNotNull(startIPAddress, nameof(startIPAddress));
            Argument.AssertNotNull(endIPAddress, nameof(endIPAddress));

            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFirewallRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress"> The start IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFirewallRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IPAddress startIPAddress, IPAddress endIPAddress, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFirewallRuleData"/> for deserialization. </summary>
        internal PostgreSqlFirewallRuleData()
        {
        }

        /// <summary> The start IP address of the server firewall rule. Must be IPv4 format. </summary>
        [WirePath("properties.startIpAddress")]
        public IPAddress StartIPAddress { get; set; }
        /// <summary> The end IP address of the server firewall rule. Must be IPv4 format. </summary>
        [WirePath("properties.endIpAddress")]
        public IPAddress EndIPAddress { get; set; }
    }
}
