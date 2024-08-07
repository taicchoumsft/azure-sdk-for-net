// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Describes the status of a service. </summary>
    public readonly partial struct CosmosDBServiceStatus : IEquatable<CosmosDBServiceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBServiceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBServiceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string RunningValue = "Running";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string ErrorValue = "Error";
        private const string StoppedValue = "Stopped";

        /// <summary> Creating. </summary>
        public static CosmosDBServiceStatus Creating { get; } = new CosmosDBServiceStatus(CreatingValue);
        /// <summary> Running. </summary>
        public static CosmosDBServiceStatus Running { get; } = new CosmosDBServiceStatus(RunningValue);
        /// <summary> Updating. </summary>
        public static CosmosDBServiceStatus Updating { get; } = new CosmosDBServiceStatus(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static CosmosDBServiceStatus Deleting { get; } = new CosmosDBServiceStatus(DeletingValue);
        /// <summary> Error. </summary>
        public static CosmosDBServiceStatus Error { get; } = new CosmosDBServiceStatus(ErrorValue);
        /// <summary> Stopped. </summary>
        public static CosmosDBServiceStatus Stopped { get; } = new CosmosDBServiceStatus(StoppedValue);
        /// <summary> Determines if two <see cref="CosmosDBServiceStatus"/> values are the same. </summary>
        public static bool operator ==(CosmosDBServiceStatus left, CosmosDBServiceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBServiceStatus"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBServiceStatus left, CosmosDBServiceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBServiceStatus"/>. </summary>
        public static implicit operator CosmosDBServiceStatus(string value) => new CosmosDBServiceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBServiceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBServiceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
