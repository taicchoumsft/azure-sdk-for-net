// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> This determines if traffic is allowed over public network. By default it is enabled. If value is SecuredByPerimeter then Inbound and Outbound communication is controlled by the network security perimeter and profile's access rules. </summary>
    public readonly partial struct EventHubsPublicNetworkAccessFlag : IEquatable<EventHubsPublicNetworkAccessFlag>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubsPublicNetworkAccessFlag"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubsPublicNetworkAccessFlag(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";
        private const string SecuredByPerimeterValue = "SecuredByPerimeter";

        /// <summary> Enabled. </summary>
        public static EventHubsPublicNetworkAccessFlag Enabled { get; } = new EventHubsPublicNetworkAccessFlag(EnabledValue);
        /// <summary> Disabled. </summary>
        public static EventHubsPublicNetworkAccessFlag Disabled { get; } = new EventHubsPublicNetworkAccessFlag(DisabledValue);
        /// <summary> SecuredByPerimeter. </summary>
        public static EventHubsPublicNetworkAccessFlag SecuredByPerimeter { get; } = new EventHubsPublicNetworkAccessFlag(SecuredByPerimeterValue);
        /// <summary> Determines if two <see cref="EventHubsPublicNetworkAccessFlag"/> values are the same. </summary>
        public static bool operator ==(EventHubsPublicNetworkAccessFlag left, EventHubsPublicNetworkAccessFlag right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubsPublicNetworkAccessFlag"/> values are not the same. </summary>
        public static bool operator !=(EventHubsPublicNetworkAccessFlag left, EventHubsPublicNetworkAccessFlag right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventHubsPublicNetworkAccessFlag"/>. </summary>
        public static implicit operator EventHubsPublicNetworkAccessFlag(string value) => new EventHubsPublicNetworkAccessFlag(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubsPublicNetworkAccessFlag other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubsPublicNetworkAccessFlag other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
