// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The form of AutoReplicate that is being used by this cluster. </summary>
    public readonly partial struct CassandraAutoReplicateForm : IEquatable<CassandraAutoReplicateForm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CassandraAutoReplicateForm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CassandraAutoReplicateForm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SystemKeyspacesValue = "SystemKeyspaces";
        private const string AllKeyspacesValue = "AllKeyspaces";

        /// <summary> None. </summary>
        public static CassandraAutoReplicateForm None { get; } = new CassandraAutoReplicateForm(NoneValue);
        /// <summary> SystemKeyspaces. </summary>
        public static CassandraAutoReplicateForm SystemKeyspaces { get; } = new CassandraAutoReplicateForm(SystemKeyspacesValue);
        /// <summary> AllKeyspaces. </summary>
        public static CassandraAutoReplicateForm AllKeyspaces { get; } = new CassandraAutoReplicateForm(AllKeyspacesValue);
        /// <summary> Determines if two <see cref="CassandraAutoReplicateForm"/> values are the same. </summary>
        public static bool operator ==(CassandraAutoReplicateForm left, CassandraAutoReplicateForm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CassandraAutoReplicateForm"/> values are not the same. </summary>
        public static bool operator !=(CassandraAutoReplicateForm left, CassandraAutoReplicateForm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CassandraAutoReplicateForm"/>. </summary>
        public static implicit operator CassandraAutoReplicateForm(string value) => new CassandraAutoReplicateForm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CassandraAutoReplicateForm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CassandraAutoReplicateForm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
