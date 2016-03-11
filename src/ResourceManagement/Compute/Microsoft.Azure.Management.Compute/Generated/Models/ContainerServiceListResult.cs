// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The List Container Service operation response
    /// </summary>
    public partial class ContainerServiceListResult
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceListResult class.
        /// </summary>
        public ContainerServiceListResult() { }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceListResult class.
        /// </summary>
        public ContainerServiceListResult(object properties = default(object))
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the list of container services.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

    }
}
