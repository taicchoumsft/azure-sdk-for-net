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
    /// A class representing the SqlServerJobStep data model.
    /// A job step.
    /// </summary>
    public partial class SqlServerJobStepData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SqlServerJobStepData"/>. </summary>
        public SqlServerJobStepData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerJobStepData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="stepId"> The job step's index within the job. If not specified when creating the job step, it will be created as the last step. If not specified when updating the job step, the step id is not modified. </param>
        /// <param name="targetGroup"> The resource ID of the target group that the job step will be executed on. </param>
        /// <param name="credential"> The resource ID of the job credential that will be used to connect to the targets. </param>
        /// <param name="action"> The action payload of the job step. </param>
        /// <param name="output"> Output destination properties of the job step. </param>
        /// <param name="executionOptions"> Execution options for the job step. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerJobStepData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? stepId, string targetGroup, string credential, JobStepAction action, JobStepOutput output, JobStepExecutionOptions executionOptions, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            StepId = stepId;
            TargetGroup = targetGroup;
            Credential = credential;
            Action = action;
            Output = output;
            ExecutionOptions = executionOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The job step's index within the job. If not specified when creating the job step, it will be created as the last step. If not specified when updating the job step, the step id is not modified. </summary>
        [WirePath("properties.stepId")]
        public int? StepId { get; set; }
        /// <summary> The resource ID of the target group that the job step will be executed on. </summary>
        [WirePath("properties.targetGroup")]
        public string TargetGroup { get; set; }
        /// <summary> The resource ID of the job credential that will be used to connect to the targets. </summary>
        [WirePath("properties.credential")]
        public string Credential { get; set; }
        /// <summary> The action payload of the job step. </summary>
        [WirePath("properties.action")]
        public JobStepAction Action { get; set; }
        /// <summary> Output destination properties of the job step. </summary>
        [WirePath("properties.output")]
        public JobStepOutput Output { get; set; }
        /// <summary> Execution options for the job step. </summary>
        [WirePath("properties.executionOptions")]
        public JobStepExecutionOptions ExecutionOptions { get; set; }
    }
}
