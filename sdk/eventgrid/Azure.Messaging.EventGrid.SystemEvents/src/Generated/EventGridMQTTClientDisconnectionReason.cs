// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> EventGrid MQTT Client Disconnection Reason. </summary>
    public readonly partial struct EventGridMQTTClientDisconnectionReason : IEquatable<EventGridMQTTClientDisconnectionReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridMQTTClientDisconnectionReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridMQTTClientDisconnectionReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClientAuthenticationErrorValue = "ClientAuthenticationError";
        private const string ClientAuthorizationErrorValue = "ClientAuthorizationError";
        private const string ClientErrorValue = "ClientError";
        private const string ClientInitiatedDisconnectValue = "ClientInitiatedDisconnect";
        private const string ConnectionLostValue = "ConnectionLost";
        private const string IpForbiddenValue = "IpForbidden";
        private const string QuotaExceededValue = "QuotaExceeded";
        private const string ServerErrorValue = "ServerError";
        private const string ServerInitiatedDisconnectValue = "ServerInitiatedDisconnect";
        private const string SessionOverflowValue = "SessionOverflow";
        private const string SessionTakenOverValue = "SessionTakenOver";

        /// <summary> The client got disconnected for any authentication reasons (for example, certificate expired, client got disabled, or client configuration changed). </summary>
        public static EventGridMQTTClientDisconnectionReason ClientAuthenticationError { get; } = new EventGridMQTTClientDisconnectionReason(ClientAuthenticationErrorValue);
        /// <summary> The client got disconnected for any authorization reasons (for example, because of a change in the configuration of topic spaces, permission bindings, or client groups). </summary>
        public static EventGridMQTTClientDisconnectionReason ClientAuthorizationError { get; } = new EventGridMQTTClientDisconnectionReason(ClientAuthorizationErrorValue);
        /// <summary> The client sent a bad request or used one of the unsupported features that resulted in a connection termination by the service. </summary>
        public static EventGridMQTTClientDisconnectionReason ClientError { get; } = new EventGridMQTTClientDisconnectionReason(ClientErrorValue);
        /// <summary> The client initiated a graceful disconnect through a DISCONNECT packet for MQTT or a close frame for MQTT over WebSocket. </summary>
        public static EventGridMQTTClientDisconnectionReason ClientInitiatedDisconnect { get; } = new EventGridMQTTClientDisconnectionReason(ClientInitiatedDisconnectValue);
        /// <summary> The client-server connection is lost. (EXCHANGE ONLINE PROTECTION). </summary>
        public static EventGridMQTTClientDisconnectionReason ConnectionLost { get; } = new EventGridMQTTClientDisconnectionReason(ConnectionLostValue);
        /// <summary> The client's IP address is blocked by IP filter or Private links configuration. </summary>
        public static EventGridMQTTClientDisconnectionReason IpForbidden { get; } = new EventGridMQTTClientDisconnectionReason(IpForbiddenValue);
        /// <summary> The client exceeded one or more of the throttling limits that resulted in a connection termination by the service. </summary>
        public static EventGridMQTTClientDisconnectionReason QuotaExceeded { get; } = new EventGridMQTTClientDisconnectionReason(QuotaExceededValue);
        /// <summary> The connection got terminated due to an unexpected server error. </summary>
        public static EventGridMQTTClientDisconnectionReason ServerError { get; } = new EventGridMQTTClientDisconnectionReason(ServerErrorValue);
        /// <summary> The server initiates a graceful disconnect for any operational reason. </summary>
        public static EventGridMQTTClientDisconnectionReason ServerInitiatedDisconnect { get; } = new EventGridMQTTClientDisconnectionReason(ServerInitiatedDisconnectValue);
        /// <summary> The client's queue for unacknowledged QoS1 messages reached its limit, which resulted in a connection termination by the server. </summary>
        public static EventGridMQTTClientDisconnectionReason SessionOverflow { get; } = new EventGridMQTTClientDisconnectionReason(SessionOverflowValue);
        /// <summary> The client reconnected with the same authentication name, which resulted in the termination of the previous connection. </summary>
        public static EventGridMQTTClientDisconnectionReason SessionTakenOver { get; } = new EventGridMQTTClientDisconnectionReason(SessionTakenOverValue);
        /// <summary> Determines if two <see cref="EventGridMQTTClientDisconnectionReason"/> values are the same. </summary>
        public static bool operator ==(EventGridMQTTClientDisconnectionReason left, EventGridMQTTClientDisconnectionReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridMQTTClientDisconnectionReason"/> values are not the same. </summary>
        public static bool operator !=(EventGridMQTTClientDisconnectionReason left, EventGridMQTTClientDisconnectionReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventGridMQTTClientDisconnectionReason"/>. </summary>
        public static implicit operator EventGridMQTTClientDisconnectionReason(string value) => new EventGridMQTTClientDisconnectionReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridMQTTClientDisconnectionReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridMQTTClientDisconnectionReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
