// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a ServiceEndpointPolicyDefinition along with the instance operations that can be performed on it. </summary>
    public class ServiceEndpointPolicyDefinition : ServiceEndpointPolicyDefinitionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ServiceEndpointPolicyDefinition"/> class for mocking. </summary>
        protected ServiceEndpointPolicyDefinition() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceEndpointPolicyDefinition"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ServiceEndpointPolicyDefinition(ResourceOperations options, ServiceEndpointPolicyDefinitionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ServiceEndpointPolicyDefinitionData. </summary>
        public virtual ServiceEndpointPolicyDefinitionData Data { get; private set; }
    }
}
