// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Tier of a public IP prefix SKU. </summary>
    public readonly partial struct PublicIPPrefixSkuTier : IEquatable<PublicIPPrefixSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PublicIPPrefixSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PublicIPPrefixSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegionalValue = "Regional";
        private const string GlobalValue = "Global";

        /// <summary> Regional. </summary>
        public static PublicIPPrefixSkuTier Regional { get; } = new PublicIPPrefixSkuTier(RegionalValue);
        /// <summary> Global. </summary>
        public static PublicIPPrefixSkuTier Global { get; } = new PublicIPPrefixSkuTier(GlobalValue);
        /// <summary> Determines if two <see cref="PublicIPPrefixSkuTier"/> values are the same. </summary>
        public static bool operator ==(PublicIPPrefixSkuTier left, PublicIPPrefixSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PublicIPPrefixSkuTier"/> values are not the same. </summary>
        public static bool operator !=(PublicIPPrefixSkuTier left, PublicIPPrefixSkuTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PublicIPPrefixSkuTier"/>. </summary>
        public static implicit operator PublicIPPrefixSkuTier(string value) => new PublicIPPrefixSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PublicIPPrefixSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PublicIPPrefixSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
