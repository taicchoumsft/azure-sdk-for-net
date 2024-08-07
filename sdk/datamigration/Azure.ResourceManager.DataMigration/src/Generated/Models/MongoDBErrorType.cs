// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The type of error or warning. </summary>
    public readonly partial struct MongoDBErrorType : IEquatable<MongoDBErrorType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoDBErrorType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoDBErrorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string ValidationErrorValue = "ValidationError";
        private const string WarningValue = "Warning";

        /// <summary> Error. </summary>
        public static MongoDBErrorType Error { get; } = new MongoDBErrorType(ErrorValue);
        /// <summary> ValidationError. </summary>
        public static MongoDBErrorType ValidationError { get; } = new MongoDBErrorType(ValidationErrorValue);
        /// <summary> Warning. </summary>
        public static MongoDBErrorType Warning { get; } = new MongoDBErrorType(WarningValue);
        /// <summary> Determines if two <see cref="MongoDBErrorType"/> values are the same. </summary>
        public static bool operator ==(MongoDBErrorType left, MongoDBErrorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoDBErrorType"/> values are not the same. </summary>
        public static bool operator !=(MongoDBErrorType left, MongoDBErrorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MongoDBErrorType"/>. </summary>
        public static implicit operator MongoDBErrorType(string value) => new MongoDBErrorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoDBErrorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoDBErrorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
