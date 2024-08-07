// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> Type for sorting. </summary>
    public readonly partial struct AtlasSortType : IEquatable<AtlasSortType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AtlasSortType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AtlasSortType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "NONE";
        private const string AscendValue = "ASC";
        private const string DescendValue = "DESC";

        /// <summary> No sorting order. </summary>
        public static AtlasSortType None { get; } = new AtlasSortType(NoneValue);
        /// <summary> Use ascending order for sorting. </summary>
        public static AtlasSortType Ascend { get; } = new AtlasSortType(AscendValue);
        /// <summary> Use descending order for sorting. </summary>
        public static AtlasSortType Descend { get; } = new AtlasSortType(DescendValue);
        /// <summary> Determines if two <see cref="AtlasSortType"/> values are the same. </summary>
        public static bool operator ==(AtlasSortType left, AtlasSortType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AtlasSortType"/> values are not the same. </summary>
        public static bool operator !=(AtlasSortType left, AtlasSortType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AtlasSortType"/>. </summary>
        public static implicit operator AtlasSortType(string value) => new AtlasSortType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AtlasSortType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AtlasSortType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
