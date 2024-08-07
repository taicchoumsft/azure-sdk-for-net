// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Recurrence Interval. </summary>
    public readonly partial struct DataShareSynchronizationRecurrenceInterval : IEquatable<DataShareSynchronizationRecurrenceInterval>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataShareSynchronizationRecurrenceInterval"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataShareSynchronizationRecurrenceInterval(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HourValue = "Hour";
        private const string DayValue = "Day";

        /// <summary> Hour. </summary>
        public static DataShareSynchronizationRecurrenceInterval Hour { get; } = new DataShareSynchronizationRecurrenceInterval(HourValue);
        /// <summary> Day. </summary>
        public static DataShareSynchronizationRecurrenceInterval Day { get; } = new DataShareSynchronizationRecurrenceInterval(DayValue);
        /// <summary> Determines if two <see cref="DataShareSynchronizationRecurrenceInterval"/> values are the same. </summary>
        public static bool operator ==(DataShareSynchronizationRecurrenceInterval left, DataShareSynchronizationRecurrenceInterval right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataShareSynchronizationRecurrenceInterval"/> values are not the same. </summary>
        public static bool operator !=(DataShareSynchronizationRecurrenceInterval left, DataShareSynchronizationRecurrenceInterval right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataShareSynchronizationRecurrenceInterval"/>. </summary>
        public static implicit operator DataShareSynchronizationRecurrenceInterval(string value) => new DataShareSynchronizationRecurrenceInterval(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataShareSynchronizationRecurrenceInterval other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataShareSynchronizationRecurrenceInterval other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
