// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The minimum TLS version required from the clients to establish an SSL handshake with Front Door. </summary>
    public readonly partial struct FrontDoorRequiredMinimumTlsVersion : IEquatable<FrontDoorRequiredMinimumTlsVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorRequiredMinimumTlsVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorRequiredMinimumTlsVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Tls1_0Value = "1.0";
        private const string Tls1_2Value = "1.2";
        /// <summary> Determines if two <see cref="FrontDoorRequiredMinimumTlsVersion"/> values are the same. </summary>
        public static bool operator ==(FrontDoorRequiredMinimumTlsVersion left, FrontDoorRequiredMinimumTlsVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorRequiredMinimumTlsVersion"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorRequiredMinimumTlsVersion left, FrontDoorRequiredMinimumTlsVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FrontDoorRequiredMinimumTlsVersion"/>. </summary>
        public static implicit operator FrontDoorRequiredMinimumTlsVersion(string value) => new FrontDoorRequiredMinimumTlsVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorRequiredMinimumTlsVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorRequiredMinimumTlsVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
