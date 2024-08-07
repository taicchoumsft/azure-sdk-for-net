// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The current status of trigger. </summary>
    public readonly partial struct ContainerRegistryTriggerStatus : IEquatable<ContainerRegistryTriggerStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTriggerStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryTriggerStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static ContainerRegistryTriggerStatus Disabled { get; } = new ContainerRegistryTriggerStatus(DisabledValue);
        /// <summary> Enabled. </summary>
        public static ContainerRegistryTriggerStatus Enabled { get; } = new ContainerRegistryTriggerStatus(EnabledValue);
        /// <summary> Determines if two <see cref="ContainerRegistryTriggerStatus"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryTriggerStatus left, ContainerRegistryTriggerStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryTriggerStatus"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryTriggerStatus left, ContainerRegistryTriggerStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistryTriggerStatus"/>. </summary>
        public static implicit operator ContainerRegistryTriggerStatus(string value) => new ContainerRegistryTriggerStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryTriggerStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryTriggerStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
