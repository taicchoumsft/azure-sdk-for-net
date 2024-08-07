// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The principal type of the assigned principal ID. </summary>
    public readonly partial struct RoleManagementPrincipalType : IEquatable<RoleManagementPrincipalType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleManagementPrincipalType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleManagementPrincipalType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "User";
        private const string GroupValue = "Group";
        private const string ServicePrincipalValue = "ServicePrincipal";
        private const string ForeignGroupValue = "ForeignGroup";
        private const string DeviceValue = "Device";

        /// <summary> User. </summary>
        public static RoleManagementPrincipalType User { get; } = new RoleManagementPrincipalType(UserValue);
        /// <summary> Group. </summary>
        public static RoleManagementPrincipalType Group { get; } = new RoleManagementPrincipalType(GroupValue);
        /// <summary> ServicePrincipal. </summary>
        public static RoleManagementPrincipalType ServicePrincipal { get; } = new RoleManagementPrincipalType(ServicePrincipalValue);
        /// <summary> ForeignGroup. </summary>
        public static RoleManagementPrincipalType ForeignGroup { get; } = new RoleManagementPrincipalType(ForeignGroupValue);
        /// <summary> Device. </summary>
        public static RoleManagementPrincipalType Device { get; } = new RoleManagementPrincipalType(DeviceValue);
        /// <summary> Determines if two <see cref="RoleManagementPrincipalType"/> values are the same. </summary>
        public static bool operator ==(RoleManagementPrincipalType left, RoleManagementPrincipalType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleManagementPrincipalType"/> values are not the same. </summary>
        public static bool operator !=(RoleManagementPrincipalType left, RoleManagementPrincipalType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoleManagementPrincipalType"/>. </summary>
        public static implicit operator RoleManagementPrincipalType(string value) => new RoleManagementPrincipalType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleManagementPrincipalType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleManagementPrincipalType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
