// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Chat
{
    /// <summary> The type of attachment. </summary>
    public readonly partial struct ChatAttachmentType : IEquatable<ChatAttachmentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChatAttachmentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChatAttachmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ImageValue = "image";
        private const string FileValue = "file";

        /// <summary> image. </summary>
        public static ChatAttachmentType Image { get; } = new ChatAttachmentType(ImageValue);
        /// <summary> file. </summary>
        public static ChatAttachmentType File { get; } = new ChatAttachmentType(FileValue);
        /// <summary> Determines if two <see cref="ChatAttachmentType"/> values are the same. </summary>
        public static bool operator ==(ChatAttachmentType left, ChatAttachmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChatAttachmentType"/> values are not the same. </summary>
        public static bool operator !=(ChatAttachmentType left, ChatAttachmentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChatAttachmentType"/>. </summary>
        public static implicit operator ChatAttachmentType(string value) => new ChatAttachmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChatAttachmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChatAttachmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
