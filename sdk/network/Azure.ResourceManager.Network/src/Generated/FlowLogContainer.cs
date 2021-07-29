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
    /// <summary> A class representing collection of FlowLog and their operations over a NetworkWatcher. </summary>
    public partial class FlowLogContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="FlowLogContainer"/> class for mocking. </summary>
        protected FlowLogContainer()
        {
        }

        /// <summary> Initializes a new instance of FlowLogContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FlowLogContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private FlowLogsRestOperations _restClient => new FlowLogsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => NetworkWatcherOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update a flow log for the specified network security group. </summary>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<FlowLog> CreateOrUpdate(string flowLogName, FlowLogData parameters, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(flowLogName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a flow log for the specified network security group. </summary>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<FlowLog>> CreateOrUpdateAsync(string flowLogName, FlowLogData parameters, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(flowLogName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a flow log for the specified network security group. </summary>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FlowLogsCreateOrUpdateOperation StartCreateOrUpdate(string flowLogName, FlowLogData parameters, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, flowLogName, parameters, cancellationToken);
                return new FlowLogsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, flowLogName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a flow log for the specified network security group. </summary>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FlowLogsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string flowLogName, FlowLogData parameters, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, flowLogName, parameters, cancellationToken).ConfigureAwait(false);
                return new FlowLogsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, flowLogName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<FlowLog> Get(string flowLogName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.Get");
            scope.Start();
            try
            {
                if (flowLogName == null)
                {
                    throw new ArgumentNullException(nameof(flowLogName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken);
                return Response.FromValue(new FlowLog(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<FlowLog>> GetAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.Get");
            scope.Start();
            try
            {
                if (flowLogName == null)
                {
                    throw new ArgumentNullException(nameof(flowLogName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FlowLog(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual FlowLog TryGet(string flowLogName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.TryGet");
            scope.Start();
            try
            {
                if (flowLogName == null)
                {
                    throw new ArgumentNullException(nameof(flowLogName));
                }

                return Get(flowLogName, cancellationToken: cancellationToken).Value;
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
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<FlowLog> TryGetAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.TryGet");
            scope.Start();
            try
            {
                if (flowLogName == null)
                {
                    throw new ArgumentNullException(nameof(flowLogName));
                }

                return await GetAsync(flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string flowLogName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (flowLogName == null)
                {
                    throw new ArgumentNullException(nameof(flowLogName));
                }

                return TryGet(flowLogName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (flowLogName == null)
                {
                    throw new ArgumentNullException(nameof(flowLogName));
                }

                return await TryGetAsync(flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all flow log resources for the specified Network Watcher. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FlowLog" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<FlowLog> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FlowLog> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FlowLog> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all flow log resources for the specified Network Watcher. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FlowLog" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<FlowLog> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FlowLog>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FlowLog>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="FlowLog" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FlowLogOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="FlowLog" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FlowLogOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, FlowLog, FlowLogData> Construct() { }
    }
}
