// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The Sku tier. </summary>
    public readonly partial struct DataBoxEdgeSkuTier : IEquatable<DataBoxEdgeSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";

        /// <summary> Standard. </summary>
        public static DataBoxEdgeSkuTier Standard { get; } = new DataBoxEdgeSkuTier(StandardValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeSkuTier"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeSkuTier left, DataBoxEdgeSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeSkuTier"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeSkuTier left, DataBoxEdgeSkuTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoxEdgeSkuTier"/>. </summary>
        public static implicit operator DataBoxEdgeSkuTier(string value) => new DataBoxEdgeSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
