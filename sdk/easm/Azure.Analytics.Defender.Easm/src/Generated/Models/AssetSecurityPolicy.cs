// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The AssetSecurityPolicy. </summary>
    public partial class AssetSecurityPolicy
    {
        /// <summary> Initializes a new instance of AssetSecurityPolicy. </summary>
        internal AssetSecurityPolicy()
        {
            Sources = new ChangeTrackingList<Source>();
        }

        /// <summary> Initializes a new instance of AssetSecurityPolicy. </summary>
        /// <param name="policyName"></param>
        /// <param name="isAffected"></param>
        /// <param name="description"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="recent"></param>
        /// <param name="sources"></param>
        internal AssetSecurityPolicy(string policyName, bool? isAffected, string description, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, bool? recent, IReadOnlyList<Source> sources)
        {
            PolicyName = policyName;
            IsAffected = isAffected;
            Description = description;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Recent = recent;
            Sources = sources;
        }

        /// <summary> Gets the policy name. </summary>
        public string PolicyName { get; }
        /// <summary> Gets the is affected. </summary>
        public bool? IsAffected { get; }
        /// <summary> Gets the description. </summary>
        public string Description { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<Source> Sources { get; }
    }
}
