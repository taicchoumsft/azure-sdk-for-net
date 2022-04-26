// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MongoDbMigrationState. </summary>
    public readonly partial struct MongoDbMigrationState : IEquatable<MongoDbMigrationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoDbMigrationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoDbMigrationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string ValidatingInputValue = "ValidatingInput";
        private const string InitializingValue = "Initializing";
        private const string RestartingValue = "Restarting";
        private const string CopyingValue = "Copying";
        private const string InitialReplayValue = "InitialReplay";
        private const string ReplayingValue = "Replaying";
        private const string FinalizingValue = "Finalizing";
        private const string CompleteValue = "Complete";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> NotStarted. </summary>
        public static MongoDbMigrationState NotStarted { get; } = new MongoDbMigrationState(NotStartedValue);
        /// <summary> ValidatingInput. </summary>
        public static MongoDbMigrationState ValidatingInput { get; } = new MongoDbMigrationState(ValidatingInputValue);
        /// <summary> Initializing. </summary>
        public static MongoDbMigrationState Initializing { get; } = new MongoDbMigrationState(InitializingValue);
        /// <summary> Restarting. </summary>
        public static MongoDbMigrationState Restarting { get; } = new MongoDbMigrationState(RestartingValue);
        /// <summary> Copying. </summary>
        public static MongoDbMigrationState Copying { get; } = new MongoDbMigrationState(CopyingValue);
        /// <summary> InitialReplay. </summary>
        public static MongoDbMigrationState InitialReplay { get; } = new MongoDbMigrationState(InitialReplayValue);
        /// <summary> Replaying. </summary>
        public static MongoDbMigrationState Replaying { get; } = new MongoDbMigrationState(ReplayingValue);
        /// <summary> Finalizing. </summary>
        public static MongoDbMigrationState Finalizing { get; } = new MongoDbMigrationState(FinalizingValue);
        /// <summary> Complete. </summary>
        public static MongoDbMigrationState Complete { get; } = new MongoDbMigrationState(CompleteValue);
        /// <summary> Canceled. </summary>
        public static MongoDbMigrationState Canceled { get; } = new MongoDbMigrationState(CanceledValue);
        /// <summary> Failed. </summary>
        public static MongoDbMigrationState Failed { get; } = new MongoDbMigrationState(FailedValue);
        /// <summary> Determines if two <see cref="MongoDbMigrationState"/> values are the same. </summary>
        public static bool operator ==(MongoDbMigrationState left, MongoDbMigrationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoDbMigrationState"/> values are not the same. </summary>
        public static bool operator !=(MongoDbMigrationState left, MongoDbMigrationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MongoDbMigrationState"/>. </summary>
        public static implicit operator MongoDbMigrationState(string value) => new MongoDbMigrationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoDbMigrationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoDbMigrationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
