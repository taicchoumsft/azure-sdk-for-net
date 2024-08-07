// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The SettingsType. </summary>
    public readonly partial struct SettingsType : IEquatable<SettingsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SettingsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SettingsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicValue = "public";

        /// <summary> public. </summary>
        public static SettingsType Public { get; } = new SettingsType(PublicValue);
        /// <summary> Determines if two <see cref="SettingsType"/> values are the same. </summary>
        public static bool operator ==(SettingsType left, SettingsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SettingsType"/> values are not the same. </summary>
        public static bool operator !=(SettingsType left, SettingsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SettingsType"/>. </summary>
        public static implicit operator SettingsType(string value) => new SettingsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SettingsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SettingsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
