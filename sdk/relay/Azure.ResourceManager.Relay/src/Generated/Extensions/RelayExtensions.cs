// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Relay.Mocking;
using Azure.ResourceManager.Relay.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Relay
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Relay. </summary>
    public static partial class RelayExtensions
    {
        private static MockableRelayArmClient GetMockableRelayArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableRelayArmClient(client0));
        }

        private static MockableRelayResourceGroupResource GetMockableRelayResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableRelayResourceGroupResource(client, resource.Id));
        }

        private static MockableRelaySubscriptionResource GetMockableRelaySubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableRelaySubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelayNamespaceAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="RelayNamespaceAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetRelayNamespaceAuthorizationRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RelayNamespaceAuthorizationRuleResource"/> object. </returns>
        public static RelayNamespaceAuthorizationRuleResource GetRelayNamespaceAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetRelayNamespaceAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelayHybridConnectionAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayHybridConnectionAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="RelayHybridConnectionAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetRelayHybridConnectionAuthorizationRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RelayHybridConnectionAuthorizationRuleResource"/> object. </returns>
        public static RelayHybridConnectionAuthorizationRuleResource GetRelayHybridConnectionAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetRelayHybridConnectionAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WcfRelayAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WcfRelayAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="WcfRelayAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetWcfRelayAuthorizationRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="WcfRelayAuthorizationRuleResource"/> object. </returns>
        public static WcfRelayAuthorizationRuleResource GetWcfRelayAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetWcfRelayAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelayNamespaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNamespaceResource.CreateResourceIdentifier" /> to create a <see cref="RelayNamespaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetRelayNamespaceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RelayNamespaceResource"/> object. </returns>
        public static RelayNamespaceResource GetRelayNamespaceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetRelayNamespaceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelayNetworkRuleSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNetworkRuleSetResource.CreateResourceIdentifier" /> to create a <see cref="RelayNetworkRuleSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetRelayNetworkRuleSetResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RelayNetworkRuleSetResource"/> object. </returns>
        public static RelayNetworkRuleSetResource GetRelayNetworkRuleSetResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetRelayNetworkRuleSetResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelayHybridConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayHybridConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RelayHybridConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetRelayHybridConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RelayHybridConnectionResource"/> object. </returns>
        public static RelayHybridConnectionResource GetRelayHybridConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetRelayHybridConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WcfRelayResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WcfRelayResource.CreateResourceIdentifier" /> to create a <see cref="WcfRelayResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetWcfRelayResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="WcfRelayResource"/> object. </returns>
        public static WcfRelayResource GetWcfRelayResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetWcfRelayResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelayPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RelayPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetRelayPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RelayPrivateEndpointConnectionResource"/> object. </returns>
        public static RelayPrivateEndpointConnectionResource GetRelayPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetRelayPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelayPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="RelayPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayArmClient.GetRelayPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RelayPrivateLinkResource"/> object. </returns>
        public static RelayPrivateLinkResource GetRelayPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRelayArmClient(client).GetRelayPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets a collection of RelayNamespaceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayResourceGroupResource.GetRelayNamespaces()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of RelayNamespaceResources and their operations over a RelayNamespaceResource. </returns>
        public static RelayNamespaceCollection GetRelayNamespaces(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableRelayResourceGroupResource(resourceGroupResource).GetRelayNamespaces();
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RelayNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayResourceGroupResource.GetRelayNamespaceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<RelayNamespaceResource>> GetRelayNamespaceAsync(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableRelayResourceGroupResource(resourceGroupResource).GetRelayNamespaceAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RelayNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelayResourceGroupResource.GetRelayNamespace(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<RelayNamespaceResource> GetRelayNamespace(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableRelayResourceGroupResource(resourceGroupResource).GetRelayNamespace(namespaceName, cancellationToken);
        }

        /// <summary>
        /// Check the specified namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Relay/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RelayNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelaySubscriptionResource.CheckRelayNamespaceNameAvailability(RelayNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the specified namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<RelayNameAvailabilityResult>> CheckRelayNamespaceNameAvailabilityAsync(this SubscriptionResource subscriptionResource, RelayNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableRelaySubscriptionResource(subscriptionResource).CheckRelayNamespaceNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the specified namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Relay/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RelayNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelaySubscriptionResource.CheckRelayNamespaceNameAvailability(RelayNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the specified namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<RelayNameAvailabilityResult> CheckRelayNamespaceNameAvailability(this SubscriptionResource subscriptionResource, RelayNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableRelaySubscriptionResource(subscriptionResource).CheckRelayNamespaceNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the subscription regardless of the resourceGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Relay/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RelayNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelaySubscriptionResource.GetRelayNamespaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="RelayNamespaceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RelayNamespaceResource> GetRelayNamespacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableRelaySubscriptionResource(subscriptionResource).GetRelayNamespacesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the subscription regardless of the resourceGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Relay/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RelayNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRelaySubscriptionResource.GetRelayNamespaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="RelayNamespaceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RelayNamespaceResource> GetRelayNamespaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableRelaySubscriptionResource(subscriptionResource).GetRelayNamespaces(cancellationToken);
        }
    }
}
