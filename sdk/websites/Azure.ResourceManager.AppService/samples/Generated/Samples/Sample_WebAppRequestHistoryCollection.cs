// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WebAppRequestHistoryCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListRepetitionRequestHistory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/WorkflowRunActionRepetitionsRequestHistories_List.json
            // this example is just showing the usage of "WorkflowRunActionRepetitionsRequestHistories_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunActionRepetitionResource created on azure
            // for more information of creating WorkflowRunActionRepetitionResource, please refer to the document of WorkflowRunActionRepetitionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string runName = "08586776228332053161046300351";
            string actionName = "HTTP_Webhook";
            string repetitionName = "000001";
            ResourceIdentifier workflowRunActionRepetitionResourceId = WorkflowRunActionRepetitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            WorkflowRunActionRepetitionResource workflowRunActionRepetition = client.GetWorkflowRunActionRepetitionResource(workflowRunActionRepetitionResourceId);

            // get the collection of this WebAppRequestHistoryResource
            WebAppRequestHistoryCollection collection = workflowRunActionRepetition.GetWebAppRequestHistories();

            // invoke the operation and iterate over the result
            await foreach (WebAppRequestHistoryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WebAppRequestHistoryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetARepetitionRequestHistory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/WorkflowRunActionRepetitionsRequestHistories_Get.json
            // this example is just showing the usage of "WorkflowRunActionRepetitionsRequestHistories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunActionRepetitionResource created on azure
            // for more information of creating WorkflowRunActionRepetitionResource, please refer to the document of WorkflowRunActionRepetitionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string runName = "08586776228332053161046300351";
            string actionName = "HTTP_Webhook";
            string repetitionName = "000001";
            ResourceIdentifier workflowRunActionRepetitionResourceId = WorkflowRunActionRepetitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            WorkflowRunActionRepetitionResource workflowRunActionRepetition = client.GetWorkflowRunActionRepetitionResource(workflowRunActionRepetitionResourceId);

            // get the collection of this WebAppRequestHistoryResource
            WebAppRequestHistoryCollection collection = workflowRunActionRepetition.GetWebAppRequestHistories();

            // invoke the operation
            string requestHistoryName = "08586611142732800686";
            WebAppRequestHistoryResource result = await collection.GetAsync(requestHistoryName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebAppRequestHistoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetARepetitionRequestHistory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/WorkflowRunActionRepetitionsRequestHistories_Get.json
            // this example is just showing the usage of "WorkflowRunActionRepetitionsRequestHistories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunActionRepetitionResource created on azure
            // for more information of creating WorkflowRunActionRepetitionResource, please refer to the document of WorkflowRunActionRepetitionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string runName = "08586776228332053161046300351";
            string actionName = "HTTP_Webhook";
            string repetitionName = "000001";
            ResourceIdentifier workflowRunActionRepetitionResourceId = WorkflowRunActionRepetitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            WorkflowRunActionRepetitionResource workflowRunActionRepetition = client.GetWorkflowRunActionRepetitionResource(workflowRunActionRepetitionResourceId);

            // get the collection of this WebAppRequestHistoryResource
            WebAppRequestHistoryCollection collection = workflowRunActionRepetition.GetWebAppRequestHistories();

            // invoke the operation
            string requestHistoryName = "08586611142732800686";
            bool result = await collection.ExistsAsync(requestHistoryName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetARepetitionRequestHistory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/WorkflowRunActionRepetitionsRequestHistories_Get.json
            // this example is just showing the usage of "WorkflowRunActionRepetitionsRequestHistories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunActionRepetitionResource created on azure
            // for more information of creating WorkflowRunActionRepetitionResource, please refer to the document of WorkflowRunActionRepetitionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string runName = "08586776228332053161046300351";
            string actionName = "HTTP_Webhook";
            string repetitionName = "000001";
            ResourceIdentifier workflowRunActionRepetitionResourceId = WorkflowRunActionRepetitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            WorkflowRunActionRepetitionResource workflowRunActionRepetition = client.GetWorkflowRunActionRepetitionResource(workflowRunActionRepetitionResourceId);

            // get the collection of this WebAppRequestHistoryResource
            WebAppRequestHistoryCollection collection = workflowRunActionRepetition.GetWebAppRequestHistories();

            // invoke the operation
            string requestHistoryName = "08586611142732800686";
            NullableResponse<WebAppRequestHistoryResource> response = await collection.GetIfExistsAsync(requestHistoryName);
            WebAppRequestHistoryResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WebAppRequestHistoryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
