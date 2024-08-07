// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Provisioning state of the KPack build result. </summary>
    public readonly partial struct AppPlatformBuildProvisioningState : IEquatable<AppPlatformBuildProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformBuildProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static AppPlatformBuildProvisioningState Creating { get; } = new AppPlatformBuildProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static AppPlatformBuildProvisioningState Updating { get; } = new AppPlatformBuildProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static AppPlatformBuildProvisioningState Succeeded { get; } = new AppPlatformBuildProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AppPlatformBuildProvisioningState Failed { get; } = new AppPlatformBuildProvisioningState(FailedValue);
        /// <summary> Deleting. </summary>
        public static AppPlatformBuildProvisioningState Deleting { get; } = new AppPlatformBuildProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="AppPlatformBuildProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AppPlatformBuildProvisioningState left, AppPlatformBuildProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformBuildProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformBuildProvisioningState left, AppPlatformBuildProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppPlatformBuildProvisioningState"/>. </summary>
        public static implicit operator AppPlatformBuildProvisioningState(string value) => new AppPlatformBuildProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformBuildProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformBuildProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
