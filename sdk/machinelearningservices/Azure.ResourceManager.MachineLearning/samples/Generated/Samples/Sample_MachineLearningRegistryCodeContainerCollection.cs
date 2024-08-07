// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningRegistryCodeContainerCollection
    {
        // List Registry Code Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListRegistryCodeContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/CodeContainer/list.json
            // this example is just showing the usage of "RegistryCodeContainers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryResource created on azure
            // for more information of creating MachineLearningRegistryResource, please refer to the document of MachineLearningRegistryResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string registryName = "testregistry";
            ResourceIdentifier machineLearningRegistryResourceId = MachineLearningRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            MachineLearningRegistryResource machineLearningRegistry = client.GetMachineLearningRegistryResource(machineLearningRegistryResourceId);

            // get the collection of this MachineLearningRegistryCodeContainerResource
            MachineLearningRegistryCodeContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryCodeContainers();

            // invoke the operation and iterate over the result
            await foreach (MachineLearningRegistryCodeContainerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningCodeContainerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Registry Code Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistryCodeContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/CodeContainer/get.json
            // this example is just showing the usage of "RegistryCodeContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryResource created on azure
            // for more information of creating MachineLearningRegistryResource, please refer to the document of MachineLearningRegistryResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string registryName = "testregistry";
            ResourceIdentifier machineLearningRegistryResourceId = MachineLearningRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            MachineLearningRegistryResource machineLearningRegistry = client.GetMachineLearningRegistryResource(machineLearningRegistryResourceId);

            // get the collection of this MachineLearningRegistryCodeContainerResource
            MachineLearningRegistryCodeContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryCodeContainers();

            // invoke the operation
            string codeName = "testContainer";
            MachineLearningRegistryCodeContainerResource result = await collection.GetAsync(codeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningCodeContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Registry Code Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRegistryCodeContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/CodeContainer/get.json
            // this example is just showing the usage of "RegistryCodeContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryResource created on azure
            // for more information of creating MachineLearningRegistryResource, please refer to the document of MachineLearningRegistryResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string registryName = "testregistry";
            ResourceIdentifier machineLearningRegistryResourceId = MachineLearningRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            MachineLearningRegistryResource machineLearningRegistry = client.GetMachineLearningRegistryResource(machineLearningRegistryResourceId);

            // get the collection of this MachineLearningRegistryCodeContainerResource
            MachineLearningRegistryCodeContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryCodeContainers();

            // invoke the operation
            string codeName = "testContainer";
            bool result = await collection.ExistsAsync(codeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Registry Code Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRegistryCodeContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/CodeContainer/get.json
            // this example is just showing the usage of "RegistryCodeContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryResource created on azure
            // for more information of creating MachineLearningRegistryResource, please refer to the document of MachineLearningRegistryResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string registryName = "testregistry";
            ResourceIdentifier machineLearningRegistryResourceId = MachineLearningRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            MachineLearningRegistryResource machineLearningRegistry = client.GetMachineLearningRegistryResource(machineLearningRegistryResourceId);

            // get the collection of this MachineLearningRegistryCodeContainerResource
            MachineLearningRegistryCodeContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryCodeContainers();

            // invoke the operation
            string codeName = "testContainer";
            NullableResponse<MachineLearningRegistryCodeContainerResource> response = await collection.GetIfExistsAsync(codeName);
            MachineLearningRegistryCodeContainerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningCodeContainerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateOrUpdate Registry Code Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateRegistryCodeContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/CodeContainer/createOrUpdate.json
            // this example is just showing the usage of "RegistryCodeContainers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryResource created on azure
            // for more information of creating MachineLearningRegistryResource, please refer to the document of MachineLearningRegistryResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string registryName = "testregistry";
            ResourceIdentifier machineLearningRegistryResourceId = MachineLearningRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            MachineLearningRegistryResource machineLearningRegistry = client.GetMachineLearningRegistryResource(machineLearningRegistryResourceId);

            // get the collection of this MachineLearningRegistryCodeContainerResource
            MachineLearningRegistryCodeContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryCodeContainers();

            // invoke the operation
            string codeName = "testContainer";
            MachineLearningCodeContainerData data = new MachineLearningCodeContainerData(new MachineLearningCodeContainerProperties()
            {
                Description = "string",
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            });
            ArmOperation<MachineLearningRegistryCodeContainerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, codeName, data);
            MachineLearningRegistryCodeContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningCodeContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
