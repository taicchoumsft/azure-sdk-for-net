// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The history of how this asset was pulled into the workspace through the discovery process. </summary>
    public partial class AuditTrailItem
    {
        /// <summary> Initializes a new instance of AuditTrailItem. </summary>
        internal AuditTrailItem()
        {
        }

        /// <summary> Initializes a new instance of AuditTrailItem. </summary>
        /// <param name="id"> The system generated unique id for the resource. </param>
        /// <param name="name"> The caller provided unique name for the resource. </param>
        /// <param name="displayName"> The name that can be used for display purposes. </param>
        /// <param name="kind"> The kind of asset. </param>
        /// <param name="reason"> An explanation of why this audit trail node was discovered from the previous node. </param>
        internal AuditTrailItem(string id, string name, string displayName, AuditTrailItemKind? kind, string reason)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            Kind = kind;
            Reason = reason;
        }

        /// <summary> The system generated unique id for the resource. </summary>
        public string Id { get; }
        /// <summary> The caller provided unique name for the resource. </summary>
        public string Name { get; }
        /// <summary> The name that can be used for display purposes. </summary>
        public string DisplayName { get; }
        /// <summary> The kind of asset. </summary>
        public AuditTrailItemKind? Kind { get; }
        /// <summary> An explanation of why this audit trail node was discovered from the previous node. </summary>
        public string Reason { get; }
    }
}
