// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Type of the custom mapping. </summary>
    internal readonly partial struct InputSchemaMappingType : IEquatable<InputSchemaMappingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InputSchemaMappingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InputSchemaMappingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JsonValue = "Json";

        /// <summary> Json. </summary>
        public static InputSchemaMappingType Json { get; } = new InputSchemaMappingType(JsonValue);
        /// <summary> Determines if two <see cref="InputSchemaMappingType"/> values are the same. </summary>
        public static bool operator ==(InputSchemaMappingType left, InputSchemaMappingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InputSchemaMappingType"/> values are not the same. </summary>
        public static bool operator !=(InputSchemaMappingType left, InputSchemaMappingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InputSchemaMappingType"/>. </summary>
        public static implicit operator InputSchemaMappingType(string value) => new InputSchemaMappingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InputSchemaMappingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InputSchemaMappingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
