// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The catalog's properties for partial update. Properties not provided in the update request will not be changed. </summary>
    public partial class DevCenterCatalogPatch
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

        /// <summary> Initializes a new instance of <see cref="DevCenterCatalogPatch"/>. </summary>
        public DevCenterCatalogPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterCatalogPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="gitHub"> Properties for a GitHub catalog type. </param>
        /// <param name="adoGit"> Properties for an Azure DevOps catalog type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterCatalogPatch(IDictionary<string, string> tags, DevCenterGitCatalog gitHub, DevCenterGitCatalog adoGit, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            GitHub = gitHub;
            AdoGit = adoGit;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties for a GitHub catalog type. </summary>
        public DevCenterGitCatalog GitHub { get; set; }
        /// <summary> Properties for an Azure DevOps catalog type. </summary>
        public DevCenterGitCatalog AdoGit { get; set; }
    }
}
