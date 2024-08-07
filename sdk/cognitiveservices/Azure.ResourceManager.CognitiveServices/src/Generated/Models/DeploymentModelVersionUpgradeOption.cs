// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Deployment model version upgrade option. </summary>
    public readonly partial struct DeploymentModelVersionUpgradeOption : IEquatable<DeploymentModelVersionUpgradeOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeploymentModelVersionUpgradeOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentModelVersionUpgradeOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnceNewDefaultVersionAvailableValue = "OnceNewDefaultVersionAvailable";
        private const string OnceCurrentVersionExpiredValue = "OnceCurrentVersionExpired";
        private const string NoAutoUpgradeValue = "NoAutoUpgrade";

        /// <summary> OnceNewDefaultVersionAvailable. </summary>
        public static DeploymentModelVersionUpgradeOption OnceNewDefaultVersionAvailable { get; } = new DeploymentModelVersionUpgradeOption(OnceNewDefaultVersionAvailableValue);
        /// <summary> OnceCurrentVersionExpired. </summary>
        public static DeploymentModelVersionUpgradeOption OnceCurrentVersionExpired { get; } = new DeploymentModelVersionUpgradeOption(OnceCurrentVersionExpiredValue);
        /// <summary> NoAutoUpgrade. </summary>
        public static DeploymentModelVersionUpgradeOption NoAutoUpgrade { get; } = new DeploymentModelVersionUpgradeOption(NoAutoUpgradeValue);
        /// <summary> Determines if two <see cref="DeploymentModelVersionUpgradeOption"/> values are the same. </summary>
        public static bool operator ==(DeploymentModelVersionUpgradeOption left, DeploymentModelVersionUpgradeOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentModelVersionUpgradeOption"/> values are not the same. </summary>
        public static bool operator !=(DeploymentModelVersionUpgradeOption left, DeploymentModelVersionUpgradeOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeploymentModelVersionUpgradeOption"/>. </summary>
        public static implicit operator DeploymentModelVersionUpgradeOption(string value) => new DeploymentModelVersionUpgradeOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentModelVersionUpgradeOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentModelVersionUpgradeOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
