// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates MySQL database connection. </summary>
    public partial class ConnectToSourceMySqlTaskInput
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

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceMySqlTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to MySQL source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/> is null. </exception>
        public ConnectToSourceMySqlTaskInput(MySqlConnectionInfo sourceConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));

            SourceConnectionInfo = sourceConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceMySqlTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to MySQL source. </param>
        /// <param name="targetPlatform"> Target Platform for the migration. </param>
        /// <param name="checkPermissionsGroup"> Permission group for validations. </param>
        /// <param name="isOfflineMigration"> Flag for whether or not the migration is offline. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToSourceMySqlTaskInput(MySqlConnectionInfo sourceConnectionInfo, MySqlTargetPlatformType? targetPlatform, ServerLevelPermissionsGroup? checkPermissionsGroup, bool? isOfflineMigration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetPlatform = targetPlatform;
            CheckPermissionsGroup = checkPermissionsGroup;
            IsOfflineMigration = isOfflineMigration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceMySqlTaskInput"/> for deserialization. </summary>
        internal ConnectToSourceMySqlTaskInput()
        {
        }

        /// <summary> Information for connecting to MySQL source. </summary>
        public MySqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Target Platform for the migration. </summary>
        public MySqlTargetPlatformType? TargetPlatform { get; set; }
        /// <summary> Permission group for validations. </summary>
        public ServerLevelPermissionsGroup? CheckPermissionsGroup { get; set; }
        /// <summary> Flag for whether or not the migration is offline. </summary>
        public bool? IsOfflineMigration { get; set; }
    }
}
