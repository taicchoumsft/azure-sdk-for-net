// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> This setting determines how the cache gets username and group names for clients. </summary>
    public readonly partial struct StorageCacheUsernameSourceType : IEquatable<StorageCacheUsernameSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageCacheUsernameSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageCacheUsernameSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ADValue = "AD";
        private const string LdapValue = "LDAP";
        private const string FileValue = "File";
        private const string NoneValue = "None";

        /// <summary> AD. </summary>
        public static StorageCacheUsernameSourceType AD { get; } = new StorageCacheUsernameSourceType(ADValue);
        /// <summary> LDAP. </summary>
        public static StorageCacheUsernameSourceType Ldap { get; } = new StorageCacheUsernameSourceType(LdapValue);
        /// <summary> File. </summary>
        public static StorageCacheUsernameSourceType File { get; } = new StorageCacheUsernameSourceType(FileValue);
        /// <summary> None. </summary>
        public static StorageCacheUsernameSourceType None { get; } = new StorageCacheUsernameSourceType(NoneValue);
        /// <summary> Determines if two <see cref="StorageCacheUsernameSourceType"/> values are the same. </summary>
        public static bool operator ==(StorageCacheUsernameSourceType left, StorageCacheUsernameSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageCacheUsernameSourceType"/> values are not the same. </summary>
        public static bool operator !=(StorageCacheUsernameSourceType left, StorageCacheUsernameSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageCacheUsernameSourceType"/>. </summary>
        public static implicit operator StorageCacheUsernameSourceType(string value) => new StorageCacheUsernameSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageCacheUsernameSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageCacheUsernameSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
