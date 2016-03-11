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

    [JsonTransformation]
    public partial class ContainerService : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ContainerService class.
        /// </summary>
        public ContainerService() { }

        /// <summary>
        /// Initializes a new instance of the ContainerService class.
        /// </summary>
        public ContainerService(String location, ContainerServiceMasterProfile masterProfile, IList<ContainerServiceAgentPoolProfile> agentPoolProfiles, ContainerServiceLinuxProfile linuxProfile, String id = default(String), String name = default(String), String type = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), string provisioningState = default(string), ContainerServiceOrchestratorProfile orchestratorProfile = default(ContainerServiceOrchestratorProfile), ContainerServiceWindowsProfile windowsProfile = default(ContainerServiceWindowsProfile), ContainerServiceDiagnosticsProfile diagnosticsProfile = default(ContainerServiceDiagnosticsProfile))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            OrchestratorProfile = orchestratorProfile;
            MasterProfile = masterProfile;
            AgentPoolProfiles = agentPoolProfiles;
            WindowsProfile = windowsProfile;
            LinuxProfile = linuxProfile;
            DiagnosticsProfile = diagnosticsProfile;
        }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// The location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.orchestratorProfile")]
        public ContainerServiceOrchestratorProfile OrchestratorProfile { get; set; }

        /// <summary>
        /// Properties of master agents
        /// </summary>
        [JsonProperty(PropertyName = "properties.masterProfile")]
        public ContainerServiceMasterProfile MasterProfile { get; set; }

        /// <summary>
        /// Properties of agent pools
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentPoolProfiles")]
        public IList<ContainerServiceAgentPoolProfile> AgentPoolProfiles { get; set; }

        /// <summary>
        /// Properties of Windows VMs
        /// </summary>
        [JsonProperty(PropertyName = "properties.windowsProfile")]
        public ContainerServiceWindowsProfile WindowsProfile { get; set; }

        /// <summary>
        /// Properties for Linux VMs
        /// </summary>
        [JsonProperty(PropertyName = "properties.linuxProfile")]
        public ContainerServiceLinuxProfile LinuxProfile { get; set; }

        /// <summary>
        /// Properties for Diagnostic Agent
        /// </summary>
        [JsonProperty(PropertyName = "properties.diagnosticsProfile")]
        public ContainerServiceDiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (MasterProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MasterProfile");
            }
            if (AgentPoolProfiles == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AgentPoolProfiles");
            }
            if (LinuxProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinuxProfile");
            }
            if (this.MasterProfile != null)
            {
                this.MasterProfile.Validate();
            }
            if (this.AgentPoolProfiles != null)
            {
                foreach (var element in this.AgentPoolProfiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.WindowsProfile != null)
            {
                this.WindowsProfile.Validate();
            }
            if (this.LinuxProfile != null)
            {
                this.LinuxProfile.Validate();
            }
        }
    }
}
