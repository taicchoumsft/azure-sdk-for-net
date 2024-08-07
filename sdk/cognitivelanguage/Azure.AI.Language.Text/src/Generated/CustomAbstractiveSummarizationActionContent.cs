// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Supported parameters for the Custom Abstractive Summarization task. </summary>
    public partial class CustomAbstractiveSummarizationActionContent
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

        /// <summary> Initializes a new instance of <see cref="CustomAbstractiveSummarizationActionContent"/>. </summary>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        public CustomAbstractiveSummarizationActionContent(string projectName, string deploymentName)
        {
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));

            ProjectName = projectName;
            DeploymentName = deploymentName;
        }

        /// <summary> Initializes a new instance of <see cref="CustomAbstractiveSummarizationActionContent"/>. </summary>
        /// <param name="sentenceCount"> Controls the approximate number of sentences in the output summaries. </param>
        /// <param name="stringIndexType"> String index type. </param>
        /// <param name="summaryLength"> (NOTE: Recommended to use summaryLength over sentenceCount) Controls the approximate length of the output summaries. </param>
        /// <param name="loggingOptOut"> logging opt out. </param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomAbstractiveSummarizationActionContent(int? sentenceCount, StringIndexType? stringIndexType, SummaryLengthBucket? summaryLength, bool? loggingOptOut, string projectName, string deploymentName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SentenceCount = sentenceCount;
            StringIndexType = stringIndexType;
            SummaryLength = summaryLength;
            LoggingOptOut = loggingOptOut;
            ProjectName = projectName;
            DeploymentName = deploymentName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomAbstractiveSummarizationActionContent"/> for deserialization. </summary>
        internal CustomAbstractiveSummarizationActionContent()
        {
        }

        /// <summary> Controls the approximate number of sentences in the output summaries. </summary>
        public int? SentenceCount { get; set; }
        /// <summary> String index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
        /// <summary> (NOTE: Recommended to use summaryLength over sentenceCount) Controls the approximate length of the output summaries. </summary>
        public SummaryLengthBucket? SummaryLength { get; set; }
        /// <summary> logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> This field indicates the project name for the model. </summary>
        public string ProjectName { get; }
        /// <summary> This field indicates the deployment name for the model. </summary>
        public string DeploymentName { get; }
    }
}
