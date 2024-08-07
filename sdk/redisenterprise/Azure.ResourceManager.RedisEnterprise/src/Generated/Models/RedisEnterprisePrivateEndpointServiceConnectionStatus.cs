// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct RedisEnterprisePrivateEndpointServiceConnectionStatus : IEquatable<RedisEnterprisePrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisEnterprisePrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisEnterprisePrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static RedisEnterprisePrivateEndpointServiceConnectionStatus Pending { get; } = new RedisEnterprisePrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static RedisEnterprisePrivateEndpointServiceConnectionStatus Approved { get; } = new RedisEnterprisePrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static RedisEnterprisePrivateEndpointServiceConnectionStatus Rejected { get; } = new RedisEnterprisePrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="RedisEnterprisePrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(RedisEnterprisePrivateEndpointServiceConnectionStatus left, RedisEnterprisePrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisEnterprisePrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(RedisEnterprisePrivateEndpointServiceConnectionStatus left, RedisEnterprisePrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RedisEnterprisePrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator RedisEnterprisePrivateEndpointServiceConnectionStatus(string value) => new RedisEnterprisePrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisEnterprisePrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisEnterprisePrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
