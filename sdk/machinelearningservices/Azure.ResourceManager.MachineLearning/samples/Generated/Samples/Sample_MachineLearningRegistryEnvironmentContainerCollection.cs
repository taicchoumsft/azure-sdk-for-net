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
    public partial class Sample_MachineLearningRegistryEnvironmentContainerCollection
    {
        // List Registry Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListRegistryEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentContainer/list.json
            // this example is just showing the usage of "RegistryEnvironmentContainers_List" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningRegistryEnvironmentContainerResource
            MachineLearningRegistryEnvironmentContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryEnvironmentContainers();

            // invoke the operation and iterate over the result
            await foreach (MachineLearningRegistryEnvironmentContainerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningEnvironmentContainerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Registry Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistryEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentContainer/get.json
            // this example is just showing the usage of "RegistryEnvironmentContainers_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningRegistryEnvironmentContainerResource
            MachineLearningRegistryEnvironmentContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryEnvironmentContainers();

            // invoke the operation
            string environmentName = "testEnvironment";
            MachineLearningRegistryEnvironmentContainerResource result = await collection.GetAsync(environmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Registry Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRegistryEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentContainer/get.json
            // this example is just showing the usage of "RegistryEnvironmentContainers_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningRegistryEnvironmentContainerResource
            MachineLearningRegistryEnvironmentContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryEnvironmentContainers();

            // invoke the operation
            string environmentName = "testEnvironment";
            bool result = await collection.ExistsAsync(environmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Registry Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRegistryEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentContainer/get.json
            // this example is just showing the usage of "RegistryEnvironmentContainers_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningRegistryEnvironmentContainerResource
            MachineLearningRegistryEnvironmentContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryEnvironmentContainers();

            // invoke the operation
            string environmentName = "testEnvironment";
            NullableResponse<MachineLearningRegistryEnvironmentContainerResource> response = await collection.GetIfExistsAsync(environmentName);
            MachineLearningRegistryEnvironmentContainerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningEnvironmentContainerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateOrUpdate Registry Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateRegistryEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentContainer/createOrUpdate.json
            // this example is just showing the usage of "RegistryEnvironmentContainers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningRegistryEnvironmentContainerResource
            MachineLearningRegistryEnvironmentContainerCollection collection = machineLearningRegistry.GetMachineLearningRegistryEnvironmentContainers();

            // invoke the operation
            string environmentName = "testEnvironment";
            MachineLearningEnvironmentContainerData data = new MachineLearningEnvironmentContainerData(new MachineLearningEnvironmentContainerProperties()
            {
                Description = "string",
                Tags =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string",
},
                Properties =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string",
},
            });
            ArmOperation<MachineLearningRegistryEnvironmentContainerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, environmentName, data);
            MachineLearningRegistryEnvironmentContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
