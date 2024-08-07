// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Samples
{
    public partial class Sample_VCenterInventoryItemCollection
    {
        // CreateInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateInventoryItem()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/CreateInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVCenterResource created on azure
            // for more information of creating VMwareVCenterResource, please refer to the document of VMwareVCenterResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vcenterName = "ContosoVCenter";
            ResourceIdentifier vMwareVCenterResourceId = VMwareVCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vcenterName);
            VMwareVCenterResource vMwareVCenter = client.GetVMwareVCenterResource(vMwareVCenterResourceId);

            // get the collection of this VCenterInventoryItemResource
            VCenterInventoryItemCollection collection = vMwareVCenter.GetVCenterInventoryItems();

            // invoke the operation
            string inventoryItemName = "testItem";
            VCenterInventoryItemData data = new VCenterInventoryItemData(VCenterInventoryType.ResourcePool);
            ArmOperation<VCenterInventoryItemResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, inventoryItemName, data);
            VCenterInventoryItemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VCenterInventoryItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInventoryItem()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/GetInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVCenterResource created on azure
            // for more information of creating VMwareVCenterResource, please refer to the document of VMwareVCenterResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vcenterName = "ContosoVCenter";
            ResourceIdentifier vMwareVCenterResourceId = VMwareVCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vcenterName);
            VMwareVCenterResource vMwareVCenter = client.GetVMwareVCenterResource(vMwareVCenterResourceId);

            // get the collection of this VCenterInventoryItemResource
            VCenterInventoryItemCollection collection = vMwareVCenter.GetVCenterInventoryItems();

            // invoke the operation
            string inventoryItemName = "testItem";
            VCenterInventoryItemResource result = await collection.GetAsync(inventoryItemName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VCenterInventoryItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetInventoryItem()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/GetInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVCenterResource created on azure
            // for more information of creating VMwareVCenterResource, please refer to the document of VMwareVCenterResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vcenterName = "ContosoVCenter";
            ResourceIdentifier vMwareVCenterResourceId = VMwareVCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vcenterName);
            VMwareVCenterResource vMwareVCenter = client.GetVMwareVCenterResource(vMwareVCenterResourceId);

            // get the collection of this VCenterInventoryItemResource
            VCenterInventoryItemCollection collection = vMwareVCenter.GetVCenterInventoryItems();

            // invoke the operation
            string inventoryItemName = "testItem";
            bool result = await collection.ExistsAsync(inventoryItemName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetInventoryItem()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/GetInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVCenterResource created on azure
            // for more information of creating VMwareVCenterResource, please refer to the document of VMwareVCenterResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vcenterName = "ContosoVCenter";
            ResourceIdentifier vMwareVCenterResourceId = VMwareVCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vcenterName);
            VMwareVCenterResource vMwareVCenter = client.GetVMwareVCenterResource(vMwareVCenterResourceId);

            // get the collection of this VCenterInventoryItemResource
            VCenterInventoryItemCollection collection = vMwareVCenter.GetVCenterInventoryItems();

            // invoke the operation
            string inventoryItemName = "testItem";
            NullableResponse<VCenterInventoryItemResource> response = await collection.GetIfExistsAsync(inventoryItemName);
            VCenterInventoryItemResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VCenterInventoryItemData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // InventoryItemsListByVCenter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_InventoryItemsListByVCenter()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/InventoryItems_ListByVCenter.json
            // this example is just showing the usage of "InventoryItems_ListByVCenter" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVCenterResource created on azure
            // for more information of creating VMwareVCenterResource, please refer to the document of VMwareVCenterResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vcenterName = "ContosoVCenter";
            ResourceIdentifier vMwareVCenterResourceId = VMwareVCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vcenterName);
            VMwareVCenterResource vMwareVCenter = client.GetVMwareVCenterResource(vMwareVCenterResourceId);

            // get the collection of this VCenterInventoryItemResource
            VCenterInventoryItemCollection collection = vMwareVCenter.GetVCenterInventoryItems();

            // invoke the operation and iterate over the result
            await foreach (VCenterInventoryItemResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VCenterInventoryItemData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
