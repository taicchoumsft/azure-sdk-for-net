// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> Type of chunking strategy. </summary>
    internal readonly partial struct VectorStoreChunkingStrategyResponseType : IEquatable<VectorStoreChunkingStrategyResponseType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreChunkingStrategyResponseType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreChunkingStrategyResponseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "other";
        private const string StaticValue = "static";

        /// <summary> other. </summary>
        public static VectorStoreChunkingStrategyResponseType Other { get; } = new VectorStoreChunkingStrategyResponseType(OtherValue);
        /// <summary> static. </summary>
        public static VectorStoreChunkingStrategyResponseType Static { get; } = new VectorStoreChunkingStrategyResponseType(StaticValue);
        /// <summary> Determines if two <see cref="VectorStoreChunkingStrategyResponseType"/> values are the same. </summary>
        public static bool operator ==(VectorStoreChunkingStrategyResponseType left, VectorStoreChunkingStrategyResponseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreChunkingStrategyResponseType"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreChunkingStrategyResponseType left, VectorStoreChunkingStrategyResponseType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorStoreChunkingStrategyResponseType"/>. </summary>
        public static implicit operator VectorStoreChunkingStrategyResponseType(string value) => new VectorStoreChunkingStrategyResponseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreChunkingStrategyResponseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreChunkingStrategyResponseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
