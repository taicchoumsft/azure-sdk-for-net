// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The provisioning state. </summary>
    public readonly partial struct TimeSeriesDatabaseConnectionState : IEquatable<TimeSeriesDatabaseConnectionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TimeSeriesDatabaseConnectionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TimeSeriesDatabaseConnectionState(string value)
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
        public static TimeSeriesDatabaseConnectionState Provisioning { get; } = new TimeSeriesDatabaseConnectionState(ProvisioningValue);
        /// <summary> Deleting. </summary>
        public static TimeSeriesDatabaseConnectionState Deleting { get; } = new TimeSeriesDatabaseConnectionState(DeletingValue);
        /// <summary> Updating. </summary>
        public static TimeSeriesDatabaseConnectionState Updating { get; } = new TimeSeriesDatabaseConnectionState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static TimeSeriesDatabaseConnectionState Succeeded { get; } = new TimeSeriesDatabaseConnectionState(SucceededValue);
        /// <summary> Failed. </summary>
        public static TimeSeriesDatabaseConnectionState Failed { get; } = new TimeSeriesDatabaseConnectionState(FailedValue);
        /// <summary> Canceled. </summary>
        public static TimeSeriesDatabaseConnectionState Canceled { get; } = new TimeSeriesDatabaseConnectionState(CanceledValue);
        /// <summary> Deleted. </summary>
        public static TimeSeriesDatabaseConnectionState Deleted { get; } = new TimeSeriesDatabaseConnectionState(DeletedValue);
        /// <summary> Warning. </summary>
        public static TimeSeriesDatabaseConnectionState Warning { get; } = new TimeSeriesDatabaseConnectionState(WarningValue);
        /// <summary> Suspending. </summary>
        public static TimeSeriesDatabaseConnectionState Suspending { get; } = new TimeSeriesDatabaseConnectionState(SuspendingValue);
        /// <summary> Restoring. </summary>
        public static TimeSeriesDatabaseConnectionState Restoring { get; } = new TimeSeriesDatabaseConnectionState(RestoringValue);
        /// <summary> Moving. </summary>
        public static TimeSeriesDatabaseConnectionState Moving { get; } = new TimeSeriesDatabaseConnectionState(MovingValue);
        /// <summary> Disabled. </summary>
        public static TimeSeriesDatabaseConnectionState Disabled { get; } = new TimeSeriesDatabaseConnectionState(DisabledValue);
        /// <summary> Determines if two <see cref="TimeSeriesDatabaseConnectionState"/> values are the same. </summary>
        public static bool operator ==(TimeSeriesDatabaseConnectionState left, TimeSeriesDatabaseConnectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TimeSeriesDatabaseConnectionState"/> values are not the same. </summary>
        public static bool operator !=(TimeSeriesDatabaseConnectionState left, TimeSeriesDatabaseConnectionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TimeSeriesDatabaseConnectionState"/>. </summary>
        public static implicit operator TimeSeriesDatabaseConnectionState(string value) => new TimeSeriesDatabaseConnectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TimeSeriesDatabaseConnectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TimeSeriesDatabaseConnectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
