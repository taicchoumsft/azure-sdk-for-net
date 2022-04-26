// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Error type. </summary>
    internal readonly partial struct ErrorType : IEquatable<ErrorType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ErrorType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ErrorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";

        /// <summary> Default. </summary>
        public static ErrorType Default { get; } = new ErrorType(DefaultValue);
        /// <summary> Warning. </summary>
        public static ErrorType Warning { get; } = new ErrorType(WarningValue);
        /// <summary> Error. </summary>
        public static ErrorType Error { get; } = new ErrorType(ErrorValue);
        /// <summary> Determines if two <see cref="ErrorType"/> values are the same. </summary>
        public static bool operator ==(ErrorType left, ErrorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ErrorType"/> values are not the same. </summary>
        public static bool operator !=(ErrorType left, ErrorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ErrorType"/>. </summary>
        public static implicit operator ErrorType(string value) => new ErrorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ErrorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ErrorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
