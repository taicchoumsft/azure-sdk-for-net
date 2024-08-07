// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> User &amp; groups can be synced automatically or via a static list that's refreshed. </summary>
    public readonly partial struct RangerUsersyncMode : IEquatable<RangerUsersyncMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RangerUsersyncMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RangerUsersyncMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticValue = "static";
        private const string AutomaticValue = "automatic";

        /// <summary> static. </summary>
        public static RangerUsersyncMode Static { get; } = new RangerUsersyncMode(StaticValue);
        /// <summary> automatic. </summary>
        public static RangerUsersyncMode Automatic { get; } = new RangerUsersyncMode(AutomaticValue);
        /// <summary> Determines if two <see cref="RangerUsersyncMode"/> values are the same. </summary>
        public static bool operator ==(RangerUsersyncMode left, RangerUsersyncMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RangerUsersyncMode"/> values are not the same. </summary>
        public static bool operator !=(RangerUsersyncMode left, RangerUsersyncMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RangerUsersyncMode"/>. </summary>
        public static implicit operator RangerUsersyncMode(string value) => new RangerUsersyncMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RangerUsersyncMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RangerUsersyncMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
