// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Criterion for dynamic threshold. </summary>
    public partial class DynamicMetricCriteria : MultiMetricCriteria
    {
        /// <summary> Initializes a new instance of <see cref="DynamicMetricCriteria"/>. </summary>
        /// <param name="name"> Name of the criteria. </param>
        /// <param name="metricName"> Name of the metric. </param>
        /// <param name="timeAggregation"> the criteria time aggregation types. </param>
        /// <param name="operator"> The operator used to compare the metric value against the threshold. </param>
        /// <param name="alertSensitivity"> The extent of deviation required to trigger an alert. This will affect how tight the threshold is to the metric series pattern. </param>
        /// <param name="failingPeriods"> The minimum number of violations required within the selected lookback time window required to raise an alert. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="metricName"/> or <paramref name="failingPeriods"/> is null. </exception>
        public DynamicMetricCriteria(string name, string metricName, MetricCriteriaTimeAggregationType timeAggregation, DynamicThresholdOperator @operator, DynamicThresholdSensitivity alertSensitivity, DynamicThresholdFailingPeriods failingPeriods) : base(name, metricName, timeAggregation)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(metricName, nameof(metricName));
            Argument.AssertNotNull(failingPeriods, nameof(failingPeriods));

            Operator = @operator;
            AlertSensitivity = alertSensitivity;
            FailingPeriods = failingPeriods;
            CriterionType = CriterionType.DynamicThresholdCriterion;
        }

        /// <summary> Initializes a new instance of <see cref="DynamicMetricCriteria"/>. </summary>
        /// <param name="criterionType"> Specifies the type of threshold criteria. </param>
        /// <param name="name"> Name of the criteria. </param>
        /// <param name="metricName"> Name of the metric. </param>
        /// <param name="metricNamespace"> Namespace of the metric. </param>
        /// <param name="timeAggregation"> the criteria time aggregation types. </param>
        /// <param name="dimensions"> List of dimension conditions. </param>
        /// <param name="skipMetricValidation"> Allows creating an alert rule on a custom metric that isn't yet emitted, by causing the metric validation to be skipped. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="operator"> The operator used to compare the metric value against the threshold. </param>
        /// <param name="alertSensitivity"> The extent of deviation required to trigger an alert. This will affect how tight the threshold is to the metric series pattern. </param>
        /// <param name="failingPeriods"> The minimum number of violations required within the selected lookback time window required to raise an alert. </param>
        /// <param name="ignoreDataBefore"> Use this option to set the date from which to start learning the metric historical data and calculate the dynamic thresholds (in ISO8601 format). </param>
        internal DynamicMetricCriteria(CriterionType criterionType, string name, string metricName, string metricNamespace, MetricCriteriaTimeAggregationType timeAggregation, IList<MetricDimension> dimensions, bool? skipMetricValidation, IDictionary<string, BinaryData> additionalProperties, DynamicThresholdOperator @operator, DynamicThresholdSensitivity alertSensitivity, DynamicThresholdFailingPeriods failingPeriods, DateTimeOffset? ignoreDataBefore) : base(criterionType, name, metricName, metricNamespace, timeAggregation, dimensions, skipMetricValidation, additionalProperties)
        {
            Operator = @operator;
            AlertSensitivity = alertSensitivity;
            FailingPeriods = failingPeriods;
            IgnoreDataBefore = ignoreDataBefore;
            CriterionType = criterionType;
        }

        /// <summary> Initializes a new instance of <see cref="DynamicMetricCriteria"/> for deserialization. </summary>
        internal DynamicMetricCriteria()
        {
        }

        /// <summary> The operator used to compare the metric value against the threshold. </summary>
        public DynamicThresholdOperator Operator { get; set; }
        /// <summary> The extent of deviation required to trigger an alert. This will affect how tight the threshold is to the metric series pattern. </summary>
        public DynamicThresholdSensitivity AlertSensitivity { get; set; }
        /// <summary> The minimum number of violations required within the selected lookback time window required to raise an alert. </summary>
        public DynamicThresholdFailingPeriods FailingPeriods { get; set; }
        /// <summary> Use this option to set the date from which to start learning the metric historical data and calculate the dynamic thresholds (in ISO8601 format). </summary>
        public DateTimeOffset? IgnoreDataBefore { get; set; }
    }
}
