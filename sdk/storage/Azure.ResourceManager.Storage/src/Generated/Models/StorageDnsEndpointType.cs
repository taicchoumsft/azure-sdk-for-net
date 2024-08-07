// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an alphanumeric DNS Zone identifier. </summary>
    public readonly partial struct StorageDnsEndpointType : IEquatable<StorageDnsEndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageDnsEndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageDnsEndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string AzureDnsZoneValue = "AzureDnsZone";

        /// <summary> Standard. </summary>
        public static StorageDnsEndpointType Standard { get; } = new StorageDnsEndpointType(StandardValue);
        /// <summary> AzureDnsZone. </summary>
        public static StorageDnsEndpointType AzureDnsZone { get; } = new StorageDnsEndpointType(AzureDnsZoneValue);
        /// <summary> Determines if two <see cref="StorageDnsEndpointType"/> values are the same. </summary>
        public static bool operator ==(StorageDnsEndpointType left, StorageDnsEndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageDnsEndpointType"/> values are not the same. </summary>
        public static bool operator !=(StorageDnsEndpointType left, StorageDnsEndpointType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageDnsEndpointType"/>. </summary>
        public static implicit operator StorageDnsEndpointType(string value) => new StorageDnsEndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageDnsEndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageDnsEndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
