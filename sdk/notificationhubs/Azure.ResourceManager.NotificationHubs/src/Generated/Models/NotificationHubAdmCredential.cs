// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub AdmCredential. </summary>
    public partial class NotificationHubAdmCredential
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

        /// <summary> Initializes a new instance of <see cref="NotificationHubAdmCredential"/>. </summary>
        /// <param name="clientId"> Gets or sets the client identifier. </param>
        /// <param name="clientSecret"> Gets or sets the credential secret access key. </param>
        /// <param name="authTokenUri"> Gets or sets the URL of the authorization token. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientId"/>, <paramref name="clientSecret"/> or <paramref name="authTokenUri"/> is null. </exception>
        public NotificationHubAdmCredential(string clientId, string clientSecret, Uri authTokenUri)
        {
            Argument.AssertNotNull(clientId, nameof(clientId));
            Argument.AssertNotNull(clientSecret, nameof(clientSecret));
            Argument.AssertNotNull(authTokenUri, nameof(authTokenUri));

            ClientId = clientId;
            ClientSecret = clientSecret;
            AuthTokenUri = authTokenUri;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubAdmCredential"/>. </summary>
        /// <param name="clientId"> Gets or sets the client identifier. </param>
        /// <param name="clientSecret"> Gets or sets the credential secret access key. </param>
        /// <param name="authTokenUri"> Gets or sets the URL of the authorization token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubAdmCredential(string clientId, string clientSecret, Uri authTokenUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AuthTokenUri = authTokenUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the client identifier. </summary>
        public string ClientId { get; set; }
        /// <summary> Gets or sets the credential secret access key. </summary>
        public string ClientSecret { get; set; }
        /// <summary> Gets or sets the URL of the authorization token. </summary>
        public Uri AuthTokenUri { get; set; }
    }
}
