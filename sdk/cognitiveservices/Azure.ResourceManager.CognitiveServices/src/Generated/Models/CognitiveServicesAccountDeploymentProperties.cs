// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties of Cognitive Services account deployment. </summary>
    public partial class CognitiveServicesAccountDeploymentProperties
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountDeploymentProperties"/>. </summary>
        public CognitiveServicesAccountDeploymentProperties()
        {
            Capabilities = new ChangeTrackingDictionary<string, string>();
            RateLimits = new ChangeTrackingList<ServiceAccountThrottlingRule>();
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountDeploymentProperties"/>. </summary>
        /// <param name="provisioningState"> Gets the status of the resource at the time the operation was called. </param>
        /// <param name="model"> Properties of Cognitive Services account deployment model. </param>
        /// <param name="scaleSettings"> Properties of Cognitive Services account deployment model. </param>
        /// <param name="capabilities"> The capabilities. </param>
        /// <param name="raiPolicyName"> The name of RAI policy. </param>
        /// <param name="callRateLimit"> The call rate limit Cognitive Services account. </param>
        /// <param name="rateLimits"></param>
        /// <param name="versionUpgradeOption"> Deployment model version upgrade option. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesAccountDeploymentProperties(CognitiveServicesAccountDeploymentProvisioningState? provisioningState, CognitiveServicesAccountDeploymentModel model, CognitiveServicesAccountDeploymentScaleSettings scaleSettings, IReadOnlyDictionary<string, string> capabilities, string raiPolicyName, ServiceAccountCallRateLimit callRateLimit, IReadOnlyList<ServiceAccountThrottlingRule> rateLimits, DeploymentModelVersionUpgradeOption? versionUpgradeOption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Model = model;
            ScaleSettings = scaleSettings;
            Capabilities = capabilities;
            RaiPolicyName = raiPolicyName;
            CallRateLimit = callRateLimit;
            RateLimits = rateLimits;
            VersionUpgradeOption = versionUpgradeOption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the status of the resource at the time the operation was called. </summary>
        [WirePath("provisioningState")]
        public CognitiveServicesAccountDeploymentProvisioningState? ProvisioningState { get; }
        /// <summary> Properties of Cognitive Services account deployment model. </summary>
        [WirePath("model")]
        public CognitiveServicesAccountDeploymentModel Model { get; set; }
        /// <summary> Properties of Cognitive Services account deployment model. </summary>
        [WirePath("scaleSettings")]
        public CognitiveServicesAccountDeploymentScaleSettings ScaleSettings { get; set; }
        /// <summary> The capabilities. </summary>
        [WirePath("capabilities")]
        public IReadOnlyDictionary<string, string> Capabilities { get; }
        /// <summary> The name of RAI policy. </summary>
        [WirePath("raiPolicyName")]
        public string RaiPolicyName { get; set; }
        /// <summary> The call rate limit Cognitive Services account. </summary>
        [WirePath("callRateLimit")]
        public ServiceAccountCallRateLimit CallRateLimit { get; }
        /// <summary> Gets the rate limits. </summary>
        [WirePath("rateLimits")]
        public IReadOnlyList<ServiceAccountThrottlingRule> RateLimits { get; }
        /// <summary> Deployment model version upgrade option. </summary>
        [WirePath("versionUpgradeOption")]
        public DeploymentModelVersionUpgradeOption? VersionUpgradeOption { get; set; }
    }
}
