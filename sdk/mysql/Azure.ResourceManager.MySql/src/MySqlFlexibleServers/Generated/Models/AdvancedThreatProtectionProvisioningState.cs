// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct AdvancedThreatProtectionProvisioningState : IEquatable<AdvancedThreatProtectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AdvancedThreatProtectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AdvancedThreatProtectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string UpdatingValue = "Updating";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static AdvancedThreatProtectionProvisioningState Succeeded { get; } = new AdvancedThreatProtectionProvisioningState(SucceededValue);
        /// <summary> Updating. </summary>
        public static AdvancedThreatProtectionProvisioningState Updating { get; } = new AdvancedThreatProtectionProvisioningState(UpdatingValue);
        /// <summary> Canceled. </summary>
        public static AdvancedThreatProtectionProvisioningState Canceled { get; } = new AdvancedThreatProtectionProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static AdvancedThreatProtectionProvisioningState Failed { get; } = new AdvancedThreatProtectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="AdvancedThreatProtectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AdvancedThreatProtectionProvisioningState left, AdvancedThreatProtectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AdvancedThreatProtectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AdvancedThreatProtectionProvisioningState left, AdvancedThreatProtectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AdvancedThreatProtectionProvisioningState"/>. </summary>
        public static implicit operator AdvancedThreatProtectionProvisioningState(string value) => new AdvancedThreatProtectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AdvancedThreatProtectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AdvancedThreatProtectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
