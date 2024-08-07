// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MonitoringAlertNotificationType. </summary>
    internal readonly partial struct MonitoringAlertNotificationType : IEquatable<MonitoringAlertNotificationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitoringAlertNotificationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitoringAlertNotificationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureMonitorValue = "AzureMonitor";
        private const string EmailValue = "Email";

        /// <summary> Settings for Azure Monitor based alerting. </summary>
        public static MonitoringAlertNotificationType AzureMonitor { get; } = new MonitoringAlertNotificationType(AzureMonitorValue);
        /// <summary> Settings for AML email notifications. </summary>
        public static MonitoringAlertNotificationType Email { get; } = new MonitoringAlertNotificationType(EmailValue);
        /// <summary> Determines if two <see cref="MonitoringAlertNotificationType"/> values are the same. </summary>
        public static bool operator ==(MonitoringAlertNotificationType left, MonitoringAlertNotificationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitoringAlertNotificationType"/> values are not the same. </summary>
        public static bool operator !=(MonitoringAlertNotificationType left, MonitoringAlertNotificationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitoringAlertNotificationType"/>. </summary>
        public static implicit operator MonitoringAlertNotificationType(string value) => new MonitoringAlertNotificationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitoringAlertNotificationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitoringAlertNotificationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
