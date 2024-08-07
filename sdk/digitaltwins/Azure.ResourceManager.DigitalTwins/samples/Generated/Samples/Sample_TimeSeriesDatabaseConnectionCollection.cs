// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DigitalTwins.Models;

namespace Azure.ResourceManager.DigitalTwins.Samples
{
    public partial class Sample_TimeSeriesDatabaseConnectionCollection
    {
        // List time series database connections for a DigitalTwins instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListTimeSeriesDatabaseConnectionsForADigitalTwinsInstance()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/TimeSeriesDatabaseConnectionsList_example.json
            // this example is just showing the usage of "TimeSeriesDatabaseConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this TimeSeriesDatabaseConnectionResource
            TimeSeriesDatabaseConnectionCollection collection = digitalTwinsDescription.GetTimeSeriesDatabaseConnections();

            // invoke the operation and iterate over the result
            await foreach (TimeSeriesDatabaseConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TimeSeriesDatabaseConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get time series database connection for a DigitalTwins instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTimeSeriesDatabaseConnectionForADigitalTwinsInstance()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/TimeSeriesDatabaseConnectionsGet_example.json
            // this example is just showing the usage of "TimeSeriesDatabaseConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this TimeSeriesDatabaseConnectionResource
            TimeSeriesDatabaseConnectionCollection collection = digitalTwinsDescription.GetTimeSeriesDatabaseConnections();

            // invoke the operation
            string timeSeriesDatabaseConnectionName = "myConnection";
            TimeSeriesDatabaseConnectionResource result = await collection.GetAsync(timeSeriesDatabaseConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TimeSeriesDatabaseConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get time series database connection for a DigitalTwins instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTimeSeriesDatabaseConnectionForADigitalTwinsInstance()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/TimeSeriesDatabaseConnectionsGet_example.json
            // this example is just showing the usage of "TimeSeriesDatabaseConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this TimeSeriesDatabaseConnectionResource
            TimeSeriesDatabaseConnectionCollection collection = digitalTwinsDescription.GetTimeSeriesDatabaseConnections();

            // invoke the operation
            string timeSeriesDatabaseConnectionName = "myConnection";
            bool result = await collection.ExistsAsync(timeSeriesDatabaseConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get time series database connection for a DigitalTwins instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTimeSeriesDatabaseConnectionForADigitalTwinsInstance()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/TimeSeriesDatabaseConnectionsGet_example.json
            // this example is just showing the usage of "TimeSeriesDatabaseConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this TimeSeriesDatabaseConnectionResource
            TimeSeriesDatabaseConnectionCollection collection = digitalTwinsDescription.GetTimeSeriesDatabaseConnections();

            // invoke the operation
            string timeSeriesDatabaseConnectionName = "myConnection";
            NullableResponse<TimeSeriesDatabaseConnectionResource> response = await collection.GetIfExistsAsync(timeSeriesDatabaseConnectionName);
            TimeSeriesDatabaseConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TimeSeriesDatabaseConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or replace a time series database connection for a DigitalTwins instance with user assigned identity.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrReplaceATimeSeriesDatabaseConnectionForADigitalTwinsInstanceWithUserAssignedIdentity()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/TimeSeriesDatabaseConnectionsPut_WithUserIdentity_example.json
            // this example is just showing the usage of "TimeSeriesDatabaseConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this TimeSeriesDatabaseConnectionResource
            TimeSeriesDatabaseConnectionCollection collection = digitalTwinsDescription.GetTimeSeriesDatabaseConnections();

            // invoke the operation
            string timeSeriesDatabaseConnectionName = "myConnection";
            TimeSeriesDatabaseConnectionData data = new TimeSeriesDatabaseConnectionData()
            {
                Properties = new DataExplorerConnectionProperties(new ResourceIdentifier("/subscriptions/c493073e-2460-45ba-a403-f3e0df1e9feg/resourceGroups/testrg/providers/Microsoft.Kusto/clusters/mycluster"), new Uri("https://mycluster.kusto.windows.net"), "myDatabase", new Uri("sb://myeh.servicebus.windows.net/"), "myeh", new ResourceIdentifier("/subscriptions/c493073e-2460-45ba-a403-f3e0df1e9feg/resourceGroups/testrg/providers/Microsoft.EventHub/namespaces/myeh"))
                {
                    AdxTableName = "myTable",
                    Identity = new DigitalTwinsManagedIdentityReference()
                    {
                        IdentityType = DigitalTwinsManagedIdentityType.UserAssigned,
                        UserAssignedIdentity = "/subscriptions/50016170-c839-41ba-a724-51e9df440b9e/resourceGroups/testrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/testidentity",
                    },
                },
            };
            ArmOperation<TimeSeriesDatabaseConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, timeSeriesDatabaseConnectionName, data);
            TimeSeriesDatabaseConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TimeSeriesDatabaseConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or replace a time series database connection for a DigitalTwins instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrReplaceATimeSeriesDatabaseConnectionForADigitalTwinsInstance()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/TimeSeriesDatabaseConnectionsPut_example.json
            // this example is just showing the usage of "TimeSeriesDatabaseConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this TimeSeriesDatabaseConnectionResource
            TimeSeriesDatabaseConnectionCollection collection = digitalTwinsDescription.GetTimeSeriesDatabaseConnections();

            // invoke the operation
            string timeSeriesDatabaseConnectionName = "myConnection";
            TimeSeriesDatabaseConnectionData data = new TimeSeriesDatabaseConnectionData()
            {
                Properties = new DataExplorerConnectionProperties(new ResourceIdentifier("/subscriptions/c493073e-2460-45ba-a403-f3e0df1e9feg/resourceGroups/testrg/providers/Microsoft.Kusto/clusters/mycluster"), new Uri("https://mycluster.kusto.windows.net"), "myDatabase", new Uri("sb://myeh.servicebus.windows.net/"), "myeh", new ResourceIdentifier("/subscriptions/c493073e-2460-45ba-a403-f3e0df1e9feg/resourceGroups/testrg/providers/Microsoft.EventHub/namespaces/myeh"))
                {
                    AdxTableName = "myPropertyUpdatesTable",
                    AdxTwinLifecycleEventsTableName = "myTwinLifecycleEventsTable",
                    AdxRelationshipLifecycleEventsTableName = "myRelationshipLifecycleEventsTable",
                    RecordPropertyAndItemRemovals = RecordPropertyAndItemRemoval.True,
                },
            };
            ArmOperation<TimeSeriesDatabaseConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, timeSeriesDatabaseConnectionName, data);
            TimeSeriesDatabaseConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TimeSeriesDatabaseConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
