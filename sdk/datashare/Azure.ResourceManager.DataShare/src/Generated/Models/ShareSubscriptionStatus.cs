// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Gets the status of share subscription. </summary>
    public readonly partial struct ShareSubscriptionStatus : IEquatable<ShareSubscriptionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ShareSubscriptionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ShareSubscriptionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string RevokedValue = "Revoked";
        private const string SourceDeletedValue = "SourceDeleted";
        private const string RevokingValue = "Revoking";

        /// <summary> Active. </summary>
        public static ShareSubscriptionStatus Active { get; } = new ShareSubscriptionStatus(ActiveValue);
        /// <summary> Revoked. </summary>
        public static ShareSubscriptionStatus Revoked { get; } = new ShareSubscriptionStatus(RevokedValue);
        /// <summary> SourceDeleted. </summary>
        public static ShareSubscriptionStatus SourceDeleted { get; } = new ShareSubscriptionStatus(SourceDeletedValue);
        /// <summary> Revoking. </summary>
        public static ShareSubscriptionStatus Revoking { get; } = new ShareSubscriptionStatus(RevokingValue);
        /// <summary> Determines if two <see cref="ShareSubscriptionStatus"/> values are the same. </summary>
        public static bool operator ==(ShareSubscriptionStatus left, ShareSubscriptionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ShareSubscriptionStatus"/> values are not the same. </summary>
        public static bool operator !=(ShareSubscriptionStatus left, ShareSubscriptionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ShareSubscriptionStatus"/>. </summary>
        public static implicit operator ShareSubscriptionStatus(string value) => new ShareSubscriptionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ShareSubscriptionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ShareSubscriptionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
