// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Cognitive Services Model. </summary>
    public partial class CognitiveServicesModel
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesModel"/>. </summary>
        internal CognitiveServicesModel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesModel"/>. </summary>
        /// <param name="model"> Model Metadata. </param>
        /// <param name="kind"> The Kind of the Model. </param>
        /// <param name="skuName"> The SKU of the Model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesModel(CognitiveServicesAccountModel model, string kind, string skuName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Model = model;
            Kind = kind;
            SkuName = skuName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Model Metadata. </summary>
        [WirePath("model")]
        public CognitiveServicesAccountModel Model { get; }
        /// <summary> The Kind of the Model. </summary>
        [WirePath("kind")]
        public string Kind { get; }
        /// <summary> The SKU of the Model. </summary>
        [WirePath("skuName")]
        public string SkuName { get; }
    }
}
