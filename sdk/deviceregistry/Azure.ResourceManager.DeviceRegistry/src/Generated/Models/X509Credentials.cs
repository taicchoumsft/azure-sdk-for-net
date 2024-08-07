// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> The x509 certificate for authentication mode Certificate. </summary>
    internal partial class X509Credentials
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

        /// <summary> Initializes a new instance of <see cref="X509Credentials"/>. </summary>
        /// <param name="certificateReference"> A reference to secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateReference"/> is null. </exception>
        public X509Credentials(string certificateReference)
        {
            Argument.AssertNotNull(certificateReference, nameof(certificateReference));

            CertificateReference = certificateReference;
        }

        /// <summary> Initializes a new instance of <see cref="X509Credentials"/>. </summary>
        /// <param name="certificateReference"> A reference to secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal X509Credentials(string certificateReference, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CertificateReference = certificateReference;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="X509Credentials"/> for deserialization. </summary>
        internal X509Credentials()
        {
        }

        /// <summary> A reference to secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx). </summary>
        public string CertificateReference { get; set; }
    }
}
