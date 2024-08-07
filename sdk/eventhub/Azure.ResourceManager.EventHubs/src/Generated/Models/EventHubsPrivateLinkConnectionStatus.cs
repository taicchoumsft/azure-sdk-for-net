// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Status of the connection. </summary>
    public readonly partial struct EventHubsPrivateLinkConnectionStatus : IEquatable<EventHubsPrivateLinkConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubsPrivateLinkConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubsPrivateLinkConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static EventHubsPrivateLinkConnectionStatus Pending { get; } = new EventHubsPrivateLinkConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static EventHubsPrivateLinkConnectionStatus Approved { get; } = new EventHubsPrivateLinkConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static EventHubsPrivateLinkConnectionStatus Rejected { get; } = new EventHubsPrivateLinkConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static EventHubsPrivateLinkConnectionStatus Disconnected { get; } = new EventHubsPrivateLinkConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="EventHubsPrivateLinkConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(EventHubsPrivateLinkConnectionStatus left, EventHubsPrivateLinkConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubsPrivateLinkConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(EventHubsPrivateLinkConnectionStatus left, EventHubsPrivateLinkConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventHubsPrivateLinkConnectionStatus"/>. </summary>
        public static implicit operator EventHubsPrivateLinkConnectionStatus(string value) => new EventHubsPrivateLinkConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubsPrivateLinkConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubsPrivateLinkConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
