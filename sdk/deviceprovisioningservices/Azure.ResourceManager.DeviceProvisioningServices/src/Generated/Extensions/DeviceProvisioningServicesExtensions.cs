// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices.Mocking;
using Azure.ResourceManager.DeviceProvisioningServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DeviceProvisioningServices. </summary>
    public static partial class DeviceProvisioningServicesExtensions
    {
        private static MockableDeviceProvisioningServicesArmClient GetMockableDeviceProvisioningServicesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDeviceProvisioningServicesArmClient(client0));
        }

        private static MockableDeviceProvisioningServicesResourceGroupResource GetMockableDeviceProvisioningServicesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDeviceProvisioningServicesResourceGroupResource(client, resource.Id));
        }

        private static MockableDeviceProvisioningServicesSubscriptionResource GetMockableDeviceProvisioningServicesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDeviceProvisioningServicesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceProvisioningServicesCertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceProvisioningServicesCertificateResource.CreateResourceIdentifier" /> to create a <see cref="DeviceProvisioningServicesCertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesArmClient.GetDeviceProvisioningServicesCertificateResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DeviceProvisioningServicesCertificateResource"/> object. </returns>
        public static DeviceProvisioningServicesCertificateResource GetDeviceProvisioningServicesCertificateResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDeviceProvisioningServicesArmClient(client).GetDeviceProvisioningServicesCertificateResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceProvisioningServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceProvisioningServiceResource.CreateResourceIdentifier" /> to create a <see cref="DeviceProvisioningServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesArmClient.GetDeviceProvisioningServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DeviceProvisioningServiceResource"/> object. </returns>
        public static DeviceProvisioningServiceResource GetDeviceProvisioningServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDeviceProvisioningServicesArmClient(client).GetDeviceProvisioningServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceProvisioningServicesPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceProvisioningServicesPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="DeviceProvisioningServicesPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesArmClient.GetDeviceProvisioningServicesPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DeviceProvisioningServicesPrivateLinkResource"/> object. </returns>
        public static DeviceProvisioningServicesPrivateLinkResource GetDeviceProvisioningServicesPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDeviceProvisioningServicesArmClient(client).GetDeviceProvisioningServicesPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesArmClient.GetDeviceProvisioningServicesPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource"/> object. </returns>
        public static DeviceProvisioningServicesPrivateEndpointConnectionResource GetDeviceProvisioningServicesPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDeviceProvisioningServicesArmClient(client).GetDeviceProvisioningServicesPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets a collection of DeviceProvisioningServiceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesResourceGroupResource.GetDeviceProvisioningServices()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DeviceProvisioningServiceResources and their operations over a DeviceProvisioningServiceResource. </returns>
        public static DeviceProvisioningServiceCollection GetDeviceProvisioningServices(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDeviceProvisioningServicesResourceGroupResource(resourceGroupResource).GetDeviceProvisioningServices();
        }

        /// <summary>
        /// Get the metadata of the provisioning service without SAS keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesResourceGroupResource.GetDeviceProvisioningServiceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="provisioningServiceName"> Name of the provisioning service to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="provisioningServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeviceProvisioningServiceResource>> GetDeviceProvisioningServiceAsync(this ResourceGroupResource resourceGroupResource, string provisioningServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDeviceProvisioningServicesResourceGroupResource(resourceGroupResource).GetDeviceProvisioningServiceAsync(provisioningServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the metadata of the provisioning service without SAS keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesResourceGroupResource.GetDeviceProvisioningService(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="provisioningServiceName"> Name of the provisioning service to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="provisioningServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DeviceProvisioningServiceResource> GetDeviceProvisioningService(this ResourceGroupResource resourceGroupResource, string provisioningServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDeviceProvisioningServicesResourceGroupResource(resourceGroupResource).GetDeviceProvisioningService(provisioningServiceName, cancellationToken);
        }

        /// <summary>
        /// List all the provisioning services for a given subscription id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/provisioningServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesSubscriptionResource.GetDeviceProvisioningServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DeviceProvisioningServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeviceProvisioningServiceResource> GetDeviceProvisioningServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDeviceProvisioningServicesSubscriptionResource(subscriptionResource).GetDeviceProvisioningServicesAsync(cancellationToken);
        }

        /// <summary>
        /// List all the provisioning services for a given subscription id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/provisioningServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesSubscriptionResource.GetDeviceProvisioningServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DeviceProvisioningServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeviceProvisioningServiceResource> GetDeviceProvisioningServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDeviceProvisioningServicesSubscriptionResource(subscriptionResource).GetDeviceProvisioningServices(cancellationToken);
        }

        /// <summary>
        /// Check if a provisioning service name is available. This will validate if the name is syntactically valid and if the name is usable
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkProvisioningServiceNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CheckProvisioningServiceNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesSubscriptionResource.CheckDeviceProvisioningServicesNameAvailability(DeviceProvisioningServicesNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the provisioning service to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<DeviceProvisioningServicesNameAvailabilityResult>> CheckDeviceProvisioningServicesNameAvailabilityAsync(this SubscriptionResource subscriptionResource, DeviceProvisioningServicesNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableDeviceProvisioningServicesSubscriptionResource(subscriptionResource).CheckDeviceProvisioningServicesNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a provisioning service name is available. This will validate if the name is syntactically valid and if the name is usable
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkProvisioningServiceNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CheckProvisioningServiceNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDeviceProvisioningServicesSubscriptionResource.CheckDeviceProvisioningServicesNameAvailability(DeviceProvisioningServicesNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the provisioning service to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<DeviceProvisioningServicesNameAvailabilityResult> CheckDeviceProvisioningServicesNameAvailability(this SubscriptionResource subscriptionResource, DeviceProvisioningServicesNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDeviceProvisioningServicesSubscriptionResource(subscriptionResource).CheckDeviceProvisioningServicesNameAvailability(content, cancellationToken);
        }
    }
}
