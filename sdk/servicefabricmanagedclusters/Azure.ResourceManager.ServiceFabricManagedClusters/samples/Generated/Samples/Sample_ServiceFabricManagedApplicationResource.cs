// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Samples
{
    public partial class Sample_ServiceFabricManagedApplicationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ReadUpgrade_GetAnApplicationUpgrade()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-06-01-preview/examples/ApplicationActionGetUpgrade_example.json
            // this example is just showing the usage of "Applications_ReadUpgrade" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // invoke the operation
            await serviceFabricManagedApplication.ReadUpgradeAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StartRollback_StartAnApplicationUpgradeRollback()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-06-01-preview/examples/ApplicationActionStartRollback_example.json
            // this example is just showing the usage of "Applications_StartRollback" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // invoke the operation
            await serviceFabricManagedApplication.StartRollbackAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ResumeUpgrade_ResumeUpgrade()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-06-01-preview/examples/ApplicationActionResumeUpgrade_example.json
            // this example is just showing the usage of "Applications_ResumeUpgrade" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // invoke the operation
            RuntimeResumeApplicationUpgradeContent content = new RuntimeResumeApplicationUpgradeContent()
            {
                UpgradeDomainName = "UD1",
            };
            await serviceFabricManagedApplication.ResumeUpgradeAsync(WaitUntil.Completed, content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnApplication()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-06-01-preview/examples/ApplicationGetOperation_example.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // invoke the operation
            ServiceFabricManagedApplicationResource result = await serviceFabricManagedApplication.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchAnApplication()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-06-01-preview/examples/ApplicationPatchOperation_example.json
            // this example is just showing the usage of "Applications_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // invoke the operation
            ServiceFabricManagedApplicationPatch patch = new ServiceFabricManagedApplicationPatch()
            {
                Tags =
{
["a"] = "b",
},
            };
            ServiceFabricManagedApplicationResource result = await serviceFabricManagedApplication.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnApplication()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-06-01-preview/examples/ApplicationDeleteOperation_example.json
            // this example is just showing the usage of "Applications_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // invoke the operation
            await serviceFabricManagedApplication.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
