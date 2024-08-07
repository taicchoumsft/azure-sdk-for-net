// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The properties of a DataTransfer Job. </summary>
    public partial class DataTransferJobProperties
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

        /// <summary> Initializes a new instance of <see cref="DataTransferJobProperties"/>. </summary>
        /// <param name="source">
        /// Source DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="BaseCosmosDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </param>
        /// <param name="destination">
        /// Destination DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="BaseCosmosDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> or <paramref name="destination"/> is null. </exception>
        public DataTransferJobProperties(DataTransferDataSourceSink source, DataTransferDataSourceSink destination)
        {
            Argument.AssertNotNull(source, nameof(source));
            Argument.AssertNotNull(destination, nameof(destination));

            Source = source;
            Destination = destination;
        }

        /// <summary> Initializes a new instance of <see cref="DataTransferJobProperties"/>. </summary>
        /// <param name="jobName"> Job Name. </param>
        /// <param name="source">
        /// Source DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="BaseCosmosDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </param>
        /// <param name="destination">
        /// Destination DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="BaseCosmosDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </param>
        /// <param name="status"> Job Status. </param>
        /// <param name="processedCount"> Processed Count. </param>
        /// <param name="totalCount"> Total Count. </param>
        /// <param name="lastUpdatedUtcOn"> Last Updated Time (ISO-8601 format). </param>
        /// <param name="workerCount"> Worker count. </param>
        /// <param name="error"> Error response for Faulted job. </param>
        /// <param name="duration"> Total Duration of Job. </param>
        /// <param name="mode"> Mode of job execution. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataTransferJobProperties(string jobName, DataTransferDataSourceSink source, DataTransferDataSourceSink destination, string status, long? processedCount, long? totalCount, DateTimeOffset? lastUpdatedUtcOn, int? workerCount, CosmosDBErrorResult error, TimeSpan? duration, DataTransferJobMode? mode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobName = jobName;
            Source = source;
            Destination = destination;
            Status = status;
            ProcessedCount = processedCount;
            TotalCount = totalCount;
            LastUpdatedUtcOn = lastUpdatedUtcOn;
            WorkerCount = workerCount;
            Error = error;
            Duration = duration;
            Mode = mode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataTransferJobProperties"/> for deserialization. </summary>
        internal DataTransferJobProperties()
        {
        }

        /// <summary> Job Name. </summary>
        [WirePath("jobName")]
        public string JobName { get; }
        /// <summary>
        /// Source DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="BaseCosmosDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </summary>
        [WirePath("source")]
        public DataTransferDataSourceSink Source { get; set; }
        /// <summary>
        /// Destination DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="BaseCosmosDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </summary>
        [WirePath("destination")]
        public DataTransferDataSourceSink Destination { get; set; }
        /// <summary> Job Status. </summary>
        [WirePath("status")]
        public string Status { get; }
        /// <summary> Processed Count. </summary>
        [WirePath("processedCount")]
        public long? ProcessedCount { get; }
        /// <summary> Total Count. </summary>
        [WirePath("totalCount")]
        public long? TotalCount { get; }
        /// <summary> Last Updated Time (ISO-8601 format). </summary>
        [WirePath("lastUpdatedUtcTime")]
        public DateTimeOffset? LastUpdatedUtcOn { get; }
        /// <summary> Worker count. </summary>
        [WirePath("workerCount")]
        public int? WorkerCount { get; set; }
        /// <summary> Error response for Faulted job. </summary>
        [WirePath("error")]
        public CosmosDBErrorResult Error { get; }
        /// <summary> Total Duration of Job. </summary>
        [WirePath("duration")]
        public TimeSpan? Duration { get; }
        /// <summary> Mode of job execution. </summary>
        [WirePath("mode")]
        public DataTransferJobMode? Mode { get; set; }
    }
}
