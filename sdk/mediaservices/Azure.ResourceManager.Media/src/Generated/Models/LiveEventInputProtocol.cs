// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The input protocol for the live event. This is specified at creation time and cannot be updated. </summary>
    public readonly partial struct LiveEventInputProtocol : IEquatable<LiveEventInputProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LiveEventInputProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LiveEventInputProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FragmentedMp4Value = "FragmentedMP4";
        private const string RtmpValue = "RTMP";

        /// <summary> Smooth Streaming input will be sent by the contribution encoder to the live event. </summary>
        public static LiveEventInputProtocol FragmentedMp4 { get; } = new LiveEventInputProtocol(FragmentedMp4Value);
        /// <summary> RTMP input will be sent by the contribution encoder to the live event. </summary>
        public static LiveEventInputProtocol Rtmp { get; } = new LiveEventInputProtocol(RtmpValue);
        /// <summary> Determines if two <see cref="LiveEventInputProtocol"/> values are the same. </summary>
        public static bool operator ==(LiveEventInputProtocol left, LiveEventInputProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LiveEventInputProtocol"/> values are not the same. </summary>
        public static bool operator !=(LiveEventInputProtocol left, LiveEventInputProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LiveEventInputProtocol"/>. </summary>
        public static implicit operator LiveEventInputProtocol(string value) => new LiveEventInputProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LiveEventInputProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LiveEventInputProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
