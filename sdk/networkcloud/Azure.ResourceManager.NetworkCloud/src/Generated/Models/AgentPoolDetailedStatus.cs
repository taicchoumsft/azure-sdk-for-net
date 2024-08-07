// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The current status of the agent pool. </summary>
    public readonly partial struct AgentPoolDetailedStatus : IEquatable<AgentPoolDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgentPoolDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgentPoolDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string ErrorValue = "Error";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Available. </summary>
        public static AgentPoolDetailedStatus Available { get; } = new AgentPoolDetailedStatus(AvailableValue);
        /// <summary> Error. </summary>
        public static AgentPoolDetailedStatus Error { get; } = new AgentPoolDetailedStatus(ErrorValue);
        /// <summary> Provisioning. </summary>
        public static AgentPoolDetailedStatus Provisioning { get; } = new AgentPoolDetailedStatus(ProvisioningValue);
        /// <summary> Determines if two <see cref="AgentPoolDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(AgentPoolDetailedStatus left, AgentPoolDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgentPoolDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(AgentPoolDetailedStatus left, AgentPoolDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AgentPoolDetailedStatus"/>. </summary>
        public static implicit operator AgentPoolDetailedStatus(string value) => new AgentPoolDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgentPoolDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgentPoolDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
