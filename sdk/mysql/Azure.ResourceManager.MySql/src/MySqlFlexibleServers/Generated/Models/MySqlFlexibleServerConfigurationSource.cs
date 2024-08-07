// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Source of the configuration. </summary>
    public readonly partial struct MySqlFlexibleServerConfigurationSource : IEquatable<MySqlFlexibleServerConfigurationSource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigurationSource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlFlexibleServerConfigurationSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemDefaultValue = "system-default";
        private const string UserOverrideValue = "user-override";

        /// <summary> system-default. </summary>
        public static MySqlFlexibleServerConfigurationSource SystemDefault { get; } = new MySqlFlexibleServerConfigurationSource(SystemDefaultValue);
        /// <summary> user-override. </summary>
        public static MySqlFlexibleServerConfigurationSource UserOverride { get; } = new MySqlFlexibleServerConfigurationSource(UserOverrideValue);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerConfigurationSource"/> values are the same. </summary>
        public static bool operator ==(MySqlFlexibleServerConfigurationSource left, MySqlFlexibleServerConfigurationSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerConfigurationSource"/> values are not the same. </summary>
        public static bool operator !=(MySqlFlexibleServerConfigurationSource left, MySqlFlexibleServerConfigurationSource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MySqlFlexibleServerConfigurationSource"/>. </summary>
        public static implicit operator MySqlFlexibleServerConfigurationSource(string value) => new MySqlFlexibleServerConfigurationSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlFlexibleServerConfigurationSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlFlexibleServerConfigurationSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
