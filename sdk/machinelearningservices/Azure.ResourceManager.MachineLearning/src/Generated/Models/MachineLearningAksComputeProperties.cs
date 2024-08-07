// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> AKS properties. </summary>
    public partial class MachineLearningAksComputeProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningAksComputeProperties"/>. </summary>
        public MachineLearningAksComputeProperties()
        {
            SystemServices = new ChangeTrackingList<MachineLearningComputeSystemService>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAksComputeProperties"/>. </summary>
        /// <param name="clusterFqdn"> Cluster full qualified domain name. </param>
        /// <param name="systemServices"> System services. </param>
        /// <param name="agentCount"> Number of agents. </param>
        /// <param name="agentVmSize"> Agent virtual machine size. </param>
        /// <param name="clusterPurpose"> Intended usage of the cluster. </param>
        /// <param name="sslConfiguration"> SSL configuration. </param>
        /// <param name="aksNetworkingConfiguration"> AKS networking configuration for vnet. </param>
        /// <param name="loadBalancerType"> Load Balancer Type. </param>
        /// <param name="loadBalancerSubnet"> Load Balancer Subnet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningAksComputeProperties(string clusterFqdn, IReadOnlyList<MachineLearningComputeSystemService> systemServices, int? agentCount, string agentVmSize, MachineLearningClusterPurpose? clusterPurpose, MachineLearningSslConfiguration sslConfiguration, MachineLearningAksNetworkingConfiguration aksNetworkingConfiguration, MachineLearningLoadBalancerType? loadBalancerType, string loadBalancerSubnet, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClusterFqdn = clusterFqdn;
            SystemServices = systemServices;
            AgentCount = agentCount;
            AgentVmSize = agentVmSize;
            ClusterPurpose = clusterPurpose;
            SslConfiguration = sslConfiguration;
            AksNetworkingConfiguration = aksNetworkingConfiguration;
            LoadBalancerType = loadBalancerType;
            LoadBalancerSubnet = loadBalancerSubnet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Cluster full qualified domain name. </summary>
        public string ClusterFqdn { get; set; }
        /// <summary> System services. </summary>
        public IReadOnlyList<MachineLearningComputeSystemService> SystemServices { get; }
        /// <summary> Number of agents. </summary>
        public int? AgentCount { get; set; }
        /// <summary> Agent virtual machine size. </summary>
        public string AgentVmSize { get; set; }
        /// <summary> Intended usage of the cluster. </summary>
        public MachineLearningClusterPurpose? ClusterPurpose { get; set; }
        /// <summary> SSL configuration. </summary>
        public MachineLearningSslConfiguration SslConfiguration { get; set; }
        /// <summary> AKS networking configuration for vnet. </summary>
        public MachineLearningAksNetworkingConfiguration AksNetworkingConfiguration { get; set; }
        /// <summary> Load Balancer Type. </summary>
        public MachineLearningLoadBalancerType? LoadBalancerType { get; set; }
        /// <summary> Load Balancer Subnet. </summary>
        public string LoadBalancerSubnet { get; set; }
    }
}
