// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HealthcareApis.Models;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_FhirServiceResource
    {
        // Get a Fhir Service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAFhirService()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/fhirservices/FhirServices_Get.json
            // this example is just showing the usage of "FhirServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FhirServiceResource created on azure
            // for more information of creating FhirServiceResource, please refer to the document of FhirServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string fhirServiceName = "fhirservices1";
            ResourceIdentifier fhirServiceResourceId = FhirServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, fhirServiceName);
            FhirServiceResource fhirService = client.GetFhirServiceResource(fhirServiceResourceId);

            // invoke the operation
            FhirServiceResource result = await fhirService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FhirServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a Fhir Service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAFhirService()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/fhirservices/FhirServices_Patch.json
            // this example is just showing the usage of "FhirServices_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FhirServiceResource created on azure
            // for more information of creating FhirServiceResource, please refer to the document of FhirServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string fhirServiceName = "fhirservice1";
            ResourceIdentifier fhirServiceResourceId = FhirServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, fhirServiceName);
            FhirServiceResource fhirService = client.GetFhirServiceResource(fhirServiceResourceId);

            // invoke the operation
            FhirServicePatch patch = new FhirServicePatch()
            {
                Tags =
{
["tagKey"] = "tagValue",
},
            };
            ArmOperation<FhirServiceResource> lro = await fhirService.UpdateAsync(WaitUntil.Completed, patch);
            FhirServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FhirServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a Fhir Service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAFhirService()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/fhirservices/FhirServices_Delete.json
            // this example is just showing the usage of "FhirServices_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FhirServiceResource created on azure
            // for more information of creating FhirServiceResource, please refer to the document of FhirServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string fhirServiceName = "fhirservice1";
            ResourceIdentifier fhirServiceResourceId = FhirServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, fhirServiceName);
            FhirServiceResource fhirService = client.GetFhirServiceResource(fhirServiceResourceId);

            // invoke the operation
            await fhirService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
