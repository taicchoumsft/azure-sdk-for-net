// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The type of data source. </summary>
    public readonly partial struct MongoDbClusterType : IEquatable<MongoDbClusterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoDbClusterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoDbClusterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BlobContainerValue = "BlobContainer";
        private const string CosmosDbValue = "CosmosDb";
        private const string MongoDbValue = "MongoDb";

        /// <summary> BlobContainer. </summary>
        public static MongoDbClusterType BlobContainer { get; } = new MongoDbClusterType(BlobContainerValue);
        /// <summary> CosmosDb. </summary>
        public static MongoDbClusterType CosmosDb { get; } = new MongoDbClusterType(CosmosDbValue);
        /// <summary> MongoDb. </summary>
        public static MongoDbClusterType MongoDb { get; } = new MongoDbClusterType(MongoDbValue);
        /// <summary> Determines if two <see cref="MongoDbClusterType"/> values are the same. </summary>
        public static bool operator ==(MongoDbClusterType left, MongoDbClusterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoDbClusterType"/> values are not the same. </summary>
        public static bool operator !=(MongoDbClusterType left, MongoDbClusterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MongoDbClusterType"/>. </summary>
        public static implicit operator MongoDbClusterType(string value) => new MongoDbClusterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoDbClusterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoDbClusterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
