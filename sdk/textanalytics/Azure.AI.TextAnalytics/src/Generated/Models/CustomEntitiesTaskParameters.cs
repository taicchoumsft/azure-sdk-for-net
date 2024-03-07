// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Supported parameters for a Custom Entities task. </summary>
    internal partial class CustomEntitiesTaskParameters : CustomTaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="CustomEntitiesTaskParameters"/>. </summary>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        public CustomEntitiesTaskParameters(string projectName, string deploymentName) : base(projectName, deploymentName)
        {
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntitiesTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        internal CustomEntitiesTaskParameters(bool? loggingOptOut, string projectName, string deploymentName, StringIndexType? stringIndexType) : base(loggingOptOut, projectName, deploymentName)
        {
            StringIndexType = stringIndexType;
        }

        /// <summary> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
