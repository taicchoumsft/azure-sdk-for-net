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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicalDatabaseTransparentDataEncryptionResource"/> and their operations.
    /// Each <see cref="LogicalDatabaseTransparentDataEncryptionResource"/> in the collection will belong to the same instance of <see cref="SqlDatabaseResource"/>.
    /// To get a <see cref="LogicalDatabaseTransparentDataEncryptionCollection"/> instance call the GetLogicalDatabaseTransparentDataEncryptions method from an instance of <see cref="SqlDatabaseResource"/>.
    /// </summary>
    public partial class LogicalDatabaseTransparentDataEncryptionCollection : ArmCollection, IEnumerable<LogicalDatabaseTransparentDataEncryptionResource>, IAsyncEnumerable<LogicalDatabaseTransparentDataEncryptionResource>
    {
        private readonly ClientDiagnostics _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics;
        private readonly TransparentDataEncryptionsRestOperations _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicalDatabaseTransparentDataEncryptionCollection"/> class for mocking. </summary>
        protected LogicalDatabaseTransparentDataEncryptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicalDatabaseTransparentDataEncryptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicalDatabaseTransparentDataEncryptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", LogicalDatabaseTransparentDataEncryptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicalDatabaseTransparentDataEncryptionResource.ResourceType, out string logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsApiVersion);
            _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient = new TransparentDataEncryptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates a logical database's transparent data encryption configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="data"> The database transparent data encryption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LogicalDatabaseTransparentDataEncryptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, TransparentDataEncryptionName tdeName, LogicalDatabaseTransparentDataEncryptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LogicalDatabaseTransparentDataEncryptionResource>(new LogicalDatabaseTransparentDataEncryptionOperationSource(Client), _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics, Pipeline, _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates a logical database's transparent data encryption configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="data"> The database transparent data encryption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LogicalDatabaseTransparentDataEncryptionResource> CreateOrUpdate(WaitUntil waitUntil, TransparentDataEncryptionName tdeName, LogicalDatabaseTransparentDataEncryptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, data, cancellationToken);
                var operation = new SqlArmOperation<LogicalDatabaseTransparentDataEncryptionResource>(new LogicalDatabaseTransparentDataEncryptionOperationSource(Client), _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics, Pipeline, _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a logical database's transparent data encryption.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogicalDatabaseTransparentDataEncryptionResource>> GetAsync(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicalDatabaseTransparentDataEncryptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a logical database's transparent data encryption.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogicalDatabaseTransparentDataEncryptionResource> Get(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryptionCollection.Get");
            scope.Start();
            try
            {
                var response = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicalDatabaseTransparentDataEncryptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of the logical database's transparent data encryption.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicalDatabaseTransparentDataEncryptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicalDatabaseTransparentDataEncryptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LogicalDatabaseTransparentDataEncryptionResource(Client, LogicalDatabaseTransparentDataEncryptionData.DeserializeLogicalDatabaseTransparentDataEncryptionData(e)), _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics, Pipeline, "LogicalDatabaseTransparentDataEncryptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of the logical database's transparent data encryption.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicalDatabaseTransparentDataEncryptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicalDatabaseTransparentDataEncryptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LogicalDatabaseTransparentDataEncryptionResource(Client, LogicalDatabaseTransparentDataEncryptionData.DeserializeLogicalDatabaseTransparentDataEncryptionData(e)), _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics, Pipeline, "LogicalDatabaseTransparentDataEncryptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<LogicalDatabaseTransparentDataEncryptionResource>> GetIfExistsAsync(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogicalDatabaseTransparentDataEncryptionResource>(response.GetRawResponse());
                return Response.FromValue(new LogicalDatabaseTransparentDataEncryptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TransparentDataEncryptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalDatabaseTransparentDataEncryptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<LogicalDatabaseTransparentDataEncryptionResource> GetIfExists(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogicalDatabaseTransparentDataEncryptionResource>(response.GetRawResponse());
                return Response.FromValue(new LogicalDatabaseTransparentDataEncryptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogicalDatabaseTransparentDataEncryptionResource> IEnumerable<LogicalDatabaseTransparentDataEncryptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogicalDatabaseTransparentDataEncryptionResource> IAsyncEnumerable<LogicalDatabaseTransparentDataEncryptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
