// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes threat intelligence metric. </summary>
    public partial class ThreatIntelligenceMetric
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

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceMetric"/>. </summary>
        internal ThreatIntelligenceMetric()
        {
            ThreatTypeMetrics = new ChangeTrackingList<ThreatIntelligenceMetricEntity>();
            PatternTypeMetrics = new ChangeTrackingList<ThreatIntelligenceMetricEntity>();
            SourceMetrics = new ChangeTrackingList<ThreatIntelligenceMetricEntity>();
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceMetric"/>. </summary>
        /// <param name="lastUpdatedOn"> Last updated indicator metric. </param>
        /// <param name="threatTypeMetrics"> Threat type metrics. </param>
        /// <param name="patternTypeMetrics"> Pattern type metrics. </param>
        /// <param name="sourceMetrics"> Source metrics. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreatIntelligenceMetric(string lastUpdatedOn, IReadOnlyList<ThreatIntelligenceMetricEntity> threatTypeMetrics, IReadOnlyList<ThreatIntelligenceMetricEntity> patternTypeMetrics, IReadOnlyList<ThreatIntelligenceMetricEntity> sourceMetrics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastUpdatedOn = lastUpdatedOn;
            ThreatTypeMetrics = threatTypeMetrics;
            PatternTypeMetrics = patternTypeMetrics;
            SourceMetrics = sourceMetrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Last updated indicator metric. </summary>
        public string LastUpdatedOn { get; }
        /// <summary> Threat type metrics. </summary>
        public IReadOnlyList<ThreatIntelligenceMetricEntity> ThreatTypeMetrics { get; }
        /// <summary> Pattern type metrics. </summary>
        public IReadOnlyList<ThreatIntelligenceMetricEntity> PatternTypeMetrics { get; }
        /// <summary> Source metrics. </summary>
        public IReadOnlyList<ThreatIntelligenceMetricEntity> SourceMetrics { get; }
    }
}
