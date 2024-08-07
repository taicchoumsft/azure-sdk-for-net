// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The KubernetesVersionProfileProperties. </summary>
    public partial class KubernetesVersionProfileProperties
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

        /// <summary> Initializes a new instance of <see cref="KubernetesVersionProfileProperties"/>. </summary>
        internal KubernetesVersionProfileProperties()
        {
            Values = new ChangeTrackingList<KubernetesVersionProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesVersionProfileProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="values"> List of supported Kubernetes versions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesVersionProfileProperties(HybridContainerServiceResourceProvisioningState? provisioningState, IReadOnlyList<KubernetesVersionProperties> values, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Values = values;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public HybridContainerServiceResourceProvisioningState? ProvisioningState { get; }
        /// <summary> List of supported Kubernetes versions. </summary>
        public IReadOnlyList<KubernetesVersionProperties> Values { get; }
    }
}
