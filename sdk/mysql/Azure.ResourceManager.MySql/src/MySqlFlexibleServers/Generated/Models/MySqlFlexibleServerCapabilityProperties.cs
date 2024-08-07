// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Location capabilities. </summary>
    public partial class MySqlFlexibleServerCapabilityProperties
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

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerCapabilityProperties"/>. </summary>
        internal MySqlFlexibleServerCapabilityProperties()
        {
            SupportedHAMode = new ChangeTrackingList<string>();
            SupportedGeoBackupRegions = new ChangeTrackingList<string>();
            SupportedFlexibleServerEditions = new ChangeTrackingList<MySqlFlexibleServerEditionCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerCapabilityProperties"/>. </summary>
        /// <param name="zone"> zone name. </param>
        /// <param name="supportedHAMode"> Supported high availability mode. </param>
        /// <param name="supportedGeoBackupRegions"> supported geo backup regions. </param>
        /// <param name="supportedFlexibleServerEditions"> A list of supported flexible server editions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerCapabilityProperties(string zone, IReadOnlyList<string> supportedHAMode, IReadOnlyList<string> supportedGeoBackupRegions, IReadOnlyList<MySqlFlexibleServerEditionCapability> supportedFlexibleServerEditions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Zone = zone;
            SupportedHAMode = supportedHAMode;
            SupportedGeoBackupRegions = supportedGeoBackupRegions;
            SupportedFlexibleServerEditions = supportedFlexibleServerEditions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> zone name. </summary>
        public string Zone { get; }
        /// <summary> Supported high availability mode. </summary>
        public IReadOnlyList<string> SupportedHAMode { get; }
        /// <summary> supported geo backup regions. </summary>
        public IReadOnlyList<string> SupportedGeoBackupRegions { get; }
        /// <summary> A list of supported flexible server editions. </summary>
        public IReadOnlyList<MySqlFlexibleServerEditionCapability> SupportedFlexibleServerEditions { get; }
    }
}
