// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The WafRuleType. </summary>
    public readonly partial struct WafRuleType : IEquatable<WafRuleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WafRuleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WafRuleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManagedValue = "managed";
        private const string CustomValue = "custom";
        private const string BotValue = "bot";

        /// <summary> managed. </summary>
        public static WafRuleType Managed { get; } = new WafRuleType(ManagedValue);
        /// <summary> custom. </summary>
        public static WafRuleType Custom { get; } = new WafRuleType(CustomValue);
        /// <summary> bot. </summary>
        public static WafRuleType Bot { get; } = new WafRuleType(BotValue);
        /// <summary> Determines if two <see cref="WafRuleType"/> values are the same. </summary>
        public static bool operator ==(WafRuleType left, WafRuleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WafRuleType"/> values are not the same. </summary>
        public static bool operator !=(WafRuleType left, WafRuleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WafRuleType"/>. </summary>
        public static implicit operator WafRuleType(string value) => new WafRuleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WafRuleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WafRuleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
