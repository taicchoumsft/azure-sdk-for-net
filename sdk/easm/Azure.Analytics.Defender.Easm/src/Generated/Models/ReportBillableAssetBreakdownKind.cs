// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The kind of billable asset. </summary>
    public readonly partial struct ReportBillableAssetBreakdownKind : IEquatable<ReportBillableAssetBreakdownKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReportBillableAssetBreakdownKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReportBillableAssetBreakdownKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DomainValue = "domain";
        private const string HostValue = "host";
        private const string IpAddressValue = "ipAddress";

        /// <summary> domain. </summary>
        public static ReportBillableAssetBreakdownKind Domain { get; } = new ReportBillableAssetBreakdownKind(DomainValue);
        /// <summary> host. </summary>
        public static ReportBillableAssetBreakdownKind Host { get; } = new ReportBillableAssetBreakdownKind(HostValue);
        /// <summary> ipAddress. </summary>
        public static ReportBillableAssetBreakdownKind IpAddress { get; } = new ReportBillableAssetBreakdownKind(IpAddressValue);
        /// <summary> Determines if two <see cref="ReportBillableAssetBreakdownKind"/> values are the same. </summary>
        public static bool operator ==(ReportBillableAssetBreakdownKind left, ReportBillableAssetBreakdownKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReportBillableAssetBreakdownKind"/> values are not the same. </summary>
        public static bool operator !=(ReportBillableAssetBreakdownKind left, ReportBillableAssetBreakdownKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReportBillableAssetBreakdownKind"/>. </summary>
        public static implicit operator ReportBillableAssetBreakdownKind(string value) => new ReportBillableAssetBreakdownKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReportBillableAssetBreakdownKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReportBillableAssetBreakdownKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
