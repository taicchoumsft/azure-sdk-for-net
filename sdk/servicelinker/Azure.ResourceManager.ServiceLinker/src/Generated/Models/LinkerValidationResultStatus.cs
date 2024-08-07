// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The result of validation. </summary>
    public readonly partial struct LinkerValidationResultStatus : IEquatable<LinkerValidationResultStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LinkerValidationResultStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LinkerValidationResultStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SuccessValue = "success";
        private const string FailureValue = "failure";
        private const string WarningValue = "warning";

        /// <summary> success. </summary>
        public static LinkerValidationResultStatus Success { get; } = new LinkerValidationResultStatus(SuccessValue);
        /// <summary> failure. </summary>
        public static LinkerValidationResultStatus Failure { get; } = new LinkerValidationResultStatus(FailureValue);
        /// <summary> warning. </summary>
        public static LinkerValidationResultStatus Warning { get; } = new LinkerValidationResultStatus(WarningValue);
        /// <summary> Determines if two <see cref="LinkerValidationResultStatus"/> values are the same. </summary>
        public static bool operator ==(LinkerValidationResultStatus left, LinkerValidationResultStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LinkerValidationResultStatus"/> values are not the same. </summary>
        public static bool operator !=(LinkerValidationResultStatus left, LinkerValidationResultStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LinkerValidationResultStatus"/>. </summary>
        public static implicit operator LinkerValidationResultStatus(string value) => new LinkerValidationResultStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LinkerValidationResultStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LinkerValidationResultStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
