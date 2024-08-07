// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> State of the script execution. This only appears in the response. </summary>
    public readonly partial struct ScriptProvisioningState : IEquatable<ScriptProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string ProvisioningResourcesValue = "ProvisioningResources";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Creating. </summary>
        public static ScriptProvisioningState Creating { get; } = new ScriptProvisioningState(CreatingValue);
        /// <summary> ProvisioningResources. </summary>
        public static ScriptProvisioningState ProvisioningResources { get; } = new ScriptProvisioningState(ProvisioningResourcesValue);
        /// <summary> Running. </summary>
        public static ScriptProvisioningState Running { get; } = new ScriptProvisioningState(RunningValue);
        /// <summary> Succeeded. </summary>
        public static ScriptProvisioningState Succeeded { get; } = new ScriptProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ScriptProvisioningState Failed { get; } = new ScriptProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ScriptProvisioningState Canceled { get; } = new ScriptProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="ScriptProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ScriptProvisioningState left, ScriptProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ScriptProvisioningState left, ScriptProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScriptProvisioningState"/>. </summary>
        public static implicit operator ScriptProvisioningState(string value) => new ScriptProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
