// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Audio channel type to stream, eg. unmixed audio, mixed audio. </summary>
    public readonly partial struct MediaStreamingAudioChannel : IEquatable<MediaStreamingAudioChannel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaStreamingAudioChannel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaStreamingAudioChannel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MixedValue = "mixed";
        private const string UnmixedValue = "unmixed";

        /// <summary> mixed. </summary>
        public static MediaStreamingAudioChannel Mixed { get; } = new MediaStreamingAudioChannel(MixedValue);
        /// <summary> unmixed. </summary>
        public static MediaStreamingAudioChannel Unmixed { get; } = new MediaStreamingAudioChannel(UnmixedValue);
        /// <summary> Determines if two <see cref="MediaStreamingAudioChannel"/> values are the same. </summary>
        public static bool operator ==(MediaStreamingAudioChannel left, MediaStreamingAudioChannel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaStreamingAudioChannel"/> values are not the same. </summary>
        public static bool operator !=(MediaStreamingAudioChannel left, MediaStreamingAudioChannel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaStreamingAudioChannel"/>. </summary>
        public static implicit operator MediaStreamingAudioChannel(string value) => new MediaStreamingAudioChannel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaStreamingAudioChannel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaStreamingAudioChannel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
