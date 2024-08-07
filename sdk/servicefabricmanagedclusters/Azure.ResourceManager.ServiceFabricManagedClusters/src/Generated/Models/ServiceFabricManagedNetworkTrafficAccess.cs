// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The network traffic is allowed or denied. </summary>
    public readonly partial struct ServiceFabricManagedNetworkTrafficAccess : IEquatable<ServiceFabricManagedNetworkTrafficAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedNetworkTrafficAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceFabricManagedNetworkTrafficAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "allow";
        private const string DenyValue = "deny";

        /// <summary> allow. </summary>
        public static ServiceFabricManagedNetworkTrafficAccess Allow { get; } = new ServiceFabricManagedNetworkTrafficAccess(AllowValue);
        /// <summary> deny. </summary>
        public static ServiceFabricManagedNetworkTrafficAccess Deny { get; } = new ServiceFabricManagedNetworkTrafficAccess(DenyValue);
        /// <summary> Determines if two <see cref="ServiceFabricManagedNetworkTrafficAccess"/> values are the same. </summary>
        public static bool operator ==(ServiceFabricManagedNetworkTrafficAccess left, ServiceFabricManagedNetworkTrafficAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceFabricManagedNetworkTrafficAccess"/> values are not the same. </summary>
        public static bool operator !=(ServiceFabricManagedNetworkTrafficAccess left, ServiceFabricManagedNetworkTrafficAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceFabricManagedNetworkTrafficAccess"/>. </summary>
        public static implicit operator ServiceFabricManagedNetworkTrafficAccess(string value) => new ServiceFabricManagedNetworkTrafficAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceFabricManagedNetworkTrafficAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceFabricManagedNetworkTrafficAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
