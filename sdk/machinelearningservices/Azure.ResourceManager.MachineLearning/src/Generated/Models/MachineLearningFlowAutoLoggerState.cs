// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine the state of mlflow autologger. </summary>
    public readonly partial struct MachineLearningFlowAutoLoggerState : IEquatable<MachineLearningFlowAutoLoggerState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningFlowAutoLoggerState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningFlowAutoLoggerState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static MachineLearningFlowAutoLoggerState Enabled { get; } = new MachineLearningFlowAutoLoggerState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static MachineLearningFlowAutoLoggerState Disabled { get; } = new MachineLearningFlowAutoLoggerState(DisabledValue);
        /// <summary> Determines if two <see cref="MachineLearningFlowAutoLoggerState"/> values are the same. </summary>
        public static bool operator ==(MachineLearningFlowAutoLoggerState left, MachineLearningFlowAutoLoggerState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningFlowAutoLoggerState"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningFlowAutoLoggerState left, MachineLearningFlowAutoLoggerState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningFlowAutoLoggerState"/>. </summary>
        public static implicit operator MachineLearningFlowAutoLoggerState(string value) => new MachineLearningFlowAutoLoggerState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningFlowAutoLoggerState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningFlowAutoLoggerState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
