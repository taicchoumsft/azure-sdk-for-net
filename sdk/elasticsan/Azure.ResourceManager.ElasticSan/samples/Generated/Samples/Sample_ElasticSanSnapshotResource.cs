// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ElasticSan.Models;

namespace Azure.ResourceManager.ElasticSan.Samples
{
    public partial class Sample_ElasticSanSnapshotResource
    {
        // VolumeSnapshots_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VolumeSnapshotsCreateMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanSnapshotResource created on azure
            // for more information of creating ElasticSanSnapshotResource, please refer to the document of ElasticSanSnapshotResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            string snapshotName = "snapshotname";
            ResourceIdentifier elasticSanSnapshotResourceId = ElasticSanSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            ElasticSanSnapshotResource elasticSanSnapshot = client.GetElasticSanSnapshotResource(elasticSanSnapshotResourceId);

            // invoke the operation
            ElasticSanSnapshotData data = new ElasticSanSnapshotData(new SnapshotCreationInfo(new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}")));
            ArmOperation<ElasticSanSnapshotResource> lro = await elasticSanSnapshot.UpdateAsync(WaitUntil.Completed, data);
            ElasticSanSnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeSnapshots_Create_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VolumeSnapshotsCreateMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Create_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanSnapshotResource created on azure
            // for more information of creating ElasticSanSnapshotResource, please refer to the document of ElasticSanSnapshotResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            string snapshotName = "snapshotname";
            ResourceIdentifier elasticSanSnapshotResourceId = ElasticSanSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            ElasticSanSnapshotResource elasticSanSnapshot = client.GetElasticSanSnapshotResource(elasticSanSnapshotResourceId);

            // invoke the operation
            ElasticSanSnapshotData data = new ElasticSanSnapshotData(new SnapshotCreationInfo(new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}")));
            ArmOperation<ElasticSanSnapshotResource> lro = await elasticSanSnapshot.UpdateAsync(WaitUntil.Completed, data);
            ElasticSanSnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeSnapshots_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VolumeSnapshotsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanSnapshotResource created on azure
            // for more information of creating ElasticSanSnapshotResource, please refer to the document of ElasticSanSnapshotResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            string snapshotName = "snapshotname";
            ResourceIdentifier elasticSanSnapshotResourceId = ElasticSanSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            ElasticSanSnapshotResource elasticSanSnapshot = client.GetElasticSanSnapshotResource(elasticSanSnapshotResourceId);

            // invoke the operation
            await elasticSanSnapshot.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VolumeSnapshots_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VolumeSnapshotsDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanSnapshotResource created on azure
            // for more information of creating ElasticSanSnapshotResource, please refer to the document of ElasticSanSnapshotResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            string snapshotName = "snapshotname";
            ResourceIdentifier elasticSanSnapshotResourceId = ElasticSanSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            ElasticSanSnapshotResource elasticSanSnapshot = client.GetElasticSanSnapshotResource(elasticSanSnapshotResourceId);

            // invoke the operation
            await elasticSanSnapshot.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VolumeSnapshots_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeSnapshotsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanSnapshotResource created on azure
            // for more information of creating ElasticSanSnapshotResource, please refer to the document of ElasticSanSnapshotResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            string snapshotName = "snapshotname";
            ResourceIdentifier elasticSanSnapshotResourceId = ElasticSanSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            ElasticSanSnapshotResource elasticSanSnapshot = client.GetElasticSanSnapshotResource(elasticSanSnapshotResourceId);

            // invoke the operation
            ElasticSanSnapshotResource result = await elasticSanSnapshot.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeSnapshots_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeSnapshotsGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanSnapshotResource created on azure
            // for more information of creating ElasticSanSnapshotResource, please refer to the document of ElasticSanSnapshotResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            string snapshotName = "snapshotname";
            ResourceIdentifier elasticSanSnapshotResourceId = ElasticSanSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            ElasticSanSnapshotResource elasticSanSnapshot = client.GetElasticSanSnapshotResource(elasticSanSnapshotResourceId);

            // invoke the operation
            ElasticSanSnapshotResource result = await elasticSanSnapshot.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
