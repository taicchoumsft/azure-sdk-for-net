// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Enum to indicate type of Continuous backup tier. </summary>
    public readonly partial struct ContinuousTier : IEquatable<ContinuousTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContinuousTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContinuousTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Continuous7DaysValue = "Continuous7Days";
        private const string Continuous30DaysValue = "Continuous30Days";

        /// <summary> Continuous7Days. </summary>
        public static ContinuousTier Continuous7Days { get; } = new ContinuousTier(Continuous7DaysValue);
        /// <summary> Continuous30Days. </summary>
        public static ContinuousTier Continuous30Days { get; } = new ContinuousTier(Continuous30DaysValue);
        /// <summary> Determines if two <see cref="ContinuousTier"/> values are the same. </summary>
        public static bool operator ==(ContinuousTier left, ContinuousTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContinuousTier"/> values are not the same. </summary>
        public static bool operator !=(ContinuousTier left, ContinuousTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContinuousTier"/>. </summary>
        public static implicit operator ContinuousTier(string value) => new ContinuousTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContinuousTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContinuousTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
