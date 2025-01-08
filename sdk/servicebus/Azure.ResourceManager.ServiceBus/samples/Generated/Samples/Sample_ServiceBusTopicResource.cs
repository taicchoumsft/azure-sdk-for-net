// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusTopicResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TopicGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Topics/SBTopicGet.json
            // this example is just showing the usage of "Topics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusTopicResource created on azure
            // for more information of creating ServiceBusTopicResource, please refer to the document of ServiceBusTopicResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-1617";
            string topicName = "sdk-Topics-5488";
            ResourceIdentifier serviceBusTopicResourceId = ServiceBusTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            ServiceBusTopicResource serviceBusTopic = client.GetServiceBusTopicResource(serviceBusTopicResourceId);

            // invoke the operation
            ServiceBusTopicResource result = await serviceBusTopic.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_TopicDelete()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Topics/SBTopicDelete.json
            // this example is just showing the usage of "Topics_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusTopicResource created on azure
            // for more information of creating ServiceBusTopicResource, please refer to the document of ServiceBusTopicResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-1617";
            string topicName = "sdk-Topics-5488";
            ResourceIdentifier serviceBusTopicResourceId = ServiceBusTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            ServiceBusTopicResource serviceBusTopic = client.GetServiceBusTopicResource(serviceBusTopicResourceId);

            // invoke the operation
            await serviceBusTopic.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_TopicCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Topics/SBTopicCreate.json
            // this example is just showing the usage of "Topics_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusTopicResource created on azure
            // for more information of creating ServiceBusTopicResource, please refer to the document of ServiceBusTopicResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-1617";
            string topicName = "sdk-Topics-5488";
            ResourceIdentifier serviceBusTopicResourceId = ServiceBusTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            ServiceBusTopicResource serviceBusTopic = client.GetServiceBusTopicResource(serviceBusTopicResourceId);

            // invoke the operation
            ServiceBusTopicData data = new ServiceBusTopicData
            {
                EnableExpress = true,
            };
            ArmOperation<ServiceBusTopicResource> lro = await serviceBusTopic.UpdateAsync(WaitUntil.Completed, data);
            ServiceBusTopicResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
