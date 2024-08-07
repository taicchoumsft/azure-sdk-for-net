// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Provisioning status of the origin group. </summary>
    public readonly partial struct OriginGroupProvisioningState : IEquatable<OriginGroupProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OriginGroupProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OriginGroupProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string CreatingValue = "Creating";

        /// <summary> Succeeded. </summary>
        public static OriginGroupProvisioningState Succeeded { get; } = new OriginGroupProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static OriginGroupProvisioningState Failed { get; } = new OriginGroupProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static OriginGroupProvisioningState Updating { get; } = new OriginGroupProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static OriginGroupProvisioningState Deleting { get; } = new OriginGroupProvisioningState(DeletingValue);
        /// <summary> Creating. </summary>
        public static OriginGroupProvisioningState Creating { get; } = new OriginGroupProvisioningState(CreatingValue);
        /// <summary> Determines if two <see cref="OriginGroupProvisioningState"/> values are the same. </summary>
        public static bool operator ==(OriginGroupProvisioningState left, OriginGroupProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OriginGroupProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(OriginGroupProvisioningState left, OriginGroupProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OriginGroupProvisioningState"/>. </summary>
        public static implicit operator OriginGroupProvisioningState(string value) => new OriginGroupProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OriginGroupProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OriginGroupProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
