// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceRegistry.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.DeviceRegistry.Samples
{
    public partial class Sample_DiscoveredAssetEndpointProfileResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetDiscoveredAssetEndpointProfiles_ListDiscoveredAssetEndpointProfilesSubscription()
        {
            // Generated from example definition: specification/deviceregistry/resource-manager/Microsoft.DeviceRegistry/preview/2024-09-01-preview/examples/List_DiscoveredAssetEndpointProfiles_Subscription.json
            // this example is just showing the usage of "DiscoveredAssetEndpointProfiles_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DiscoveredAssetEndpointProfileResource item in subscriptionResource.GetDiscoveredAssetEndpointProfilesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiscoveredAssetEndpointProfileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDiscoveredAssetEndpointProfile()
        {
            // Generated from example definition: specification/deviceregistry/resource-manager/Microsoft.DeviceRegistry/preview/2024-09-01-preview/examples/Get_DiscoveredAssetEndpointProfile.json
            // this example is just showing the usage of "DiscoveredAssetEndpointProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiscoveredAssetEndpointProfileResource created on azure
            // for more information of creating DiscoveredAssetEndpointProfileResource, please refer to the document of DiscoveredAssetEndpointProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string discoveredAssetEndpointProfileName = "my-discoveredassetendpointprofile";
            ResourceIdentifier discoveredAssetEndpointProfileResourceId = DiscoveredAssetEndpointProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, discoveredAssetEndpointProfileName);
            DiscoveredAssetEndpointProfileResource discoveredAssetEndpointProfile = client.GetDiscoveredAssetEndpointProfileResource(discoveredAssetEndpointProfileResourceId);

            // invoke the operation
            DiscoveredAssetEndpointProfileResource result = await discoveredAssetEndpointProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiscoveredAssetEndpointProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateDiscoveredAssetEndpointProfile()
        {
            // Generated from example definition: specification/deviceregistry/resource-manager/Microsoft.DeviceRegistry/preview/2024-09-01-preview/examples/Update_DiscoveredAssetEndpointProfile.json
            // this example is just showing the usage of "DiscoveredAssetEndpointProfiles_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiscoveredAssetEndpointProfileResource created on azure
            // for more information of creating DiscoveredAssetEndpointProfileResource, please refer to the document of DiscoveredAssetEndpointProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string discoveredAssetEndpointProfileName = "my-discoveredassetendpointprofile";
            ResourceIdentifier discoveredAssetEndpointProfileResourceId = DiscoveredAssetEndpointProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, discoveredAssetEndpointProfileName);
            DiscoveredAssetEndpointProfileResource discoveredAssetEndpointProfile = client.GetDiscoveredAssetEndpointProfileResource(discoveredAssetEndpointProfileResourceId);

            // invoke the operation
            DiscoveredAssetEndpointProfilePatch patch = new DiscoveredAssetEndpointProfilePatch()
            {
                Properties = new DiscoveredAssetEndpointProfileUpdateProperties()
                {
                    TargetAddress = new Uri("https://www.example.com/myTargetAddress"),
                    AdditionalConfiguration = "{\"foo\": \"bar\"}",
                    SupportedAuthenticationMethods =
{
AuthenticationMethod.Anonymous,AuthenticationMethod.Certificate
},
                    EndpointProfileType = "myEndpointProfileType",
                    DiscoveryId = "11111111-1111-1111-1111-111111111111",
                    Version = 73766L,
                },
            };
            ArmOperation<DiscoveredAssetEndpointProfileResource> lro = await discoveredAssetEndpointProfile.UpdateAsync(WaitUntil.Completed, patch);
            DiscoveredAssetEndpointProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiscoveredAssetEndpointProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteDiscoveredAssetEndpointProfile()
        {
            // Generated from example definition: specification/deviceregistry/resource-manager/Microsoft.DeviceRegistry/preview/2024-09-01-preview/examples/Delete_DiscoveredAssetEndpointProfile.json
            // this example is just showing the usage of "DiscoveredAssetEndpointProfiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiscoveredAssetEndpointProfileResource created on azure
            // for more information of creating DiscoveredAssetEndpointProfileResource, please refer to the document of DiscoveredAssetEndpointProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string discoveredAssetEndpointProfileName = "my-discoveredassetendpointprofile";
            ResourceIdentifier discoveredAssetEndpointProfileResourceId = DiscoveredAssetEndpointProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, discoveredAssetEndpointProfileName);
            DiscoveredAssetEndpointProfileResource discoveredAssetEndpointProfile = client.GetDiscoveredAssetEndpointProfileResource(discoveredAssetEndpointProfileResourceId);

            // invoke the operation
            await discoveredAssetEndpointProfile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
