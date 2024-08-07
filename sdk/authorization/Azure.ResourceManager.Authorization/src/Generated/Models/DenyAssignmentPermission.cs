// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Deny assignment permissions. </summary>
    public partial class DenyAssignmentPermission
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DenyAssignmentPermission"/>. </summary>
        internal DenyAssignmentPermission()
        {
            Actions = new ChangeTrackingList<string>();
            NotActions = new ChangeTrackingList<string>();
            DataActions = new ChangeTrackingList<string>();
            NotDataActions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DenyAssignmentPermission"/>. </summary>
        /// <param name="actions"> Actions to which the deny assignment does not grant access. </param>
        /// <param name="notActions"> Actions to exclude from that the deny assignment does not grant access. </param>
        /// <param name="dataActions"> Data actions to which the deny assignment does not grant access. </param>
        /// <param name="notDataActions"> Data actions to exclude from that the deny assignment does not grant access. </param>
        /// <param name="condition"> The conditions on the Deny assignment permission. This limits the resources it applies to. </param>
        /// <param name="conditionVersion"> Version of the condition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DenyAssignmentPermission(IReadOnlyList<string> actions, IReadOnlyList<string> notActions, IReadOnlyList<string> dataActions, IReadOnlyList<string> notDataActions, string condition, string conditionVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Actions = actions;
            NotActions = notActions;
            DataActions = dataActions;
            NotDataActions = notDataActions;
            Condition = condition;
            ConditionVersion = conditionVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Actions to which the deny assignment does not grant access. </summary>
        [WirePath("actions")]
        public IReadOnlyList<string> Actions { get; }
        /// <summary> Actions to exclude from that the deny assignment does not grant access. </summary>
        [WirePath("notActions")]
        public IReadOnlyList<string> NotActions { get; }
        /// <summary> Data actions to which the deny assignment does not grant access. </summary>
        [WirePath("dataActions")]
        public IReadOnlyList<string> DataActions { get; }
        /// <summary> Data actions to exclude from that the deny assignment does not grant access. </summary>
        [WirePath("notDataActions")]
        public IReadOnlyList<string> NotDataActions { get; }
        /// <summary> The conditions on the Deny assignment permission. This limits the resources it applies to. </summary>
        [WirePath("condition")]
        public string Condition { get; }
        /// <summary> Version of the condition. </summary>
        [WirePath("conditionVersion")]
        public string ConditionVersion { get; }
    }
}
