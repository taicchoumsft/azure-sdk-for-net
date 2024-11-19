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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebAppRequestHistoryResource"/> and their operations.
    /// Each <see cref="WebAppRequestHistoryResource"/> in the collection will belong to the same instance of <see cref="WorkflowRunActionRepetitionResource"/>.
    /// To get a <see cref="WebAppRequestHistoryCollection"/> instance call the GetWebAppRequestHistories method from an instance of <see cref="WorkflowRunActionRepetitionResource"/>.
    /// </summary>
    public partial class WebAppRequestHistoryCollection : ArmCollection, IEnumerable<WebAppRequestHistoryResource>, IAsyncEnumerable<WebAppRequestHistoryResource>
    {
        private readonly ClientDiagnostics _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics;
        private readonly WorkflowRunActionRepetitionsRequestHistoriesRestOperations _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebAppRequestHistoryCollection"/> class for mocking. </summary>
        protected WebAppRequestHistoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebAppRequestHistoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebAppRequestHistoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebAppRequestHistoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebAppRequestHistoryResource.ResourceType, out string webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesApiVersion);
            _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient = new WorkflowRunActionRepetitionsRequestHistoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkflowRunActionRepetitionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkflowRunActionRepetitionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a workflow run repetition request history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        public virtual async Task<Response<WebAppRequestHistoryResource>> GetAsync(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var scope = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics.CreateScope("WebAppRequestHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, requestHistoryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebAppRequestHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow run repetition request history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        public virtual Response<WebAppRequestHistoryResource> Get(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var scope = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics.CreateScope("WebAppRequestHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, requestHistoryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebAppRequestHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List a workflow run repetition request history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebAppRequestHistoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebAppRequestHistoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebAppRequestHistoryResource(Client, WebAppRequestHistoryData.DeserializeWebAppRequestHistoryData(e)), _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics, Pipeline, "WebAppRequestHistoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List a workflow run repetition request history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebAppRequestHistoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebAppRequestHistoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebAppRequestHistoryResource(Client, WebAppRequestHistoryData.DeserializeWebAppRequestHistoryData(e)), _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics, Pipeline, "WebAppRequestHistoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var scope = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics.CreateScope("WebAppRequestHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, requestHistoryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        public virtual Response<bool> Exists(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var scope = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics.CreateScope("WebAppRequestHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, requestHistoryName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        public virtual async Task<NullableResponse<WebAppRequestHistoryResource>> GetIfExistsAsync(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var scope = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics.CreateScope("WebAppRequestHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, requestHistoryName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebAppRequestHistoryResource>(response.GetRawResponse());
                return Response.FromValue(new WebAppRequestHistoryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        public virtual NullableResponse<WebAppRequestHistoryResource> GetIfExists(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var scope = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesClientDiagnostics.CreateScope("WebAppRequestHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppRequestHistoryWorkflowRunActionRepetitionsRequestHistoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, requestHistoryName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebAppRequestHistoryResource>(response.GetRawResponse());
                return Response.FromValue(new WebAppRequestHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebAppRequestHistoryResource> IEnumerable<WebAppRequestHistoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebAppRequestHistoryResource> IAsyncEnumerable<WebAppRequestHistoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
