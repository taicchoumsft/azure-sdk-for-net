// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> An value that determines where the API Version identifier will be located in a HTTP request. </summary>
    public readonly partial struct VersioningScheme : IEquatable<VersioningScheme>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VersioningScheme"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VersioningScheme(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SegmentValue = "Segment";
        private const string QueryValue = "Query";
        private const string HeaderValue = "Header";

        /// <summary> Segment. </summary>
        public static VersioningScheme Segment { get; } = new VersioningScheme(SegmentValue);
        /// <summary> Query. </summary>
        public static VersioningScheme Query { get; } = new VersioningScheme(QueryValue);
        /// <summary> Header. </summary>
        public static VersioningScheme Header { get; } = new VersioningScheme(HeaderValue);
        /// <summary> Determines if two <see cref="VersioningScheme"/> values are the same. </summary>
        public static bool operator ==(VersioningScheme left, VersioningScheme right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VersioningScheme"/> values are not the same. </summary>
        public static bool operator !=(VersioningScheme left, VersioningScheme right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VersioningScheme"/>. </summary>
        public static implicit operator VersioningScheme(string value) => new VersioningScheme(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VersioningScheme other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VersioningScheme other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
