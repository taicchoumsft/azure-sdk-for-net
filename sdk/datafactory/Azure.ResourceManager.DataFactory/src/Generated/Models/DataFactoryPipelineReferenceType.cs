// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Pipeline reference type. </summary>
    public readonly partial struct DataFactoryPipelineReferenceType : IEquatable<DataFactoryPipelineReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFactoryPipelineReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PipelineReferenceValue = "PipelineReference";

        /// <summary> PipelineReference. </summary>
        public static DataFactoryPipelineReferenceType PipelineReference { get; } = new DataFactoryPipelineReferenceType(PipelineReferenceValue);
        /// <summary> Determines if two <see cref="DataFactoryPipelineReferenceType"/> values are the same. </summary>
        public static bool operator ==(DataFactoryPipelineReferenceType left, DataFactoryPipelineReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFactoryPipelineReferenceType"/> values are not the same. </summary>
        public static bool operator !=(DataFactoryPipelineReferenceType left, DataFactoryPipelineReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFactoryPipelineReferenceType"/>. </summary>
        public static implicit operator DataFactoryPipelineReferenceType(string value) => new DataFactoryPipelineReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFactoryPipelineReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFactoryPipelineReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
