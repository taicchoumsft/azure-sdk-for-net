// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerSecurityAlertPolicy data model.
    /// A server security alert policy.
    /// </summary>
    public partial class SqlServerSecurityAlertPolicyData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SqlServerSecurityAlertPolicyData"/>. </summary>
        public SqlServerSecurityAlertPolicyData()
        {
            DisabledAlerts = new ChangeTrackingList<string>();
            EmailAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerSecurityAlertPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database. </param>
        /// <param name="disabledAlerts"> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration, Unsafe_Action, Brute_Force. </param>
        /// <param name="emailAddresses"> Specifies an array of e-mail addresses to which the alert is sent. </param>
        /// <param name="sendToEmailAccountAdmins"> Specifies that the alert is sent to the account administrators. </param>
        /// <param name="storageEndpoint"> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </param>
        /// <param name="storageAccountAccessKey"> Specifies the identifier key of the Threat Detection audit storage account. </param>
        /// <param name="retentionDays"> Specifies the number of days to keep in the Threat Detection audit logs. </param>
        /// <param name="createdOn"> Specifies the UTC creation time of the policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerSecurityAlertPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityAlertsPolicyState? state, IList<string> disabledAlerts, IList<string> emailAddresses, bool? sendToEmailAccountAdmins, string storageEndpoint, string storageAccountAccessKey, int? retentionDays, DateTimeOffset? createdOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            State = state;
            DisabledAlerts = disabledAlerts;
            EmailAddresses = emailAddresses;
            SendToEmailAccountAdmins = sendToEmailAccountAdmins;
            StorageEndpoint = storageEndpoint;
            StorageAccountAccessKey = storageAccountAccessKey;
            RetentionDays = retentionDays;
            CreatedOn = createdOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database. </summary>
        [WirePath("properties.state")]
        public SecurityAlertsPolicyState? State { get; set; }
        /// <summary> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration, Unsafe_Action, Brute_Force. </summary>
        [WirePath("properties.disabledAlerts")]
        public IList<string> DisabledAlerts { get; }
        /// <summary> Specifies an array of e-mail addresses to which the alert is sent. </summary>
        [WirePath("properties.emailAddresses")]
        public IList<string> EmailAddresses { get; }
        /// <summary> Specifies that the alert is sent to the account administrators. </summary>
        [WirePath("properties.emailAccountAdmins")]
        public bool? SendToEmailAccountAdmins { get; set; }
        /// <summary> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </summary>
        [WirePath("properties.storageEndpoint")]
        public string StorageEndpoint { get; set; }
        /// <summary> Specifies the identifier key of the Threat Detection audit storage account. </summary>
        [WirePath("properties.storageAccountAccessKey")]
        public string StorageAccountAccessKey { get; set; }
        /// <summary> Specifies the number of days to keep in the Threat Detection audit logs. </summary>
        [WirePath("properties.retentionDays")]
        public int? RetentionDays { get; set; }
        /// <summary> Specifies the UTC creation time of the policy. </summary>
        [WirePath("properties.creationTime")]
        public DateTimeOffset? CreatedOn { get; }
    }
}
