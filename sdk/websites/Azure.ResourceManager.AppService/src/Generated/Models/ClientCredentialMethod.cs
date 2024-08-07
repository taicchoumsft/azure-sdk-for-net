// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The method that should be used to authenticate the user. </summary>
    public readonly partial struct ClientCredentialMethod : IEquatable<ClientCredentialMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClientCredentialMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClientCredentialMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClientSecretPostValue = "ClientSecretPost";

        /// <summary> ClientSecretPost. </summary>
        public static ClientCredentialMethod ClientSecretPost { get; } = new ClientCredentialMethod(ClientSecretPostValue);
        /// <summary> Determines if two <see cref="ClientCredentialMethod"/> values are the same. </summary>
        public static bool operator ==(ClientCredentialMethod left, ClientCredentialMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClientCredentialMethod"/> values are not the same. </summary>
        public static bool operator !=(ClientCredentialMethod left, ClientCredentialMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClientCredentialMethod"/>. </summary>
        public static implicit operator ClientCredentialMethod(string value) => new ClientCredentialMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClientCredentialMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClientCredentialMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
