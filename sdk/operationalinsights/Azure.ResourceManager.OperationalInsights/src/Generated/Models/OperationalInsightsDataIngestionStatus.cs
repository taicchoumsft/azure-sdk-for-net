// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The status of data ingestion for this workspace. </summary>
    public readonly partial struct OperationalInsightsDataIngestionStatus : IEquatable<OperationalInsightsDataIngestionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsDataIngestionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsDataIngestionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RespectQuotaValue = "RespectQuota";
        private const string ForceOnValue = "ForceOn";
        private const string ForceOffValue = "ForceOff";
        private const string OverQuotaValue = "OverQuota";
        private const string SubscriptionSuspendedValue = "SubscriptionSuspended";
        private const string ApproachingQuotaValue = "ApproachingQuota";

        /// <summary> Ingestion enabled following daily cap quota reset, or subscription enablement. </summary>
        public static OperationalInsightsDataIngestionStatus RespectQuota { get; } = new OperationalInsightsDataIngestionStatus(RespectQuotaValue);
        /// <summary> Ingestion started following service setting change. </summary>
        public static OperationalInsightsDataIngestionStatus ForceOn { get; } = new OperationalInsightsDataIngestionStatus(ForceOnValue);
        /// <summary> Ingestion stopped following service setting change. </summary>
        public static OperationalInsightsDataIngestionStatus ForceOff { get; } = new OperationalInsightsDataIngestionStatus(ForceOffValue);
        /// <summary> Reached daily cap quota, ingestion stopped. </summary>
        public static OperationalInsightsDataIngestionStatus OverQuota { get; } = new OperationalInsightsDataIngestionStatus(OverQuotaValue);
        /// <summary> Ingestion stopped following suspended subscription. </summary>
        public static OperationalInsightsDataIngestionStatus SubscriptionSuspended { get; } = new OperationalInsightsDataIngestionStatus(SubscriptionSuspendedValue);
        /// <summary> 80% of daily cap quota reached. </summary>
        public static OperationalInsightsDataIngestionStatus ApproachingQuota { get; } = new OperationalInsightsDataIngestionStatus(ApproachingQuotaValue);
        /// <summary> Determines if two <see cref="OperationalInsightsDataIngestionStatus"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsDataIngestionStatus left, OperationalInsightsDataIngestionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsDataIngestionStatus"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsDataIngestionStatus left, OperationalInsightsDataIngestionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationalInsightsDataIngestionStatus"/>. </summary>
        public static implicit operator OperationalInsightsDataIngestionStatus(string value) => new OperationalInsightsDataIngestionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsDataIngestionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsDataIngestionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
