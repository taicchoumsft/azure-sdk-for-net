// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The identifier kind, for example 'communicationUser' or 'phoneNumber'. </summary>
    public readonly partial struct AcsCommunicationIdentifierKind : IEquatable<AcsCommunicationIdentifierKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AcsCommunicationIdentifierKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AcsCommunicationIdentifierKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string CommunicationUserValue = "communicationUser";
        private const string PhoneNumberValue = "phoneNumber";
        private const string MicrosoftTeamsUserValue = "microsoftTeamsUser";
        private const string MicrosoftTeamsAppValue = "microsoftTeamsApp";

        /// <summary> unknown. </summary>
        public static AcsCommunicationIdentifierKind Unknown { get; } = new AcsCommunicationIdentifierKind(UnknownValue);
        /// <summary> communicationUser. </summary>
        public static AcsCommunicationIdentifierKind CommunicationUser { get; } = new AcsCommunicationIdentifierKind(CommunicationUserValue);
        /// <summary> phoneNumber. </summary>
        public static AcsCommunicationIdentifierKind PhoneNumber { get; } = new AcsCommunicationIdentifierKind(PhoneNumberValue);
        /// <summary> microsoftTeamsUser. </summary>
        public static AcsCommunicationIdentifierKind MicrosoftTeamsUser { get; } = new AcsCommunicationIdentifierKind(MicrosoftTeamsUserValue);
        /// <summary> microsoftTeamsApp. </summary>
        public static AcsCommunicationIdentifierKind MicrosoftTeamsApp { get; } = new AcsCommunicationIdentifierKind(MicrosoftTeamsAppValue);
        /// <summary> Determines if two <see cref="AcsCommunicationIdentifierKind"/> values are the same. </summary>
        public static bool operator ==(AcsCommunicationIdentifierKind left, AcsCommunicationIdentifierKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AcsCommunicationIdentifierKind"/> values are not the same. </summary>
        public static bool operator !=(AcsCommunicationIdentifierKind left, AcsCommunicationIdentifierKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AcsCommunicationIdentifierKind"/>. </summary>
        public static implicit operator AcsCommunicationIdentifierKind(string value) => new AcsCommunicationIdentifierKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AcsCommunicationIdentifierKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AcsCommunicationIdentifierKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
