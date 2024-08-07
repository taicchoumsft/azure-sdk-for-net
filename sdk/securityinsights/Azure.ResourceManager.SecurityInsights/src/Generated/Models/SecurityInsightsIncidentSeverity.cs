// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The severity of the incident. </summary>
    public readonly partial struct SecurityInsightsIncidentSeverity : IEquatable<SecurityInsightsIncidentSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsIncidentSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HighValue = "High";
        private const string MediumValue = "Medium";
        private const string LowValue = "Low";
        private const string InformationalValue = "Informational";

        /// <summary> High severity. </summary>
        public static SecurityInsightsIncidentSeverity High { get; } = new SecurityInsightsIncidentSeverity(HighValue);
        /// <summary> Medium severity. </summary>
        public static SecurityInsightsIncidentSeverity Medium { get; } = new SecurityInsightsIncidentSeverity(MediumValue);
        /// <summary> Low severity. </summary>
        public static SecurityInsightsIncidentSeverity Low { get; } = new SecurityInsightsIncidentSeverity(LowValue);
        /// <summary> Informational severity. </summary>
        public static SecurityInsightsIncidentSeverity Informational { get; } = new SecurityInsightsIncidentSeverity(InformationalValue);
        /// <summary> Determines if two <see cref="SecurityInsightsIncidentSeverity"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsIncidentSeverity left, SecurityInsightsIncidentSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsIncidentSeverity"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsIncidentSeverity left, SecurityInsightsIncidentSeverity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsIncidentSeverity"/>. </summary>
        public static implicit operator SecurityInsightsIncidentSeverity(string value) => new SecurityInsightsIncidentSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsIncidentSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsIncidentSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
