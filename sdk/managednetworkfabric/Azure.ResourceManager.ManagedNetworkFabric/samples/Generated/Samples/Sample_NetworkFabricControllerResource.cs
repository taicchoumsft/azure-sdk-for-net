// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_NetworkFabricControllerResource
    {
        // NetworkFabricControllers_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkFabricControllersGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabricControllers_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabricControllers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricControllerResource created on azure
            // for more information of creating NetworkFabricControllerResource, please refer to the document of NetworkFabricControllerResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricControllerName = "example-networkController";
            ResourceIdentifier networkFabricControllerResourceId = NetworkFabricControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricControllerName);
            NetworkFabricControllerResource networkFabricController = client.GetNetworkFabricControllerResource(networkFabricControllerResourceId);

            // invoke the operation
            NetworkFabricControllerResource result = await networkFabricController.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricControllerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkFabricControllers_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NetworkFabricControllersUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabricControllers_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabricControllers_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricControllerResource created on azure
            // for more information of creating NetworkFabricControllerResource, please refer to the document of NetworkFabricControllerResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricControllerName = "example-networkController";
            ResourceIdentifier networkFabricControllerResourceId = NetworkFabricControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricControllerName);
            NetworkFabricControllerResource networkFabricController = client.GetNetworkFabricControllerResource(networkFabricControllerResourceId);

            // invoke the operation
            NetworkFabricControllerPatch patch = new NetworkFabricControllerPatch()
            {
                InfrastructureExpressRouteConnections =
{
new ExpressRouteConnectionInformation(new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.Network/expressRouteCircuits/expressRouteCircuitName"))
{
ExpressRouteAuthorizationKey = "xxxxxxx",
}
},
                WorkloadExpressRouteConnections =
{
new ExpressRouteConnectionInformation(new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.Network/expressRouteCircuits/expressRouteCircuitName"))
{
ExpressRouteAuthorizationKey = "xxxxxxx",
}
},
            };
            ArmOperation<NetworkFabricControllerResource> lro = await networkFabricController.UpdateAsync(WaitUntil.Completed, patch);
            NetworkFabricControllerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricControllerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkFabricControllers_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NetworkFabricControllersDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabricControllers_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabricControllers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricControllerResource created on azure
            // for more information of creating NetworkFabricControllerResource, please refer to the document of NetworkFabricControllerResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricControllerName = "example-networkController";
            ResourceIdentifier networkFabricControllerResourceId = NetworkFabricControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricControllerName);
            NetworkFabricControllerResource networkFabricController = client.GetNetworkFabricControllerResource(networkFabricControllerResourceId);

            // invoke the operation
            await networkFabricController.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // NetworkFabricControllers_ListBySubscription_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkFabricControllers_NetworkFabricControllersListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabricControllers_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabricControllers_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkFabricControllerResource item in subscriptionResource.GetNetworkFabricControllersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkFabricControllerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
