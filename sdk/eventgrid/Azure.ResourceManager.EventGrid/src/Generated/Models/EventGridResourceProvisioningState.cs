// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the Private Endpoint Connection. </summary>
    public readonly partial struct EventGridResourceProvisioningState : IEquatable<EventGridResourceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridResourceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridResourceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static EventGridResourceProvisioningState Creating { get; } = new EventGridResourceProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static EventGridResourceProvisioningState Updating { get; } = new EventGridResourceProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static EventGridResourceProvisioningState Deleting { get; } = new EventGridResourceProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static EventGridResourceProvisioningState Succeeded { get; } = new EventGridResourceProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static EventGridResourceProvisioningState Canceled { get; } = new EventGridResourceProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static EventGridResourceProvisioningState Failed { get; } = new EventGridResourceProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="EventGridResourceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(EventGridResourceProvisioningState left, EventGridResourceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridResourceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(EventGridResourceProvisioningState left, EventGridResourceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventGridResourceProvisioningState"/>. </summary>
        public static implicit operator EventGridResourceProvisioningState(string value) => new EventGridResourceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridResourceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridResourceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
