// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The phase the task is in. </summary>
    public readonly partial struct TaskResourcePhase : IEquatable<TaskResourcePhase>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TaskResourcePhase"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TaskResourcePhase(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "running";
        private const string PollingValue = "polling";
        private const string CompleteValue = "complete";

        /// <summary> running. </summary>
        public static TaskResourcePhase Running { get; } = new TaskResourcePhase(RunningValue);
        /// <summary> polling. </summary>
        public static TaskResourcePhase Polling { get; } = new TaskResourcePhase(PollingValue);
        /// <summary> complete. </summary>
        public static TaskResourcePhase Complete { get; } = new TaskResourcePhase(CompleteValue);
        /// <summary> Determines if two <see cref="TaskResourcePhase"/> values are the same. </summary>
        public static bool operator ==(TaskResourcePhase left, TaskResourcePhase right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TaskResourcePhase"/> values are not the same. </summary>
        public static bool operator !=(TaskResourcePhase left, TaskResourcePhase right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TaskResourcePhase"/>. </summary>
        public static implicit operator TaskResourcePhase(string value) => new TaskResourcePhase(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TaskResourcePhase other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TaskResourcePhase other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
