// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The synchronization state of the catalog. </summary>
    public readonly partial struct DevCenterCatalogSyncState : IEquatable<DevCenterCatalogSyncState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevCenterCatalogSyncState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevCenterCatalogSyncState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string InProgressValue = "InProgress";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static DevCenterCatalogSyncState Succeeded { get; } = new DevCenterCatalogSyncState(SucceededValue);
        /// <summary> InProgress. </summary>
        public static DevCenterCatalogSyncState InProgress { get; } = new DevCenterCatalogSyncState(InProgressValue);
        /// <summary> Failed. </summary>
        public static DevCenterCatalogSyncState Failed { get; } = new DevCenterCatalogSyncState(FailedValue);
        /// <summary> Canceled. </summary>
        public static DevCenterCatalogSyncState Canceled { get; } = new DevCenterCatalogSyncState(CanceledValue);
        /// <summary> Determines if two <see cref="DevCenterCatalogSyncState"/> values are the same. </summary>
        public static bool operator ==(DevCenterCatalogSyncState left, DevCenterCatalogSyncState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevCenterCatalogSyncState"/> values are not the same. </summary>
        public static bool operator !=(DevCenterCatalogSyncState left, DevCenterCatalogSyncState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevCenterCatalogSyncState"/>. </summary>
        public static implicit operator DevCenterCatalogSyncState(string value) => new DevCenterCatalogSyncState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevCenterCatalogSyncState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevCenterCatalogSyncState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
