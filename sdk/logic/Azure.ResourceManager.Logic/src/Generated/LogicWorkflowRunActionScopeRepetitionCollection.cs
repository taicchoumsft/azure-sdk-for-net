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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicWorkflowRunActionScopeRepetitionResource"/> and their operations.
    /// Each <see cref="LogicWorkflowRunActionScopeRepetitionResource"/> in the collection will belong to the same instance of <see cref="LogicWorkflowRunActionResource"/>.
    /// To get a <see cref="LogicWorkflowRunActionScopeRepetitionCollection"/> instance call the GetLogicWorkflowRunActionScopeRepetitions method from an instance of <see cref="LogicWorkflowRunActionResource"/>.
    /// </summary>
    public partial class LogicWorkflowRunActionScopeRepetitionCollection : ArmCollection, IEnumerable<LogicWorkflowRunActionScopeRepetitionResource>, IAsyncEnumerable<LogicWorkflowRunActionScopeRepetitionResource>
    {
        private readonly ClientDiagnostics _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics;
        private readonly WorkflowRunActionScopeRepetitionsRestOperations _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionScopeRepetitionCollection"/> class for mocking. </summary>
        protected LogicWorkflowRunActionScopeRepetitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionScopeRepetitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicWorkflowRunActionScopeRepetitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowRunActionScopeRepetitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicWorkflowRunActionScopeRepetitionResource.ResourceType, out string logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsApiVersion);
            _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient = new WorkflowRunActionScopeRepetitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LogicWorkflowRunActionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LogicWorkflowRunActionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a workflow run action scoped repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual async Task<Response<LogicWorkflowRunActionScopeRepetitionResource>> GetAsync(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionScopeRepetitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunActionScopeRepetitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workflow run action scoped repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual Response<LogicWorkflowRunActionScopeRepetitionResource> Get(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionScopeRepetitionCollection.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunActionScopeRepetitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the workflow run action scoped repetitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicWorkflowRunActionScopeRepetitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicWorkflowRunActionScopeRepetitionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new LogicWorkflowRunActionScopeRepetitionResource(Client, LogicWorkflowRunActionRepetitionDefinitionData.DeserializeLogicWorkflowRunActionRepetitionDefinitionData(e)), _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics, Pipeline, "LogicWorkflowRunActionScopeRepetitionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List the workflow run action scoped repetitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicWorkflowRunActionScopeRepetitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicWorkflowRunActionScopeRepetitionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new LogicWorkflowRunActionScopeRepetitionResource(Client, LogicWorkflowRunActionRepetitionDefinitionData.DeserializeLogicWorkflowRunActionRepetitionDefinitionData(e)), _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics, Pipeline, "LogicWorkflowRunActionScopeRepetitionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionScopeRepetitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionScopeRepetitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual async Task<NullableResponse<LogicWorkflowRunActionScopeRepetitionResource>> GetIfExistsAsync(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionScopeRepetitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogicWorkflowRunActionScopeRepetitionResource>(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunActionScopeRepetitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual NullableResponse<LogicWorkflowRunActionScopeRepetitionResource> GetIfExists(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionScopeRepetitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogicWorkflowRunActionScopeRepetitionResource>(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunActionScopeRepetitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogicWorkflowRunActionScopeRepetitionResource> IEnumerable<LogicWorkflowRunActionScopeRepetitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogicWorkflowRunActionScopeRepetitionResource> IAsyncEnumerable<LogicWorkflowRunActionScopeRepetitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
