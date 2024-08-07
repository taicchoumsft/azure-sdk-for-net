// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Connected Partner Resource Properties. </summary>
    public partial class NewRelicConnectedPartnerResourceProperties
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

        /// <summary> Initializes a new instance of <see cref="NewRelicConnectedPartnerResourceProperties"/>. </summary>
        internal NewRelicConnectedPartnerResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicConnectedPartnerResourceProperties"/>. </summary>
        /// <param name="accountName"> NewRelic account name. </param>
        /// <param name="accountId"> NewRelic Account Id. </param>
        /// <param name="azureResourceId"> The azure resource Id of the deployment. </param>
        /// <param name="location"> The location of the deployment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicConnectedPartnerResourceProperties(string accountName, string accountId, string azureResourceId, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountName = accountName;
            AccountId = accountId;
            AzureResourceId = azureResourceId;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> NewRelic account name. </summary>
        [WirePath("accountName")]
        public string AccountName { get; }
        /// <summary> NewRelic Account Id. </summary>
        [WirePath("accountId")]
        public string AccountId { get; }
        /// <summary> The azure resource Id of the deployment. </summary>
        [WirePath("azureResourceId")]
        public string AzureResourceId { get; }
        /// <summary> The location of the deployment. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; }
    }
}
