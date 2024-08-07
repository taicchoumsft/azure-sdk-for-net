// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WorkflowRun along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WorkflowRunResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWorkflowRunResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource"/> using the GetWorkflowRun method.
    /// </summary>
    public partial class WorkflowRunResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkflowRunResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="workflowName"> The workflowName. </param>
        /// <param name="runName"> The runName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workflowRunClientDiagnostics;
        private readonly WorkflowRunsRestOperations _workflowRunRestClient;
        private readonly WorkflowRunData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/hostruntime/webhooks/api/workflows/runs";

        /// <summary> Initializes a new instance of the <see cref="WorkflowRunResource"/> class for mocking. </summary>
        protected WorkflowRunResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkflowRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkflowRunResource(ArmClient client, WorkflowRunData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WorkflowRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkflowRunResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workflowRunClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workflowRunApiVersion);
            _workflowRunRestClient = new WorkflowRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workflowRunApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkflowRunData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of WorkflowRunActionResources in the WorkflowRun. </summary>
        /// <returns> An object representing collection of WorkflowRunActionResources and their operations over a WorkflowRunActionResource. </returns>
        public virtual WorkflowRunActionCollection GetWorkflowRunActions()
        {
            return GetCachedClient(client => new WorkflowRunActionCollection(client, Id));
        }

        /// <summary>
        /// Gets a workflow run action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WorkflowRunActionResource>> GetWorkflowRunActionAsync(string actionName, CancellationToken cancellationToken = default)
        {
            return await GetWorkflowRunActions().GetAsync(actionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workflow run action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WorkflowRunActionResource> GetWorkflowRunAction(string actionName, CancellationToken cancellationToken = default)
        {
            return GetWorkflowRunActions().Get(actionName, cancellationToken);
        }

        /// <summary>
        /// Gets a workflow run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkflowRunResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowRunClientDiagnostics.CreateScope("WorkflowRunResource.Get");
            scope.Start();
            try
            {
                var response = await _workflowRunRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkflowRunResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowRunClientDiagnostics.CreateScope("WorkflowRunResource.Get");
            scope.Start();
            try
            {
                var response = _workflowRunRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a workflow run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Cancel</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowRunClientDiagnostics.CreateScope("WorkflowRunResource.Cancel");
            scope.Start();
            try
            {
                var response = await _workflowRunRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a workflow run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Cancel</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowRunClientDiagnostics.CreateScope("WorkflowRunResource.Cancel");
            scope.Start();
            try
            {
                var response = _workflowRunRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
