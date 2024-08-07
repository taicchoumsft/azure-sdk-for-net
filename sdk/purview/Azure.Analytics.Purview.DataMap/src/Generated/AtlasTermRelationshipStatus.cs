// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> Status for atlas term relationship. </summary>
    public readonly partial struct AtlasTermRelationshipStatus : IEquatable<AtlasTermRelationshipStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AtlasTermRelationshipStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AtlasTermRelationshipStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DraftValue = "DRAFT";
        private const string ActiveValue = "ACTIVE";
        private const string DeprecatedValue = "DEPRECATED";
        private const string ObsoleteValue = "OBSOLETE";
        private const string OtherValue = "OTHER";

        /// <summary> draft. </summary>
        public static AtlasTermRelationshipStatus Draft { get; } = new AtlasTermRelationshipStatus(DraftValue);
        /// <summary> active. </summary>
        public static AtlasTermRelationshipStatus Active { get; } = new AtlasTermRelationshipStatus(ActiveValue);
        /// <summary> deprecated. </summary>
        public static AtlasTermRelationshipStatus Deprecated { get; } = new AtlasTermRelationshipStatus(DeprecatedValue);
        /// <summary> obsolete. </summary>
        public static AtlasTermRelationshipStatus Obsolete { get; } = new AtlasTermRelationshipStatus(ObsoleteValue);
        /// <summary> other. </summary>
        public static AtlasTermRelationshipStatus Other { get; } = new AtlasTermRelationshipStatus(OtherValue);
        /// <summary> Determines if two <see cref="AtlasTermRelationshipStatus"/> values are the same. </summary>
        public static bool operator ==(AtlasTermRelationshipStatus left, AtlasTermRelationshipStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AtlasTermRelationshipStatus"/> values are not the same. </summary>
        public static bool operator !=(AtlasTermRelationshipStatus left, AtlasTermRelationshipStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AtlasTermRelationshipStatus"/>. </summary>
        public static implicit operator AtlasTermRelationshipStatus(string value) => new AtlasTermRelationshipStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AtlasTermRelationshipStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AtlasTermRelationshipStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
