// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Expression type. </summary>
    public readonly partial struct DataFactoryExpressionType : IEquatable<DataFactoryExpressionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFactoryExpressionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFactoryExpressionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExpressionValue = "Expression";

        /// <summary> Expression. </summary>
        public static DataFactoryExpressionType Expression { get; } = new DataFactoryExpressionType(ExpressionValue);
        /// <summary> Determines if two <see cref="DataFactoryExpressionType"/> values are the same. </summary>
        public static bool operator ==(DataFactoryExpressionType left, DataFactoryExpressionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFactoryExpressionType"/> values are not the same. </summary>
        public static bool operator !=(DataFactoryExpressionType left, DataFactoryExpressionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFactoryExpressionType"/>. </summary>
        public static implicit operator DataFactoryExpressionType(string value) => new DataFactoryExpressionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFactoryExpressionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFactoryExpressionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
