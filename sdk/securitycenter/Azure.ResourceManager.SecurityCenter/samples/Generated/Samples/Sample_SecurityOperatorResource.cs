// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SecurityOperatorResource
    {
        // Get a specific security operator by scope and securityOperatorName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASpecificSecurityOperatorByScopeAndSecurityOperatorName()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-01-01-preview/examples/SecurityOperators/GetSecurityOperatorByName_example.json
            // this example is just showing the usage of "SecurityOperators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityOperatorResource created on azure
            // for more information of creating SecurityOperatorResource, please refer to the document of SecurityOperatorResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "CloudPosture";
            string securityOperatorName = "DefenderCSPMSecurityOperator";
            ResourceIdentifier securityOperatorResourceId = SecurityOperatorResource.CreateResourceIdentifier(subscriptionId, pricingName, securityOperatorName);
            SecurityOperatorResource securityOperator = client.GetSecurityOperatorResource(securityOperatorResourceId);

            // invoke the operation
            SecurityOperatorResource result = await securityOperator.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityOperatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a security operator on the given scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateASecurityOperatorOnTheGivenScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-01-01-preview/examples/SecurityOperators/PutSecurityOperatorByName_example.json
            // this example is just showing the usage of "SecurityOperators_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityOperatorResource created on azure
            // for more information of creating SecurityOperatorResource, please refer to the document of SecurityOperatorResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "CloudPosture";
            string securityOperatorName = "DefenderCSPMSecurityOperator";
            ResourceIdentifier securityOperatorResourceId = SecurityOperatorResource.CreateResourceIdentifier(subscriptionId, pricingName, securityOperatorName);
            SecurityOperatorResource securityOperator = client.GetSecurityOperatorResource(securityOperatorResourceId);

            // invoke the operation
            ArmOperation<SecurityOperatorResource> lro = await securityOperator.UpdateAsync(WaitUntil.Completed);
            SecurityOperatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityOperatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete SecurityOperator on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteSecurityOperatorOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-01-01-preview/examples/SecurityOperators/DeleteSecurityOperatorByName_example.json
            // this example is just showing the usage of "SecurityOperators_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityOperatorResource created on azure
            // for more information of creating SecurityOperatorResource, please refer to the document of SecurityOperatorResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string pricingName = "CloudPosture";
            string securityOperatorName = "DefenderCSPMSecurityOperator";
            ResourceIdentifier securityOperatorResourceId = SecurityOperatorResource.CreateResourceIdentifier(subscriptionId, pricingName, securityOperatorName);
            SecurityOperatorResource securityOperator = client.GetSecurityOperatorResource(securityOperatorResourceId);

            // invoke the operation
            await securityOperator.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
