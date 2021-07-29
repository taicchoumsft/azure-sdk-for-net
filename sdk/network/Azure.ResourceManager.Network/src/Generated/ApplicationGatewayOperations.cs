// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific ApplicationGateway. </summary>
    public partial class ApplicationGatewayOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ApplicationGatewaysRestOperations _restClient { get; }
        private ApplicationGatewayPrivateLinkResourcesRestOperations _applicationGatewayPrivateLinkResourcesRestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayOperations"/> class for mocking. </summary>
        protected ApplicationGatewayOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ApplicationGatewayOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ApplicationGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _applicationGatewayPrivateLinkResourcesRestClient = new ApplicationGatewayPrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/applicationGateways";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ApplicationGateway>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApplicationGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationGateway> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ApplicationGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ApplicationGatewaysDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ApplicationGatewaysDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationGatewaysDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new ApplicationGatewaysDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Updates the specified application gateway tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationGateway>> UpdateTagsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, tags, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApplicationGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified application gateway tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationGateway> UpdateTags(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = _restClient.UpdateTags(Id.ResourceGroupName, Id.Name, tags, cancellationToken);
                return Response.FromValue(new ApplicationGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all private link resources on an application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationGatewayPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationGatewayPrivateLinkResource> GetApplicationGatewayPrivateLinkResources(CancellationToken cancellationToken = default)
        {
            Page<ApplicationGatewayPrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.GetApplicationGatewayPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = _applicationGatewayPrivateLinkResourcesRestClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationGatewayPrivateLinkResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.GetApplicationGatewayPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = _applicationGatewayPrivateLinkResourcesRestClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all private link resources on an application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationGatewayPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationGatewayPrivateLinkResource> GetApplicationGatewayPrivateLinkResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationGatewayPrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.GetApplicationGatewayPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = await _applicationGatewayPrivateLinkResourcesRestClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationGatewayPrivateLinkResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.GetApplicationGatewayPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = await _applicationGatewayPrivateLinkResourcesRestClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Starts the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StartAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.Start");
            scope.Start();
            try
            {
                var operation = await StartStartAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Start(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.Start");
            scope.Start();
            try
            {
                var operation = StartStart(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ApplicationGatewaysStartOperation> StartStartAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartStart");
            scope.Start();
            try
            {
                var response = await _restClient.StartAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ApplicationGatewaysStartOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationGatewaysStartOperation StartStart(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartStart");
            scope.Start();
            try
            {
                var response = _restClient.Start(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new ApplicationGatewaysStartOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified application gateway in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.Stop");
            scope.Start();
            try
            {
                var operation = await StartStopAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified application gateway in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Stop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.Stop");
            scope.Start();
            try
            {
                var operation = StartStop(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified application gateway in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ApplicationGatewaysStopOperation> StartStopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartStop");
            scope.Start();
            try
            {
                var response = await _restClient.StopAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ApplicationGatewaysStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified application gateway in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationGatewaysStopOperation StartStop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartStop");
            scope.Start();
            try
            {
                var response = _restClient.Stop(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new ApplicationGatewaysStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the backend health of the specified application gateway in a resource group. </summary>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ApplicationGatewayBackendHealth>> BackendHealthAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.BackendHealth");
            scope.Start();
            try
            {
                var operation = await StartBackendHealthAsync(expand, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the backend health of the specified application gateway in a resource group. </summary>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationGatewayBackendHealth> BackendHealth(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.BackendHealth");
            scope.Start();
            try
            {
                var operation = StartBackendHealth(expand, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the backend health of the specified application gateway in a resource group. </summary>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ApplicationGatewaysBackendHealthOperation> StartBackendHealthAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartBackendHealth");
            scope.Start();
            try
            {
                var response = await _restClient.BackendHealthAsync(Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                return new ApplicationGatewaysBackendHealthOperation(_clientDiagnostics, Pipeline, _restClient.CreateBackendHealthRequest(Id.ResourceGroupName, Id.Name, expand).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the backend health of the specified application gateway in a resource group. </summary>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationGatewaysBackendHealthOperation StartBackendHealth(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartBackendHealth");
            scope.Start();
            try
            {
                var response = _restClient.BackendHealth(Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                return new ApplicationGatewaysBackendHealthOperation(_clientDiagnostics, Pipeline, _restClient.CreateBackendHealthRequest(Id.ResourceGroupName, Id.Name, expand).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the backend health for given combination of backend pool and http setting of the specified application gateway in a resource group. </summary>
        /// <param name="probeRequest"> Request body for on-demand test probe operation. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="probeRequest"/> is null. </exception>
        public async virtual Task<Response<ApplicationGatewayBackendHealthOnDemand>> BackendHealthOnDemandAsync(ApplicationGatewayOnDemandProbe probeRequest, string expand = null, CancellationToken cancellationToken = default)
        {
            if (probeRequest == null)
            {
                throw new ArgumentNullException(nameof(probeRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.BackendHealthOnDemand");
            scope.Start();
            try
            {
                var operation = await StartBackendHealthOnDemandAsync(probeRequest, expand, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the backend health for given combination of backend pool and http setting of the specified application gateway in a resource group. </summary>
        /// <param name="probeRequest"> Request body for on-demand test probe operation. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="probeRequest"/> is null. </exception>
        public virtual Response<ApplicationGatewayBackendHealthOnDemand> BackendHealthOnDemand(ApplicationGatewayOnDemandProbe probeRequest, string expand = null, CancellationToken cancellationToken = default)
        {
            if (probeRequest == null)
            {
                throw new ArgumentNullException(nameof(probeRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.BackendHealthOnDemand");
            scope.Start();
            try
            {
                var operation = StartBackendHealthOnDemand(probeRequest, expand, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the backend health for given combination of backend pool and http setting of the specified application gateway in a resource group. </summary>
        /// <param name="probeRequest"> Request body for on-demand test probe operation. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="probeRequest"/> is null. </exception>
        public async virtual Task<ApplicationGatewaysBackendHealthOnDemandOperation> StartBackendHealthOnDemandAsync(ApplicationGatewayOnDemandProbe probeRequest, string expand = null, CancellationToken cancellationToken = default)
        {
            if (probeRequest == null)
            {
                throw new ArgumentNullException(nameof(probeRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartBackendHealthOnDemand");
            scope.Start();
            try
            {
                var response = await _restClient.BackendHealthOnDemandAsync(Id.ResourceGroupName, Id.Name, probeRequest, expand, cancellationToken).ConfigureAwait(false);
                return new ApplicationGatewaysBackendHealthOnDemandOperation(_clientDiagnostics, Pipeline, _restClient.CreateBackendHealthOnDemandRequest(Id.ResourceGroupName, Id.Name, probeRequest, expand).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the backend health for given combination of backend pool and http setting of the specified application gateway in a resource group. </summary>
        /// <param name="probeRequest"> Request body for on-demand test probe operation. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="probeRequest"/> is null. </exception>
        public virtual ApplicationGatewaysBackendHealthOnDemandOperation StartBackendHealthOnDemand(ApplicationGatewayOnDemandProbe probeRequest, string expand = null, CancellationToken cancellationToken = default)
        {
            if (probeRequest == null)
            {
                throw new ArgumentNullException(nameof(probeRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayOperations.StartBackendHealthOnDemand");
            scope.Start();
            try
            {
                var response = _restClient.BackendHealthOnDemand(Id.ResourceGroupName, Id.Name, probeRequest, expand, cancellationToken);
                return new ApplicationGatewaysBackendHealthOnDemandOperation(_clientDiagnostics, Pipeline, _restClient.CreateBackendHealthOnDemandRequest(Id.ResourceGroupName, Id.Name, probeRequest, expand).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of ApplicationGatewayPrivateEndpointConnections in the ApplicationGateway. </summary>
        /// <returns> An object representing collection of ApplicationGatewayPrivateEndpointConnections and their operations over a ApplicationGateway. </returns>
        public ApplicationGatewayPrivateEndpointConnectionContainer GetApplicationGatewayPrivateEndpointConnections()
        {
            return new ApplicationGatewayPrivateEndpointConnectionContainer(this);
        }
    }
}
