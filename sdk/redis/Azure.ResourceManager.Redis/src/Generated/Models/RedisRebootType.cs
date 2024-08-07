// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Which Redis node(s) to reboot. Depending on this value data loss is possible. </summary>
    public readonly partial struct RedisRebootType : IEquatable<RedisRebootType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisRebootType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisRebootType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryNodeValue = "PrimaryNode";
        private const string SecondaryNodeValue = "SecondaryNode";
        private const string AllNodesValue = "AllNodes";

        /// <summary> PrimaryNode. </summary>
        public static RedisRebootType PrimaryNode { get; } = new RedisRebootType(PrimaryNodeValue);
        /// <summary> SecondaryNode. </summary>
        public static RedisRebootType SecondaryNode { get; } = new RedisRebootType(SecondaryNodeValue);
        /// <summary> AllNodes. </summary>
        public static RedisRebootType AllNodes { get; } = new RedisRebootType(AllNodesValue);
        /// <summary> Determines if two <see cref="RedisRebootType"/> values are the same. </summary>
        public static bool operator ==(RedisRebootType left, RedisRebootType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisRebootType"/> values are not the same. </summary>
        public static bool operator !=(RedisRebootType left, RedisRebootType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RedisRebootType"/>. </summary>
        public static implicit operator RedisRebootType(string value) => new RedisRebootType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisRebootType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisRebootType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
