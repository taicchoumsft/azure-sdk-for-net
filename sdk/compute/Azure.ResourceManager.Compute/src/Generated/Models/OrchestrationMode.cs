// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the orchestration mode for the virtual machine scale set. </summary>
    public readonly partial struct OrchestrationMode : IEquatable<OrchestrationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OrchestrationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OrchestrationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UniformValue = "Uniform";
        private const string FlexibleValue = "Flexible";

        /// <summary> Uniform. </summary>
        public static OrchestrationMode Uniform { get; } = new OrchestrationMode(UniformValue);
        /// <summary> Flexible. </summary>
        public static OrchestrationMode Flexible { get; } = new OrchestrationMode(FlexibleValue);
        /// <summary> Determines if two <see cref="OrchestrationMode"/> values are the same. </summary>
        public static bool operator ==(OrchestrationMode left, OrchestrationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrchestrationMode"/> values are not the same. </summary>
        public static bool operator !=(OrchestrationMode left, OrchestrationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OrchestrationMode"/>. </summary>
        public static implicit operator OrchestrationMode(string value) => new OrchestrationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrchestrationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrchestrationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
