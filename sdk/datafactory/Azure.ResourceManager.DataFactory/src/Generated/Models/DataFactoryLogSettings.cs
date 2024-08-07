// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Log settings. </summary>
    public partial class DataFactoryLogSettings
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

        /// <summary> Initializes a new instance of <see cref="DataFactoryLogSettings"/>. </summary>
        /// <param name="logLocationSettings"> Log location settings customer needs to provide when enabling log. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logLocationSettings"/> is null. </exception>
        public DataFactoryLogSettings(LogLocationSettings logLocationSettings)
        {
            Argument.AssertNotNull(logLocationSettings, nameof(logLocationSettings));

            LogLocationSettings = logLocationSettings;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryLogSettings"/>. </summary>
        /// <param name="enableCopyActivityLog"> Specifies whether to enable copy activity log. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="copyActivityLogSettings"> Specifies settings for copy activity log. </param>
        /// <param name="logLocationSettings"> Log location settings customer needs to provide when enabling log. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryLogSettings(DataFactoryElement<bool> enableCopyActivityLog, CopyActivityLogSettings copyActivityLogSettings, LogLocationSettings logLocationSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnableCopyActivityLog = enableCopyActivityLog;
            CopyActivityLogSettings = copyActivityLogSettings;
            LogLocationSettings = logLocationSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryLogSettings"/> for deserialization. </summary>
        internal DataFactoryLogSettings()
        {
        }

        /// <summary> Specifies whether to enable copy activity log. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableCopyActivityLog { get; set; }
        /// <summary> Specifies settings for copy activity log. </summary>
        public CopyActivityLogSettings CopyActivityLogSettings { get; set; }
        /// <summary> Log location settings customer needs to provide when enabling log. </summary>
        public LogLocationSettings LogLocationSettings { get; set; }
    }
}
