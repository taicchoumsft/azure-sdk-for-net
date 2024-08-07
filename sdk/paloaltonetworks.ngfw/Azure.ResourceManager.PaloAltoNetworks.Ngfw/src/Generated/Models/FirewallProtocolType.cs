// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Protocol Enum. </summary>
    public readonly partial struct FirewallProtocolType : IEquatable<FirewallProtocolType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FirewallProtocolType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirewallProtocolType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "TCP";
        private const string UdpValue = "UDP";

        /// <summary> TCP. </summary>
        public static FirewallProtocolType Tcp { get; } = new FirewallProtocolType(TcpValue);
        /// <summary> UDP. </summary>
        public static FirewallProtocolType Udp { get; } = new FirewallProtocolType(UdpValue);
        /// <summary> Determines if two <see cref="FirewallProtocolType"/> values are the same. </summary>
        public static bool operator ==(FirewallProtocolType left, FirewallProtocolType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallProtocolType"/> values are not the same. </summary>
        public static bool operator !=(FirewallProtocolType left, FirewallProtocolType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallProtocolType"/>. </summary>
        public static implicit operator FirewallProtocolType(string value) => new FirewallProtocolType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallProtocolType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallProtocolType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
