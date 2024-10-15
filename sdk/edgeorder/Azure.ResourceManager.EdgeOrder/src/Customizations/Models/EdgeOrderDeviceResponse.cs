// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.EdgeOrder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.ResourceManager.EdgeOrder.Customizations.Models
{
    /// <summary>
    /// Represents a response to a request to list EdgeOrderDevices
    /// </summary>
#pragma warning disable AZC0030 // Improper model name suffix
    public  class EdgeOrderDeviceResponse
#pragma warning restore AZC0030 // Improper model name suffix
    {
        /// <summary>
        /// List of EdgeOrderDevices
        /// </summary>
        public  List<EdgeOrderDevice> EdgeOrderDevices { get; set; }

        /// <summary>
        /// Skip token
        /// </summary>
        public   string SkipToken { get; set;}
    }
}
