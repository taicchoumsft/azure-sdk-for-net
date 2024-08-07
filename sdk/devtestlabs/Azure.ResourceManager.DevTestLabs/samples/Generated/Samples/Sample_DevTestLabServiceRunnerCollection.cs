// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevTestLabs.Models;

namespace Azure.ResourceManager.DevTestLabs.Samples
{
    public partial class Sample_DevTestLabServiceRunnerCollection
    {
        // ServiceRunners_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ServiceRunnersGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/ServiceRunners_Get.json
            // this example is just showing the usage of "ServiceRunners_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabServiceRunnerResource
            DevTestLabServiceRunnerCollection collection = devTestLab.GetDevTestLabServiceRunners();

            // invoke the operation
            string name = "{servicerunnerName}";
            DevTestLabServiceRunnerResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabServiceRunnerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ServiceRunners_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ServiceRunnersGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/ServiceRunners_Get.json
            // this example is just showing the usage of "ServiceRunners_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabServiceRunnerResource
            DevTestLabServiceRunnerCollection collection = devTestLab.GetDevTestLabServiceRunners();

            // invoke the operation
            string name = "{servicerunnerName}";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ServiceRunners_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ServiceRunnersGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/ServiceRunners_Get.json
            // this example is just showing the usage of "ServiceRunners_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabServiceRunnerResource
            DevTestLabServiceRunnerCollection collection = devTestLab.GetDevTestLabServiceRunners();

            // invoke the operation
            string name = "{servicerunnerName}";
            NullableResponse<DevTestLabServiceRunnerResource> response = await collection.GetIfExistsAsync(name);
            DevTestLabServiceRunnerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevTestLabServiceRunnerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ServiceRunners_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ServiceRunnersCreateOrUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/ServiceRunners_CreateOrUpdate.json
            // this example is just showing the usage of "ServiceRunners_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabServiceRunnerResource
            DevTestLabServiceRunnerCollection collection = devTestLab.GetDevTestLabServiceRunners();

            // invoke the operation
            string name = "{servicerunnerName}";
            DevTestLabServiceRunnerData data = new DevTestLabServiceRunnerData(new AzureLocation("{location}"))
            {
                Identity = new DevTestLabManagedIdentity()
                {
                    ManagedIdentityType = "{identityType}",
                    PrincipalId = Guid.Parse("{identityPrincipalId}"),
                    TenantId = Guid.Parse("{identityTenantId}"),
                    ClientSecretUri = new Uri("{identityClientSecretUrl}"),
                },
                Tags =
{
["tagName1"] = "tagValue1",
},
            };
            ArmOperation<DevTestLabServiceRunnerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            DevTestLabServiceRunnerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabServiceRunnerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
