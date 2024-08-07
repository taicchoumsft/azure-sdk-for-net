// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementGatewayHostnameConfiguration data model.
    /// Gateway hostname configuration details.
    /// </summary>
    public partial class ApiManagementGatewayHostnameConfigurationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementGatewayHostnameConfigurationData"/>. </summary>
        public ApiManagementGatewayHostnameConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementGatewayHostnameConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="hostname"> Hostname value. Supports valid domain name, partial or full wildcard. </param>
        /// <param name="certificateId"> Identifier of Certificate entity that will be used for TLS connection establishment. </param>
        /// <param name="isClientCertificateRequired"> Determines whether gateway requests client certificate. </param>
        /// <param name="isTls10Enabled"> Specifies if TLS 1.0 is supported. </param>
        /// <param name="isTls11Enabled"> Specifies if TLS 1.1 is supported. </param>
        /// <param name="isHttp20Enabled"> Specifies if HTTP/2.0 is supported. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementGatewayHostnameConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string hostname, string certificateId, bool? isClientCertificateRequired, bool? isTls10Enabled, bool? isTls11Enabled, bool? isHttp20Enabled, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Hostname = hostname;
            CertificateId = certificateId;
            IsClientCertificateRequired = isClientCertificateRequired;
            IsTls1_0Enabled = isTls10Enabled;
            IsTls1_1Enabled = isTls11Enabled;
            IsHttp2_0Enabled = isHttp20Enabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Hostname value. Supports valid domain name, partial or full wildcard. </summary>
        [WirePath("properties.hostname")]
        public string Hostname { get; set; }
        /// <summary> Identifier of Certificate entity that will be used for TLS connection establishment. </summary>
        [WirePath("properties.certificateId")]
        public string CertificateId { get; set; }
        /// <summary> Determines whether gateway requests client certificate. </summary>
        [WirePath("properties.negotiateClientCertificate")]
        public bool? IsClientCertificateRequired { get; set; }
    }
}
