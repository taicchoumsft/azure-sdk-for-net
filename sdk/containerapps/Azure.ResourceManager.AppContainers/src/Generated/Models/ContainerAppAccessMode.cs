// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Access mode for storage. </summary>
    public readonly partial struct ContainerAppAccessMode : IEquatable<ContainerAppAccessMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppAccessMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppAccessMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadOnlyValue = "ReadOnly";
        private const string ReadWriteValue = "ReadWrite";

        /// <summary> ReadOnly. </summary>
        public static ContainerAppAccessMode ReadOnly { get; } = new ContainerAppAccessMode(ReadOnlyValue);
        /// <summary> ReadWrite. </summary>
        public static ContainerAppAccessMode ReadWrite { get; } = new ContainerAppAccessMode(ReadWriteValue);
        /// <summary> Determines if two <see cref="ContainerAppAccessMode"/> values are the same. </summary>
        public static bool operator ==(ContainerAppAccessMode left, ContainerAppAccessMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppAccessMode"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppAccessMode left, ContainerAppAccessMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerAppAccessMode"/>. </summary>
        public static implicit operator ContainerAppAccessMode(string value) => new ContainerAppAccessMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppAccessMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppAccessMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
