// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the PublishingUser data model.
    /// User credentials used for publishing activity.
    /// </summary>
    public partial class PublishingUserData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PublishingUserData"/>. </summary>
        public PublishingUserData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PublishingUserData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publishingUserName"> Username used for publishing. </param>
        /// <param name="publishingPassword"> Password used for publishing. </param>
        /// <param name="publishingPasswordHash"> Password hash used for publishing. </param>
        /// <param name="publishingPasswordHashSalt"> Password hash salt used for publishing. </param>
        /// <param name="scmUri"> Url of SCM site. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PublishingUserData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string publishingUserName, string publishingPassword, string publishingPasswordHash, string publishingPasswordHashSalt, Uri scmUri, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PublishingUserName = publishingUserName;
            PublishingPassword = publishingPassword;
            PublishingPasswordHash = publishingPasswordHash;
            PublishingPasswordHashSalt = publishingPasswordHashSalt;
            ScmUri = scmUri;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Username used for publishing. </summary>
        [WirePath("properties.publishingUserName")]
        public string PublishingUserName { get; set; }
        /// <summary> Password used for publishing. </summary>
        [WirePath("properties.publishingPassword")]
        public string PublishingPassword { get; set; }
        /// <summary> Password hash used for publishing. </summary>
        [WirePath("properties.publishingPasswordHash")]
        public string PublishingPasswordHash { get; set; }
        /// <summary> Password hash salt used for publishing. </summary>
        [WirePath("properties.publishingPasswordHashSalt")]
        public string PublishingPasswordHashSalt { get; set; }
        /// <summary> Url of SCM site. </summary>
        [WirePath("properties.scmUri")]
        public Uri ScmUri { get; set; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
