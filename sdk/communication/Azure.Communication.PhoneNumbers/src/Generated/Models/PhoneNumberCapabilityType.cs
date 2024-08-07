// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Capability value for calling. </summary>
    public readonly partial struct PhoneNumberCapabilityType : IEquatable<PhoneNumberCapabilityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberCapabilityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhoneNumberCapabilityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string InboundValue = "inbound";
        private const string OutboundValue = "outbound";
        private const string InboundOutboundValue = "inbound+outbound";

        /// <summary> none. </summary>
        public static PhoneNumberCapabilityType None { get; } = new PhoneNumberCapabilityType(NoneValue);
        /// <summary> inbound. </summary>
        public static PhoneNumberCapabilityType Inbound { get; } = new PhoneNumberCapabilityType(InboundValue);
        /// <summary> outbound. </summary>
        public static PhoneNumberCapabilityType Outbound { get; } = new PhoneNumberCapabilityType(OutboundValue);
        /// <summary> inbound+outbound. </summary>
        public static PhoneNumberCapabilityType InboundOutbound { get; } = new PhoneNumberCapabilityType(InboundOutboundValue);
        /// <summary> Determines if two <see cref="PhoneNumberCapabilityType"/> values are the same. </summary>
        public static bool operator ==(PhoneNumberCapabilityType left, PhoneNumberCapabilityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PhoneNumberCapabilityType"/> values are not the same. </summary>
        public static bool operator !=(PhoneNumberCapabilityType left, PhoneNumberCapabilityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PhoneNumberCapabilityType"/>. </summary>
        public static implicit operator PhoneNumberCapabilityType(string value) => new PhoneNumberCapabilityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhoneNumberCapabilityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PhoneNumberCapabilityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
