// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The InternalAssistantFileDeletionStatus_object. </summary>
    internal readonly partial struct InternalAssistantFileDeletionStatusObject : IEquatable<InternalAssistantFileDeletionStatusObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalAssistantFileDeletionStatusObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalAssistantFileDeletionStatusObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssistantFileDeletedValue = "assistant.file.deleted";

        /// <summary> assistant.file.deleted. </summary>
        public static InternalAssistantFileDeletionStatusObject AssistantFileDeleted { get; } = new InternalAssistantFileDeletionStatusObject(AssistantFileDeletedValue);
        /// <summary> Determines if two <see cref="InternalAssistantFileDeletionStatusObject"/> values are the same. </summary>
        public static bool operator ==(InternalAssistantFileDeletionStatusObject left, InternalAssistantFileDeletionStatusObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalAssistantFileDeletionStatusObject"/> values are not the same. </summary>
        public static bool operator !=(InternalAssistantFileDeletionStatusObject left, InternalAssistantFileDeletionStatusObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalAssistantFileDeletionStatusObject"/>. </summary>
        public static implicit operator InternalAssistantFileDeletionStatusObject(string value) => new InternalAssistantFileDeletionStatusObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalAssistantFileDeletionStatusObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalAssistantFileDeletionStatusObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
