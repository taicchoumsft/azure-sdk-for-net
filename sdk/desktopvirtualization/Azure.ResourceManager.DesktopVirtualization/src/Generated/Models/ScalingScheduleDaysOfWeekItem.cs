// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The ScalingScheduleDaysOfWeekItem. </summary>
    public readonly partial struct ScalingScheduleDaysOfWeekItem : IEquatable<ScalingScheduleDaysOfWeekItem>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScalingScheduleDaysOfWeekItem"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScalingScheduleDaysOfWeekItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SundayValue = "Sunday";
        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";

        /// <summary> Sunday. </summary>
        public static ScalingScheduleDaysOfWeekItem Sunday { get; } = new ScalingScheduleDaysOfWeekItem(SundayValue);
        /// <summary> Monday. </summary>
        public static ScalingScheduleDaysOfWeekItem Monday { get; } = new ScalingScheduleDaysOfWeekItem(MondayValue);
        /// <summary> Tuesday. </summary>
        public static ScalingScheduleDaysOfWeekItem Tuesday { get; } = new ScalingScheduleDaysOfWeekItem(TuesdayValue);
        /// <summary> Wednesday. </summary>
        public static ScalingScheduleDaysOfWeekItem Wednesday { get; } = new ScalingScheduleDaysOfWeekItem(WednesdayValue);
        /// <summary> Thursday. </summary>
        public static ScalingScheduleDaysOfWeekItem Thursday { get; } = new ScalingScheduleDaysOfWeekItem(ThursdayValue);
        /// <summary> Friday. </summary>
        public static ScalingScheduleDaysOfWeekItem Friday { get; } = new ScalingScheduleDaysOfWeekItem(FridayValue);
        /// <summary> Saturday. </summary>
        public static ScalingScheduleDaysOfWeekItem Saturday { get; } = new ScalingScheduleDaysOfWeekItem(SaturdayValue);
        /// <summary> Determines if two <see cref="ScalingScheduleDaysOfWeekItem"/> values are the same. </summary>
        public static bool operator ==(ScalingScheduleDaysOfWeekItem left, ScalingScheduleDaysOfWeekItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScalingScheduleDaysOfWeekItem"/> values are not the same. </summary>
        public static bool operator !=(ScalingScheduleDaysOfWeekItem left, ScalingScheduleDaysOfWeekItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScalingScheduleDaysOfWeekItem"/>. </summary>
        public static implicit operator ScalingScheduleDaysOfWeekItem(string value) => new ScalingScheduleDaysOfWeekItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScalingScheduleDaysOfWeekItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScalingScheduleDaysOfWeekItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
