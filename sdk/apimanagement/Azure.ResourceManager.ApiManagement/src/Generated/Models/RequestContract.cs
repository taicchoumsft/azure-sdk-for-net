// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Operation request details. </summary>
    public partial class RequestContract
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

        /// <summary> Initializes a new instance of <see cref="RequestContract"/>. </summary>
        public RequestContract()
        {
            QueryParameters = new ChangeTrackingList<ParameterContract>();
            Headers = new ChangeTrackingList<ParameterContract>();
            Representations = new ChangeTrackingList<RepresentationContract>();
        }

        /// <summary> Initializes a new instance of <see cref="RequestContract"/>. </summary>
        /// <param name="description"> Operation request description. </param>
        /// <param name="queryParameters"> Collection of operation request query parameters. </param>
        /// <param name="headers"> Collection of operation request headers. </param>
        /// <param name="representations"> Collection of operation request representations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RequestContract(string description, IList<ParameterContract> queryParameters, IList<ParameterContract> headers, IList<RepresentationContract> representations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            QueryParameters = queryParameters;
            Headers = headers;
            Representations = representations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Operation request description. </summary>
        [WirePath("description")]
        public string Description { get; set; }
        /// <summary> Collection of operation request query parameters. </summary>
        [WirePath("queryParameters")]
        public IList<ParameterContract> QueryParameters { get; }
        /// <summary> Collection of operation request headers. </summary>
        [WirePath("headers")]
        public IList<ParameterContract> Headers { get; }
        /// <summary> Collection of operation request representations. </summary>
        [WirePath("representations")]
        public IList<RepresentationContract> Representations { get; }
    }
}
