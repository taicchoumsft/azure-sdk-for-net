// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VPN client Processor Architecture. </summary>
    public readonly partial struct ProcessorArchitecture : IEquatable<ProcessorArchitecture>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProcessorArchitecture"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProcessorArchitecture(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Amd64Value = "Amd64";
        private const string X86Value = "X86";

        /// <summary> Amd64. </summary>
        public static ProcessorArchitecture Amd64 { get; } = new ProcessorArchitecture(Amd64Value);
        /// <summary> X86. </summary>
        public static ProcessorArchitecture X86 { get; } = new ProcessorArchitecture(X86Value);
        /// <summary> Determines if two <see cref="ProcessorArchitecture"/> values are the same. </summary>
        public static bool operator ==(ProcessorArchitecture left, ProcessorArchitecture right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProcessorArchitecture"/> values are not the same. </summary>
        public static bool operator !=(ProcessorArchitecture left, ProcessorArchitecture right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProcessorArchitecture"/>. </summary>
        public static implicit operator ProcessorArchitecture(string value) => new ProcessorArchitecture(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProcessorArchitecture other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProcessorArchitecture other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
