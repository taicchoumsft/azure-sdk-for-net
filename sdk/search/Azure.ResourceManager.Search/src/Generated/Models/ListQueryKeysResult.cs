// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing the query API keys for a given Azure AI Search service. </summary>
    internal partial class ListQueryKeysResult
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

        /// <summary> Initializes a new instance of <see cref="ListQueryKeysResult"/>. </summary>
        internal ListQueryKeysResult()
        {
            Value = new ChangeTrackingList<SearchServiceQueryKey>();
        }

        /// <summary> Initializes a new instance of <see cref="ListQueryKeysResult"/>. </summary>
        /// <param name="value"> The query keys for the Azure AI Search service. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of query keys. Returned when the total number of requested query keys exceed maximum page size. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListQueryKeysResult(IReadOnlyList<SearchServiceQueryKey> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The query keys for the Azure AI Search service. </summary>
        public IReadOnlyList<SearchServiceQueryKey> Value { get; }
        /// <summary> Request URL that can be used to query next page of query keys. Returned when the total number of requested query keys exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
