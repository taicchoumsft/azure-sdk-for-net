// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // Locations_CheckTrialAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckAvsTrialAvailability_LocationsCheckTrialAvailability()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/Locations_CheckTrialAvailability.json
            // this example is just showing the usage of "Locations_CheckTrialAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("eastus");
            AvsSubscriptionTrialAvailabilityResult result = await subscriptionResource.CheckAvsTrialAvailabilityAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Locations_CheckTrialAvailabilityWithSku
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckAvsTrialAvailability_LocationsCheckTrialAvailabilityWithSku()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/Locations_CheckTrialAvailabilityWithSku.json
            // this example is just showing the usage of "Locations_CheckTrialAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("eastus");
            AvsSku sku = new AvsSku("avs52t");
            AvsSubscriptionTrialAvailabilityResult result = await subscriptionResource.CheckAvsTrialAvailabilityAsync(location, sku: sku);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Locations_CheckQuotaAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckAvsQuotaAvailability_LocationsCheckQuotaAvailability()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/Locations_CheckQuotaAvailability.json
            // this example is just showing the usage of "Locations_CheckQuotaAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("eastus");
            AvsSubscriptionQuotaAvailabilityResult result = await subscriptionResource.CheckAvsQuotaAvailabilityAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
