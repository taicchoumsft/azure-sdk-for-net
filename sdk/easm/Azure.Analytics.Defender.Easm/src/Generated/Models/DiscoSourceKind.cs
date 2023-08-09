// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The kind of disco source. </summary>
    public readonly partial struct DiscoSourceKind : IEquatable<DiscoSourceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiscoSourceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiscoSourceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AsValue = "as";
        private const string AttributeValue = "attribute";
        private const string ContactValue = "contact";
        private const string DomainValue = "domain";
        private const string HostValue = "host";
        private const string IpBlockValue = "ipBlock";

        /// <summary> as. </summary>
        public static DiscoSourceKind As { get; } = new DiscoSourceKind(AsValue);
        /// <summary> attribute. </summary>
        public static DiscoSourceKind Attribute { get; } = new DiscoSourceKind(AttributeValue);
        /// <summary> contact. </summary>
        public static DiscoSourceKind Contact { get; } = new DiscoSourceKind(ContactValue);
        /// <summary> domain. </summary>
        public static DiscoSourceKind Domain { get; } = new DiscoSourceKind(DomainValue);
        /// <summary> host. </summary>
        public static DiscoSourceKind Host { get; } = new DiscoSourceKind(HostValue);
        /// <summary> ipBlock. </summary>
        public static DiscoSourceKind IpBlock { get; } = new DiscoSourceKind(IpBlockValue);
        /// <summary> Determines if two <see cref="DiscoSourceKind"/> values are the same. </summary>
        public static bool operator ==(DiscoSourceKind left, DiscoSourceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiscoSourceKind"/> values are not the same. </summary>
        public static bool operator !=(DiscoSourceKind left, DiscoSourceKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiscoSourceKind"/>. </summary>
        public static implicit operator DiscoSourceKind(string value) => new DiscoSourceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiscoSourceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiscoSourceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
