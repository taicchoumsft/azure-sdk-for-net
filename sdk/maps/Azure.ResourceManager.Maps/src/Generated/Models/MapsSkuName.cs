// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> The name of the SKU, in standard format (such as S0). </summary>
    public readonly partial struct MapsSkuName : IEquatable<MapsSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapsSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapsSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string S0Value = "S0";
        private const string S1Value = "S1";
        private const string G2Value = "G2";

        /// <summary> S0. </summary>
        public static MapsSkuName S0 { get; } = new MapsSkuName(S0Value);
        /// <summary> S1. </summary>
        public static MapsSkuName S1 { get; } = new MapsSkuName(S1Value);
        /// <summary> G2. </summary>
        public static MapsSkuName G2 { get; } = new MapsSkuName(G2Value);
        /// <summary> Determines if two <see cref="MapsSkuName"/> values are the same. </summary>
        public static bool operator ==(MapsSkuName left, MapsSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapsSkuName"/> values are not the same. </summary>
        public static bool operator !=(MapsSkuName left, MapsSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MapsSkuName"/>. </summary>
        public static implicit operator MapsSkuName(string value) => new MapsSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapsSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapsSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
