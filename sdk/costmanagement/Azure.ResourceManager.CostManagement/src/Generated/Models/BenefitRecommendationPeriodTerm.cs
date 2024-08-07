// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Grain which corresponds to value. </summary>
    public readonly partial struct BenefitRecommendationPeriodTerm : IEquatable<BenefitRecommendationPeriodTerm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BenefitRecommendationPeriodTerm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BenefitRecommendationPeriodTerm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string P1YValue = "P1Y";
        private const string P3YValue = "P3Y";

        /// <summary> Benefit term is 1 year. </summary>
        public static BenefitRecommendationPeriodTerm P1Y { get; } = new BenefitRecommendationPeriodTerm(P1YValue);
        /// <summary> Benefit term is 3 years. </summary>
        public static BenefitRecommendationPeriodTerm P3Y { get; } = new BenefitRecommendationPeriodTerm(P3YValue);
        /// <summary> Determines if two <see cref="BenefitRecommendationPeriodTerm"/> values are the same. </summary>
        public static bool operator ==(BenefitRecommendationPeriodTerm left, BenefitRecommendationPeriodTerm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BenefitRecommendationPeriodTerm"/> values are not the same. </summary>
        public static bool operator !=(BenefitRecommendationPeriodTerm left, BenefitRecommendationPeriodTerm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BenefitRecommendationPeriodTerm"/>. </summary>
        public static implicit operator BenefitRecommendationPeriodTerm(string value) => new BenefitRecommendationPeriodTerm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BenefitRecommendationPeriodTerm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BenefitRecommendationPeriodTerm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
