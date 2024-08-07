// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Provisioning status of the profile. </summary>
    public readonly partial struct ProfileProvisioningState : IEquatable<ProfileProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProfileProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProfileProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string CreatingValue = "Creating";

        /// <summary> Succeeded. </summary>
        public static ProfileProvisioningState Succeeded { get; } = new ProfileProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ProfileProvisioningState Failed { get; } = new ProfileProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static ProfileProvisioningState Updating { get; } = new ProfileProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static ProfileProvisioningState Deleting { get; } = new ProfileProvisioningState(DeletingValue);
        /// <summary> Creating. </summary>
        public static ProfileProvisioningState Creating { get; } = new ProfileProvisioningState(CreatingValue);
        /// <summary> Determines if two <see cref="ProfileProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ProfileProvisioningState left, ProfileProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProfileProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ProfileProvisioningState left, ProfileProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProfileProvisioningState"/>. </summary>
        public static implicit operator ProfileProvisioningState(string value) => new ProfileProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProfileProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProfileProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
