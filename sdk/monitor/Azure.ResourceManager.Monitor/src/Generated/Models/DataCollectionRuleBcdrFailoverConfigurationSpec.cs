// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The DataCollectionRuleBcdrFailoverConfigurationSpec. </summary>
    public partial class DataCollectionRuleBcdrFailoverConfigurationSpec
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataCollectionRuleBcdrFailoverConfigurationSpec"/>. </summary>
        internal DataCollectionRuleBcdrFailoverConfigurationSpec()
        {
            Locations = new ChangeTrackingList<DataCollectionRuleBcdrLocationSpec>();
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionRuleBcdrFailoverConfigurationSpec"/>. </summary>
        /// <param name="activeLocation"> Active location where data flow will occur. </param>
        /// <param name="locations"> Locations that are configured for failover. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataCollectionRuleBcdrFailoverConfigurationSpec(string activeLocation, IReadOnlyList<DataCollectionRuleBcdrLocationSpec> locations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActiveLocation = activeLocation;
            Locations = locations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Active location where data flow will occur. </summary>
        public string ActiveLocation { get; }
        /// <summary> Locations that are configured for failover. </summary>
        public IReadOnlyList<DataCollectionRuleBcdrLocationSpec> Locations { get; }
    }
}
