// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The Sku name of the resource. The possible values are: Basic or Premium. </summary>
    public readonly partial struct EventGridSku : IEquatable<EventGridSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string PremiumValue = "Premium";

        /// <summary> Basic. </summary>
        public static EventGridSku Basic { get; } = new EventGridSku(BasicValue);
        /// <summary> Premium. </summary>
        public static EventGridSku Premium { get; } = new EventGridSku(PremiumValue);
        /// <summary> Determines if two <see cref="EventGridSku"/> values are the same. </summary>
        public static bool operator ==(EventGridSku left, EventGridSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridSku"/> values are not the same. </summary>
        public static bool operator !=(EventGridSku left, EventGridSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventGridSku"/>. </summary>
        public static implicit operator EventGridSku(string value) => new EventGridSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
