// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the TagResource data model.
    /// Wrapper resource for tags API requests and responses.
    /// </summary>
    public partial class TagResourceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TagResourceData"/>. </summary>
        /// <param name="properties"> The set of tags. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public TagResourceData(Tag properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="TagResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The set of tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TagResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Tag properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TagResourceData"/> for deserialization. </summary>
        internal TagResourceData()
        {
        }

        /// <summary> The set of tags. </summary>
        internal Tag Properties { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> TagValues
        {
            get
            {
                if (Properties is null)
                    Properties = new Tag();
                return Properties.TagValues;
            }
        }
    }
}
