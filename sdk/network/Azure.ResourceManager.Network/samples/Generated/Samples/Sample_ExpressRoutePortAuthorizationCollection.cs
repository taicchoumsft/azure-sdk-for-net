// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRoutePortAuthorizationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateExpressRoutePortAuthorization()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRoutePortAuthorizationCreate.json
            // this example is just showing the usage of "ExpressRoutePortAuthorizations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "expressRoutePortName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRoutePortAuthorizationResource
            ExpressRoutePortAuthorizationCollection collection = expressRoutePort.GetExpressRoutePortAuthorizations();

            // invoke the operation
            string authorizationName = "authorizatinName";
            ExpressRoutePortAuthorizationData data = new ExpressRoutePortAuthorizationData();
            ArmOperation<ExpressRoutePortAuthorizationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationName, data);
            ExpressRoutePortAuthorizationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRoutePortAuthorizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetExpressRoutePortAuthorization()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRoutePortAuthorizationGet.json
            // this example is just showing the usage of "ExpressRoutePortAuthorizations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "expressRoutePortName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRoutePortAuthorizationResource
            ExpressRoutePortAuthorizationCollection collection = expressRoutePort.GetExpressRoutePortAuthorizations();

            // invoke the operation
            string authorizationName = "authorizationName";
            ExpressRoutePortAuthorizationResource result = await collection.GetAsync(authorizationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRoutePortAuthorizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListExpressRoutePortAuthorization()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRoutePortAuthorizationList.json
            // this example is just showing the usage of "ExpressRoutePortAuthorizations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "expressRoutePortName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRoutePortAuthorizationResource
            ExpressRoutePortAuthorizationCollection collection = expressRoutePort.GetExpressRoutePortAuthorizations();

            // invoke the operation and iterate over the result
            await foreach (ExpressRoutePortAuthorizationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRoutePortAuthorizationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetExpressRoutePortAuthorization()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRoutePortAuthorizationGet.json
            // this example is just showing the usage of "ExpressRoutePortAuthorizations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "expressRoutePortName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRoutePortAuthorizationResource
            ExpressRoutePortAuthorizationCollection collection = expressRoutePort.GetExpressRoutePortAuthorizations();

            // invoke the operation
            string authorizationName = "authorizationName";
            bool result = await collection.ExistsAsync(authorizationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetExpressRoutePortAuthorization()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRoutePortAuthorizationGet.json
            // this example is just showing the usage of "ExpressRoutePortAuthorizations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "expressRoutePortName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRoutePortAuthorizationResource
            ExpressRoutePortAuthorizationCollection collection = expressRoutePort.GetExpressRoutePortAuthorizations();

            // invoke the operation
            string authorizationName = "authorizationName";
            NullableResponse<ExpressRoutePortAuthorizationResource> response = await collection.GetIfExistsAsync(authorizationName);
            ExpressRoutePortAuthorizationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRoutePortAuthorizationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
