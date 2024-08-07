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

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A Class representing a DataBoxEdgeStorageAccountCredential along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DataBoxEdgeStorageAccountCredentialResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDataBoxEdgeStorageAccountCredentialResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataBoxEdgeDeviceResource"/> using the GetDataBoxEdgeStorageAccountCredential method.
    /// </summary>
    public partial class DataBoxEdgeStorageAccountCredentialResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataBoxEdgeStorageAccountCredentialResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="deviceName"> The deviceName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string deviceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccountCredentials/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics;
        private readonly StorageAccountCredentialsRestOperations _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient;
        private readonly DataBoxEdgeStorageAccountCredentialData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccountCredentials";

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeStorageAccountCredentialResource"/> class for mocking. </summary>
        protected DataBoxEdgeStorageAccountCredentialResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeStorageAccountCredentialResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataBoxEdgeStorageAccountCredentialResource(ArmClient client, DataBoxEdgeStorageAccountCredentialData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeStorageAccountCredentialResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataBoxEdgeStorageAccountCredentialResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsApiVersion);
            _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient = new StorageAccountCredentialsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataBoxEdgeStorageAccountCredentialData Data
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
        /// Gets the properties of the specified storage account credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccountCredentials/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccountCredentials_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeStorageAccountCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataBoxEdgeStorageAccountCredentialResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCredentialResource.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeStorageAccountCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified storage account credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccountCredentials/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccountCredentials_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeStorageAccountCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataBoxEdgeStorageAccountCredentialResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCredentialResource.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeStorageAccountCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the storage account credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccountCredentials/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccountCredentials_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeStorageAccountCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCredentialResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation(_dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics, Pipeline, _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the storage account credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccountCredentials/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccountCredentials_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeStorageAccountCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCredentialResource.Delete");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataBoxEdgeArmOperation(_dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics, Pipeline, _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates the storage account credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccountCredentials/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccountCredentials_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeStorageAccountCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The storage account credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeStorageAccountCredentialResource>> UpdateAsync(WaitUntil waitUntil, DataBoxEdgeStorageAccountCredentialData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCredentialResource.Update");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeStorageAccountCredentialResource>(new DataBoxEdgeStorageAccountCredentialOperationSource(Client), _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics, Pipeline, _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates the storage account credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccountCredentials/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccountCredentials_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeStorageAccountCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The storage account credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeStorageAccountCredentialResource> Update(WaitUntil waitUntil, DataBoxEdgeStorageAccountCredentialData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCredentialResource.Update");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeStorageAccountCredentialResource>(new DataBoxEdgeStorageAccountCredentialOperationSource(Client), _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsClientDiagnostics, Pipeline, _dataBoxEdgeStorageAccountCredentialStorageAccountCredentialsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
