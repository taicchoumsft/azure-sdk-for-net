// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> A specific data exfiltration scenario that is disabled for the service. </summary>
    public readonly partial struct SearchDisabledDataExfiltrationOption : IEquatable<SearchDisabledDataExfiltrationOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SearchDisabledDataExfiltrationOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SearchDisabledDataExfiltrationOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "All";

        /// <summary> Indicates that all data exfiltration scenarios are disabled. </summary>
        public static SearchDisabledDataExfiltrationOption All { get; } = new SearchDisabledDataExfiltrationOption(AllValue);
        /// <summary> Determines if two <see cref="SearchDisabledDataExfiltrationOption"/> values are the same. </summary>
        public static bool operator ==(SearchDisabledDataExfiltrationOption left, SearchDisabledDataExfiltrationOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchDisabledDataExfiltrationOption"/> values are not the same. </summary>
        public static bool operator !=(SearchDisabledDataExfiltrationOption left, SearchDisabledDataExfiltrationOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SearchDisabledDataExfiltrationOption"/>. </summary>
        public static implicit operator SearchDisabledDataExfiltrationOption(string value) => new SearchDisabledDataExfiltrationOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchDisabledDataExfiltrationOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchDisabledDataExfiltrationOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
