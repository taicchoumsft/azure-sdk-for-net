// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration account partner's business identity. </summary>
    public partial class IntegrationAccountBusinessIdentity
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

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountBusinessIdentity"/>. </summary>
        /// <param name="qualifier"> The business identity qualifier e.g. as2identity, ZZ, ZZZ, 31, 32. </param>
        /// <param name="value"> The user defined business identity value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="qualifier"/> or <paramref name="value"/> is null. </exception>
        public IntegrationAccountBusinessIdentity(string qualifier, string value)
        {
            Argument.AssertNotNull(qualifier, nameof(qualifier));
            Argument.AssertNotNull(value, nameof(value));

            Qualifier = qualifier;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountBusinessIdentity"/>. </summary>
        /// <param name="qualifier"> The business identity qualifier e.g. as2identity, ZZ, ZZZ, 31, 32. </param>
        /// <param name="value"> The user defined business identity value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountBusinessIdentity(string qualifier, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Qualifier = qualifier;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountBusinessIdentity"/> for deserialization. </summary>
        internal IntegrationAccountBusinessIdentity()
        {
        }

        /// <summary> The business identity qualifier e.g. as2identity, ZZ, ZZZ, 31, 32. </summary>
        public string Qualifier { get; set; }
        /// <summary> The user defined business identity value. </summary>
        public string Value { get; set; }
    }
}
