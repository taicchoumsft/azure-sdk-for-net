// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PostgreSql.Models;

namespace Azure.ResourceManager.PostgreSql.Samples
{
    public partial class Sample_PostgreSqlServerKeyCollection
    {
        // List the keys for a PostgreSQL Server.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListTheKeysForAPostgreSQLServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2020-01-01/examples/ServerKeyList.json
            // this example is just showing the usage of "ServerKeys_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerKeyResource
            PostgreSqlServerKeyCollection collection = postgreSqlServer.GetPostgreSqlServerKeys();

            // invoke the operation and iterate over the result
            await foreach (PostgreSqlServerKeyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlServerKeyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get the PostgreSQL Server key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetThePostgreSQLServerKey()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2020-01-01/examples/ServerKeyGet.json
            // this example is just showing the usage of "ServerKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerKeyResource
            PostgreSqlServerKeyCollection collection = postgreSqlServer.GetPostgreSqlServerKeys();

            // invoke the operation
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            PostgreSqlServerKeyResource result = await collection.GetAsync(keyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the PostgreSQL Server key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetThePostgreSQLServerKey()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2020-01-01/examples/ServerKeyGet.json
            // this example is just showing the usage of "ServerKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerKeyResource
            PostgreSqlServerKeyCollection collection = postgreSqlServer.GetPostgreSqlServerKeys();

            // invoke the operation
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            bool result = await collection.ExistsAsync(keyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the PostgreSQL Server key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetThePostgreSQLServerKey()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2020-01-01/examples/ServerKeyGet.json
            // this example is just showing the usage of "ServerKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerKeyResource
            PostgreSqlServerKeyCollection collection = postgreSqlServer.GetPostgreSqlServerKeys();

            // invoke the operation
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            NullableResponse<PostgreSqlServerKeyResource> response = await collection.GetIfExistsAsync(keyName);
            PostgreSqlServerKeyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlServerKeyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Creates or updates a PostgreSQL Server key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesOrUpdatesAPostgreSQLServerKey()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2020-01-01/examples/ServerKeyCreateOrUpdate.json
            // this example is just showing the usage of "ServerKeys_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerKeyResource
            PostgreSqlServerKeyCollection collection = postgreSqlServer.GetPostgreSqlServerKeys();

            // invoke the operation
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            PostgreSqlServerKeyData data = new PostgreSqlServerKeyData()
            {
                ServerKeyType = PostgreSqlServerKeyType.AzureKeyVault,
                Uri = new Uri("https://someVault.vault.azure.net/keys/someKey/01234567890123456789012345678901"),
            };
            ArmOperation<PostgreSqlServerKeyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, keyName, data);
            PostgreSqlServerKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
