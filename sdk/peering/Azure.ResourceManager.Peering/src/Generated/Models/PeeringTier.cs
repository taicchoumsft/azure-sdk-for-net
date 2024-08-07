// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The tier of the peering SKU. </summary>
    public readonly partial struct PeeringTier : IEquatable<PeeringTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PeeringTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PeeringTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string PremiumValue = "Premium";

        /// <summary> Basic. </summary>
        public static PeeringTier Basic { get; } = new PeeringTier(BasicValue);
        /// <summary> Premium. </summary>
        public static PeeringTier Premium { get; } = new PeeringTier(PremiumValue);
        /// <summary> Determines if two <see cref="PeeringTier"/> values are the same. </summary>
        public static bool operator ==(PeeringTier left, PeeringTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PeeringTier"/> values are not the same. </summary>
        public static bool operator !=(PeeringTier left, PeeringTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PeeringTier"/>. </summary>
        public static implicit operator PeeringTier(string value) => new PeeringTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PeeringTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PeeringTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
