// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ConfidentialLedger.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConfidentialLedger.Samples
{
    public partial class Sample_ManagedCcfResource
    {
        // ManagedCCFGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ManagedCCFGet()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2023-06-28-preview/examples/ManagedCCF_Get.json
            // this example is just showing the usage of "ManagedCCF_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedCcfResource created on azure
            // for more information of creating ManagedCcfResource, please refer to the document of ManagedCcfResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string appName = "DummyMccfAppName";
            ResourceIdentifier managedCcfResourceId = ManagedCcfResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, appName);
            ManagedCcfResource managedCcf = client.GetManagedCcfResource(managedCcfResourceId);

            // invoke the operation
            ManagedCcfResource result = await managedCcf.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedCcfData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConfidentialLedgerDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ConfidentialLedgerDelete()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2023-06-28-preview/examples/ManagedCCF_Delete.json
            // this example is just showing the usage of "ManagedCCF_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedCcfResource created on azure
            // for more information of creating ManagedCcfResource, please refer to the document of ManagedCcfResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string appName = "DummyMccfAppName";
            ResourceIdentifier managedCcfResourceId = ManagedCcfResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, appName);
            ManagedCcfResource managedCcf = client.GetManagedCcfResource(managedCcfResourceId);

            // invoke the operation
            await managedCcf.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ManagedCCFUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ManagedCCFUpdate()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2023-06-28-preview/examples/ManagedCCF_Update.json
            // this example is just showing the usage of "ManagedCCF_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedCcfResource created on azure
            // for more information of creating ManagedCcfResource, please refer to the document of ManagedCcfResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string appName = "DummyMccfAppName";
            ResourceIdentifier managedCcfResourceId = ManagedCcfResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, appName);
            ManagedCcfResource managedCcf = client.GetManagedCcfResource(managedCcfResourceId);

            // invoke the operation
            ManagedCcfData data = new ManagedCcfData(new AzureLocation("EastUS"))
            {
                Properties = new ManagedCcfProperties()
                {
                    DeploymentType = new ConfidentialLedgerDeploymentType()
                    {
                        LanguageRuntime = ConfidentialLedgerLanguageRuntime.CPP,
                        AppSourceUri = new Uri("https://myaccount.blob.core.windows.net/storage/mccfsource?sv=2022-02-11%st=2022-03-11"),
                    },
                },
                Tags =
{
["additionalProps1"] = "additional properties",
},
            };
            ArmOperation<ManagedCcfResource> lro = await managedCcf.UpdateAsync(WaitUntil.Completed, data);
            ManagedCcfResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedCcfData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedCCFListBySub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetManagedCcfs_ManagedCCFListBySub()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2023-06-28-preview/examples/ManagedCCF_ListBySub.json
            // this example is just showing the usage of "ManagedCCF_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ManagedCcfResource item in subscriptionResource.GetManagedCcfsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedCcfData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ManagedCCFBackup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Backup_ManagedCCFBackup()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2023-06-28-preview/examples/ManagedCCF_Backup.json
            // this example is just showing the usage of "ManagedCCF_Backup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedCcfResource created on azure
            // for more information of creating ManagedCcfResource, please refer to the document of ManagedCcfResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string appName = "DummyMccfAppName";
            ResourceIdentifier managedCcfResourceId = ManagedCcfResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, appName);
            ManagedCcfResource managedCcf = client.GetManagedCcfResource(managedCcfResourceId);

            // invoke the operation
            ManagedCcfBackupContent content = new ManagedCcfBackupContent(new Uri("DummySASUri"))
            {
                RestoreRegion = "EastUS",
            };
            ArmOperation<ManagedCcfBackupResult> lro = await managedCcf.BackupAsync(WaitUntil.Completed, content);
            ManagedCcfBackupResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // ManagedCCFRestore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restore_ManagedCCFRestore()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2023-06-28-preview/examples/ManagedCCF_Restore.json
            // this example is just showing the usage of "ManagedCCF_Restore" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedCcfResource created on azure
            // for more information of creating ManagedCcfResource, please refer to the document of ManagedCcfResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string appName = "DummyMccfAppName";
            ResourceIdentifier managedCcfResourceId = ManagedCcfResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, appName);
            ManagedCcfResource managedCcf = client.GetManagedCcfResource(managedCcfResourceId);

            // invoke the operation
            ManagedCcfRestoreContent content = new ManagedCcfRestoreContent("DummyFileShareName", "EastUS", new Uri("DummySASUri"));
            ArmOperation<ManagedCcfRestoreResult> lro = await managedCcf.RestoreAsync(WaitUntil.Completed, content);
            ManagedCcfRestoreResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
