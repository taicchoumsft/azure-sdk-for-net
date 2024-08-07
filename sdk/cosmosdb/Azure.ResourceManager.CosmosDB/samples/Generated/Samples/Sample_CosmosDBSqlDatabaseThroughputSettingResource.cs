// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBSqlDatabaseThroughputSettingResource
    {
        // CosmosDBSqlDatabaseThroughputGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBSqlDatabaseThroughputGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBSqlDatabaseThroughputGet.json
            // this example is just showing the usage of "SqlResources_GetSqlDatabaseThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlDatabaseThroughputSettingResource, please refer to the document of CosmosDBSqlDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseThroughputSettingResourceId = CosmosDBSqlDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseThroughputSettingResource cosmosDBSqlDatabaseThroughputSetting = client.GetCosmosDBSqlDatabaseThroughputSettingResource(cosmosDBSqlDatabaseThroughputSettingResourceId);

            // invoke the operation
            CosmosDBSqlDatabaseThroughputSettingResource result = await cosmosDBSqlDatabaseThroughputSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlDatabaseThroughputUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CosmosDBSqlDatabaseThroughputUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBSqlDatabaseThroughputUpdate.json
            // this example is just showing the usage of "SqlResources_UpdateSqlDatabaseThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlDatabaseThroughputSettingResource, please refer to the document of CosmosDBSqlDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseThroughputSettingResourceId = CosmosDBSqlDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseThroughputSettingResource cosmosDBSqlDatabaseThroughputSetting = client.GetCosmosDBSqlDatabaseThroughputSettingResource(cosmosDBSqlDatabaseThroughputSettingResourceId);

            // invoke the operation
            ThroughputSettingsUpdateData data = new ThroughputSettingsUpdateData(new AzureLocation("West US"), new ThroughputSettingsResourceInfo()
            {
                Throughput = 400,
            })
            {
                Tags =
{
},
            };
            ArmOperation<CosmosDBSqlDatabaseThroughputSettingResource> lro = await cosmosDBSqlDatabaseThroughputSetting.CreateOrUpdateAsync(WaitUntil.Completed, data);
            CosmosDBSqlDatabaseThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlDatabaseMigrateToAutoscale
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateSqlDatabaseToAutoscale_CosmosDBSqlDatabaseMigrateToAutoscale()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBSqlDatabaseMigrateToAutoscale.json
            // this example is just showing the usage of "SqlResources_MigrateSqlDatabaseToAutoscale" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlDatabaseThroughputSettingResource, please refer to the document of CosmosDBSqlDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseThroughputSettingResourceId = CosmosDBSqlDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseThroughputSettingResource cosmosDBSqlDatabaseThroughputSetting = client.GetCosmosDBSqlDatabaseThroughputSettingResource(cosmosDBSqlDatabaseThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CosmosDBSqlDatabaseThroughputSettingResource> lro = await cosmosDBSqlDatabaseThroughputSetting.MigrateSqlDatabaseToAutoscaleAsync(WaitUntil.Completed);
            CosmosDBSqlDatabaseThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlDatabaseMigrateToManualThroughput
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateSqlDatabaseToManualThroughput_CosmosDBSqlDatabaseMigrateToManualThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBSqlDatabaseMigrateToManualThroughput.json
            // this example is just showing the usage of "SqlResources_MigrateSqlDatabaseToManualThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlDatabaseThroughputSettingResource, please refer to the document of CosmosDBSqlDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseThroughputSettingResourceId = CosmosDBSqlDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseThroughputSettingResource cosmosDBSqlDatabaseThroughputSetting = client.GetCosmosDBSqlDatabaseThroughputSettingResource(cosmosDBSqlDatabaseThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CosmosDBSqlDatabaseThroughputSettingResource> lro = await cosmosDBSqlDatabaseThroughputSetting.MigrateSqlDatabaseToManualThroughputAsync(WaitUntil.Completed);
            CosmosDBSqlDatabaseThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlDatabaseRetrieveThroughputDistribution
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SqlDatabaseRetrieveThroughputDistribution_CosmosDBSqlDatabaseRetrieveThroughputDistribution()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBSqlDatabaseRetrieveThroughputDistribution.json
            // this example is just showing the usage of "SqlResources_SqlDatabaseRetrieveThroughputDistribution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlDatabaseThroughputSettingResource, please refer to the document of CosmosDBSqlDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseThroughputSettingResourceId = CosmosDBSqlDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseThroughputSettingResource cosmosDBSqlDatabaseThroughputSetting = client.GetCosmosDBSqlDatabaseThroughputSettingResource(cosmosDBSqlDatabaseThroughputSettingResourceId);

            // invoke the operation
            RetrieveThroughputParameters retrieveThroughputParameters = new RetrieveThroughputParameters(new AzureLocation("placeholder"), new RetrieveThroughputPropertiesResource(new WritableSubResource[]
            {
new WritableSubResource()
{
Id = new ResourceIdentifier("0"),
},new WritableSubResource()
{
Id = new ResourceIdentifier("1"),
}
            }));
            ArmOperation<PhysicalPartitionThroughputInfoResult> lro = await cosmosDBSqlDatabaseThroughputSetting.SqlDatabaseRetrieveThroughputDistributionAsync(WaitUntil.Completed, retrieveThroughputParameters);
            PhysicalPartitionThroughputInfoResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // CosmosDBSqlDatabaseRedistributeThroughput
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SqlDatabaseRedistributeThroughput_CosmosDBSqlDatabaseRedistributeThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBSqlDatabaseRedistributeThroughput.json
            // this example is just showing the usage of "SqlResources_SqlDatabaseRedistributeThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlDatabaseThroughputSettingResource, please refer to the document of CosmosDBSqlDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseThroughputSettingResourceId = CosmosDBSqlDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseThroughputSettingResource cosmosDBSqlDatabaseThroughputSetting = client.GetCosmosDBSqlDatabaseThroughputSettingResource(cosmosDBSqlDatabaseThroughputSettingResourceId);

            // invoke the operation
            RedistributeThroughputParameters redistributeThroughputParameters = new RedistributeThroughputParameters(new AzureLocation("placeholder"), new RedistributeThroughputPropertiesResource(ThroughputPolicyType.Custom, new PhysicalPartitionThroughputInfoResource[]
            {
new PhysicalPartitionThroughputInfoResource("0")
{
Throughput = 5000,
},new PhysicalPartitionThroughputInfoResource("1")
{
Throughput = 5000,
}
            }, new PhysicalPartitionThroughputInfoResource[]
            {
new PhysicalPartitionThroughputInfoResource("2")
{
Throughput = 5000,
},new PhysicalPartitionThroughputInfoResource("3")
            }));
            ArmOperation<PhysicalPartitionThroughputInfoResult> lro = await cosmosDBSqlDatabaseThroughputSetting.SqlDatabaseRedistributeThroughputAsync(WaitUntil.Completed, redistributeThroughputParameters);
            PhysicalPartitionThroughputInfoResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
