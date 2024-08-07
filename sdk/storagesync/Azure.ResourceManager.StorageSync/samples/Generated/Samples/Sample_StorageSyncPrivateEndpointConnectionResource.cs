// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync.Samples
{
    public partial class Sample_StorageSyncPrivateEndpointConnectionResource
    {
        // PrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSyncPrivateEndpointConnectionResource created on azure
            // for more information of creating StorageSyncPrivateEndpointConnectionResource, please refer to the document of StorageSyncPrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string storageSyncServiceName = "sss2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier storageSyncPrivateEndpointConnectionResourceId = StorageSyncPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, privateEndpointConnectionName);
            StorageSyncPrivateEndpointConnectionResource storageSyncPrivateEndpointConnection = client.GetStorageSyncPrivateEndpointConnectionResource(storageSyncPrivateEndpointConnectionResourceId);

            // invoke the operation
            StorageSyncPrivateEndpointConnectionResource result = await storageSyncPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageSyncPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnections_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PrivateEndpointConnectionsCreate()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/PrivateEndpointConnections_Create.json
            // this example is just showing the usage of "PrivateEndpointConnections_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSyncPrivateEndpointConnectionResource created on azure
            // for more information of creating StorageSyncPrivateEndpointConnectionResource, please refer to the document of StorageSyncPrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string storageSyncServiceName = "sss2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier storageSyncPrivateEndpointConnectionResourceId = StorageSyncPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, privateEndpointConnectionName);
            StorageSyncPrivateEndpointConnectionResource storageSyncPrivateEndpointConnection = client.GetStorageSyncPrivateEndpointConnectionResource(storageSyncPrivateEndpointConnectionResourceId);

            // invoke the operation
            StorageSyncPrivateEndpointConnectionData data = new StorageSyncPrivateEndpointConnectionData()
            {
                ConnectionState = new StorageSyncPrivateLinkServiceConnectionState()
                {
                    Status = StorageSyncPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<StorageSyncPrivateEndpointConnectionResource> lro = await storageSyncPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            StorageSyncPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageSyncPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnections_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PrivateEndpointConnectionsDelete()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/PrivateEndpointConnections_Delete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSyncPrivateEndpointConnectionResource created on azure
            // for more information of creating StorageSyncPrivateEndpointConnectionResource, please refer to the document of StorageSyncPrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string storageSyncServiceName = "sss2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier storageSyncPrivateEndpointConnectionResourceId = StorageSyncPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, privateEndpointConnectionName);
            StorageSyncPrivateEndpointConnectionResource storageSyncPrivateEndpointConnection = client.GetStorageSyncPrivateEndpointConnectionResource(storageSyncPrivateEndpointConnectionResourceId);

            // invoke the operation
            await storageSyncPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
