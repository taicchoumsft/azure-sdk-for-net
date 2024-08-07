// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The event hub type. </summary>
    public readonly partial struct PurviewKafkaEventHubType : IEquatable<PurviewKafkaEventHubType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PurviewKafkaEventHubType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PurviewKafkaEventHubType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotificationValue = "Notification";
        private const string HookValue = "Hook";

        /// <summary> Notification. </summary>
        public static PurviewKafkaEventHubType Notification { get; } = new PurviewKafkaEventHubType(NotificationValue);
        /// <summary> Hook. </summary>
        public static PurviewKafkaEventHubType Hook { get; } = new PurviewKafkaEventHubType(HookValue);
        /// <summary> Determines if two <see cref="PurviewKafkaEventHubType"/> values are the same. </summary>
        public static bool operator ==(PurviewKafkaEventHubType left, PurviewKafkaEventHubType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PurviewKafkaEventHubType"/> values are not the same. </summary>
        public static bool operator !=(PurviewKafkaEventHubType left, PurviewKafkaEventHubType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PurviewKafkaEventHubType"/>. </summary>
        public static implicit operator PurviewKafkaEventHubType(string value) => new PurviewKafkaEventHubType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PurviewKafkaEventHubType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PurviewKafkaEventHubType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
