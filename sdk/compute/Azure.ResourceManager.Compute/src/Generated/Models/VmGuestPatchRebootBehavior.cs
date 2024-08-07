// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the reboot requirements of the patch. </summary>
    public readonly partial struct VmGuestPatchRebootBehavior : IEquatable<VmGuestPatchRebootBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmGuestPatchRebootBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmGuestPatchRebootBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string NeverRebootsValue = "NeverReboots";
        private const string AlwaysRequiresRebootValue = "AlwaysRequiresReboot";
        private const string CanRequestRebootValue = "CanRequestReboot";

        /// <summary> Unknown. </summary>
        public static VmGuestPatchRebootBehavior Unknown { get; } = new VmGuestPatchRebootBehavior(UnknownValue);
        /// <summary> NeverReboots. </summary>
        public static VmGuestPatchRebootBehavior NeverReboots { get; } = new VmGuestPatchRebootBehavior(NeverRebootsValue);
        /// <summary> AlwaysRequiresReboot. </summary>
        public static VmGuestPatchRebootBehavior AlwaysRequiresReboot { get; } = new VmGuestPatchRebootBehavior(AlwaysRequiresRebootValue);
        /// <summary> CanRequestReboot. </summary>
        public static VmGuestPatchRebootBehavior CanRequestReboot { get; } = new VmGuestPatchRebootBehavior(CanRequestRebootValue);
        /// <summary> Determines if two <see cref="VmGuestPatchRebootBehavior"/> values are the same. </summary>
        public static bool operator ==(VmGuestPatchRebootBehavior left, VmGuestPatchRebootBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmGuestPatchRebootBehavior"/> values are not the same. </summary>
        public static bool operator !=(VmGuestPatchRebootBehavior left, VmGuestPatchRebootBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VmGuestPatchRebootBehavior"/>. </summary>
        public static implicit operator VmGuestPatchRebootBehavior(string value) => new VmGuestPatchRebootBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmGuestPatchRebootBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmGuestPatchRebootBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
