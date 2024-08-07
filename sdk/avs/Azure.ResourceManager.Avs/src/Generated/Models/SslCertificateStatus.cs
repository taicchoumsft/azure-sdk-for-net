// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Protect LDAP communication using SSL certificate (LDAPS). </summary>
    public readonly partial struct SslCertificateStatus : IEquatable<SslCertificateStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SslCertificateStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SslCertificateStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static SslCertificateStatus Enabled { get; } = new SslCertificateStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static SslCertificateStatus Disabled { get; } = new SslCertificateStatus(DisabledValue);
        /// <summary> Determines if two <see cref="SslCertificateStatus"/> values are the same. </summary>
        public static bool operator ==(SslCertificateStatus left, SslCertificateStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SslCertificateStatus"/> values are not the same. </summary>
        public static bool operator !=(SslCertificateStatus left, SslCertificateStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SslCertificateStatus"/>. </summary>
        public static implicit operator SslCertificateStatus(string value) => new SslCertificateStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SslCertificateStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SslCertificateStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
