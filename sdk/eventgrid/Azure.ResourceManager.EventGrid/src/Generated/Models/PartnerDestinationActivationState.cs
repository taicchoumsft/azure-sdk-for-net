// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Activation state of the partner destination. </summary>
    public readonly partial struct PartnerDestinationActivationState : IEquatable<PartnerDestinationActivationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PartnerDestinationActivationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PartnerDestinationActivationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NeverActivatedValue = "NeverActivated";
        private const string ActivatedValue = "Activated";

        /// <summary> NeverActivated. </summary>
        public static PartnerDestinationActivationState NeverActivated { get; } = new PartnerDestinationActivationState(NeverActivatedValue);
        /// <summary> Activated. </summary>
        public static PartnerDestinationActivationState Activated { get; } = new PartnerDestinationActivationState(ActivatedValue);
        /// <summary> Determines if two <see cref="PartnerDestinationActivationState"/> values are the same. </summary>
        public static bool operator ==(PartnerDestinationActivationState left, PartnerDestinationActivationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PartnerDestinationActivationState"/> values are not the same. </summary>
        public static bool operator !=(PartnerDestinationActivationState left, PartnerDestinationActivationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PartnerDestinationActivationState"/>. </summary>
        public static implicit operator PartnerDestinationActivationState(string value) => new PartnerDestinationActivationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PartnerDestinationActivationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PartnerDestinationActivationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
