// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> State of the private endpoint connection. </summary>
    public readonly partial struct SqlPrivateEndpointProvisioningState : IEquatable<SqlPrivateEndpointProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlPrivateEndpointProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlPrivateEndpointProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApprovingValue = "Approving";
        private const string ReadyValue = "Ready";
        private const string DroppingValue = "Dropping";
        private const string FailedValue = "Failed";
        private const string RejectingValue = "Rejecting";

        /// <summary> Approving. </summary>
        public static SqlPrivateEndpointProvisioningState Approving { get; } = new SqlPrivateEndpointProvisioningState(ApprovingValue);
        /// <summary> Ready. </summary>
        public static SqlPrivateEndpointProvisioningState Ready { get; } = new SqlPrivateEndpointProvisioningState(ReadyValue);
        /// <summary> Dropping. </summary>
        public static SqlPrivateEndpointProvisioningState Dropping { get; } = new SqlPrivateEndpointProvisioningState(DroppingValue);
        /// <summary> Failed. </summary>
        public static SqlPrivateEndpointProvisioningState Failed { get; } = new SqlPrivateEndpointProvisioningState(FailedValue);
        /// <summary> Rejecting. </summary>
        public static SqlPrivateEndpointProvisioningState Rejecting { get; } = new SqlPrivateEndpointProvisioningState(RejectingValue);
        /// <summary> Determines if two <see cref="SqlPrivateEndpointProvisioningState"/> values are the same. </summary>
        public static bool operator ==(SqlPrivateEndpointProvisioningState left, SqlPrivateEndpointProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlPrivateEndpointProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(SqlPrivateEndpointProvisioningState left, SqlPrivateEndpointProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlPrivateEndpointProvisioningState"/>. </summary>
        public static implicit operator SqlPrivateEndpointProvisioningState(string value) => new SqlPrivateEndpointProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlPrivateEndpointProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlPrivateEndpointProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
