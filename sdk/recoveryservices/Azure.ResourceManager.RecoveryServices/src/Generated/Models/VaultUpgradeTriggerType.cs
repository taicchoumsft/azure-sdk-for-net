// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The way the vault upgrade was triggered. </summary>
    public readonly partial struct VaultUpgradeTriggerType : IEquatable<VaultUpgradeTriggerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VaultUpgradeTriggerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VaultUpgradeTriggerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserTriggeredValue = "UserTriggered";
        private const string ForcedUpgradeValue = "ForcedUpgrade";

        /// <summary> UserTriggered. </summary>
        public static VaultUpgradeTriggerType UserTriggered { get; } = new VaultUpgradeTriggerType(UserTriggeredValue);
        /// <summary> ForcedUpgrade. </summary>
        public static VaultUpgradeTriggerType ForcedUpgrade { get; } = new VaultUpgradeTriggerType(ForcedUpgradeValue);
        /// <summary> Determines if two <see cref="VaultUpgradeTriggerType"/> values are the same. </summary>
        public static bool operator ==(VaultUpgradeTriggerType left, VaultUpgradeTriggerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VaultUpgradeTriggerType"/> values are not the same. </summary>
        public static bool operator !=(VaultUpgradeTriggerType left, VaultUpgradeTriggerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VaultUpgradeTriggerType"/>. </summary>
        public static implicit operator VaultUpgradeTriggerType(string value) => new VaultUpgradeTriggerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VaultUpgradeTriggerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VaultUpgradeTriggerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
