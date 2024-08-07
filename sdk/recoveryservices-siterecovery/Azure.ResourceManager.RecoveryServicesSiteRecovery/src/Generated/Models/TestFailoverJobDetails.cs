// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the details for a test failover job. </summary>
    public partial class TestFailoverJobDetails : SiteRecoveryJobDetails
    {
        /// <summary> Initializes a new instance of <see cref="TestFailoverJobDetails"/>. </summary>
        internal TestFailoverJobDetails()
        {
            ProtectedItemDetails = new ChangeTrackingList<FailoverReplicationProtectedItemDetails>();
            InstanceType = "TestFailoverJobDetails";
        }

        /// <summary> Initializes a new instance of <see cref="TestFailoverJobDetails"/>. </summary>
        /// <param name="instanceType"> Gets the type of job details (see JobDetailsTypes enum for possible values). </param>
        /// <param name="affectedObjectDetails"> The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow object details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="testFailoverStatus"> The test failover status. </param>
        /// <param name="comments"> The test failover comments. </param>
        /// <param name="networkName"> The test network name. </param>
        /// <param name="networkFriendlyName"> The test network friendly name. </param>
        /// <param name="networkType"> The test network type (see TestFailoverInput enum for possible values). </param>
        /// <param name="protectedItemDetails"> The test VM details. </param>
        internal TestFailoverJobDetails(string instanceType, IReadOnlyDictionary<string, string> affectedObjectDetails, IDictionary<string, BinaryData> serializedAdditionalRawData, string testFailoverStatus, string comments, string networkName, string networkFriendlyName, string networkType, IReadOnlyList<FailoverReplicationProtectedItemDetails> protectedItemDetails) : base(instanceType, affectedObjectDetails, serializedAdditionalRawData)
        {
            TestFailoverStatus = testFailoverStatus;
            Comments = comments;
            NetworkName = networkName;
            NetworkFriendlyName = networkFriendlyName;
            NetworkType = networkType;
            ProtectedItemDetails = protectedItemDetails;
            InstanceType = instanceType ?? "TestFailoverJobDetails";
        }

        /// <summary> The test failover status. </summary>
        public string TestFailoverStatus { get; }
        /// <summary> The test failover comments. </summary>
        public string Comments { get; }
        /// <summary> The test network name. </summary>
        public string NetworkName { get; }
        /// <summary> The test network friendly name. </summary>
        public string NetworkFriendlyName { get; }
        /// <summary> The test network type (see TestFailoverInput enum for possible values). </summary>
        public string NetworkType { get; }
        /// <summary> The test VM details. </summary>
        public IReadOnlyList<FailoverReplicationProtectedItemDetails> ProtectedItemDetails { get; }
    }
}
