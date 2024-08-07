// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_DataFactoryGlobalParameterCollection
    {
        // GlobalParameters_ListByFactory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GlobalParametersListByFactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_ListByFactory.json
            // this example is just showing the usage of "GlobalParameters_ListByFactory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryGlobalParameterResource
            DataFactoryGlobalParameterCollection collection = dataFactory.GetDataFactoryGlobalParameters();

            // invoke the operation and iterate over the result
            await foreach (DataFactoryGlobalParameterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryGlobalParameterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GlobalParameters_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GlobalParametersGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Get.json
            // this example is just showing the usage of "GlobalParameters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryGlobalParameterResource
            DataFactoryGlobalParameterCollection collection = dataFactory.GetDataFactoryGlobalParameters();

            // invoke the operation
            string globalParameterName = "default";
            DataFactoryGlobalParameterResource result = await collection.GetAsync(globalParameterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryGlobalParameterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GlobalParameters_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GlobalParametersGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Get.json
            // this example is just showing the usage of "GlobalParameters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryGlobalParameterResource
            DataFactoryGlobalParameterCollection collection = dataFactory.GetDataFactoryGlobalParameters();

            // invoke the operation
            string globalParameterName = "default";
            bool result = await collection.ExistsAsync(globalParameterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GlobalParameters_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GlobalParametersGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Get.json
            // this example is just showing the usage of "GlobalParameters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryGlobalParameterResource
            DataFactoryGlobalParameterCollection collection = dataFactory.GetDataFactoryGlobalParameters();

            // invoke the operation
            string globalParameterName = "default";
            NullableResponse<DataFactoryGlobalParameterResource> response = await collection.GetIfExistsAsync(globalParameterName);
            DataFactoryGlobalParameterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryGlobalParameterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // GlobalParameters_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_GlobalParametersCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Create.json
            // this example is just showing the usage of "GlobalParameters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryGlobalParameterResource
            DataFactoryGlobalParameterCollection collection = dataFactory.GetDataFactoryGlobalParameters();

            // invoke the operation
            string globalParameterName = "default";
            DataFactoryGlobalParameterData data = new DataFactoryGlobalParameterData(new Dictionary<string, DataFactoryGlobalParameterProperties>()
            {
                ["waitTime"] = new DataFactoryGlobalParameterProperties(DataFactoryGlobalParameterType.Int, BinaryData.FromString("\"5\"")),
            });
            ArmOperation<DataFactoryGlobalParameterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, globalParameterName, data);
            DataFactoryGlobalParameterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryGlobalParameterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GlobalParameters_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_GlobalParametersUpdate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Update.json
            // this example is just showing the usage of "GlobalParameters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryGlobalParameterResource
            DataFactoryGlobalParameterCollection collection = dataFactory.GetDataFactoryGlobalParameters();

            // invoke the operation
            string globalParameterName = "default";
            DataFactoryGlobalParameterData data = new DataFactoryGlobalParameterData(new Dictionary<string, DataFactoryGlobalParameterProperties>()
            {
                ["waitTime"] = new DataFactoryGlobalParameterProperties(DataFactoryGlobalParameterType.Int, BinaryData.FromString("\"5\"")),
            });
            ArmOperation<DataFactoryGlobalParameterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, globalParameterName, data);
            DataFactoryGlobalParameterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryGlobalParameterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
