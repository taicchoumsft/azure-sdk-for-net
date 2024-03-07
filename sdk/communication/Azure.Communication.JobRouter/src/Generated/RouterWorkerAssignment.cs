// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> The assignment for a worker to a job. </summary>
    public partial class RouterWorkerAssignment
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

        /// <summary> Initializes a new instance of <see cref="RouterWorkerAssignment"/>. </summary>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/> or <paramref name="jobId"/> is null. </exception>
        internal RouterWorkerAssignment(string assignmentId, string jobId, int capacityCost, DateTimeOffset assignedAt)
        {
            Argument.AssertNotNull(assignmentId, nameof(assignmentId));
            Argument.AssertNotNull(jobId, nameof(jobId));

            AssignmentId = assignmentId;
            JobId = jobId;
            CapacityCost = capacityCost;
            AssignedAt = assignedAt;
        }

        /// <summary> Initializes a new instance of <see cref="RouterWorkerAssignment"/>. </summary>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouterWorkerAssignment(string assignmentId, string jobId, int capacityCost, DateTimeOffset assignedAt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssignmentId = assignmentId;
            JobId = jobId;
            CapacityCost = capacityCost;
            AssignedAt = assignedAt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RouterWorkerAssignment"/> for deserialization. </summary>
        internal RouterWorkerAssignment()
        {
        }

        /// <summary> Id of the assignment. </summary>
        public string AssignmentId { get; }
        /// <summary> Id of the job assigned. </summary>
        public string JobId { get; }
        /// <summary> The amount of capacity this assignment has consumed on the worker. </summary>
        public int CapacityCost { get; }
        /// <summary> The assignment time of the job in UTC. </summary>
        public DateTimeOffset AssignedAt { get; }
    }
}
