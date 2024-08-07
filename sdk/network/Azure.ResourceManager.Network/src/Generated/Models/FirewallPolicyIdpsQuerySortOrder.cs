// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes if results should be in ascending/descending order. </summary>
    public readonly partial struct FirewallPolicyIdpsQuerySortOrder : IEquatable<FirewallPolicyIdpsQuerySortOrder>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyIdpsQuerySortOrder"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirewallPolicyIdpsQuerySortOrder(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AscendingValue = "Ascending";
        private const string DescendingValue = "Descending";

        /// <summary> Ascending. </summary>
        public static FirewallPolicyIdpsQuerySortOrder Ascending { get; } = new FirewallPolicyIdpsQuerySortOrder(AscendingValue);
        /// <summary> Descending. </summary>
        public static FirewallPolicyIdpsQuerySortOrder Descending { get; } = new FirewallPolicyIdpsQuerySortOrder(DescendingValue);
        /// <summary> Determines if two <see cref="FirewallPolicyIdpsQuerySortOrder"/> values are the same. </summary>
        public static bool operator ==(FirewallPolicyIdpsQuerySortOrder left, FirewallPolicyIdpsQuerySortOrder right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallPolicyIdpsQuerySortOrder"/> values are not the same. </summary>
        public static bool operator !=(FirewallPolicyIdpsQuerySortOrder left, FirewallPolicyIdpsQuerySortOrder right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallPolicyIdpsQuerySortOrder"/>. </summary>
        public static implicit operator FirewallPolicyIdpsQuerySortOrder(string value) => new FirewallPolicyIdpsQuerySortOrder(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallPolicyIdpsQuerySortOrder other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallPolicyIdpsQuerySortOrder other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
