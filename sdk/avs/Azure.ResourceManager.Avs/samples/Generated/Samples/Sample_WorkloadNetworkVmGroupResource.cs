// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkVmGroupResource
    {
        // WorkloadNetworks_GetVMGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkloadNetworksGetVMGroup()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/WorkloadNetworks_GetVMGroups.json
            // this example is just showing the usage of "WorkloadNetworks_GetVmGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkVmGroupResource created on azure
            // for more information of creating WorkloadNetworkVmGroupResource, please refer to the document of WorkloadNetworkVmGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string vmGroupId = "vmGroup1";
            ResourceIdentifier workloadNetworkVmGroupResourceId = WorkloadNetworkVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, vmGroupId);
            WorkloadNetworkVmGroupResource workloadNetworkVmGroup = client.GetWorkloadNetworkVmGroupResource(workloadNetworkVmGroupResourceId);

            // invoke the operation
            WorkloadNetworkVmGroupResource result = await workloadNetworkVmGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkVmGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_UpdateVMGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WorkloadNetworksUpdateVMGroup()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/WorkloadNetworks_UpdateVMGroups.json
            // this example is just showing the usage of "WorkloadNetworks_UpdateVmGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkVmGroupResource created on azure
            // for more information of creating WorkloadNetworkVmGroupResource, please refer to the document of WorkloadNetworkVmGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string vmGroupId = "vmGroup1";
            ResourceIdentifier workloadNetworkVmGroupResourceId = WorkloadNetworkVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, vmGroupId);
            WorkloadNetworkVmGroupResource workloadNetworkVmGroup = client.GetWorkloadNetworkVmGroupResource(workloadNetworkVmGroupResourceId);

            // invoke the operation
            WorkloadNetworkVmGroupData data = new WorkloadNetworkVmGroupData()
            {
                Members =
{
"564d43da-fefc-2a3b-1d92-42855622fa50"
},
                Revision = 1,
            };
            ArmOperation<WorkloadNetworkVmGroupResource> lro = await workloadNetworkVmGroup.UpdateAsync(WaitUntil.Completed, data);
            WorkloadNetworkVmGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkVmGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_DeleteVMGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_WorkloadNetworksDeleteVMGroup()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/WorkloadNetworks_DeleteVMGroups.json
            // this example is just showing the usage of "WorkloadNetworks_DeleteVmGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkVmGroupResource created on azure
            // for more information of creating WorkloadNetworkVmGroupResource, please refer to the document of WorkloadNetworkVmGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string vmGroupId = "vmGroup1";
            ResourceIdentifier workloadNetworkVmGroupResourceId = WorkloadNetworkVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, vmGroupId);
            WorkloadNetworkVmGroupResource workloadNetworkVmGroup = client.GetWorkloadNetworkVmGroupResource(workloadNetworkVmGroupResourceId);

            // invoke the operation
            await workloadNetworkVmGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
