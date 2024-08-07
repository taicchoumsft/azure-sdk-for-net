// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The AccessTier. </summary>
    public readonly partial struct AccessTier : IEquatable<AccessTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccessTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string P4Value = "P4";
        private const string P6Value = "P6";
        private const string P10Value = "P10";
        private const string P15Value = "P15";
        private const string P20Value = "P20";
        private const string P30Value = "P30";
        private const string P40Value = "P40";
        private const string P50Value = "P50";
        private const string P60Value = "P60";
        private const string P70Value = "P70";
        private const string P80Value = "P80";
        private const string HotValue = "Hot";
        private const string CoolValue = "Cool";
        private const string ArchiveValue = "Archive";
        private const string PremiumValue = "Premium";
        private const string ColdValue = "Cold";

        /// <summary> P4. </summary>
        public static AccessTier P4 { get; } = new AccessTier(P4Value);
        /// <summary> P6. </summary>
        public static AccessTier P6 { get; } = new AccessTier(P6Value);
        /// <summary> P10. </summary>
        public static AccessTier P10 { get; } = new AccessTier(P10Value);
        /// <summary> P15. </summary>
        public static AccessTier P15 { get; } = new AccessTier(P15Value);
        /// <summary> P20. </summary>
        public static AccessTier P20 { get; } = new AccessTier(P20Value);
        /// <summary> P30. </summary>
        public static AccessTier P30 { get; } = new AccessTier(P30Value);
        /// <summary> P40. </summary>
        public static AccessTier P40 { get; } = new AccessTier(P40Value);
        /// <summary> P50. </summary>
        public static AccessTier P50 { get; } = new AccessTier(P50Value);
        /// <summary> P60. </summary>
        public static AccessTier P60 { get; } = new AccessTier(P60Value);
        /// <summary> P70. </summary>
        public static AccessTier P70 { get; } = new AccessTier(P70Value);
        /// <summary> P80. </summary>
        public static AccessTier P80 { get; } = new AccessTier(P80Value);
        /// <summary> Hot. </summary>
        public static AccessTier Hot { get; } = new AccessTier(HotValue);
        /// <summary> Cool. </summary>
        public static AccessTier Cool { get; } = new AccessTier(CoolValue);
        /// <summary> Archive. </summary>
        public static AccessTier Archive { get; } = new AccessTier(ArchiveValue);
        /// <summary> Premium. </summary>
        public static AccessTier Premium { get; } = new AccessTier(PremiumValue);
        /// <summary> Cold. </summary>
        public static AccessTier Cold { get; } = new AccessTier(ColdValue);
        /// <summary> Determines if two <see cref="AccessTier"/> values are the same. </summary>
        public static bool operator ==(AccessTier left, AccessTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessTier"/> values are not the same. </summary>
        public static bool operator !=(AccessTier left, AccessTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessTier"/>. </summary>
        public static implicit operator AccessTier(string value) => new AccessTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
