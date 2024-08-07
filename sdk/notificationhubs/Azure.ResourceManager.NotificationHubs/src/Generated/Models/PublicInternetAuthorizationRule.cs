// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> A default (public Internet) network authorization rule, which contains rights if no other network rule matches. </summary>
    internal partial class PublicInternetAuthorizationRule
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

        /// <summary> Initializes a new instance of <see cref="PublicInternetAuthorizationRule"/>. </summary>
        /// <param name="accessRights"> List of access rights. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accessRights"/> is null. </exception>
        public PublicInternetAuthorizationRule(IEnumerable<AuthorizationRuleAccessRightExt> accessRights)
        {
            Argument.AssertNotNull(accessRights, nameof(accessRights));

            AccessRights = accessRights.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PublicInternetAuthorizationRule"/>. </summary>
        /// <param name="accessRights"> List of access rights. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PublicInternetAuthorizationRule(IList<AuthorizationRuleAccessRightExt> accessRights, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccessRights = accessRights;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PublicInternetAuthorizationRule"/> for deserialization. </summary>
        internal PublicInternetAuthorizationRule()
        {
        }

        /// <summary> List of access rights. </summary>
        public IList<AuthorizationRuleAccessRightExt> AccessRights { get; }
    }
}
