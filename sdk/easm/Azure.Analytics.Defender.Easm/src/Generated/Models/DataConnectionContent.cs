// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The type of data the data connection will transfer. </summary>
    public readonly partial struct DataConnectionContent : IEquatable<DataConnectionContent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataConnectionContent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataConnectionContent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssetsValue = "assets";
        private const string AttackSurfaceInsightsValue = "attackSurfaceInsights";

        /// <summary> assets. </summary>
        public static DataConnectionContent Assets { get; } = new DataConnectionContent(AssetsValue);
        /// <summary> attackSurfaceInsights. </summary>
        public static DataConnectionContent AttackSurfaceInsights { get; } = new DataConnectionContent(AttackSurfaceInsightsValue);
        /// <summary> Determines if two <see cref="DataConnectionContent"/> values are the same. </summary>
        public static bool operator ==(DataConnectionContent left, DataConnectionContent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataConnectionContent"/> values are not the same. </summary>
        public static bool operator !=(DataConnectionContent left, DataConnectionContent right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataConnectionContent"/>. </summary>
        public static implicit operator DataConnectionContent(string value) => new DataConnectionContent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataConnectionContent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataConnectionContent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
