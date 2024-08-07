// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The SecurityTransportProtocol. </summary>
    public readonly partial struct SecurityTransportProtocol : IEquatable<SecurityTransportProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityTransportProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityTransportProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "TCP";
        private const string UdpValue = "UDP";

        /// <summary> TCP. </summary>
        public static SecurityTransportProtocol Tcp { get; } = new SecurityTransportProtocol(TcpValue);
        /// <summary> UDP. </summary>
        public static SecurityTransportProtocol Udp { get; } = new SecurityTransportProtocol(UdpValue);
        /// <summary> Determines if two <see cref="SecurityTransportProtocol"/> values are the same. </summary>
        public static bool operator ==(SecurityTransportProtocol left, SecurityTransportProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityTransportProtocol"/> values are not the same. </summary>
        public static bool operator !=(SecurityTransportProtocol left, SecurityTransportProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityTransportProtocol"/>. </summary>
        public static implicit operator SecurityTransportProtocol(string value) => new SecurityTransportProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityTransportProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityTransportProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
