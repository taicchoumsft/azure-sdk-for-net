// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The provisioning state. </summary>
    public readonly partial struct PlacementPolicyProvisioningState : IEquatable<PlacementPolicyProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PlacementPolicyProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PlacementPolicyProvisioningState(string value)
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
        public static PlacementPolicyProvisioningState Succeeded { get; } = new PlacementPolicyProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static PlacementPolicyProvisioningState Failed { get; } = new PlacementPolicyProvisioningState(FailedValue);
        /// <summary> Building. </summary>
        public static PlacementPolicyProvisioningState Building { get; } = new PlacementPolicyProvisioningState(BuildingValue);
        /// <summary> Deleting. </summary>
        public static PlacementPolicyProvisioningState Deleting { get; } = new PlacementPolicyProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static PlacementPolicyProvisioningState Updating { get; } = new PlacementPolicyProvisioningState(UpdatingValue);
        /// <summary> Canceled. </summary>
        public static PlacementPolicyProvisioningState Canceled { get; } = new PlacementPolicyProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="PlacementPolicyProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PlacementPolicyProvisioningState left, PlacementPolicyProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PlacementPolicyProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PlacementPolicyProvisioningState left, PlacementPolicyProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PlacementPolicyProvisioningState"/>. </summary>
        public static implicit operator PlacementPolicyProvisioningState(string value) => new PlacementPolicyProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PlacementPolicyProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PlacementPolicyProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
