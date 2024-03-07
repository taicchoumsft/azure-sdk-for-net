// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A rule that provide the triggers and parameters for the scaling action. </summary>
    public partial class AutoscaleRule
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

        /// <summary> Initializes a new instance of <see cref="AutoscaleRule"/>. </summary>
        /// <param name="metricTrigger"> the trigger that results in a scaling action. </param>
        /// <param name="scaleAction"> the parameters for the scaling action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricTrigger"/> or <paramref name="scaleAction"/> is null. </exception>
        public AutoscaleRule(MetricTrigger metricTrigger, MonitorScaleAction scaleAction)
        {
            Argument.AssertNotNull(metricTrigger, nameof(metricTrigger));
            Argument.AssertNotNull(scaleAction, nameof(scaleAction));

            MetricTrigger = metricTrigger;
            ScaleAction = scaleAction;
        }

        /// <summary> Initializes a new instance of <see cref="AutoscaleRule"/>. </summary>
        /// <param name="metricTrigger"> the trigger that results in a scaling action. </param>
        /// <param name="scaleAction"> the parameters for the scaling action. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoscaleRule(MetricTrigger metricTrigger, MonitorScaleAction scaleAction, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MetricTrigger = metricTrigger;
            ScaleAction = scaleAction;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutoscaleRule"/> for deserialization. </summary>
        internal AutoscaleRule()
        {
        }

        /// <summary> the trigger that results in a scaling action. </summary>
        public MetricTrigger MetricTrigger { get; set; }
        /// <summary> the parameters for the scaling action. </summary>
        public MonitorScaleAction ScaleAction { get; set; }
    }
}
