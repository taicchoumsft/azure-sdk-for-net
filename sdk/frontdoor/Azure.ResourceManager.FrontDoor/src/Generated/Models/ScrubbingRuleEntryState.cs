// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the state of a log scrubbing rule. Default value is enabled. </summary>
    public readonly partial struct ScrubbingRuleEntryState : IEquatable<ScrubbingRuleEntryState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScrubbingRuleEntryState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScrubbingRuleEntryState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ScrubbingRuleEntryState Enabled { get; } = new ScrubbingRuleEntryState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ScrubbingRuleEntryState Disabled { get; } = new ScrubbingRuleEntryState(DisabledValue);
        /// <summary> Determines if two <see cref="ScrubbingRuleEntryState"/> values are the same. </summary>
        public static bool operator ==(ScrubbingRuleEntryState left, ScrubbingRuleEntryState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScrubbingRuleEntryState"/> values are not the same. </summary>
        public static bool operator !=(ScrubbingRuleEntryState left, ScrubbingRuleEntryState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScrubbingRuleEntryState"/>. </summary>
        public static implicit operator ScrubbingRuleEntryState(string value) => new ScrubbingRuleEntryState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScrubbingRuleEntryState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScrubbingRuleEntryState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
