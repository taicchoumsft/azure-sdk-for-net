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

    public partial class ContainerServiceLinuxProfile
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceLinuxProfile
        /// class.
        /// </summary>
        public ContainerServiceLinuxProfile() { }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceLinuxProfile
        /// class.
        /// </summary>
        public ContainerServiceLinuxProfile(string adminUsername, ContainerServiceSshConfiguration ssh)
        {
            AdminUsername = adminUsername;
            Ssh = ssh;
        }

        /// <summary>
        /// The administrator username to use for all Linux VMs
        /// </summary>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Specifies the ssh key configuration for Linux VMs
        /// </summary>
        [JsonProperty(PropertyName = "ssh")]
        public ContainerServiceSshConfiguration Ssh { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (AdminUsername == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdminUsername");
            }
            if (Ssh == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ssh");
            }
        }
    }
}
