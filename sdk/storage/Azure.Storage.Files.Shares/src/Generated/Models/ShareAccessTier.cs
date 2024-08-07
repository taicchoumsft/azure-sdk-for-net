// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> The ShareAccessTier. </summary>
    public readonly partial struct ShareAccessTier : IEquatable<ShareAccessTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ShareAccessTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ShareAccessTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TransactionOptimizedValue = "TransactionOptimized";
        private const string HotValue = "Hot";
        private const string CoolValue = "Cool";

        /// <summary> TransactionOptimized. </summary>
        public static ShareAccessTier TransactionOptimized { get; } = new ShareAccessTier(TransactionOptimizedValue);
        /// <summary> Hot. </summary>
        public static ShareAccessTier Hot { get; } = new ShareAccessTier(HotValue);
        /// <summary> Cool. </summary>
        public static ShareAccessTier Cool { get; } = new ShareAccessTier(CoolValue);
        /// <summary> Determines if two <see cref="ShareAccessTier"/> values are the same. </summary>
        public static bool operator ==(ShareAccessTier left, ShareAccessTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ShareAccessTier"/> values are not the same. </summary>
        public static bool operator !=(ShareAccessTier left, ShareAccessTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ShareAccessTier"/>. </summary>
        public static implicit operator ShareAccessTier(string value) => new ShareAccessTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ShareAccessTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ShareAccessTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
