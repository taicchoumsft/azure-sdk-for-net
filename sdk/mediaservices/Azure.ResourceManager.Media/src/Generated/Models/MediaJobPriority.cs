// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing TransformOutputs. The default priority is Normal. </summary>
    public readonly partial struct MediaJobPriority : IEquatable<MediaJobPriority>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaJobPriority"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaJobPriority(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowValue = "Low";
        private const string NormalValue = "Normal";
        private const string HighValue = "High";

        /// <summary> Used for TransformOutputs that can be generated after Normal and High priority TransformOutputs. </summary>
        public static MediaJobPriority Low { get; } = new MediaJobPriority(LowValue);
        /// <summary> Used for TransformOutputs that can be generated at Normal priority. </summary>
        public static MediaJobPriority Normal { get; } = new MediaJobPriority(NormalValue);
        /// <summary> Used for TransformOutputs that should take precedence over others. </summary>
        public static MediaJobPriority High { get; } = new MediaJobPriority(HighValue);
        /// <summary> Determines if two <see cref="MediaJobPriority"/> values are the same. </summary>
        public static bool operator ==(MediaJobPriority left, MediaJobPriority right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaJobPriority"/> values are not the same. </summary>
        public static bool operator !=(MediaJobPriority left, MediaJobPriority right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaJobPriority"/>. </summary>
        public static implicit operator MediaJobPriority(string value) => new MediaJobPriority(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaJobPriority other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaJobPriority other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
