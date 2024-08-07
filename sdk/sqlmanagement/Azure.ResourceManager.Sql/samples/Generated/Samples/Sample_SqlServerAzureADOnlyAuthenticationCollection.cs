// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerAzureADOnlyAuthenticationCollection
    {
        // Gets a Azure Active Directory only authentication property.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAAzureActiveDirectoryOnlyAuthenticationProperty()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/AzureADOnlyAuthGet.json
            // this example is just showing the usage of "ServerAzureADOnlyAuthentications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string serverName = "sqlcrudtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerAzureADOnlyAuthenticationResource
            SqlServerAzureADOnlyAuthenticationCollection collection = sqlServer.GetSqlServerAzureADOnlyAuthentications();

            // invoke the operation
            AuthenticationName authenticationName = AuthenticationName.Default;
            SqlServerAzureADOnlyAuthenticationResource result = await collection.GetAsync(authenticationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerAzureADOnlyAuthenticationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a Azure Active Directory only authentication property.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsAAzureActiveDirectoryOnlyAuthenticationProperty()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/AzureADOnlyAuthGet.json
            // this example is just showing the usage of "ServerAzureADOnlyAuthentications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string serverName = "sqlcrudtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerAzureADOnlyAuthenticationResource
            SqlServerAzureADOnlyAuthenticationCollection collection = sqlServer.GetSqlServerAzureADOnlyAuthentications();

            // invoke the operation
            AuthenticationName authenticationName = AuthenticationName.Default;
            bool result = await collection.ExistsAsync(authenticationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets a Azure Active Directory only authentication property.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsAAzureActiveDirectoryOnlyAuthenticationProperty()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/AzureADOnlyAuthGet.json
            // this example is just showing the usage of "ServerAzureADOnlyAuthentications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string serverName = "sqlcrudtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerAzureADOnlyAuthenticationResource
            SqlServerAzureADOnlyAuthenticationCollection collection = sqlServer.GetSqlServerAzureADOnlyAuthentications();

            // invoke the operation
            AuthenticationName authenticationName = AuthenticationName.Default;
            NullableResponse<SqlServerAzureADOnlyAuthenticationResource> response = await collection.GetIfExistsAsync(authenticationName);
            SqlServerAzureADOnlyAuthenticationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerAzureADOnlyAuthenticationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Creates or updates Azure Active Directory only authentication object.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesOrUpdatesAzureActiveDirectoryOnlyAuthenticationObject()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/AzureADOnlyAuthCreateOrUpdate.json
            // this example is just showing the usage of "ServerAzureADOnlyAuthentications_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string serverName = "sqlcrudtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerAzureADOnlyAuthenticationResource
            SqlServerAzureADOnlyAuthenticationCollection collection = sqlServer.GetSqlServerAzureADOnlyAuthentications();

            // invoke the operation
            AuthenticationName authenticationName = AuthenticationName.Default;
            SqlServerAzureADOnlyAuthenticationData data = new SqlServerAzureADOnlyAuthenticationData()
            {
                IsAzureADOnlyAuthenticationEnabled = false,
            };
            ArmOperation<SqlServerAzureADOnlyAuthenticationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authenticationName, data);
            SqlServerAzureADOnlyAuthenticationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerAzureADOnlyAuthenticationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a list of Azure Active Directory only authentication object.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsAListOfAzureActiveDirectoryOnlyAuthenticationObject()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/AzureADOnlyAuthList.json
            // this example is just showing the usage of "ServerAzureADOnlyAuthentications_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string serverName = "sqlcrudtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerAzureADOnlyAuthenticationResource
            SqlServerAzureADOnlyAuthenticationCollection collection = sqlServer.GetSqlServerAzureADOnlyAuthentications();

            // invoke the operation and iterate over the result
            await foreach (SqlServerAzureADOnlyAuthenticationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerAzureADOnlyAuthenticationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
