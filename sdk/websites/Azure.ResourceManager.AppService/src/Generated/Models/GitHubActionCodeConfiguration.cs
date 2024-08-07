// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The GitHub action code configuration. </summary>
    public partial class GitHubActionCodeConfiguration
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

        /// <summary> Initializes a new instance of <see cref="GitHubActionCodeConfiguration"/>. </summary>
        public GitHubActionCodeConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubActionCodeConfiguration"/>. </summary>
        /// <param name="runtimeStack"> Runtime stack is used to determine the workflow file content for code base apps. </param>
        /// <param name="runtimeVersion"> Runtime version is used to determine what build version to set in the workflow file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubActionCodeConfiguration(string runtimeStack, string runtimeVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RuntimeStack = runtimeStack;
            RuntimeVersion = runtimeVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Runtime stack is used to determine the workflow file content for code base apps. </summary>
        [WirePath("runtimeStack")]
        public string RuntimeStack { get; set; }
        /// <summary> Runtime version is used to determine what build version to set in the workflow file. </summary>
        [WirePath("runtimeVersion")]
        public string RuntimeVersion { get; set; }
    }
}
