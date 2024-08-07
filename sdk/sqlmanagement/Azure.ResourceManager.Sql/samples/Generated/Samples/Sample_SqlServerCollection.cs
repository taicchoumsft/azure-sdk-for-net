// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerCollection
    {
        // List servers by resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListServersByResourceGroup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerListByResourceGroup.json
            // this example is just showing the usage of "Servers_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation and iterate over the result
            await foreach (SqlServerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List servers by resource group with $expand=administrators/activedirectory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListServersByResourceGroupWithExpandAdministratorsActivedirectory()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerListByResourceGroupWithExpandEqualsAdministrators.json
            // this example is just showing the usage of "Servers_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation and iterate over the result
            await foreach (SqlServerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerGet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation
            string serverName = "sqlcrudtest-4645";
            SqlServerResource result = await collection.GetAsync(serverName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerGet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation
            string serverName = "sqlcrudtest-4645";
            bool result = await collection.ExistsAsync(serverName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerGet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation
            string serverName = "sqlcrudtest-4645";
            NullableResponse<SqlServerResource> response = await collection.GetIfExistsAsync(serverName);
            SqlServerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get server with $expand=administrators/activedirectory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetServerWithExpandAdministratorsActivedirectory()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerGetWithExpandEqualsAdministrators.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation
            string serverName = "sqlcrudtest-4645";
            SqlServerResource result = await collection.GetAsync(serverName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get server with $expand=administrators/activedirectory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetServerWithExpandAdministratorsActivedirectory()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerGetWithExpandEqualsAdministrators.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation
            string serverName = "sqlcrudtest-4645";
            bool result = await collection.ExistsAsync(serverName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get server with $expand=administrators/activedirectory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetServerWithExpandAdministratorsActivedirectory()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerGetWithExpandEqualsAdministrators.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation
            string serverName = "sqlcrudtest-4645";
            NullableResponse<SqlServerResource> response = await collection.GetIfExistsAsync(serverName);
            SqlServerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ServerCreate.json
            // this example is just showing the usage of "Servers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlServerResource
            SqlServerCollection collection = resourceGroupResource.GetSqlServers();

            // invoke the operation
            string serverName = "sqlcrudtest-4645";
            SqlServerData data = new SqlServerData(new AzureLocation("Japan East"))
            {
                AdministratorLogin = "dummylogin",
                AdministratorLoginPassword = "PLACEHOLDER",
                PublicNetworkAccess = ServerNetworkAccessFlag.Enabled,
                Administrators = new ServerExternalAdministrator()
                {
                    PrincipalType = SqlServerPrincipalType.User,
                    Login = "bob@contoso.com",
                    Sid = Guid.Parse("00000011-1111-2222-2222-123456789111"),
                    TenantId = Guid.Parse("00000011-1111-2222-2222-123456789111"),
                    IsAzureADOnlyAuthenticationEnabled = true,
                },
                RestrictOutboundNetworkAccess = ServerNetworkAccessFlag.Enabled,
                IsIPv6Enabled = ServerNetworkAccessFlag.Enabled,
            };
            ArmOperation<SqlServerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serverName, data);
            SqlServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
