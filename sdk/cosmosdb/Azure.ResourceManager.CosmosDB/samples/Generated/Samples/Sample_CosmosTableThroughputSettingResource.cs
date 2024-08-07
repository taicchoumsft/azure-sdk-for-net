// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosTableThroughputSettingResource
    {
        // CosmosDBTableThroughputGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBTableThroughputGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBTableThroughputGet.json
            // this example is just showing the usage of "TableResources_GetTableThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosTableThroughputSettingResource created on azure
            // for more information of creating CosmosTableThroughputSettingResource, please refer to the document of CosmosTableThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string tableName = "tableName";
            ResourceIdentifier cosmosTableThroughputSettingResourceId = CosmosTableThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, tableName);
            CosmosTableThroughputSettingResource cosmosTableThroughputSetting = client.GetCosmosTableThroughputSettingResource(cosmosTableThroughputSettingResourceId);

            // invoke the operation
            CosmosTableThroughputSettingResource result = await cosmosTableThroughputSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBTableThroughputUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CosmosDBTableThroughputUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBTableThroughputUpdate.json
            // this example is just showing the usage of "TableResources_UpdateTableThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosTableThroughputSettingResource created on azure
            // for more information of creating CosmosTableThroughputSettingResource, please refer to the document of CosmosTableThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string tableName = "tableName";
            ResourceIdentifier cosmosTableThroughputSettingResourceId = CosmosTableThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, tableName);
            CosmosTableThroughputSettingResource cosmosTableThroughputSetting = client.GetCosmosTableThroughputSettingResource(cosmosTableThroughputSettingResourceId);

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
            ArmOperation<CosmosTableThroughputSettingResource> lro = await cosmosTableThroughputSetting.CreateOrUpdateAsync(WaitUntil.Completed, data);
            CosmosTableThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBTableMigrateToAutoscale
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateTableToAutoscale_CosmosDBTableMigrateToAutoscale()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBTableMigrateToAutoscale.json
            // this example is just showing the usage of "TableResources_MigrateTableToAutoscale" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosTableThroughputSettingResource created on azure
            // for more information of creating CosmosTableThroughputSettingResource, please refer to the document of CosmosTableThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string tableName = "tableName";
            ResourceIdentifier cosmosTableThroughputSettingResourceId = CosmosTableThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, tableName);
            CosmosTableThroughputSettingResource cosmosTableThroughputSetting = client.GetCosmosTableThroughputSettingResource(cosmosTableThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CosmosTableThroughputSettingResource> lro = await cosmosTableThroughputSetting.MigrateTableToAutoscaleAsync(WaitUntil.Completed);
            CosmosTableThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBTableMigrateToManualThroughput
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateTableToManualThroughput_CosmosDBTableMigrateToManualThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBTableMigrateToManualThroughput.json
            // this example is just showing the usage of "TableResources_MigrateTableToManualThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosTableThroughputSettingResource created on azure
            // for more information of creating CosmosTableThroughputSettingResource, please refer to the document of CosmosTableThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string tableName = "tableName";
            ResourceIdentifier cosmosTableThroughputSettingResourceId = CosmosTableThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, tableName);
            CosmosTableThroughputSettingResource cosmosTableThroughputSetting = client.GetCosmosTableThroughputSettingResource(cosmosTableThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CosmosTableThroughputSettingResource> lro = await cosmosTableThroughputSetting.MigrateTableToManualThroughputAsync(WaitUntil.Completed);
            CosmosTableThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
