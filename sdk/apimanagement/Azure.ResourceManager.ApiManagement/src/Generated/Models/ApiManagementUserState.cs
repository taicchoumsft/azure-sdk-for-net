// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active. </summary>
    public readonly partial struct ApiManagementUserState : IEquatable<ApiManagementUserState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiManagementUserState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiManagementUserState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "active";
        private const string BlockedValue = "blocked";
        private const string PendingValue = "pending";
        private const string DeletedValue = "deleted";

        /// <summary> User state is active. </summary>
        public static ApiManagementUserState Active { get; } = new ApiManagementUserState(ActiveValue);
        /// <summary> User is blocked. Blocked users cannot authenticate at developer portal or call API. </summary>
        public static ApiManagementUserState Blocked { get; } = new ApiManagementUserState(BlockedValue);
        /// <summary> User account is pending. Requires identity confirmation before it can be made active. </summary>
        public static ApiManagementUserState Pending { get; } = new ApiManagementUserState(PendingValue);
        /// <summary> User account is closed. All identities and related entities are removed. </summary>
        public static ApiManagementUserState Deleted { get; } = new ApiManagementUserState(DeletedValue);
        /// <summary> Determines if two <see cref="ApiManagementUserState"/> values are the same. </summary>
        public static bool operator ==(ApiManagementUserState left, ApiManagementUserState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiManagementUserState"/> values are not the same. </summary>
        public static bool operator !=(ApiManagementUserState left, ApiManagementUserState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApiManagementUserState"/>. </summary>
        public static implicit operator ApiManagementUserState(string value) => new ApiManagementUserState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiManagementUserState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiManagementUserState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
