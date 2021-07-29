// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of SecurityPartnerProvider and their operations over a ResourceGroup. </summary>
    public partial class SecurityPartnerProviderContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="SecurityPartnerProviderContainer"/> class for mocking. </summary>
        protected SecurityPartnerProviderContainer()
        {
        }

        /// <summary> Initializes a new instance of SecurityPartnerProviderContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SecurityPartnerProviderContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private SecurityPartnerProvidersRestOperations _restClient => new SecurityPartnerProvidersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates the specified Security Partner Provider. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Security Partner Provider operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<SecurityPartnerProvider> CreateOrUpdate(string securityPartnerProviderName, SecurityPartnerProviderData parameters, CancellationToken cancellationToken = default)
        {
            if (securityPartnerProviderName == null)
            {
                throw new ArgumentNullException(nameof(securityPartnerProviderName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(securityPartnerProviderName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Security Partner Provider. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Security Partner Provider operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<SecurityPartnerProvider>> CreateOrUpdateAsync(string securityPartnerProviderName, SecurityPartnerProviderData parameters, CancellationToken cancellationToken = default)
        {
            if (securityPartnerProviderName == null)
            {
                throw new ArgumentNullException(nameof(securityPartnerProviderName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(securityPartnerProviderName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Security Partner Provider. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Security Partner Provider operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SecurityPartnerProvidersCreateOrUpdateOperation StartCreateOrUpdate(string securityPartnerProviderName, SecurityPartnerProviderData parameters, CancellationToken cancellationToken = default)
        {
            if (securityPartnerProviderName == null)
            {
                throw new ArgumentNullException(nameof(securityPartnerProviderName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, securityPartnerProviderName, parameters, cancellationToken);
                return new SecurityPartnerProvidersCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, securityPartnerProviderName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Security Partner Provider. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Security Partner Provider operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SecurityPartnerProvidersCreateOrUpdateOperation> StartCreateOrUpdateAsync(string securityPartnerProviderName, SecurityPartnerProviderData parameters, CancellationToken cancellationToken = default)
        {
            if (securityPartnerProviderName == null)
            {
                throw new ArgumentNullException(nameof(securityPartnerProviderName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, securityPartnerProviderName, parameters, cancellationToken).ConfigureAwait(false);
                return new SecurityPartnerProvidersCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, securityPartnerProviderName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SecurityPartnerProvider> Get(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.Get");
            scope.Start();
            try
            {
                if (securityPartnerProviderName == null)
                {
                    throw new ArgumentNullException(nameof(securityPartnerProviderName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, securityPartnerProviderName, cancellationToken: cancellationToken);
                return Response.FromValue(new SecurityPartnerProvider(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SecurityPartnerProvider>> GetAsync(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.Get");
            scope.Start();
            try
            {
                if (securityPartnerProviderName == null)
                {
                    throw new ArgumentNullException(nameof(securityPartnerProviderName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, securityPartnerProviderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SecurityPartnerProvider(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual SecurityPartnerProvider TryGet(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.TryGet");
            scope.Start();
            try
            {
                if (securityPartnerProviderName == null)
                {
                    throw new ArgumentNullException(nameof(securityPartnerProviderName));
                }

                return Get(securityPartnerProviderName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<SecurityPartnerProvider> TryGetAsync(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.TryGet");
            scope.Start();
            try
            {
                if (securityPartnerProviderName == null)
                {
                    throw new ArgumentNullException(nameof(securityPartnerProviderName));
                }

                return await GetAsync(securityPartnerProviderName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (securityPartnerProviderName == null)
                {
                    throw new ArgumentNullException(nameof(securityPartnerProviderName));
                }

                return TryGet(securityPartnerProviderName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (securityPartnerProviderName == null)
                {
                    throw new ArgumentNullException(nameof(securityPartnerProviderName));
                }

                return await TryGetAsync(securityPartnerProviderName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Security Partner Providers in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityPartnerProvider" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<SecurityPartnerProvider> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SecurityPartnerProvider> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityPartnerProvider(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SecurityPartnerProvider> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityPartnerProvider(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Security Partner Providers in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityPartnerProvider" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<SecurityPartnerProvider> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SecurityPartnerProvider>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityPartnerProvider(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SecurityPartnerProvider>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityPartnerProvider(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SecurityPartnerProvider" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SecurityPartnerProviderOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SecurityPartnerProvider" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProviderContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SecurityPartnerProviderOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, SecurityPartnerProvider, SecurityPartnerProviderData> Construct() { }
    }
}
