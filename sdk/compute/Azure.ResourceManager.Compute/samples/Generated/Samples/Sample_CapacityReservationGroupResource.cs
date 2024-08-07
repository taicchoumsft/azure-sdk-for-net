// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_CapacityReservationGroupResource
    {
        // CapacityReservationGroup_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CapacityReservationGroupUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/capacityReservationExamples/CapacityReservationGroup_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "CapacityReservationGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string capacityReservationGroupName = "aaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // invoke the operation
            CapacityReservationGroupPatch patch = new CapacityReservationGroupPatch()
            {
                Tags =
{
["key5355"] = "aaa",
},
            };
            CapacityReservationGroupResource result = await capacityReservationGroup.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityReservationGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CapacityReservationGroup_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CapacityReservationGroupUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/capacityReservationExamples/CapacityReservationGroup_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "CapacityReservationGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string capacityReservationGroupName = "aaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // invoke the operation
            CapacityReservationGroupPatch patch = new CapacityReservationGroupPatch();
            CapacityReservationGroupResource result = await capacityReservationGroup.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityReservationGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CapacityReservationGroup_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CapacityReservationGroupDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/capacityReservationExamples/CapacityReservationGroup_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "CapacityReservationGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string capacityReservationGroupName = "a";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // invoke the operation
            await capacityReservationGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CapacityReservationGroup_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CapacityReservationGroupDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/capacityReservationExamples/CapacityReservationGroup_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "CapacityReservationGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string capacityReservationGroupName = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // invoke the operation
            await capacityReservationGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a capacity reservation Group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetACapacityReservationGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/capacityReservationExamples/CapacityReservationGroup_Get.json
            // this example is just showing the usage of "CapacityReservationGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string capacityReservationGroupName = "myCapacityReservationGroup";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // invoke the operation
            CapacityReservationGroupInstanceViewType? expand = CapacityReservationGroupInstanceViewType.InstanceView;
            CapacityReservationGroupResource result = await capacityReservationGroup.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityReservationGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List capacity reservation groups in subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCapacityReservationGroups_ListCapacityReservationGroupsInSubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/capacityReservationExamples/CapacityReservationGroup_ListBySubscription.json
            // this example is just showing the usage of "CapacityReservationGroups_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            CapacityReservationGroupGetExpand? expand = CapacityReservationGroupGetExpand.VirtualMachinesRef;
            await foreach (CapacityReservationGroupResource item in subscriptionResource.GetCapacityReservationGroupsAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CapacityReservationGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List capacity reservation groups with resource Ids only in subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCapacityReservationGroups_ListCapacityReservationGroupsWithResourceIdsOnlyInSubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/capacityReservationExamples/CapacityReservationGroup_ListBySubscriptionWithResourceIdsQuery.json
            // this example is just showing the usage of "CapacityReservationGroups_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            ResourceIdOptionsForGetCapacityReservationGroup? resourceIdsOnly = ResourceIdOptionsForGetCapacityReservationGroup.All;
            await foreach (CapacityReservationGroupResource item in subscriptionResource.GetCapacityReservationGroupsAsync(resourceIdsOnly: resourceIdsOnly))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CapacityReservationGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
