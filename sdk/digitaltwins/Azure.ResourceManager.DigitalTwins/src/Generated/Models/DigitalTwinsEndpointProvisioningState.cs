// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The provisioning state. </summary>
    public readonly partial struct DigitalTwinsEndpointProvisioningState : IEquatable<DigitalTwinsEndpointProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEndpointProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DigitalTwinsEndpointProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProvisioningValue = "Provisioning";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletedValue = "Deleted";
        private const string WarningValue = "Warning";
        private const string SuspendingValue = "Suspending";
        private const string RestoringValue = "Restoring";
        private const string MovingValue = "Moving";
        private const string DisabledValue = "Disabled";

        /// <summary> Provisioning. </summary>
        public static DigitalTwinsEndpointProvisioningState Provisioning { get; } = new DigitalTwinsEndpointProvisioningState(ProvisioningValue);
        /// <summary> Deleting. </summary>
        public static DigitalTwinsEndpointProvisioningState Deleting { get; } = new DigitalTwinsEndpointProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static DigitalTwinsEndpointProvisioningState Updating { get; } = new DigitalTwinsEndpointProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static DigitalTwinsEndpointProvisioningState Succeeded { get; } = new DigitalTwinsEndpointProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DigitalTwinsEndpointProvisioningState Failed { get; } = new DigitalTwinsEndpointProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static DigitalTwinsEndpointProvisioningState Canceled { get; } = new DigitalTwinsEndpointProvisioningState(CanceledValue);
        /// <summary> Deleted. </summary>
        public static DigitalTwinsEndpointProvisioningState Deleted { get; } = new DigitalTwinsEndpointProvisioningState(DeletedValue);
        /// <summary> Warning. </summary>
        public static DigitalTwinsEndpointProvisioningState Warning { get; } = new DigitalTwinsEndpointProvisioningState(WarningValue);
        /// <summary> Suspending. </summary>
        public static DigitalTwinsEndpointProvisioningState Suspending { get; } = new DigitalTwinsEndpointProvisioningState(SuspendingValue);
        /// <summary> Restoring. </summary>
        public static DigitalTwinsEndpointProvisioningState Restoring { get; } = new DigitalTwinsEndpointProvisioningState(RestoringValue);
        /// <summary> Moving. </summary>
        public static DigitalTwinsEndpointProvisioningState Moving { get; } = new DigitalTwinsEndpointProvisioningState(MovingValue);
        /// <summary> Disabled. </summary>
        public static DigitalTwinsEndpointProvisioningState Disabled { get; } = new DigitalTwinsEndpointProvisioningState(DisabledValue);
        /// <summary> Determines if two <see cref="DigitalTwinsEndpointProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DigitalTwinsEndpointProvisioningState left, DigitalTwinsEndpointProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DigitalTwinsEndpointProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DigitalTwinsEndpointProvisioningState left, DigitalTwinsEndpointProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DigitalTwinsEndpointProvisioningState"/>. </summary>
        public static implicit operator DigitalTwinsEndpointProvisioningState(string value) => new DigitalTwinsEndpointProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DigitalTwinsEndpointProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DigitalTwinsEndpointProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
