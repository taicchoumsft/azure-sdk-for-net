// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> Enum for business attribute update behavior. </summary>
    public readonly partial struct BusinessAttributeUpdateBehavior : IEquatable<BusinessAttributeUpdateBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BusinessAttributeUpdateBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BusinessAttributeUpdateBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IgnoreValue = "ignore";
        private const string ReplaceValue = "replace";
        private const string MergeValue = "merge";

        /// <summary> Ignore the business attribute payload for update. </summary>
        public static BusinessAttributeUpdateBehavior Ignore { get; } = new BusinessAttributeUpdateBehavior(IgnoreValue);
        /// <summary> Replace all the business attributes using the payload. </summary>
        public static BusinessAttributeUpdateBehavior Replace { get; } = new BusinessAttributeUpdateBehavior(ReplaceValue);
        /// <summary> Merge the business attributes. Business attributes will not be updated if not provided. </summary>
        public static BusinessAttributeUpdateBehavior Merge { get; } = new BusinessAttributeUpdateBehavior(MergeValue);
        /// <summary> Determines if two <see cref="BusinessAttributeUpdateBehavior"/> values are the same. </summary>
        public static bool operator ==(BusinessAttributeUpdateBehavior left, BusinessAttributeUpdateBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BusinessAttributeUpdateBehavior"/> values are not the same. </summary>
        public static bool operator !=(BusinessAttributeUpdateBehavior left, BusinessAttributeUpdateBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BusinessAttributeUpdateBehavior"/>. </summary>
        public static implicit operator BusinessAttributeUpdateBehavior(string value) => new BusinessAttributeUpdateBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BusinessAttributeUpdateBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BusinessAttributeUpdateBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
