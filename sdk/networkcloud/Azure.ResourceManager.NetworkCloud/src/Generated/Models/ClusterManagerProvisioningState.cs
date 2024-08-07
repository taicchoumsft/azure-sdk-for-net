// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The provisioning state of the cluster manager. </summary>
    public readonly partial struct ClusterManagerProvisioningState : IEquatable<ClusterManagerProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterManagerProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterManagerProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ProvisioningValue = "Provisioning";
        private const string AcceptedValue = "Accepted";
        private const string UpdatingValue = "Updating";

        /// <summary> Succeeded. </summary>
        public static ClusterManagerProvisioningState Succeeded { get; } = new ClusterManagerProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ClusterManagerProvisioningState Failed { get; } = new ClusterManagerProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ClusterManagerProvisioningState Canceled { get; } = new ClusterManagerProvisioningState(CanceledValue);
        /// <summary> Provisioning. </summary>
        public static ClusterManagerProvisioningState Provisioning { get; } = new ClusterManagerProvisioningState(ProvisioningValue);
        /// <summary> Accepted. </summary>
        public static ClusterManagerProvisioningState Accepted { get; } = new ClusterManagerProvisioningState(AcceptedValue);
        /// <summary> Updating. </summary>
        public static ClusterManagerProvisioningState Updating { get; } = new ClusterManagerProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="ClusterManagerProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ClusterManagerProvisioningState left, ClusterManagerProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterManagerProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ClusterManagerProvisioningState left, ClusterManagerProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterManagerProvisioningState"/>. </summary>
        public static implicit operator ClusterManagerProvisioningState(string value) => new ClusterManagerProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterManagerProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterManagerProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
