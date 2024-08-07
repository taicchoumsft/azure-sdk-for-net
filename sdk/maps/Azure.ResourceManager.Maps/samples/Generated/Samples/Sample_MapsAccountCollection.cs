// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Maps.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Maps.Samples
{
    public partial class Sample_MapsAccountCollection
    {
        // Create Account with Managed Identities
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAccountWithManagedIdentities()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/CreateAccountManagedIdentity.json
            // this example is just showing the usage of "Accounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MapsAccountResource
            MapsAccountCollection collection = resourceGroupResource.GetMapsAccounts();

            // invoke the operation
            string accountName = "myMapsAccount";
            MapsAccountData data = new MapsAccountData(new AzureLocation("eastus"), new MapsSku(MapsSkuName.G2))
            {
                Kind = MapsAccountKind.Gen2,
                Identity = new ManagedServiceIdentity("SystemAssigned, UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/21a9967a-e8a9-4656-a70b-96ff1c4d05a0/resourceGroups/myResourceGroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/identityName")] = new UserAssignedIdentity(),
},
                },
                Properties = new MapsAccountProperties()
                {
                    DisableLocalAuth = false,
                    LinkedResources =
{
new MapsLinkedResource("myBatchStorageAccount","/subscriptions/21a9967a-e8a9-4656-a70b-96ff1c4d05a0/resourceGroups/myResourceGroup/providers/Microsoft.Storage/accounts/mystorageacc"),new MapsLinkedResource("myBlobDataSource","/subscriptions/21a9967a-e8a9-4656-a70b-96ff1c4d05a0/resourceGroups/myResourceGroup/providers/Microsoft.Storage/accounts/mystorageacc")
},
                },
                Tags =
{
["test"] = "true",
},
            };
            ArmOperation<MapsAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accountName, data);
            MapsAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MapsAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create Gen1 Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateGen1Account()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/CreateAccount.json
            // this example is just showing the usage of "Accounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MapsAccountResource
            MapsAccountCollection collection = resourceGroupResource.GetMapsAccounts();

            // invoke the operation
            string accountName = "myMapsAccount";
            MapsAccountData data = new MapsAccountData(new AzureLocation("eastus"), new MapsSku(MapsSkuName.S0))
            {
                Kind = MapsAccountKind.Gen1,
                Properties = new MapsAccountProperties()
                {
                    DisableLocalAuth = false,
                    CorsRulesValue =
{
new MapsCorsRule(new string[]
{
"http://www.contoso.com","http://www.fabrikam.com"
})
},
                },
                Tags =
{
["test"] = "true",
},
            };
            ArmOperation<MapsAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accountName, data);
            MapsAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MapsAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create Gen2 Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateGen2Account()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/CreateAccountGen2.json
            // this example is just showing the usage of "Accounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MapsAccountResource
            MapsAccountCollection collection = resourceGroupResource.GetMapsAccounts();

            // invoke the operation
            string accountName = "myMapsAccount";
            MapsAccountData data = new MapsAccountData(new AzureLocation("eastus"), new MapsSku(MapsSkuName.G2))
            {
                Kind = MapsAccountKind.Gen2,
                Properties = new MapsAccountProperties()
                {
                    DisableLocalAuth = true,
                    CorsRulesValue =
{
new MapsCorsRule(new string[]
{
"http://www.contoso.com","http://www.fabrikam.com"
})
},
                },
                Tags =
{
["test"] = "true",
},
            };
            ArmOperation<MapsAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accountName, data);
            MapsAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MapsAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetAccount
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAccount()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/GetAccount.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MapsAccountResource
            MapsAccountCollection collection = resourceGroupResource.GetMapsAccounts();

            // invoke the operation
            string accountName = "myMapsAccount";
            MapsAccountResource result = await collection.GetAsync(accountName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MapsAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetAccount
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAccount()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/GetAccount.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MapsAccountResource
            MapsAccountCollection collection = resourceGroupResource.GetMapsAccounts();

            // invoke the operation
            string accountName = "myMapsAccount";
            bool result = await collection.ExistsAsync(accountName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetAccount
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAccount()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/GetAccount.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MapsAccountResource
            MapsAccountCollection collection = resourceGroupResource.GetMapsAccounts();

            // invoke the operation
            string accountName = "myMapsAccount";
            NullableResponse<MapsAccountResource> response = await collection.GetIfExistsAsync(accountName);
            MapsAccountResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MapsAccountData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List Accounts By Resource Group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAccountsByResourceGroup()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/ListAccountsByResourceGroup.json
            // this example is just showing the usage of "Accounts_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MapsAccountResource
            MapsAccountCollection collection = resourceGroupResource.GetMapsAccounts();

            // invoke the operation and iterate over the result
            await foreach (MapsAccountResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MapsAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
