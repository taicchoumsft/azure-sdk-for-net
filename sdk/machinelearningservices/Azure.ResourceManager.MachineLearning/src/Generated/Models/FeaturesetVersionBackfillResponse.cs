// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Response payload for creating a backfill request for a given feature set version. </summary>
    public partial class FeaturesetVersionBackfillResponse
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

        /// <summary> Initializes a new instance of <see cref="FeaturesetVersionBackfillResponse"/>. </summary>
        internal FeaturesetVersionBackfillResponse()
        {
            JobIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FeaturesetVersionBackfillResponse"/>. </summary>
        /// <param name="jobIds"> List of jobs submitted as part of the backfill request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FeaturesetVersionBackfillResponse(IReadOnlyList<string> jobIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobIds = jobIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of jobs submitted as part of the backfill request. </summary>
        [WirePath("jobIds")]
        public IReadOnlyList<string> JobIds { get; }
    }
}
