// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Status of the portal's revision. </summary>
    public readonly partial struct PortalRevisionStatus : IEquatable<PortalRevisionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PortalRevisionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PortalRevisionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "pending";
        private const string PublishingValue = "publishing";
        private const string CompletedValue = "completed";
        private const string FailedValue = "failed";

        /// <summary> Portal's revision has been queued. </summary>
        public static PortalRevisionStatus Pending { get; } = new PortalRevisionStatus(PendingValue);
        /// <summary> Portal's revision is being published. </summary>
        public static PortalRevisionStatus Publishing { get; } = new PortalRevisionStatus(PublishingValue);
        /// <summary> Portal's revision publishing completed. </summary>
        public static PortalRevisionStatus Completed { get; } = new PortalRevisionStatus(CompletedValue);
        /// <summary> Portal's revision publishing failed. </summary>
        public static PortalRevisionStatus Failed { get; } = new PortalRevisionStatus(FailedValue);
        /// <summary> Determines if two <see cref="PortalRevisionStatus"/> values are the same. </summary>
        public static bool operator ==(PortalRevisionStatus left, PortalRevisionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PortalRevisionStatus"/> values are not the same. </summary>
        public static bool operator !=(PortalRevisionStatus left, PortalRevisionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PortalRevisionStatus"/>. </summary>
        public static implicit operator PortalRevisionStatus(string value) => new PortalRevisionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PortalRevisionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PortalRevisionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
