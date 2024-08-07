// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics.Samples
{
    public partial class Sample_StreamingJobFunctionCollection
    {
        // Create a CLRUdf function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateACLRUdfFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Create_CSharp.json
            // this example is just showing the usage of "Functions_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg";
            string jobName = "sjName";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function588";
            StreamingJobFunctionData data = new StreamingJobFunctionData()
            {
                Properties = new ScalarFunctionProperties()
                {
                    Inputs =
{
new StreamingJobFunctionInput()
{
DataType = "nvarchar(max)",
}
},
                    OutputDataType = "nvarchar(max)",
                    Binding = new CSharpFunctionBinding()
                    {
                        DllPath = "ASAEdgeApplication2_CodeBehind",
                        Class = "ASAEdgeUDFDemo.Class1",
                        Method = "SquareFunction",
                        UpdateMode = StreamingJobFunctionUpdateMode.Static,
                    },
                },
            };
            ArmOperation<StreamingJobFunctionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, functionName, data);
            StreamingJobFunctionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a JavaScript function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAJavaScriptFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Create_JavaScript.json
            // this example is just showing the usage of "Functions_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function8197";
            StreamingJobFunctionData data = new StreamingJobFunctionData()
            {
                Properties = new ScalarFunctionProperties()
                {
                    Inputs =
{
new StreamingJobFunctionInput()
{
DataType = "Any",
}
},
                    OutputDataType = "Any",
                    Binding = new JavaScriptFunctionBinding()
                    {
                        Script = "function (x, y) { return x + y; }",
                    },
                },
            };
            ArmOperation<StreamingJobFunctionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, functionName, data);
            StreamingJobFunctionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create an Azure ML Service function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAnAzureMLServiceFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Create_AzureMLService.json
            // this example is just showing the usage of "Functions_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg";
            string jobName = "sjName";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function588";
            StreamingJobFunctionData data = new StreamingJobFunctionData()
            {
                Properties = new ScalarFunctionProperties()
                {
                    Inputs =
{
new StreamingJobFunctionInput()
{
DataType = "nvarchar(max)",
}
},
                    OutputDataType = "nvarchar(max)",
                    Binding = new MachineLearningServiceFunctionBinding()
                    {
                        Endpoint = "someAzureMLEndpointURL",
                        ApiKey = "someApiKey==",
                        Inputs =
{
new MachineLearningServiceInputColumn()
{
Name = "data",
DataType = "array",
MapTo = 0,
}
},
                        Outputs =
{
new MachineLearningServiceOutputColumn()
{
Name = "Sentiment",
DataType = "string",
}
},
                        BatchSize = 1000,
                        NumberOfParallelRequests = 1,
                        InputRequestName = "Inputs",
                        OutputResponseName = "Results",
                    },
                },
            };
            ArmOperation<StreamingJobFunctionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, functionName, data);
            StreamingJobFunctionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create an Azure ML function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAnAzureMLFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Create_AzureML.json
            // this example is just showing the usage of "Functions_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg7";
            string jobName = "sj9093";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function588";
            StreamingJobFunctionData data = new StreamingJobFunctionData()
            {
                Properties = new ScalarFunctionProperties()
                {
                    Inputs =
{
new StreamingJobFunctionInput()
{
DataType = "nvarchar(max)",
}
},
                    OutputDataType = "nvarchar(max)",
                    Binding = new EMachineLearningStudioFunctionBinding()
                    {
                        Endpoint = "someAzureMLEndpointURL",
                        ApiKey = "someApiKey==",
                        Inputs = new MachineLearningStudioInputs()
                        {
                            Name = "input1",
                            ColumnNames =
{
new MachineLearningStudioInputColumn()
{
Name = "tweet",
DataType = "string",
MapTo = 0,
}
},
                        },
                        Outputs =
{
new MachineLearningStudioOutputColumn()
{
Name = "Sentiment",
DataType = "string",
}
},
                        BatchSize = 1000,
                    },
                },
            };
            ArmOperation<StreamingJobFunctionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, functionName, data);
            StreamingJobFunctionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a JavaScript function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAJavaScriptFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Get_JavaScript.json
            // this example is just showing the usage of "Functions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function8197";
            StreamingJobFunctionResource result = await collection.GetAsync(functionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a JavaScript function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAJavaScriptFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Get_JavaScript.json
            // this example is just showing the usage of "Functions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function8197";
            bool result = await collection.ExistsAsync(functionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a JavaScript function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAJavaScriptFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Get_JavaScript.json
            // this example is just showing the usage of "Functions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function8197";
            NullableResponse<StreamingJobFunctionResource> response = await collection.GetIfExistsAsync(functionName);
            StreamingJobFunctionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingJobFunctionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get an Azure ML function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnAzureMLFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Get_AzureML.json
            // this example is just showing the usage of "Functions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg7";
            string jobName = "sj9093";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function588";
            StreamingJobFunctionResource result = await collection.GetAsync(functionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an Azure ML function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnAzureMLFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Get_AzureML.json
            // this example is just showing the usage of "Functions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg7";
            string jobName = "sj9093";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function588";
            bool result = await collection.ExistsAsync(functionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an Azure ML function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAnAzureMLFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Get_AzureML.json
            // this example is just showing the usage of "Functions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg7";
            string jobName = "sj9093";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation
            string functionName = "function588";
            NullableResponse<StreamingJobFunctionResource> response = await collection.GetIfExistsAsync(functionName);
            StreamingJobFunctionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingJobFunctionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List all functions in a streaming job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllFunctionsInAStreamingJob()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_ListByStreamingJob.json
            // this example is just showing the usage of "Functions_ListByStreamingJob" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // get the collection of this StreamingJobFunctionResource
            StreamingJobFunctionCollection collection = streamingJob.GetStreamingJobFunctions();

            // invoke the operation and iterate over the result
            await foreach (StreamingJobFunctionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingJobFunctionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
