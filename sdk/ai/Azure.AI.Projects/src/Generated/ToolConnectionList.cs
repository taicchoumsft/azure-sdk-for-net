// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> A set of connection resources currently used by either the `bing_grounding`, `microsoft_fabric`, or `sharepoint_grounding` tools. </summary>
    public partial class ToolConnectionList
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

        /// <summary> Initializes a new instance of <see cref="ToolConnectionList"/>. </summary>
        public ToolConnectionList()
        {
            ConnectionList = new ChangeTrackingList<ToolConnection>();
        }

        /// <summary> Initializes a new instance of <see cref="ToolConnectionList"/>. </summary>
        /// <param name="connectionList">
        /// The connections attached to this tool. There can be a maximum of 1 connection
        /// resource attached to the tool.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ToolConnectionList(IList<ToolConnection> connectionList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectionList = connectionList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The connections attached to this tool. There can be a maximum of 1 connection
        /// resource attached to the tool.
        /// </summary>
        public IList<ToolConnection> ConnectionList { get; }
    }
}
