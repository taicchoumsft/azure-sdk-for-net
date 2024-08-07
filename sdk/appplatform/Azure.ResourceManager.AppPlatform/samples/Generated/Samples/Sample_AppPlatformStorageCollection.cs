// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformStorageCollection
    {
        // Storages_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StoragesGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/Storages_Get.json
            // this example is just showing the usage of "Storages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformServiceResource created on azure
            // for more information of creating AppPlatformServiceResource, please refer to the document of AppPlatformServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            ResourceIdentifier appPlatformServiceResourceId = AppPlatformServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            AppPlatformServiceResource appPlatformService = client.GetAppPlatformServiceResource(appPlatformServiceResourceId);

            // get the collection of this AppPlatformStorageResource
            AppPlatformStorageCollection collection = appPlatformService.GetAppPlatformStorages();

            // invoke the operation
            string storageName = "mystorage";
            AppPlatformStorageResource result = await collection.GetAsync(storageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Storages_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_StoragesGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/Storages_Get.json
            // this example is just showing the usage of "Storages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformServiceResource created on azure
            // for more information of creating AppPlatformServiceResource, please refer to the document of AppPlatformServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            ResourceIdentifier appPlatformServiceResourceId = AppPlatformServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            AppPlatformServiceResource appPlatformService = client.GetAppPlatformServiceResource(appPlatformServiceResourceId);

            // get the collection of this AppPlatformStorageResource
            AppPlatformStorageCollection collection = appPlatformService.GetAppPlatformStorages();

            // invoke the operation
            string storageName = "mystorage";
            bool result = await collection.ExistsAsync(storageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Storages_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_StoragesGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/Storages_Get.json
            // this example is just showing the usage of "Storages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformServiceResource created on azure
            // for more information of creating AppPlatformServiceResource, please refer to the document of AppPlatformServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            ResourceIdentifier appPlatformServiceResourceId = AppPlatformServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            AppPlatformServiceResource appPlatformService = client.GetAppPlatformServiceResource(appPlatformServiceResourceId);

            // get the collection of this AppPlatformStorageResource
            AppPlatformStorageCollection collection = appPlatformService.GetAppPlatformStorages();

            // invoke the operation
            string storageName = "mystorage";
            NullableResponse<AppPlatformStorageResource> response = await collection.GetIfExistsAsync(storageName);
            AppPlatformStorageResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformStorageData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Storages_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StoragesCreateOrUpdate()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/Storages_CreateOrUpdate.json
            // this example is just showing the usage of "Storages_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformServiceResource created on azure
            // for more information of creating AppPlatformServiceResource, please refer to the document of AppPlatformServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            ResourceIdentifier appPlatformServiceResourceId = AppPlatformServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            AppPlatformServiceResource appPlatformService = client.GetAppPlatformServiceResource(appPlatformServiceResourceId);

            // get the collection of this AppPlatformStorageResource
            AppPlatformStorageCollection collection = appPlatformService.GetAppPlatformStorages();

            // invoke the operation
            string storageName = "mystorage";
            AppPlatformStorageData data = new AppPlatformStorageData()
            {
                Properties = new AppPlatformStorageAccount("storage-account-name", "account-key-of-storage-account"),
            };
            ArmOperation<AppPlatformStorageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageName, data);
            AppPlatformStorageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Storages_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_StoragesList()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/Storages_List.json
            // this example is just showing the usage of "Storages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformServiceResource created on azure
            // for more information of creating AppPlatformServiceResource, please refer to the document of AppPlatformServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myService";
            ResourceIdentifier appPlatformServiceResourceId = AppPlatformServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            AppPlatformServiceResource appPlatformService = client.GetAppPlatformServiceResource(appPlatformServiceResourceId);

            // get the collection of this AppPlatformStorageResource
            AppPlatformStorageCollection collection = appPlatformService.GetAppPlatformStorages();

            // invoke the operation and iterate over the result
            await foreach (AppPlatformStorageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformStorageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
