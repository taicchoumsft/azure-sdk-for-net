// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Chaos.Samples
{
    public partial class Sample_ChaosExperimentExecutionCollection
    {
        // List all executions of an Experiment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllExecutionsOfAnExperiment()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/ListExperimentExecutions.json
            // this example is just showing the usage of "Experiments_ListAllExecutions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosExperimentResource created on azure
            // for more information of creating ChaosExperimentResource, please refer to the document of ChaosExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier chaosExperimentResourceId = ChaosExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ChaosExperimentResource chaosExperiment = client.GetChaosExperimentResource(chaosExperimentResourceId);

            // get the collection of this ChaosExperimentExecutionResource
            ChaosExperimentExecutionCollection collection = chaosExperiment.GetChaosExperimentExecutions();

            // invoke the operation and iterate over the result
            await foreach (ChaosExperimentExecutionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ChaosExperimentExecutionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get the execution of a Experiment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheExecutionOfAExperiment()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/GetExperimentExecution.json
            // this example is just showing the usage of "Experiments_GetExecution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosExperimentResource created on azure
            // for more information of creating ChaosExperimentResource, please refer to the document of ChaosExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier chaosExperimentResourceId = ChaosExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ChaosExperimentResource chaosExperiment = client.GetChaosExperimentResource(chaosExperimentResourceId);

            // get the collection of this ChaosExperimentExecutionResource
            ChaosExperimentExecutionCollection collection = chaosExperiment.GetChaosExperimentExecutions();

            // invoke the operation
            string executionId = "f24500ad-744e-4a26-864b-b76199eac333";
            ChaosExperimentExecutionResource result = await collection.GetAsync(executionId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ChaosExperimentExecutionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the execution of a Experiment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTheExecutionOfAExperiment()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/GetExperimentExecution.json
            // this example is just showing the usage of "Experiments_GetExecution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosExperimentResource created on azure
            // for more information of creating ChaosExperimentResource, please refer to the document of ChaosExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier chaosExperimentResourceId = ChaosExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ChaosExperimentResource chaosExperiment = client.GetChaosExperimentResource(chaosExperimentResourceId);

            // get the collection of this ChaosExperimentExecutionResource
            ChaosExperimentExecutionCollection collection = chaosExperiment.GetChaosExperimentExecutions();

            // invoke the operation
            string executionId = "f24500ad-744e-4a26-864b-b76199eac333";
            bool result = await collection.ExistsAsync(executionId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the execution of a Experiment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTheExecutionOfAExperiment()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/GetExperimentExecution.json
            // this example is just showing the usage of "Experiments_GetExecution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosExperimentResource created on azure
            // for more information of creating ChaosExperimentResource, please refer to the document of ChaosExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier chaosExperimentResourceId = ChaosExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ChaosExperimentResource chaosExperiment = client.GetChaosExperimentResource(chaosExperimentResourceId);

            // get the collection of this ChaosExperimentExecutionResource
            ChaosExperimentExecutionCollection collection = chaosExperiment.GetChaosExperimentExecutions();

            // invoke the operation
            string executionId = "f24500ad-744e-4a26-864b-b76199eac333";
            NullableResponse<ChaosExperimentExecutionResource> response = await collection.GetIfExistsAsync(executionId);
            ChaosExperimentExecutionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ChaosExperimentExecutionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
