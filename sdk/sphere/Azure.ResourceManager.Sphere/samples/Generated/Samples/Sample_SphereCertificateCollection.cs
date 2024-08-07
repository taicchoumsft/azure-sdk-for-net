// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Sphere.Samples
{
    public partial class Sample_SphereCertificateCollection
    {
        // Certificates_ListByCatalog
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CertificatesListByCatalog()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetCertificates.json
            // this example is just showing the usage of "Certificates_ListByCatalog" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereCatalogResource created on azure
            // for more information of creating SphereCatalogResource, please refer to the document of SphereCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            ResourceIdentifier sphereCatalogResourceId = SphereCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName);
            SphereCatalogResource sphereCatalog = client.GetSphereCatalogResource(sphereCatalogResourceId);

            // get the collection of this SphereCertificateResource
            SphereCertificateCollection collection = sphereCatalog.GetSphereCertificates();

            // invoke the operation and iterate over the result
            await foreach (SphereCertificateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SphereCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Certificates_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CertificatesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetCertificate.json
            // this example is just showing the usage of "Certificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereCatalogResource created on azure
            // for more information of creating SphereCatalogResource, please refer to the document of SphereCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            ResourceIdentifier sphereCatalogResourceId = SphereCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName);
            SphereCatalogResource sphereCatalog = client.GetSphereCatalogResource(sphereCatalogResourceId);

            // get the collection of this SphereCertificateResource
            SphereCertificateCollection collection = sphereCatalog.GetSphereCertificates();

            // invoke the operation
            string serialNumber = "default";
            SphereCertificateResource result = await collection.GetAsync(serialNumber);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Certificates_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_CertificatesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetCertificate.json
            // this example is just showing the usage of "Certificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereCatalogResource created on azure
            // for more information of creating SphereCatalogResource, please refer to the document of SphereCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            ResourceIdentifier sphereCatalogResourceId = SphereCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName);
            SphereCatalogResource sphereCatalog = client.GetSphereCatalogResource(sphereCatalogResourceId);

            // get the collection of this SphereCertificateResource
            SphereCertificateCollection collection = sphereCatalog.GetSphereCertificates();

            // invoke the operation
            string serialNumber = "default";
            bool result = await collection.ExistsAsync(serialNumber);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Certificates_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_CertificatesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetCertificate.json
            // this example is just showing the usage of "Certificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereCatalogResource created on azure
            // for more information of creating SphereCatalogResource, please refer to the document of SphereCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            ResourceIdentifier sphereCatalogResourceId = SphereCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName);
            SphereCatalogResource sphereCatalog = client.GetSphereCatalogResource(sphereCatalogResourceId);

            // get the collection of this SphereCertificateResource
            SphereCertificateCollection collection = sphereCatalog.GetSphereCertificates();

            // invoke the operation
            string serialNumber = "default";
            NullableResponse<SphereCertificateResource> response = await collection.GetIfExistsAsync(serialNumber);
            SphereCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SphereCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
