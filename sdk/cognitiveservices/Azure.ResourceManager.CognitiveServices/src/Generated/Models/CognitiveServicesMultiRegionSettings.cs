// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The multiregion settings Cognitive Services account. </summary>
    public partial class CognitiveServicesMultiRegionSettings
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesMultiRegionSettings"/>. </summary>
        public CognitiveServicesMultiRegionSettings()
        {
            Regions = new ChangeTrackingList<CognitiveServicesRegionSetting>();
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesMultiRegionSettings"/>. </summary>
        /// <param name="routingMethod"> Multiregion routing methods. </param>
        /// <param name="regions"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesMultiRegionSettings(CognitiveServicesRoutingMethod? routingMethod, IList<CognitiveServicesRegionSetting> regions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RoutingMethod = routingMethod;
            Regions = regions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Multiregion routing methods. </summary>
        [WirePath("routingMethod")]
        public CognitiveServicesRoutingMethod? RoutingMethod { get; set; }
        /// <summary> Gets the regions. </summary>
        [WirePath("regions")]
        public IList<CognitiveServicesRegionSetting> Regions { get; }
    }
}
