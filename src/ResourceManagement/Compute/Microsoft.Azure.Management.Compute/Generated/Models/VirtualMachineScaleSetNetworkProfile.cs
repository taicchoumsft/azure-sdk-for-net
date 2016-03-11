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
    /// Describes a virtual machine scale set network profile.
    /// </summary>
    public partial class VirtualMachineScaleSetNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkProfile class.
        /// </summary>
        public VirtualMachineScaleSetNetworkProfile() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkProfile class.
        /// </summary>
        public VirtualMachineScaleSetNetworkProfile(IList<VirtualMachineScaleSetNetworkConfiguration> networkInterfaceConfigurations = default(IList<VirtualMachineScaleSetNetworkConfiguration>))
        {
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
        }

        /// <summary>
        /// Gets or sets the list of network configurations.
        /// </summary>
        [JsonProperty(PropertyName = "networkInterfaceConfigurations")]
        public IList<VirtualMachineScaleSetNetworkConfiguration> NetworkInterfaceConfigurations { get; set; }

    }
}
