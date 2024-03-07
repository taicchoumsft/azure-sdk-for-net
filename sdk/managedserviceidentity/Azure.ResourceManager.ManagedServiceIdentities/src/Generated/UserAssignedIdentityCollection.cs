// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary>
    /// A class representing a collection of <see cref="UserAssignedIdentityResource"/> and their operations.
    /// Each <see cref="UserAssignedIdentityResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="UserAssignedIdentityCollection"/> instance call the GetUserAssignedIdentities method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class UserAssignedIdentityCollection : ArmCollection, IEnumerable<UserAssignedIdentityResource>, IAsyncEnumerable<UserAssignedIdentityResource>
    {
        private readonly ClientDiagnostics _userAssignedIdentityClientDiagnostics;
        private readonly UserAssignedIdentitiesRestOperations _userAssignedIdentityRestClient;

        /// <summary> Initializes a new instance of the <see cref="UserAssignedIdentityCollection"/> class for mocking. </summary>
        protected UserAssignedIdentityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="UserAssignedIdentityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal UserAssignedIdentityCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _userAssignedIdentityClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServiceIdentities", UserAssignedIdentityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(UserAssignedIdentityResource.ResourceType, out string userAssignedIdentityApiVersion);
            _userAssignedIdentityRestClient = new UserAssignedIdentitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, userAssignedIdentityApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an identity in the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="data"> Parameters to create or update the identity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<UserAssignedIdentityResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, UserAssignedIdentityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _userAssignedIdentityClientDiagnostics.CreateScope("UserAssignedIdentityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _userAssignedIdentityRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedServiceIdentitiesArmOperation<UserAssignedIdentityResource>(Response.FromValue(new UserAssignedIdentityResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an identity in the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="data"> Parameters to create or update the identity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<UserAssignedIdentityResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, UserAssignedIdentityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _userAssignedIdentityClientDiagnostics.CreateScope("UserAssignedIdentityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _userAssignedIdentityRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, cancellationToken);
                var operation = new ManagedServiceIdentitiesArmOperation<UserAssignedIdentityResource>(Response.FromValue(new UserAssignedIdentityResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<UserAssignedIdentityResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _userAssignedIdentityClientDiagnostics.CreateScope("UserAssignedIdentityCollection.Get");
            scope.Start();
            try
            {
                var response = await _userAssignedIdentityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UserAssignedIdentityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<UserAssignedIdentityResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _userAssignedIdentityClientDiagnostics.CreateScope("UserAssignedIdentityCollection.Get");
            scope.Start();
            try
            {
                var response = _userAssignedIdentityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UserAssignedIdentityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the userAssignedIdentities available under the specified ResourceGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="UserAssignedIdentityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<UserAssignedIdentityResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _userAssignedIdentityRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _userAssignedIdentityRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new UserAssignedIdentityResource(Client, UserAssignedIdentityData.DeserializeUserAssignedIdentityData(e)), _userAssignedIdentityClientDiagnostics, Pipeline, "UserAssignedIdentityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the userAssignedIdentities available under the specified ResourceGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="UserAssignedIdentityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<UserAssignedIdentityResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _userAssignedIdentityRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _userAssignedIdentityRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new UserAssignedIdentityResource(Client, UserAssignedIdentityData.DeserializeUserAssignedIdentityData(e)), _userAssignedIdentityClientDiagnostics, Pipeline, "UserAssignedIdentityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _userAssignedIdentityClientDiagnostics.CreateScope("UserAssignedIdentityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _userAssignedIdentityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _userAssignedIdentityClientDiagnostics.CreateScope("UserAssignedIdentityCollection.Exists");
            scope.Start();
            try
            {
                var response = _userAssignedIdentityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<UserAssignedIdentityResource>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _userAssignedIdentityClientDiagnostics.CreateScope("UserAssignedIdentityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _userAssignedIdentityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<UserAssignedIdentityResource>(response.GetRawResponse());
                return Response.FromValue(new UserAssignedIdentityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual NullableResponse<UserAssignedIdentityResource> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _userAssignedIdentityClientDiagnostics.CreateScope("UserAssignedIdentityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _userAssignedIdentityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<UserAssignedIdentityResource>(response.GetRawResponse());
                return Response.FromValue(new UserAssignedIdentityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<UserAssignedIdentityResource> IEnumerable<UserAssignedIdentityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<UserAssignedIdentityResource> IAsyncEnumerable<UserAssignedIdentityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
