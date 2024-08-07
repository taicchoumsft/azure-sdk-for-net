// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> State of the Spring Cloud Gateway. </summary>
    public readonly partial struct AppPlatformGatewayProvisioningState : IEquatable<AppPlatformGatewayProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformGatewayProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static AppPlatformGatewayProvisioningState Creating { get; } = new AppPlatformGatewayProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static AppPlatformGatewayProvisioningState Updating { get; } = new AppPlatformGatewayProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static AppPlatformGatewayProvisioningState Succeeded { get; } = new AppPlatformGatewayProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AppPlatformGatewayProvisioningState Failed { get; } = new AppPlatformGatewayProvisioningState(FailedValue);
        /// <summary> Deleting. </summary>
        public static AppPlatformGatewayProvisioningState Deleting { get; } = new AppPlatformGatewayProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="AppPlatformGatewayProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AppPlatformGatewayProvisioningState left, AppPlatformGatewayProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformGatewayProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformGatewayProvisioningState left, AppPlatformGatewayProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppPlatformGatewayProvisioningState"/>. </summary>
        public static implicit operator AppPlatformGatewayProvisioningState(string value) => new AppPlatformGatewayProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformGatewayProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformGatewayProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
