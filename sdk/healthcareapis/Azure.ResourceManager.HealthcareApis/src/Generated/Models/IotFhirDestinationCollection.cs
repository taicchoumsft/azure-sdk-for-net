// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> A collection of IoT Connector FHIR destinations. </summary>
    internal partial class IotFhirDestinationCollection
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

        /// <summary> Initializes a new instance of <see cref="IotFhirDestinationCollection"/>. </summary>
        internal IotFhirDestinationCollection()
        {
            Value = new ChangeTrackingList<HealthcareApisIotFhirDestinationData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotFhirDestinationCollection"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of IoT FHIR destinations. </param>
        /// <param name="value"> The list of IoT Connector FHIR destinations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotFhirDestinationCollection(string nextLink, IReadOnlyList<HealthcareApisIotFhirDestinationData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link used to get the next page of IoT FHIR destinations. </summary>
        public string NextLink { get; }
        /// <summary> The list of IoT Connector FHIR destinations. </summary>
        public IReadOnlyList<HealthcareApisIotFhirDestinationData> Value { get; }
    }
}
