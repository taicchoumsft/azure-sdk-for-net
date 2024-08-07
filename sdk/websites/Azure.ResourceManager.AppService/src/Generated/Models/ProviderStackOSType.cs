// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ProviderStackOSType. </summary>
    public readonly partial struct ProviderStackOSType : IEquatable<ProviderStackOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProviderStackOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProviderStackOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";
        private const string AllValue = "All";

        /// <summary> Windows. </summary>
        public static ProviderStackOSType Windows { get; } = new ProviderStackOSType(WindowsValue);
        /// <summary> Linux. </summary>
        public static ProviderStackOSType Linux { get; } = new ProviderStackOSType(LinuxValue);
        /// <summary> All. </summary>
        public static ProviderStackOSType All { get; } = new ProviderStackOSType(AllValue);
        /// <summary> Determines if two <see cref="ProviderStackOSType"/> values are the same. </summary>
        public static bool operator ==(ProviderStackOSType left, ProviderStackOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProviderStackOSType"/> values are not the same. </summary>
        public static bool operator !=(ProviderStackOSType left, ProviderStackOSType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProviderStackOSType"/>. </summary>
        public static implicit operator ProviderStackOSType(string value) => new ProviderStackOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProviderStackOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProviderStackOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
