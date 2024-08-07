// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Storage workload type. </summary>
    public readonly partial struct SqlVmStorageWorkloadType : IEquatable<SqlVmStorageWorkloadType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlVmStorageWorkloadType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlVmStorageWorkloadType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeneralValue = "GENERAL";
        private const string OltpValue = "OLTP";
        private const string DWValue = "DW";

        /// <summary> GENERAL. </summary>
        public static SqlVmStorageWorkloadType General { get; } = new SqlVmStorageWorkloadType(GeneralValue);
        /// <summary> OLTP. </summary>
        public static SqlVmStorageWorkloadType Oltp { get; } = new SqlVmStorageWorkloadType(OltpValue);
        /// <summary> DW. </summary>
        public static SqlVmStorageWorkloadType DW { get; } = new SqlVmStorageWorkloadType(DWValue);
        /// <summary> Determines if two <see cref="SqlVmStorageWorkloadType"/> values are the same. </summary>
        public static bool operator ==(SqlVmStorageWorkloadType left, SqlVmStorageWorkloadType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlVmStorageWorkloadType"/> values are not the same. </summary>
        public static bool operator !=(SqlVmStorageWorkloadType left, SqlVmStorageWorkloadType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlVmStorageWorkloadType"/>. </summary>
        public static implicit operator SqlVmStorageWorkloadType(string value) => new SqlVmStorageWorkloadType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlVmStorageWorkloadType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlVmStorageWorkloadType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
