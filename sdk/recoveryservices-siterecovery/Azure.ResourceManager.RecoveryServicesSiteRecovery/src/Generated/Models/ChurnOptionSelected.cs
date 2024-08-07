// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A value indicating the churn option selected by user. </summary>
    public readonly partial struct ChurnOptionSelected : IEquatable<ChurnOptionSelected>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChurnOptionSelected"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChurnOptionSelected(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NormalValue = "Normal";
        private const string HighValue = "High";

        /// <summary> Normal. </summary>
        public static ChurnOptionSelected Normal { get; } = new ChurnOptionSelected(NormalValue);
        /// <summary> High. </summary>
        public static ChurnOptionSelected High { get; } = new ChurnOptionSelected(HighValue);
        /// <summary> Determines if two <see cref="ChurnOptionSelected"/> values are the same. </summary>
        public static bool operator ==(ChurnOptionSelected left, ChurnOptionSelected right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChurnOptionSelected"/> values are not the same. </summary>
        public static bool operator !=(ChurnOptionSelected left, ChurnOptionSelected right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChurnOptionSelected"/>. </summary>
        public static implicit operator ChurnOptionSelected(string value) => new ChurnOptionSelected(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChurnOptionSelected other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChurnOptionSelected other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
