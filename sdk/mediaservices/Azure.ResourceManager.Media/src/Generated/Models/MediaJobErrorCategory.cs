// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Helps with categorization of errors. </summary>
    public readonly partial struct MediaJobErrorCategory : IEquatable<MediaJobErrorCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaJobErrorCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaJobErrorCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceValue = "Service";
        private const string DownloadValue = "Download";
        private const string UploadValue = "Upload";
        private const string ConfigurationValue = "Configuration";
        private const string ContentValue = "Content";
        private const string AccountValue = "Account";

        /// <summary> The error is service related. </summary>
        public static MediaJobErrorCategory Service { get; } = new MediaJobErrorCategory(ServiceValue);
        /// <summary> The error is download related. </summary>
        public static MediaJobErrorCategory Download { get; } = new MediaJobErrorCategory(DownloadValue);
        /// <summary> The error is upload related. </summary>
        public static MediaJobErrorCategory Upload { get; } = new MediaJobErrorCategory(UploadValue);
        /// <summary> The error is configuration related. </summary>
        public static MediaJobErrorCategory Configuration { get; } = new MediaJobErrorCategory(ConfigurationValue);
        /// <summary> The error is related to data in the input files. </summary>
        public static MediaJobErrorCategory Content { get; } = new MediaJobErrorCategory(ContentValue);
        /// <summary> The error is related to account information. </summary>
        public static MediaJobErrorCategory Account { get; } = new MediaJobErrorCategory(AccountValue);
        /// <summary> Determines if two <see cref="MediaJobErrorCategory"/> values are the same. </summary>
        public static bool operator ==(MediaJobErrorCategory left, MediaJobErrorCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaJobErrorCategory"/> values are not the same. </summary>
        public static bool operator !=(MediaJobErrorCategory left, MediaJobErrorCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaJobErrorCategory"/>. </summary>
        public static implicit operator MediaJobErrorCategory(string value) => new MediaJobErrorCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaJobErrorCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaJobErrorCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
