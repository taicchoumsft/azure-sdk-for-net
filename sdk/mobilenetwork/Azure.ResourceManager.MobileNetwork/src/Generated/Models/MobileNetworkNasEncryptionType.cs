// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// The supported NAS Encryption types.
    /// Serialized Name: NasEncryptionType
    /// </summary>
    public readonly partial struct MobileNetworkNasEncryptionType : IEquatable<MobileNetworkNasEncryptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkNasEncryptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkNasEncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NEA0EEA0Value = "NEA0/EEA0";
        private const string NEA1EEA1Value = "NEA1/EEA1";
        private const string NEA2EEA2Value = "NEA2/EEA2";

        /// <summary>
        /// NAS signaling is not encrypted.
        /// Serialized Name: NasEncryptionType.NEA0/EEA0
        /// </summary>
        public static MobileNetworkNasEncryptionType NEA0EEA0 { get; } = new MobileNetworkNasEncryptionType(NEA0EEA0Value);
        /// <summary>
        /// NAS signaling is encrypted with SNOW 3G cipher.
        /// Serialized Name: NasEncryptionType.NEA1/EEA1
        /// </summary>
        public static MobileNetworkNasEncryptionType NEA1EEA1 { get; } = new MobileNetworkNasEncryptionType(NEA1EEA1Value);
        /// <summary>
        ///  NAS signaling is encrypted with AES cipher.
        /// Serialized Name: NasEncryptionType.NEA2/EEA2
        /// </summary>
        public static MobileNetworkNasEncryptionType NEA2EEA2 { get; } = new MobileNetworkNasEncryptionType(NEA2EEA2Value);
        /// <summary> Determines if two <see cref="MobileNetworkNasEncryptionType"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkNasEncryptionType left, MobileNetworkNasEncryptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkNasEncryptionType"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkNasEncryptionType left, MobileNetworkNasEncryptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MobileNetworkNasEncryptionType"/>. </summary>
        public static implicit operator MobileNetworkNasEncryptionType(string value) => new MobileNetworkNasEncryptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkNasEncryptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkNasEncryptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
