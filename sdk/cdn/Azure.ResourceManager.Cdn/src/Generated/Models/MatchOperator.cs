// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct MatchOperator : IEquatable<MatchOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MatchOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MatchOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string IPMatchValue = "IPMatch";
        private const string GeoMatchValue = "GeoMatch";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string LessThanValue = "LessThan";
        private const string GreaterThanValue = "GreaterThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string RegExValue = "RegEx";

        /// <summary> Any. </summary>
        public static MatchOperator Any { get; } = new MatchOperator(AnyValue);
        /// <summary> IPMatch. </summary>
        public static MatchOperator IPMatch { get; } = new MatchOperator(IPMatchValue);
        /// <summary> GeoMatch. </summary>
        public static MatchOperator GeoMatch { get; } = new MatchOperator(GeoMatchValue);
        /// <summary> Equal. </summary>
        public static MatchOperator Equal { get; } = new MatchOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static MatchOperator Contains { get; } = new MatchOperator(ContainsValue);
        /// <summary> LessThan. </summary>
        public static MatchOperator LessThan { get; } = new MatchOperator(LessThanValue);
        /// <summary> GreaterThan. </summary>
        public static MatchOperator GreaterThan { get; } = new MatchOperator(GreaterThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static MatchOperator LessThanOrEqual { get; } = new MatchOperator(LessThanOrEqualValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static MatchOperator GreaterThanOrEqual { get; } = new MatchOperator(GreaterThanOrEqualValue);
        /// <summary> BeginsWith. </summary>
        public static MatchOperator BeginsWith { get; } = new MatchOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static MatchOperator EndsWith { get; } = new MatchOperator(EndsWithValue);
        /// <summary> RegEx. </summary>
        public static MatchOperator RegEx { get; } = new MatchOperator(RegExValue);
        /// <summary> Determines if two <see cref="MatchOperator"/> values are the same. </summary>
        public static bool operator ==(MatchOperator left, MatchOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MatchOperator"/> values are not the same. </summary>
        public static bool operator !=(MatchOperator left, MatchOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MatchOperator"/>. </summary>
        public static implicit operator MatchOperator(string value) => new MatchOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MatchOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MatchOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
