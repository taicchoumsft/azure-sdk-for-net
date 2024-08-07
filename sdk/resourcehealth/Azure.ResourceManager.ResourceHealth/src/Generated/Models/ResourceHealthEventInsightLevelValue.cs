// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Level of insight. </summary>
    public readonly partial struct ResourceHealthEventInsightLevelValue : IEquatable<ResourceHealthEventInsightLevelValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthEventInsightLevelValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceHealthEventInsightLevelValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CriticalValue = "Critical";
        private const string WarningValue = "Warning";

        /// <summary> Critical. </summary>
        public static ResourceHealthEventInsightLevelValue Critical { get; } = new ResourceHealthEventInsightLevelValue(CriticalValue);
        /// <summary> Warning. </summary>
        public static ResourceHealthEventInsightLevelValue Warning { get; } = new ResourceHealthEventInsightLevelValue(WarningValue);
        /// <summary> Determines if two <see cref="ResourceHealthEventInsightLevelValue"/> values are the same. </summary>
        public static bool operator ==(ResourceHealthEventInsightLevelValue left, ResourceHealthEventInsightLevelValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceHealthEventInsightLevelValue"/> values are not the same. </summary>
        public static bool operator !=(ResourceHealthEventInsightLevelValue left, ResourceHealthEventInsightLevelValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceHealthEventInsightLevelValue"/>. </summary>
        public static implicit operator ResourceHealthEventInsightLevelValue(string value) => new ResourceHealthEventInsightLevelValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceHealthEventInsightLevelValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceHealthEventInsightLevelValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
