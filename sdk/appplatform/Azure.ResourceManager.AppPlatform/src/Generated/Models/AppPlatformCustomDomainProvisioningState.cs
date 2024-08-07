// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Provisioning state of the Domain. </summary>
    public readonly partial struct AppPlatformCustomDomainProvisioningState : IEquatable<AppPlatformCustomDomainProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformCustomDomainProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformCustomDomainProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static AppPlatformCustomDomainProvisioningState Creating { get; } = new AppPlatformCustomDomainProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static AppPlatformCustomDomainProvisioningState Updating { get; } = new AppPlatformCustomDomainProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static AppPlatformCustomDomainProvisioningState Succeeded { get; } = new AppPlatformCustomDomainProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AppPlatformCustomDomainProvisioningState Failed { get; } = new AppPlatformCustomDomainProvisioningState(FailedValue);
        /// <summary> Deleting. </summary>
        public static AppPlatformCustomDomainProvisioningState Deleting { get; } = new AppPlatformCustomDomainProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="AppPlatformCustomDomainProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AppPlatformCustomDomainProvisioningState left, AppPlatformCustomDomainProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformCustomDomainProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformCustomDomainProvisioningState left, AppPlatformCustomDomainProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppPlatformCustomDomainProvisioningState"/>. </summary>
        public static implicit operator AppPlatformCustomDomainProvisioningState(string value) => new AppPlatformCustomDomainProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformCustomDomainProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformCustomDomainProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
