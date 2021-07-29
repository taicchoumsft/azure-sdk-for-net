// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a RouteFilter along with the instance operations that can be performed on it. </summary>
    public class RouteFilter : RouteFilterOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "RouteFilter"/> class for mocking. </summary>
        protected RouteFilter() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RouteFilter"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal RouteFilter(ResourceOperations options, RouteFilterData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the RouteFilterData. </summary>
        public virtual RouteFilterData Data { get; private set; }
    }
}
