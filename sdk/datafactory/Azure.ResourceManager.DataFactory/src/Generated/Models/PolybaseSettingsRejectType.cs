// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Indicates whether the RejectValue property is specified as a literal value or a percentage. </summary>
    public readonly partial struct PolybaseSettingsRejectType : IEquatable<PolybaseSettingsRejectType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolybaseSettingsRejectType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolybaseSettingsRejectType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValueValue = "value";
        private const string PercentageValue = "percentage";

        /// <summary> value. </summary>
        public static PolybaseSettingsRejectType Value { get; } = new PolybaseSettingsRejectType(ValueValue);
        /// <summary> percentage. </summary>
        public static PolybaseSettingsRejectType Percentage { get; } = new PolybaseSettingsRejectType(PercentageValue);
        /// <summary> Determines if two <see cref="PolybaseSettingsRejectType"/> values are the same. </summary>
        public static bool operator ==(PolybaseSettingsRejectType left, PolybaseSettingsRejectType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolybaseSettingsRejectType"/> values are not the same. </summary>
        public static bool operator !=(PolybaseSettingsRejectType left, PolybaseSettingsRejectType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolybaseSettingsRejectType"/>. </summary>
        public static implicit operator PolybaseSettingsRejectType(string value) => new PolybaseSettingsRejectType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolybaseSettingsRejectType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolybaseSettingsRejectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
