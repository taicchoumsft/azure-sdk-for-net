// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Primary metrics for Regression task. </summary>
    public readonly partial struct AutoMLVerticalRegressionPrimaryMetric : IEquatable<AutoMLVerticalRegressionPrimaryMetric>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutoMLVerticalRegressionPrimaryMetric"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutoMLVerticalRegressionPrimaryMetric(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SpearmanCorrelationValue = "SpearmanCorrelation";
        private const string NormalizedRootMeanSquaredErrorValue = "NormalizedRootMeanSquaredError";
        private const string R2ScoreValue = "R2Score";
        private const string NormalizedMeanAbsoluteErrorValue = "NormalizedMeanAbsoluteError";

        /// <summary> The Spearman's rank coefficient of correlation is a nonparametric measure of rank correlation. </summary>
        public static AutoMLVerticalRegressionPrimaryMetric SpearmanCorrelation { get; } = new AutoMLVerticalRegressionPrimaryMetric(SpearmanCorrelationValue);
        /// <summary> The Normalized Root Mean Squared Error (NRMSE) the RMSE facilitates the comparison between models with different scales. </summary>
        public static AutoMLVerticalRegressionPrimaryMetric NormalizedRootMeanSquaredError { get; } = new AutoMLVerticalRegressionPrimaryMetric(NormalizedRootMeanSquaredErrorValue);
        /// <summary> The R2 score is one of the performance evaluation measures for forecasting-based machine learning models. </summary>
        public static AutoMLVerticalRegressionPrimaryMetric R2Score { get; } = new AutoMLVerticalRegressionPrimaryMetric(R2ScoreValue);
        /// <summary> The Normalized Mean Absolute Error (NMAE) is a validation metric to compare the Mean Absolute Error (MAE) of (time) series with different scales. </summary>
        public static AutoMLVerticalRegressionPrimaryMetric NormalizedMeanAbsoluteError { get; } = new AutoMLVerticalRegressionPrimaryMetric(NormalizedMeanAbsoluteErrorValue);
        /// <summary> Determines if two <see cref="AutoMLVerticalRegressionPrimaryMetric"/> values are the same. </summary>
        public static bool operator ==(AutoMLVerticalRegressionPrimaryMetric left, AutoMLVerticalRegressionPrimaryMetric right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutoMLVerticalRegressionPrimaryMetric"/> values are not the same. </summary>
        public static bool operator !=(AutoMLVerticalRegressionPrimaryMetric left, AutoMLVerticalRegressionPrimaryMetric right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutoMLVerticalRegressionPrimaryMetric"/>. </summary>
        public static implicit operator AutoMLVerticalRegressionPrimaryMetric(string value) => new AutoMLVerticalRegressionPrimaryMetric(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutoMLVerticalRegressionPrimaryMetric other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutoMLVerticalRegressionPrimaryMetric other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
