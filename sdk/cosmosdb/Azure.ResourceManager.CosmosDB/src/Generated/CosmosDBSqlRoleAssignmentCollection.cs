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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBSqlRoleAssignmentResource"/> and their operations.
    /// Each <see cref="CosmosDBSqlRoleAssignmentResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="CosmosDBSqlRoleAssignmentCollection"/> instance call the GetCosmosDBSqlRoleAssignments method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class CosmosDBSqlRoleAssignmentCollection : ArmCollection, IEnumerable<CosmosDBSqlRoleAssignmentResource>, IAsyncEnumerable<CosmosDBSqlRoleAssignmentResource>
    {
        private readonly ClientDiagnostics _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlRoleAssignmentSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleAssignmentCollection"/> class for mocking. </summary>
        protected CosmosDBSqlRoleAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBSqlRoleAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBSqlRoleAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBSqlRoleAssignmentResource.ResourceType, out string cosmosDBSqlRoleAssignmentSqlResourcesApiVersion);
            _cosmosDBSqlRoleAssignmentSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlRoleAssignmentSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB SQL Role Assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="content"> The properties required to create or update a Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlRoleAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleAssignmentId, CosmosDBSqlRoleAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateUpdateSqlRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlRoleAssignmentResource>(new CosmosDBSqlRoleAssignmentOperationSource(Client), _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateCreateUpdateSqlRoleAssignmentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB SQL Role Assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="content"> The properties required to create or update a Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlRoleAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string roleAssignmentId, CosmosDBSqlRoleAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateUpdateSqlRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlRoleAssignmentResource>(new CosmosDBSqlRoleAssignmentOperationSource(Client), _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateCreateUpdateSqlRoleAssignmentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves the properties of an existing Azure Cosmos DB SQL Role Assignment with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual async Task<Response<CosmosDBSqlRoleAssignmentResource>> GetAsync(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.GetSqlRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB SQL Role Assignment with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual Response<CosmosDBSqlRoleAssignmentResource> Get(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.GetSqlRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB SQL Role Assignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBSqlRoleAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBSqlRoleAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateListSqlRoleAssignmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBSqlRoleAssignmentResource(Client, CosmosDBSqlRoleAssignmentData.DeserializeCosmosDBSqlRoleAssignmentData(e)), _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlRoleAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB SQL Role Assignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBSqlRoleAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBSqlRoleAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateListSqlRoleAssignmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBSqlRoleAssignmentResource(Client, CosmosDBSqlRoleAssignmentData.DeserializeCosmosDBSqlRoleAssignmentData(e)), _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlRoleAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.GetSqlRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual Response<bool> Exists(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.GetSqlRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBSqlRoleAssignmentResource>> GetIfExistsAsync(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.GetSqlRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBSqlRoleAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual NullableResponse<CosmosDBSqlRoleAssignmentResource> GetIfExists(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.GetSqlRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBSqlRoleAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBSqlRoleAssignmentResource> IEnumerable<CosmosDBSqlRoleAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBSqlRoleAssignmentResource> IAsyncEnumerable<CosmosDBSqlRoleAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
