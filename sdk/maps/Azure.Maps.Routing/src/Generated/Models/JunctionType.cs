// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Routing.Models
{
    /// <summary> The type of the junction where the maneuver takes place. For larger roundabouts, two separate instructions are generated for entering and leaving the roundabout. </summary>
    public readonly partial struct JunctionType : IEquatable<JunctionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JunctionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JunctionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegularValue = "REGULAR";
        private const string RoundaboutValue = "ROUNDABOUT";
        private const string BifurcationValue = "BIFURCATION";

        /// <summary> regular. </summary>
        public static JunctionType Regular { get; } = new JunctionType(RegularValue);
        /// <summary> roundabout. </summary>
        public static JunctionType Roundabout { get; } = new JunctionType(RoundaboutValue);
        /// <summary> bifurcation. </summary>
        public static JunctionType Bifurcation { get; } = new JunctionType(BifurcationValue);
        /// <summary> Determines if two <see cref="JunctionType"/> values are the same. </summary>
        public static bool operator ==(JunctionType left, JunctionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JunctionType"/> values are not the same. </summary>
        public static bool operator !=(JunctionType left, JunctionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JunctionType"/>. </summary>
        public static implicit operator JunctionType(string value) => new JunctionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JunctionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JunctionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
