// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Messages
{
    /// <summary> The type of the message template. </summary>
    internal readonly partial struct MessageTemplateBindingsKind : IEquatable<MessageTemplateBindingsKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageTemplateBindingsKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageTemplateBindingsKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WhatsAppValue = "whatsApp";

        /// <summary> The WhatsApp template type. </summary>
        public static MessageTemplateBindingsKind WhatsApp { get; } = new MessageTemplateBindingsKind(WhatsAppValue);
        /// <summary> Determines if two <see cref="MessageTemplateBindingsKind"/> values are the same. </summary>
        public static bool operator ==(MessageTemplateBindingsKind left, MessageTemplateBindingsKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageTemplateBindingsKind"/> values are not the same. </summary>
        public static bool operator !=(MessageTemplateBindingsKind left, MessageTemplateBindingsKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageTemplateBindingsKind"/>. </summary>
        public static implicit operator MessageTemplateBindingsKind(string value) => new MessageTemplateBindingsKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageTemplateBindingsKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageTemplateBindingsKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
