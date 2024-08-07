// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OracleDatabase.Models;

namespace Azure.ResourceManager.OracleDatabase.Samples
{
    public partial class Sample_CloudVmClusterDBNodeResource
    {
        // Get DbNode
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDbNode()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/dbNodes_get.json
            // this example is just showing the usage of "DbNodes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudVmClusterDBNodeResource created on azure
            // for more information of creating CloudVmClusterDBNodeResource, please refer to the document of CloudVmClusterDBNodeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string cloudvmclustername = "cluster1";
            string dbnodeocid = "ocid1....aaaaaa";
            ResourceIdentifier cloudVmClusterDBNodeResourceId = CloudVmClusterDBNodeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudvmclustername, dbnodeocid);
            CloudVmClusterDBNodeResource cloudVmClusterDBNode = client.GetCloudVmClusterDBNodeResource(cloudVmClusterDBNodeResourceId);

            // invoke the operation
            CloudVmClusterDBNodeResource result = await cloudVmClusterDBNode.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudVmClusterDBNodeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DbNodes_Action
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Action_DbNodesAction()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/dbNodes_action.json
            // this example is just showing the usage of "DbNodes_Action" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudVmClusterDBNodeResource created on azure
            // for more information of creating CloudVmClusterDBNodeResource, please refer to the document of CloudVmClusterDBNodeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string cloudvmclustername = "cluster1";
            string dbnodeocid = "ocid1....aaaaaa";
            ResourceIdentifier cloudVmClusterDBNodeResourceId = CloudVmClusterDBNodeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudvmclustername, dbnodeocid);
            CloudVmClusterDBNodeResource cloudVmClusterDBNode = client.GetCloudVmClusterDBNodeResource(cloudVmClusterDBNodeResourceId);

            // invoke the operation
            DBNodeAction body = new DBNodeAction(DBNodeActionType.Start);
            ArmOperation<CloudVmClusterDBNodeResource> lro = await cloudVmClusterDBNode.ActionAsync(WaitUntil.Completed, body);
            CloudVmClusterDBNodeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudVmClusterDBNodeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VM actions on DbNodes of VM Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Action_VMActionsOnDbNodesOfVMCluster()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/dbNodes_action.json
            // this example is just showing the usage of "DbNodes_Action" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudVmClusterDBNodeResource created on azure
            // for more information of creating CloudVmClusterDBNodeResource, please refer to the document of CloudVmClusterDBNodeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string cloudvmclustername = "cluster1";
            string dbnodeocid = "ocid1....aaaaaa";
            ResourceIdentifier cloudVmClusterDBNodeResourceId = CloudVmClusterDBNodeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudvmclustername, dbnodeocid);
            CloudVmClusterDBNodeResource cloudVmClusterDBNode = client.GetCloudVmClusterDBNodeResource(cloudVmClusterDBNodeResourceId);

            // invoke the operation
            DBNodeAction body = new DBNodeAction(DBNodeActionType.Start);
            ArmOperation<CloudVmClusterDBNodeResource> lro = await cloudVmClusterDBNode.ActionAsync(WaitUntil.Completed, body);
            CloudVmClusterDBNodeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudVmClusterDBNodeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
