// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Soft Delete feature state. </summary>
    public readonly partial struct SoftDeleteFeatureState : IEquatable<SoftDeleteFeatureState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SoftDeleteFeatureState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SoftDeleteFeatureState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";
        private const string AlwaysONValue = "AlwaysON";

        /// <summary> Invalid. </summary>
        public static SoftDeleteFeatureState Invalid { get; } = new SoftDeleteFeatureState(InvalidValue);
        /// <summary> Enabled. </summary>
        public static SoftDeleteFeatureState Enabled { get; } = new SoftDeleteFeatureState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static SoftDeleteFeatureState Disabled { get; } = new SoftDeleteFeatureState(DisabledValue);
        /// <summary> AlwaysON. </summary>
        public static SoftDeleteFeatureState AlwaysON { get; } = new SoftDeleteFeatureState(AlwaysONValue);
        /// <summary> Determines if two <see cref="SoftDeleteFeatureState"/> values are the same. </summary>
        public static bool operator ==(SoftDeleteFeatureState left, SoftDeleteFeatureState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SoftDeleteFeatureState"/> values are not the same. </summary>
        public static bool operator !=(SoftDeleteFeatureState left, SoftDeleteFeatureState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SoftDeleteFeatureState"/>. </summary>
        public static implicit operator SoftDeleteFeatureState(string value) => new SoftDeleteFeatureState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SoftDeleteFeatureState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SoftDeleteFeatureState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
