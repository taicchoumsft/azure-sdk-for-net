// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The provisioning state. </summary>
    public readonly partial struct WorkloadNetworkDnsZoneProvisioningState : IEquatable<WorkloadNetworkDnsZoneProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDnsZoneProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkloadNetworkDnsZoneProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string BuildingValue = "Building";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static WorkloadNetworkDnsZoneProvisioningState Succeeded { get; } = new WorkloadNetworkDnsZoneProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static WorkloadNetworkDnsZoneProvisioningState Failed { get; } = new WorkloadNetworkDnsZoneProvisioningState(FailedValue);
        /// <summary> Building. </summary>
        public static WorkloadNetworkDnsZoneProvisioningState Building { get; } = new WorkloadNetworkDnsZoneProvisioningState(BuildingValue);
        /// <summary> Deleting. </summary>
        public static WorkloadNetworkDnsZoneProvisioningState Deleting { get; } = new WorkloadNetworkDnsZoneProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static WorkloadNetworkDnsZoneProvisioningState Updating { get; } = new WorkloadNetworkDnsZoneProvisioningState(UpdatingValue);
        /// <summary> Canceled. </summary>
        public static WorkloadNetworkDnsZoneProvisioningState Canceled { get; } = new WorkloadNetworkDnsZoneProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="WorkloadNetworkDnsZoneProvisioningState"/> values are the same. </summary>
        public static bool operator ==(WorkloadNetworkDnsZoneProvisioningState left, WorkloadNetworkDnsZoneProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkloadNetworkDnsZoneProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(WorkloadNetworkDnsZoneProvisioningState left, WorkloadNetworkDnsZoneProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WorkloadNetworkDnsZoneProvisioningState"/>. </summary>
        public static implicit operator WorkloadNetworkDnsZoneProvisioningState(string value) => new WorkloadNetworkDnsZoneProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkloadNetworkDnsZoneProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkloadNetworkDnsZoneProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
