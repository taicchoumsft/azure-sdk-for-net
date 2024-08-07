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
using Azure.ResourceManager.ContainerServiceFleet.Models;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A Class representing a ContainerServiceFleetMember along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerServiceFleetMemberResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerServiceFleetMemberResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerServiceFleetResource"/> using the GetContainerServiceFleetMember method.
    /// </summary>
    public partial class ContainerServiceFleetMemberResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerServiceFleetMemberResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="fleetName"> The fleetName. </param>
        /// <param name="fleetMemberName"> The fleetMemberName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName, string fleetMemberName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerServiceFleetMemberFleetMembersClientDiagnostics;
        private readonly FleetMembersRestOperations _containerServiceFleetMemberFleetMembersRestClient;
        private readonly ContainerServiceFleetMemberData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/fleets/members";

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetMemberResource"/> class for mocking. </summary>
        protected ContainerServiceFleetMemberResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetMemberResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerServiceFleetMemberResource(ArmClient client, ContainerServiceFleetMemberData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetMemberResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerServiceFleetMemberResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceFleetMemberFleetMembersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerServiceFleet", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerServiceFleetMemberFleetMembersApiVersion);
            _containerServiceFleetMemberFleetMembersRestClient = new FleetMembersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceFleetMemberFleetMembersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerServiceFleetMemberData Data
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
        /// Get a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerServiceFleetMemberResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberResource.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetMemberFleetMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerServiceFleetMemberResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberResource.Get");
            scope.Start();
            try
            {
                var response = _containerServiceFleetMemberFleetMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberResource.Delete");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetMemberFleetMembersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation(_containerServiceFleetMemberFleetMembersClientDiagnostics, Pipeline, _containerServiceFleetMemberFleetMembersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch).Request, response, OperationFinalStateVia.Location, apiVersionOverrideValue: "2016-03-30");
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
        /// Delete a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberResource.Delete");
            scope.Start();
            try
            {
                var response = _containerServiceFleetMemberFleetMembersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation(_containerServiceFleetMemberFleetMembersClientDiagnostics, Pipeline, _containerServiceFleetMemberFleetMembersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch).Request, response, OperationFinalStateVia.Location, apiVersionOverrideValue: "2016-03-30");
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
        /// Update a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The resource properties to be updated. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerServiceFleetMemberResource>> UpdateAsync(WaitUntil waitUntil, ContainerServiceFleetMemberPatch patch, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberResource.Update");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetMemberFleetMembersRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation<ContainerServiceFleetMemberResource>(new ContainerServiceFleetMemberOperationSource(Client), _containerServiceFleetMemberFleetMembersClientDiagnostics, Pipeline, _containerServiceFleetMemberFleetMembersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, ifMatch).Request, response, OperationFinalStateVia.Location, apiVersionOverrideValue: "2016-03-30");
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
        /// Update a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The resource properties to be updated. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<ContainerServiceFleetMemberResource> Update(WaitUntil waitUntil, ContainerServiceFleetMemberPatch patch, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberResource.Update");
            scope.Start();
            try
            {
                var response = _containerServiceFleetMemberFleetMembersRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, ifMatch, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation<ContainerServiceFleetMemberResource>(new ContainerServiceFleetMemberOperationSource(Client), _containerServiceFleetMemberFleetMembersClientDiagnostics, Pipeline, _containerServiceFleetMemberFleetMembersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, ifMatch).Request, response, OperationFinalStateVia.Location, apiVersionOverrideValue: "2016-03-30");
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
