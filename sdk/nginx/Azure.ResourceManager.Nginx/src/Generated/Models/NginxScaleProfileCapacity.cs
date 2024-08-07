// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The capacity parameters of the profile. </summary>
    public partial class NginxScaleProfileCapacity
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

        /// <summary> Initializes a new instance of <see cref="NginxScaleProfileCapacity"/>. </summary>
        /// <param name="min"> The minimum number of NCUs the deployment can be autoscaled to. </param>
        /// <param name="max"> The maximum number of NCUs the deployment can be autoscaled to. </param>
        public NginxScaleProfileCapacity(int min, int max)
        {
            Min = min;
            Max = max;
        }

        /// <summary> Initializes a new instance of <see cref="NginxScaleProfileCapacity"/>. </summary>
        /// <param name="min"> The minimum number of NCUs the deployment can be autoscaled to. </param>
        /// <param name="max"> The maximum number of NCUs the deployment can be autoscaled to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxScaleProfileCapacity(int min, int max, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Min = min;
            Max = max;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NginxScaleProfileCapacity"/> for deserialization. </summary>
        internal NginxScaleProfileCapacity()
        {
        }

        /// <summary> The minimum number of NCUs the deployment can be autoscaled to. </summary>
        public int Min { get; set; }
        /// <summary> The maximum number of NCUs the deployment can be autoscaled to. </summary>
        public int Max { get; set; }
    }
}
