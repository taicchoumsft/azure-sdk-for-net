// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningListViewType. </summary>
    public readonly partial struct MachineLearningListViewType : IEquatable<MachineLearningListViewType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningListViewType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningListViewType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveOnlyValue = "ActiveOnly";
        private const string ArchivedOnlyValue = "ArchivedOnly";
        private const string AllValue = "All";

        /// <summary> ActiveOnly. </summary>
        public static MachineLearningListViewType ActiveOnly { get; } = new MachineLearningListViewType(ActiveOnlyValue);
        /// <summary> ArchivedOnly. </summary>
        public static MachineLearningListViewType ArchivedOnly { get; } = new MachineLearningListViewType(ArchivedOnlyValue);
        /// <summary> All. </summary>
        public static MachineLearningListViewType All { get; } = new MachineLearningListViewType(AllValue);
        /// <summary> Determines if two <see cref="MachineLearningListViewType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningListViewType left, MachineLearningListViewType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningListViewType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningListViewType left, MachineLearningListViewType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningListViewType"/>. </summary>
        public static implicit operator MachineLearningListViewType(string value) => new MachineLearningListViewType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningListViewType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningListViewType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
