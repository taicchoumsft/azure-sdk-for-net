// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Data source type. </summary>
    public readonly partial struct MachineLearningSourceType : IEquatable<MachineLearningSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DatasetValue = "Dataset";
        private const string DatastoreValue = "Datastore";
        private const string UriValue = "URI";

        /// <summary> Dataset. </summary>
        public static MachineLearningSourceType Dataset { get; } = new MachineLearningSourceType(DatasetValue);
        /// <summary> Datastore. </summary>
        public static MachineLearningSourceType Datastore { get; } = new MachineLearningSourceType(DatastoreValue);
        /// <summary> URI. </summary>
        public static MachineLearningSourceType Uri { get; } = new MachineLearningSourceType(UriValue);
        /// <summary> Determines if two <see cref="MachineLearningSourceType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningSourceType left, MachineLearningSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningSourceType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningSourceType left, MachineLearningSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningSourceType"/>. </summary>
        public static implicit operator MachineLearningSourceType(string value) => new MachineLearningSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
