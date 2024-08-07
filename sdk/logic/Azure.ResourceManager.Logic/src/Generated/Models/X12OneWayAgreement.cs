// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 one-way agreement. </summary>
    public partial class X12OneWayAgreement
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

        /// <summary> Initializes a new instance of <see cref="X12OneWayAgreement"/>. </summary>
        /// <param name="senderBusinessIdentity"> The sender business identity. </param>
        /// <param name="receiverBusinessIdentity"> The receiver business identity. </param>
        /// <param name="protocolSettings"> The X12 protocol settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="senderBusinessIdentity"/>, <paramref name="receiverBusinessIdentity"/> or <paramref name="protocolSettings"/> is null. </exception>
        public X12OneWayAgreement(IntegrationAccountBusinessIdentity senderBusinessIdentity, IntegrationAccountBusinessIdentity receiverBusinessIdentity, X12ProtocolSettings protocolSettings)
        {
            Argument.AssertNotNull(senderBusinessIdentity, nameof(senderBusinessIdentity));
            Argument.AssertNotNull(receiverBusinessIdentity, nameof(receiverBusinessIdentity));
            Argument.AssertNotNull(protocolSettings, nameof(protocolSettings));

            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
        }

        /// <summary> Initializes a new instance of <see cref="X12OneWayAgreement"/>. </summary>
        /// <param name="senderBusinessIdentity"> The sender business identity. </param>
        /// <param name="receiverBusinessIdentity"> The receiver business identity. </param>
        /// <param name="protocolSettings"> The X12 protocol settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal X12OneWayAgreement(IntegrationAccountBusinessIdentity senderBusinessIdentity, IntegrationAccountBusinessIdentity receiverBusinessIdentity, X12ProtocolSettings protocolSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="X12OneWayAgreement"/> for deserialization. </summary>
        internal X12OneWayAgreement()
        {
        }

        /// <summary> The sender business identity. </summary>
        public IntegrationAccountBusinessIdentity SenderBusinessIdentity { get; set; }
        /// <summary> The receiver business identity. </summary>
        public IntegrationAccountBusinessIdentity ReceiverBusinessIdentity { get; set; }
        /// <summary> The X12 protocol settings. </summary>
        public X12ProtocolSettings ProtocolSettings { get; set; }
    }
}
