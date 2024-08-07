// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Describes the image scaling mode to be applied. Default mode is 'pad'. </summary>
    public readonly partial struct ImageScaleMode : IEquatable<ImageScaleMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImageScaleMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageScaleMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreserveAspectRatioValue = "preserveAspectRatio";
        private const string PadValue = "pad";
        private const string StretchValue = "stretch";

        /// <summary> Preserves the same aspect ratio as the input image. If only one image dimension is provided, the second dimension is calculated based on the input image aspect ratio. When 2 dimensions are provided, the image is resized to fit the most constraining dimension, considering the input image size and aspect ratio. </summary>
        public static ImageScaleMode PreserveAspectRatio { get; } = new ImageScaleMode(PreserveAspectRatioValue);
        /// <summary> Pads the image with black horizontal stripes (letterbox) or black vertical stripes (pillar-box) so the image is resized to the specified dimensions while not altering the content aspect ratio. </summary>
        public static ImageScaleMode Pad { get; } = new ImageScaleMode(PadValue);
        /// <summary> Stretches the original image so it resized to the specified dimensions. </summary>
        public static ImageScaleMode Stretch { get; } = new ImageScaleMode(StretchValue);
        /// <summary> Determines if two <see cref="ImageScaleMode"/> values are the same. </summary>
        public static bool operator ==(ImageScaleMode left, ImageScaleMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageScaleMode"/> values are not the same. </summary>
        public static bool operator !=(ImageScaleMode left, ImageScaleMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImageScaleMode"/>. </summary>
        public static implicit operator ImageScaleMode(string value) => new ImageScaleMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageScaleMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageScaleMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
