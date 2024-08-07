// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Name of configuration mode to use. Modes are pre-defined configurations of security controls, extension allowlists and guest configuration, maintained by Microsoft. </summary>
    public readonly partial struct AgentConfigurationMode : IEquatable<AgentConfigurationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgentConfigurationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgentConfigurationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FullValue = "full";
        private const string MonitorValue = "monitor";

        /// <summary> full. </summary>
        public static AgentConfigurationMode Full { get; } = new AgentConfigurationMode(FullValue);
        /// <summary> monitor. </summary>
        public static AgentConfigurationMode Monitor { get; } = new AgentConfigurationMode(MonitorValue);
        /// <summary> Determines if two <see cref="AgentConfigurationMode"/> values are the same. </summary>
        public static bool operator ==(AgentConfigurationMode left, AgentConfigurationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgentConfigurationMode"/> values are not the same. </summary>
        public static bool operator !=(AgentConfigurationMode left, AgentConfigurationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AgentConfigurationMode"/>. </summary>
        public static implicit operator AgentConfigurationMode(string value) => new AgentConfigurationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgentConfigurationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgentConfigurationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
