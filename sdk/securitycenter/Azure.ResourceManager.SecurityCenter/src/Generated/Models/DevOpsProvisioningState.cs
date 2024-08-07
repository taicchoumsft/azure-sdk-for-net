// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// The provisioning state of the resource.
    ///
    /// Pending - Provisioning pending.
    /// Failed - Provisioning failed.
    /// Succeeded - Successful provisioning.
    /// Canceled - Provisioning canceled.
    /// PendingDeletion - Deletion pending.
    /// DeletionSuccess - Deletion successful.
    /// DeletionFailure - Deletion failure.
    /// </summary>
    public readonly partial struct DevOpsProvisioningState : IEquatable<DevOpsProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevOpsProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevOpsProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string PendingValue = "Pending";
        private const string PendingDeletionValue = "PendingDeletion";
        private const string DeletionSuccessValue = "DeletionSuccess";
        private const string DeletionFailureValue = "DeletionFailure";

        /// <summary> Succeeded. </summary>
        public static DevOpsProvisioningState Succeeded { get; } = new DevOpsProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DevOpsProvisioningState Failed { get; } = new DevOpsProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static DevOpsProvisioningState Canceled { get; } = new DevOpsProvisioningState(CanceledValue);
        /// <summary> Pending. </summary>
        public static DevOpsProvisioningState Pending { get; } = new DevOpsProvisioningState(PendingValue);
        /// <summary> PendingDeletion. </summary>
        public static DevOpsProvisioningState PendingDeletion { get; } = new DevOpsProvisioningState(PendingDeletionValue);
        /// <summary> DeletionSuccess. </summary>
        public static DevOpsProvisioningState DeletionSuccess { get; } = new DevOpsProvisioningState(DeletionSuccessValue);
        /// <summary> DeletionFailure. </summary>
        public static DevOpsProvisioningState DeletionFailure { get; } = new DevOpsProvisioningState(DeletionFailureValue);
        /// <summary> Determines if two <see cref="DevOpsProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DevOpsProvisioningState left, DevOpsProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevOpsProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DevOpsProvisioningState left, DevOpsProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevOpsProvisioningState"/>. </summary>
        public static implicit operator DevOpsProvisioningState(string value) => new DevOpsProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevOpsProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevOpsProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
