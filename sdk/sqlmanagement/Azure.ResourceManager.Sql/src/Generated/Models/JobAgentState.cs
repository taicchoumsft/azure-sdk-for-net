// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The state of the job agent. </summary>
    public readonly partial struct JobAgentState : IEquatable<JobAgentState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobAgentState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobAgentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string ReadyValue = "Ready";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string DisabledValue = "Disabled";

        /// <summary> Creating. </summary>
        public static JobAgentState Creating { get; } = new JobAgentState(CreatingValue);
        /// <summary> Ready. </summary>
        public static JobAgentState Ready { get; } = new JobAgentState(ReadyValue);
        /// <summary> Updating. </summary>
        public static JobAgentState Updating { get; } = new JobAgentState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static JobAgentState Deleting { get; } = new JobAgentState(DeletingValue);
        /// <summary> Disabled. </summary>
        public static JobAgentState Disabled { get; } = new JobAgentState(DisabledValue);
        /// <summary> Determines if two <see cref="JobAgentState"/> values are the same. </summary>
        public static bool operator ==(JobAgentState left, JobAgentState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobAgentState"/> values are not the same. </summary>
        public static bool operator !=(JobAgentState left, JobAgentState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobAgentState"/>. </summary>
        public static implicit operator JobAgentState(string value) => new JobAgentState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobAgentState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobAgentState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
