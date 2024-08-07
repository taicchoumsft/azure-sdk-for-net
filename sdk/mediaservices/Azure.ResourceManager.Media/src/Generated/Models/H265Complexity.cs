// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Tells the encoder how to choose its encoding settings.  Quality will provide for a higher compression ratio but at a higher cost and longer compute time.  Speed will produce a relatively larger file but is faster and more economical. The default value is Balanced. </summary>
    public readonly partial struct H265Complexity : IEquatable<H265Complexity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="H265Complexity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public H265Complexity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SpeedValue = "Speed";
        private const string BalancedValue = "Balanced";
        private const string QualityValue = "Quality";

        /// <summary> Tells the encoder to use settings that are optimized for faster encoding. Quality is sacrificed to decrease encoding time. </summary>
        public static H265Complexity Speed { get; } = new H265Complexity(SpeedValue);
        /// <summary> Tells the encoder to use settings that achieve a balance between speed and quality. </summary>
        public static H265Complexity Balanced { get; } = new H265Complexity(BalancedValue);
        /// <summary> Tells the encoder to use settings that are optimized to produce higher quality output at the expense of slower overall encode time. </summary>
        public static H265Complexity Quality { get; } = new H265Complexity(QualityValue);
        /// <summary> Determines if two <see cref="H265Complexity"/> values are the same. </summary>
        public static bool operator ==(H265Complexity left, H265Complexity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="H265Complexity"/> values are not the same. </summary>
        public static bool operator !=(H265Complexity left, H265Complexity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="H265Complexity"/>. </summary>
        public static implicit operator H265Complexity(string value) => new H265Complexity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is H265Complexity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(H265Complexity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
