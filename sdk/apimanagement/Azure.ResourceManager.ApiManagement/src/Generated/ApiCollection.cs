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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiResource"/> and their operations.
    /// Each <see cref="ApiResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="ApiCollection"/> instance call the GetApis method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ApiCollection : ArmCollection, IEnumerable<ApiResource>, IAsyncEnumerable<ApiResource>
    {
        private readonly ClientDiagnostics _apiClientDiagnostics;
        private readonly ApiRestOperations _apiRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiCollection"/> class for mocking. </summary>
        protected ApiCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiResource.ResourceType, out string apiApiVersion);
            _apiRestClient = new ApiRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates new or updates existing specified API of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="content"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string apiId, ApiCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiResource>(new ApiOperationSource(Client), _apiClientDiagnostics, Pipeline, _apiRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, content, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates new or updates existing specified API of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="content"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiResource> CreateOrUpdate(WaitUntil waitUntil, string apiId, ApiCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiResource>(new ApiOperationSource(Client), _apiClientDiagnostics, Pipeline, _apiRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, content, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<Response<ApiResource>> GetAsync(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual Response<ApiResource> Get(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.Get");
            scope.Start();
            try
            {
                var response = _apiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all APIs of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| serviceUrl | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| path | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| isCurrent | filter | eq, ne |  |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="tags"> Include tags in the response. </param>
        /// <param name="expandApiVersionSet"> Include full ApiVersionSet resource in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, string tags = null, bool? expandApiVersionSet = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, tags, expandApiVersionSet);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, tags, expandApiVersionSet);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiResource(Client, ApiData.DeserializeApiData(e)), _apiClientDiagnostics, Pipeline, "ApiCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all APIs of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| serviceUrl | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| path | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| isCurrent | filter | eq, ne |  |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="tags"> Include tags in the response. </param>
        /// <param name="expandApiVersionSet"> Include full ApiVersionSet resource in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiResource> GetAll(string filter = null, int? top = null, int? skip = null, string tags = null, bool? expandApiVersionSet = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, tags, expandApiVersionSet);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, tags, expandApiVersionSet);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiResource(Client, ApiData.DeserializeApiData(e)), _apiClientDiagnostics, Pipeline, "ApiCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual Response<bool> Exists(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiResource>> GetIfExistsAsync(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiResource>(response.GetRawResponse());
                return Response.FromValue(new ApiResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Api_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual NullableResponse<ApiResource> GetIfExists(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiResource>(response.GetRawResponse());
                return Response.FromValue(new ApiResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiResource> IEnumerable<ApiResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiResource> IAsyncEnumerable<ApiResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
