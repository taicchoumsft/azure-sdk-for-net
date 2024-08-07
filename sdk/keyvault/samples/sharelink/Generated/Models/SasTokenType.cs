// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The type of SAS token the SAS definition will create. </summary>
    public readonly partial struct SasTokenType : IEquatable<SasTokenType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SasTokenType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SasTokenType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountValue = "account";
        private const string ServiceValue = "service";

        /// <summary> account. </summary>
        public static SasTokenType Account { get; } = new SasTokenType(AccountValue);
        /// <summary> service. </summary>
        public static SasTokenType Service { get; } = new SasTokenType(ServiceValue);
        /// <summary> Determines if two <see cref="SasTokenType"/> values are the same. </summary>
        public static bool operator ==(SasTokenType left, SasTokenType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SasTokenType"/> values are not the same. </summary>
        public static bool operator !=(SasTokenType left, SasTokenType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SasTokenType"/>. </summary>
        public static implicit operator SasTokenType(string value) => new SasTokenType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SasTokenType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SasTokenType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
