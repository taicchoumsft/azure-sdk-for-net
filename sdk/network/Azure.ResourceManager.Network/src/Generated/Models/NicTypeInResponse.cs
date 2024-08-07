// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> NIC type - PublicNic, PrivateNic, or AdditionalNic. </summary>
    public readonly partial struct NicTypeInResponse : IEquatable<NicTypeInResponse>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NicTypeInResponse"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NicTypeInResponse(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicNicValue = "PublicNic";
        private const string PrivateNicValue = "PrivateNic";
        private const string AdditionalNicValue = "AdditionalNic";

        /// <summary> PublicNic. </summary>
        public static NicTypeInResponse PublicNic { get; } = new NicTypeInResponse(PublicNicValue);
        /// <summary> PrivateNic. </summary>
        public static NicTypeInResponse PrivateNic { get; } = new NicTypeInResponse(PrivateNicValue);
        /// <summary> AdditionalNic. </summary>
        public static NicTypeInResponse AdditionalNic { get; } = new NicTypeInResponse(AdditionalNicValue);
        /// <summary> Determines if two <see cref="NicTypeInResponse"/> values are the same. </summary>
        public static bool operator ==(NicTypeInResponse left, NicTypeInResponse right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NicTypeInResponse"/> values are not the same. </summary>
        public static bool operator !=(NicTypeInResponse left, NicTypeInResponse right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NicTypeInResponse"/>. </summary>
        public static implicit operator NicTypeInResponse(string value) => new NicTypeInResponse(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NicTypeInResponse other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NicTypeInResponse other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
