// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing the GlobalRulestack data model.
    /// PaloAltoNetworks GlobalRulestack
    /// </summary>
    public partial class GlobalRulestackData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="GlobalRulestackData"/>. </summary>
        /// <param name="location"> Global Location. </param>
        public GlobalRulestackData(AzureLocation location)
        {
            Location = location;
            AssociatedSubscriptions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="GlobalRulestackData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Global Location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="panETag"> PanEtag info. </param>
        /// <param name="panLocation"> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </param>
        /// <param name="scope"> Rulestack Type. </param>
        /// <param name="associatedSubscriptions"> subscription scope of global rulestack. </param>
        /// <param name="description"> rulestack description. </param>
        /// <param name="defaultMode"> Mode for default rules creation. </param>
        /// <param name="minAppIdVersion"> minimum version. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="securityServices"> Security Profile. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GlobalRulestackData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation location, ManagedServiceIdentity identity, ETag? panETag, AzureLocation? panLocation, RulestackScopeType? scope, IList<string> associatedSubscriptions, string description, RuleCreationDefaultMode? defaultMode, string minAppIdVersion, FirewallProvisioningState? provisioningState, RulestackSecurityServices securityServices, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Identity = identity;
            PanETag = panETag;
            PanLocation = panLocation;
            Scope = scope;
            AssociatedSubscriptions = associatedSubscriptions;
            Description = description;
            DefaultMode = defaultMode;
            MinAppIdVersion = minAppIdVersion;
            ProvisioningState = provisioningState;
            SecurityServices = securityServices;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GlobalRulestackData"/> for deserialization. </summary>
        internal GlobalRulestackData()
        {
        }

        /// <summary> Global Location. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> PanEtag info. </summary>
        public ETag? PanETag { get; set; }
        /// <summary> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </summary>
        public AzureLocation? PanLocation { get; set; }
        /// <summary> Rulestack Type. </summary>
        public RulestackScopeType? Scope { get; set; }
        /// <summary> subscription scope of global rulestack. </summary>
        public IList<string> AssociatedSubscriptions { get; }
        /// <summary> rulestack description. </summary>
        public string Description { get; set; }
        /// <summary> Mode for default rules creation. </summary>
        public RuleCreationDefaultMode? DefaultMode { get; set; }
        /// <summary> minimum version. </summary>
        public string MinAppIdVersion { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public FirewallProvisioningState? ProvisioningState { get; }
        /// <summary> Security Profile. </summary>
        public RulestackSecurityServices SecurityServices { get; set; }
    }
}
