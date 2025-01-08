// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Redis.Samples
{
    public partial class Sample_RedisCacheAccessPolicyAssignmentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_RedisCacheAccessPolicyAssignmentCreateUpdate()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyAssignmentCreateUpdate.json
            // this example is just showing the usage of "AccessPolicyAssignment_CreateUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyAssignmentResource
            RedisCacheAccessPolicyAssignmentCollection collection = redis.GetRedisCacheAccessPolicyAssignments();

            // invoke the operation
            string accessPolicyAssignmentName = "accessPolicyAssignmentName1";
            RedisCacheAccessPolicyAssignmentData data = new RedisCacheAccessPolicyAssignmentData
            {
                ObjectId = Guid.Parse("6497c918-11ad-41e7-1b0f-7c518a87d0b0"),
                ObjectIdAlias = "TestAADAppRedis",
                AccessPolicyName = "accessPolicy1",
            };
            ArmOperation<RedisCacheAccessPolicyAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accessPolicyAssignmentName, data);
            RedisCacheAccessPolicyAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisCacheAccessPolicyAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RedisCacheAccessPolicyAssignmentGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyAssignmentGet.json
            // this example is just showing the usage of "AccessPolicyAssignment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyAssignmentResource
            RedisCacheAccessPolicyAssignmentCollection collection = redis.GetRedisCacheAccessPolicyAssignments();

            // invoke the operation
            string accessPolicyAssignmentName = "accessPolicyAssignmentName1";
            RedisCacheAccessPolicyAssignmentResource result = await collection.GetAsync(accessPolicyAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisCacheAccessPolicyAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_RedisCacheAccessPolicyAssignmentList()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyAssignmentList.json
            // this example is just showing the usage of "AccessPolicyAssignment_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyAssignmentResource
            RedisCacheAccessPolicyAssignmentCollection collection = redis.GetRedisCacheAccessPolicyAssignments();

            // invoke the operation and iterate over the result
            await foreach (RedisCacheAccessPolicyAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisCacheAccessPolicyAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RedisCacheAccessPolicyAssignmentGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyAssignmentGet.json
            // this example is just showing the usage of "AccessPolicyAssignment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyAssignmentResource
            RedisCacheAccessPolicyAssignmentCollection collection = redis.GetRedisCacheAccessPolicyAssignments();

            // invoke the operation
            string accessPolicyAssignmentName = "accessPolicyAssignmentName1";
            bool result = await collection.ExistsAsync(accessPolicyAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RedisCacheAccessPolicyAssignmentGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyAssignmentGet.json
            // this example is just showing the usage of "AccessPolicyAssignment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyAssignmentResource
            RedisCacheAccessPolicyAssignmentCollection collection = redis.GetRedisCacheAccessPolicyAssignments();

            // invoke the operation
            string accessPolicyAssignmentName = "accessPolicyAssignmentName1";
            NullableResponse<RedisCacheAccessPolicyAssignmentResource> response = await collection.GetIfExistsAsync(accessPolicyAssignmentName);
            RedisCacheAccessPolicyAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisCacheAccessPolicyAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
