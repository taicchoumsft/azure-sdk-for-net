// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.ResourceManager.EdgeOrder.Models;

namespace Azure.ResourceManager.EdgeOrder.Customizations.Models
{
    /// <summary>
    /// Network Configuration
    /// </summary>
    public class NetworkConfiguration
    {
        /// <summary>
        /// list of network adapters.
        /// </summary>
        public List<NetworkAdapter> NetworkAdapters { get; set; }

        /// <summary>
        /// to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{{{nameof(NetworkAdapters)}={NetworkAdapters.ToString()}";
        }
    }
}
