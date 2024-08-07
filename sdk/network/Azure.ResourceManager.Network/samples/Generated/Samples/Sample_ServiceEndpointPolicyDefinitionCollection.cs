// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ServiceEndpointPolicyDefinitionCollection
    {
        // Get service endpoint definition in service endpoint policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetServiceEndpointDefinitionInServiceEndpointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/ServiceEndpointPolicyDefinitionGet.json
            // this example is just showing the usage of "ServiceEndpointPolicyDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyResource created on azure
            // for more information of creating ServiceEndpointPolicyResource, please refer to the document of ServiceEndpointPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testPolicy";
            ResourceIdentifier serviceEndpointPolicyResourceId = ServiceEndpointPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName);
            ServiceEndpointPolicyResource serviceEndpointPolicy = client.GetServiceEndpointPolicyResource(serviceEndpointPolicyResourceId);

            // get the collection of this ServiceEndpointPolicyDefinitionResource
            ServiceEndpointPolicyDefinitionCollection collection = serviceEndpointPolicy.GetServiceEndpointPolicyDefinitions();

            // invoke the operation
            string serviceEndpointPolicyDefinitionName = "testDefinition";
            ServiceEndpointPolicyDefinitionResource result = await collection.GetAsync(serviceEndpointPolicyDefinitionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get service endpoint definition in service endpoint policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetServiceEndpointDefinitionInServiceEndpointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/ServiceEndpointPolicyDefinitionGet.json
            // this example is just showing the usage of "ServiceEndpointPolicyDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyResource created on azure
            // for more information of creating ServiceEndpointPolicyResource, please refer to the document of ServiceEndpointPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testPolicy";
            ResourceIdentifier serviceEndpointPolicyResourceId = ServiceEndpointPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName);
            ServiceEndpointPolicyResource serviceEndpointPolicy = client.GetServiceEndpointPolicyResource(serviceEndpointPolicyResourceId);

            // get the collection of this ServiceEndpointPolicyDefinitionResource
            ServiceEndpointPolicyDefinitionCollection collection = serviceEndpointPolicy.GetServiceEndpointPolicyDefinitions();

            // invoke the operation
            string serviceEndpointPolicyDefinitionName = "testDefinition";
            bool result = await collection.ExistsAsync(serviceEndpointPolicyDefinitionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get service endpoint definition in service endpoint policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetServiceEndpointDefinitionInServiceEndpointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/ServiceEndpointPolicyDefinitionGet.json
            // this example is just showing the usage of "ServiceEndpointPolicyDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyResource created on azure
            // for more information of creating ServiceEndpointPolicyResource, please refer to the document of ServiceEndpointPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testPolicy";
            ResourceIdentifier serviceEndpointPolicyResourceId = ServiceEndpointPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName);
            ServiceEndpointPolicyResource serviceEndpointPolicy = client.GetServiceEndpointPolicyResource(serviceEndpointPolicyResourceId);

            // get the collection of this ServiceEndpointPolicyDefinitionResource
            ServiceEndpointPolicyDefinitionCollection collection = serviceEndpointPolicy.GetServiceEndpointPolicyDefinitions();

            // invoke the operation
            string serviceEndpointPolicyDefinitionName = "testDefinition";
            NullableResponse<ServiceEndpointPolicyDefinitionResource> response = await collection.GetIfExistsAsync(serviceEndpointPolicyDefinitionName);
            ServiceEndpointPolicyDefinitionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceEndpointPolicyDefinitionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create service endpoint policy definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateServiceEndpointPolicyDefinition()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/ServiceEndpointPolicyDefinitionCreate.json
            // this example is just showing the usage of "ServiceEndpointPolicyDefinitions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyResource created on azure
            // for more information of creating ServiceEndpointPolicyResource, please refer to the document of ServiceEndpointPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testPolicy";
            ResourceIdentifier serviceEndpointPolicyResourceId = ServiceEndpointPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName);
            ServiceEndpointPolicyResource serviceEndpointPolicy = client.GetServiceEndpointPolicyResource(serviceEndpointPolicyResourceId);

            // get the collection of this ServiceEndpointPolicyDefinitionResource
            ServiceEndpointPolicyDefinitionCollection collection = serviceEndpointPolicy.GetServiceEndpointPolicyDefinitions();

            // invoke the operation
            string serviceEndpointPolicyDefinitionName = "testDefinition";
            ServiceEndpointPolicyDefinitionData data = new ServiceEndpointPolicyDefinitionData()
            {
                Description = "Storage Service EndpointPolicy Definition",
                Service = "Microsoft.Storage",
                ServiceResources =
{
new ResourceIdentifier("/subscriptions/subid1"),new ResourceIdentifier("/subscriptions/subid1/resourceGroups/storageRg"),new ResourceIdentifier("/subscriptions/subid1/resourceGroups/storageRg/providers/Microsoft.Storage/storageAccounts/stAccount")
},
            };
            ArmOperation<ServiceEndpointPolicyDefinitionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serviceEndpointPolicyDefinitionName, data);
            ServiceEndpointPolicyDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List service endpoint definitions in service end point policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListServiceEndpointDefinitionsInServiceEndPointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/ServiceEndpointPolicyDefinitionList.json
            // this example is just showing the usage of "ServiceEndpointPolicyDefinitions_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyResource created on azure
            // for more information of creating ServiceEndpointPolicyResource, please refer to the document of ServiceEndpointPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testPolicy";
            ResourceIdentifier serviceEndpointPolicyResourceId = ServiceEndpointPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName);
            ServiceEndpointPolicyResource serviceEndpointPolicy = client.GetServiceEndpointPolicyResource(serviceEndpointPolicyResourceId);

            // get the collection of this ServiceEndpointPolicyDefinitionResource
            ServiceEndpointPolicyDefinitionCollection collection = serviceEndpointPolicy.GetServiceEndpointPolicyDefinitions();

            // invoke the operation and iterate over the result
            await foreach (ServiceEndpointPolicyDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceEndpointPolicyDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
