// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Rai policy mode. The enum value mapping is as below: Default = 0, Deferred=1, Blocking=2, Asynchronous_filter =3. Please use 'Asynchronous_filter' after 2024-10-01. It is the same as 'Deferred' in previous version. </summary>
    public readonly partial struct RaiPolicyMode : IEquatable<RaiPolicyMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RaiPolicyMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RaiPolicyMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string DeferredValue = "Deferred";
        private const string BlockingValue = "Blocking";
        private const string AsynchronousFilterValue = "Asynchronous_filter";

        /// <summary> Default. </summary>
        public static RaiPolicyMode Default { get; } = new RaiPolicyMode(DefaultValue);
        /// <summary> Deferred. </summary>
        public static RaiPolicyMode Deferred { get; } = new RaiPolicyMode(DeferredValue);
        /// <summary> Blocking. </summary>
        public static RaiPolicyMode Blocking { get; } = new RaiPolicyMode(BlockingValue);
        /// <summary> Asynchronous_filter. </summary>
        public static RaiPolicyMode AsynchronousFilter { get; } = new RaiPolicyMode(AsynchronousFilterValue);
        /// <summary> Determines if two <see cref="RaiPolicyMode"/> values are the same. </summary>
        public static bool operator ==(RaiPolicyMode left, RaiPolicyMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RaiPolicyMode"/> values are not the same. </summary>
        public static bool operator !=(RaiPolicyMode left, RaiPolicyMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RaiPolicyMode"/>. </summary>
        public static implicit operator RaiPolicyMode(string value) => new RaiPolicyMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RaiPolicyMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RaiPolicyMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
