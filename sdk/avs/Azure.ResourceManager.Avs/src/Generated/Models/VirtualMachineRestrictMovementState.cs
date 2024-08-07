// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Whether VM DRS-driven movement is restricted (enabled) or not (disabled). </summary>
    public readonly partial struct VirtualMachineRestrictMovementState : IEquatable<VirtualMachineRestrictMovementState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRestrictMovementState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualMachineRestrictMovementState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static VirtualMachineRestrictMovementState Enabled { get; } = new VirtualMachineRestrictMovementState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static VirtualMachineRestrictMovementState Disabled { get; } = new VirtualMachineRestrictMovementState(DisabledValue);
        /// <summary> Determines if two <see cref="VirtualMachineRestrictMovementState"/> values are the same. </summary>
        public static bool operator ==(VirtualMachineRestrictMovementState left, VirtualMachineRestrictMovementState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualMachineRestrictMovementState"/> values are not the same. </summary>
        public static bool operator !=(VirtualMachineRestrictMovementState left, VirtualMachineRestrictMovementState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualMachineRestrictMovementState"/>. </summary>
        public static implicit operator VirtualMachineRestrictMovementState(string value) => new VirtualMachineRestrictMovementState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualMachineRestrictMovementState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualMachineRestrictMovementState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
