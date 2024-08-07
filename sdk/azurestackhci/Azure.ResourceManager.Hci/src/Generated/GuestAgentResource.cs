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

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A Class representing a GuestAgent along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GuestAgentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGuestAgentResource method.
    /// Otherwise you can get one from its parent resource <see cref="VirtualMachineInstanceResource"/> using the GetGuestAgent method.
    /// </summary>
    public partial class GuestAgentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GuestAgentResource"/> instance. </summary>
        /// <param name="resourceUri"> The resourceUri. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.AzureStackHCI/virtualMachineInstances/default/guestAgents/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _guestAgentClientDiagnostics;
        private readonly GuestAgentRestOperations _guestAgentRestClient;
        private readonly GuestAgentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AzureStackHCI/virtualMachineInstances/guestAgents";

        /// <summary> Initializes a new instance of the <see cref="GuestAgentResource"/> class for mocking. </summary>
        protected GuestAgentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GuestAgentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GuestAgentResource(ArmClient client, GuestAgentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GuestAgentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GuestAgentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _guestAgentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string guestAgentApiVersion);
            _guestAgentRestClient = new GuestAgentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, guestAgentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GuestAgentData Data
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

        /// <summary>
        /// Implements GuestAgent GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestAgent_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GuestAgentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgentResource.Get");
            scope.Start();
            try
            {
                var response = await _guestAgentRestClient.GetAsync(Id.Parent.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements GuestAgent GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestAgent_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GuestAgentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgentResource.Get");
            scope.Start();
            try
            {
                var response = _guestAgentRestClient.Get(Id.Parent.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements GuestAgent DELETE method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestAgent_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgentResource.Delete");
            scope.Start();
            try
            {
                var response = await _guestAgentRestClient.DeleteAsync(Id.Parent.Parent, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation(_guestAgentClientDiagnostics, Pipeline, _guestAgentRestClient.CreateDeleteRequest(Id.Parent.Parent).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements GuestAgent DELETE method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestAgent_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgentResource.Delete");
            scope.Start();
            try
            {
                var response = _guestAgentRestClient.Delete(Id.Parent.Parent, cancellationToken);
                var operation = new HciArmOperation(_guestAgentClientDiagnostics, Pipeline, _guestAgentRestClient.CreateDeleteRequest(Id.Parent.Parent).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Or Update GuestAgent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestAgent_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GuestAgentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, GuestAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgentResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _guestAgentRestClient.CreateAsync(Id.Parent.Parent, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<GuestAgentResource>(new GuestAgentOperationSource(Client), _guestAgentClientDiagnostics, Pipeline, _guestAgentRestClient.CreateCreateRequest(Id.Parent.Parent, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Or Update GuestAgent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestAgent_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GuestAgentResource> CreateOrUpdate(WaitUntil waitUntil, GuestAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgentResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _guestAgentRestClient.Create(Id.Parent.Parent, data, cancellationToken);
                var operation = new HciArmOperation<GuestAgentResource>(new GuestAgentOperationSource(Client), _guestAgentClientDiagnostics, Pipeline, _guestAgentRestClient.CreateCreateRequest(Id.Parent.Parent, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
