// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Samples
{
    public partial class Sample_LocalRulestackRuleResource
    {
        // LocalRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LocalRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            LocalRulestackRuleResource result = await localRulestackRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LocalRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            LocalRulestackRuleResource result = await localRulestackRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_LocalRulesCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            LocalRulestackRuleData data = new LocalRulestackRuleData("localRule1")
            {
                ETag = new ETag("c18e6eef-ba3e-49ee-8a85-2b36c863a9d0"),
                Description = "description of local rule",
                RuleState = RulestackStateType.Disabled,
                Source = new SourceAddressInfo()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                },
                NegateSource = FirewallBooleanType.True,
                Destination = new DestinationAddressInfo()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                    FqdnLists =
{
"FQDN1"
},
                },
                NegateDestination = FirewallBooleanType.True,
                Applications =
{
"app1"
},
                Category = new EdlMatchCategory(new string[]
            {
"https://microsoft.com"
            }, new string[]
            {
"feed"
            }),
                Protocol = "HTTP",
                ProtocolPortList =
{
"80"
},
                InboundInspectionCertificate = "cert1",
                AuditComment = "example comment",
                ActionType = RulestackActionType.Allow,
                EnableLogging = RulestackStateType.Disabled,
                DecryptionRuleType = DecryptionRuleType.SslOutboundInspection,
                Tags =
{
new RulestackTagInfo("keyName","value")
},
            };
            ArmOperation<LocalRulestackRuleResource> lro = await localRulestackRule.UpdateAsync(WaitUntil.Completed, data);
            LocalRulestackRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_LocalRulesCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            LocalRulestackRuleData data = new LocalRulestackRuleData("localRule1");
            ArmOperation<LocalRulestackRuleResource> lro = await localRulestackRule.UpdateAsync(WaitUntil.Completed, data);
            LocalRulestackRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_LocalRulesDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            await localRulestackRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_LocalRulesDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            await localRulestackRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_getCounters_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCounters_LocalRulesGetCountersMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_getCounters_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_GetCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            string firewallName = "firewall1";
            FirewallRuleCounter result = await localRulestackRule.GetCountersAsync(firewallName: firewallName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocalRules_getCounters_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCounters_LocalRulesGetCountersMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_getCounters_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_GetCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            FirewallRuleCounter result = await localRulestackRule.GetCountersAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocalRules_refreshCounters_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RefreshCounters_LocalRulesRefreshCountersMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_refreshCounters_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_RefreshCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            string firewallName = "firewall1";
            await localRulestackRule.RefreshCountersAsync(firewallName: firewallName);

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_refreshCounters_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RefreshCounters_LocalRulesRefreshCountersMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_refreshCounters_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_RefreshCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            await localRulestackRule.RefreshCountersAsync();

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_resetCounters_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ResetCounters_LocalRulesResetCountersMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_resetCounters_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_ResetCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            string firewallName = "firewall1";
            FirewallRuleResetConter result = await localRulestackRule.ResetCountersAsync(firewallName: firewallName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocalRules_resetCounters_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ResetCounters_LocalRulesResetCountersMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_resetCounters_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_ResetCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackRuleResource created on azure
            // for more information of creating LocalRulestackRuleResource, please refer to the document of LocalRulestackRuleResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulestackRuleResourceId = LocalRulestackRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulestackRuleResource localRulestackRule = client.GetLocalRulestackRuleResource(localRulestackRuleResourceId);

            // invoke the operation
            FirewallRuleResetConter result = await localRulestackRule.ResetCountersAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
