// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBAccountCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBDatabaseAccountCreateMax()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDatabaseAccountCreateMax.json
            // this example is just showing the usage of "DatabaseAccounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBAccountResource
            CosmosDBAccountCollection collection = resourceGroupResource.GetCosmosDBAccounts();

            // invoke the operation
            string accountName = "ddb1";
            CosmosDBAccountCreateOrUpdateContent content = new CosmosDBAccountCreateOrUpdateContent(new AzureLocation("westus"), new CosmosDBAccountLocation[]
            {
new CosmosDBAccountLocation
{
LocationName = new AzureLocation("southcentralus"),
FailoverPriority = 0,
IsZoneRedundant = false,
},
new CosmosDBAccountLocation
{
LocationName = new AzureLocation("eastus"),
FailoverPriority = 1,
IsZoneRedundant = false,
}
            })
            {
                Kind = CosmosDBAccountKind.MongoDB,
                ConsistencyPolicy = new ConsistencyPolicy(DefaultConsistencyLevel.BoundedStaleness)
                {
                    MaxStalenessPrefix = 200L,
                    MaxIntervalInSeconds = 10,
                },
                IPRules = {new CosmosDBIPAddressOrRange
{
IPAddressOrRange = "23.43.230.120",
}, new CosmosDBIPAddressOrRange
{
IPAddressOrRange = "110.12.240.0/12",
}},
                IsVirtualNetworkFilterEnabled = true,
                VirtualNetworkRules = {new CosmosDBVirtualNetworkRule
{
Id = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/subnet1"),
IgnoreMissingVnetServiceEndpoint = false,
}},
                KeyVaultKeyUri = new Uri("https://myKeyVault.vault.azure.net"),
                DefaultIdentity = "FirstPartyIdentity",
                PublicNetworkAccess = CosmosDBPublicNetworkAccess.Enabled,
                IsFreeTierEnabled = false,
                ApiServerVersion = CosmosDBServerVersion.V3_2,
                IsAnalyticalStorageEnabled = true,
                AnalyticalStorageSchemaType = AnalyticalStorageSchemaType.WellDefined,
                CreateMode = CosmosDBAccountCreateMode.Default,
                BackupPolicy = new PeriodicModeBackupPolicy
                {
                    PeriodicModeProperties = new PeriodicModeProperties
                    {
                        BackupIntervalInMinutes = 240,
                        BackupRetentionIntervalInHours = 8,
                        BackupStorageRedundancy = CosmosDBBackupStorageRedundancy.Geo,
                    },
                },
                Cors = { new CosmosDBAccountCorsPolicy("https://test") },
                NetworkAclBypass = NetworkAclBypass.AzureServices,
                NetworkAclBypassResourceIds = { new ResourceIdentifier("/subscriptions/subId/resourcegroups/rgName/providers/Microsoft.Synapse/workspaces/workspaceName") },
                CapacityTotalThroughputLimit = 2000,
                CapacityMode = CapacityMode.Provisioned,
                EnableMaterializedViews = false,
                EnableBurstCapacity = true,
                MinimalTlsVersion = CosmosDBMinimalTlsVersion.Tls12,
                EnablePriorityBasedExecution = true,
                DefaultPriorityLevel = DefaultPriorityLevel.Low,
                EnablePerRegionPerPartitionAutoscale = true,
                Identity = new ManagedServiceIdentity("SystemAssigned,UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/eu2cgroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1")] = new UserAssignedIdentity()
},
                },
                Tags = { },
            };
            ArmOperation<CosmosDBAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accountName, content);
            CosmosDBAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBDatabaseAccountCreateMin()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDatabaseAccountCreateMin.json
            // this example is just showing the usage of "DatabaseAccounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBAccountResource
            CosmosDBAccountCollection collection = resourceGroupResource.GetCosmosDBAccounts();

            // invoke the operation
            string accountName = "ddb1";
            CosmosDBAccountCreateOrUpdateContent content = new CosmosDBAccountCreateOrUpdateContent(new AzureLocation("westus"), new CosmosDBAccountLocation[]
            {
new CosmosDBAccountLocation
{
LocationName = new AzureLocation("southcentralus"),
FailoverPriority = 0,
IsZoneRedundant = false,
}
            })
            {
                CreateMode = CosmosDBAccountCreateMode.Default,
            };
            ArmOperation<CosmosDBAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accountName, content);
            CosmosDBAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBRestoreDatabaseAccountCreateUpdateJson()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBRestoreDatabaseAccountCreateUpdate.json
            // this example is just showing the usage of "DatabaseAccounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBAccountResource
            CosmosDBAccountCollection collection = resourceGroupResource.GetCosmosDBAccounts();

            // invoke the operation
            string accountName = "ddb1";
            CosmosDBAccountCreateOrUpdateContent content = new CosmosDBAccountCreateOrUpdateContent(new AzureLocation("westus"), new CosmosDBAccountLocation[]
            {
new CosmosDBAccountLocation
{
LocationName = new AzureLocation("southcentralus"),
FailoverPriority = 0,
IsZoneRedundant = false,
}
            })
            {
                Kind = CosmosDBAccountKind.GlobalDocumentDB,
                ConsistencyPolicy = new ConsistencyPolicy(DefaultConsistencyLevel.BoundedStaleness)
                {
                    MaxStalenessPrefix = 200L,
                    MaxIntervalInSeconds = 10,
                },
                KeyVaultKeyUri = new Uri("https://myKeyVault.vault.azure.net"),
                IsFreeTierEnabled = false,
                ApiServerVersion = CosmosDBServerVersion.V3_2,
                IsAnalyticalStorageEnabled = true,
                CreateMode = CosmosDBAccountCreateMode.Restore,
                BackupPolicy = new ContinuousModeBackupPolicy
                {
                    ContinuousModeTier = ContinuousTier.Continuous30Days,
                },
                RestoreParameters = new CosmosDBAccountRestoreParameters
                {
                    RestoreMode = CosmosDBAccountRestoreMode.PointInTime,
                    DatabasesToRestore = {new DatabaseRestoreResourceInfo
{
DatabaseName = "db1",
CollectionNames = {"collection1", "collection2"},
}, new DatabaseRestoreResourceInfo
{
DatabaseName = "db2",
CollectionNames = {"collection3", "collection4"},
}},
                    SourceBackupLocation = "westus",
                    RestoreSource = "/subscriptions/subid/providers/Microsoft.DocumentDB/locations/westus/restorableDatabaseAccounts/1a97b4bb-f6a0-430e-ade1-638d781830cc",
                    RestoreTimestampInUtc = DateTimeOffset.Parse("2021-03-11T22:05:09Z"),
                    IsRestoreWithTtlDisabled = false,
                },
                EnableMaterializedViews = false,
                MinimalTlsVersion = CosmosDBMinimalTlsVersion.Tls,
                Tags = { },
            };
            ArmOperation<CosmosDBAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accountName, content);
            CosmosDBAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBDatabaseAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDatabaseAccountGet.json
            // this example is just showing the usage of "DatabaseAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBAccountResource
            CosmosDBAccountCollection collection = resourceGroupResource.GetCosmosDBAccounts();

            // invoke the operation
            string accountName = "ddb1";
            CosmosDBAccountResource result = await collection.GetAsync(accountName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CosmosDBDatabaseAccountListByResourceGroup()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDatabaseAccountListByResourceGroup.json
            // this example is just showing the usage of "DatabaseAccounts_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBAccountResource
            CosmosDBAccountCollection collection = resourceGroupResource.GetCosmosDBAccounts();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBAccountResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CosmosDBDatabaseAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDatabaseAccountGet.json
            // this example is just showing the usage of "DatabaseAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBAccountResource
            CosmosDBAccountCollection collection = resourceGroupResource.GetCosmosDBAccounts();

            // invoke the operation
            string accountName = "ddb1";
            bool result = await collection.ExistsAsync(accountName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CosmosDBDatabaseAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDatabaseAccountGet.json
            // this example is just showing the usage of "DatabaseAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBAccountResource
            CosmosDBAccountCollection collection = resourceGroupResource.GetCosmosDBAccounts();

            // invoke the operation
            string accountName = "ddb1";
            NullableResponse<CosmosDBAccountResource> response = await collection.GetIfExistsAsync(accountName);
            CosmosDBAccountResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBAccountData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
