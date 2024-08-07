// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The storage account type for the database's backups. </summary>
    public readonly partial struct StorageCapabilityStorageAccountType : IEquatable<StorageCapabilityStorageAccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageCapabilityStorageAccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageCapabilityStorageAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GrsValue = "GRS";
        private const string LrsValue = "LRS";
        private const string ZrsValue = "ZRS";

        /// <summary> GRS. </summary>
        public static StorageCapabilityStorageAccountType Grs { get; } = new StorageCapabilityStorageAccountType(GrsValue);
        /// <summary> LRS. </summary>
        public static StorageCapabilityStorageAccountType Lrs { get; } = new StorageCapabilityStorageAccountType(LrsValue);
        /// <summary> ZRS. </summary>
        public static StorageCapabilityStorageAccountType Zrs { get; } = new StorageCapabilityStorageAccountType(ZrsValue);
        /// <summary> Determines if two <see cref="StorageCapabilityStorageAccountType"/> values are the same. </summary>
        public static bool operator ==(StorageCapabilityStorageAccountType left, StorageCapabilityStorageAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageCapabilityStorageAccountType"/> values are not the same. </summary>
        public static bool operator !=(StorageCapabilityStorageAccountType left, StorageCapabilityStorageAccountType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageCapabilityStorageAccountType"/>. </summary>
        public static implicit operator StorageCapabilityStorageAccountType(string value) => new StorageCapabilityStorageAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageCapabilityStorageAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageCapabilityStorageAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
