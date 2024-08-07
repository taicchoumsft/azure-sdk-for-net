// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Logger type. </summary>
    public readonly partial struct LoggerType : IEquatable<LoggerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LoggerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LoggerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureEventHubValue = "azureEventHub";
        private const string ApplicationInsightsValue = "applicationInsights";
        private const string AzureMonitorValue = "azureMonitor";

        /// <summary> Azure Event Hub as log destination. </summary>
        public static LoggerType AzureEventHub { get; } = new LoggerType(AzureEventHubValue);
        /// <summary> Azure Application Insights as log destination. </summary>
        public static LoggerType ApplicationInsights { get; } = new LoggerType(ApplicationInsightsValue);
        /// <summary> Azure Monitor. </summary>
        public static LoggerType AzureMonitor { get; } = new LoggerType(AzureMonitorValue);
        /// <summary> Determines if two <see cref="LoggerType"/> values are the same. </summary>
        public static bool operator ==(LoggerType left, LoggerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LoggerType"/> values are not the same. </summary>
        public static bool operator !=(LoggerType left, LoggerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LoggerType"/>. </summary>
        public static implicit operator LoggerType(string value) => new LoggerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LoggerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LoggerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
