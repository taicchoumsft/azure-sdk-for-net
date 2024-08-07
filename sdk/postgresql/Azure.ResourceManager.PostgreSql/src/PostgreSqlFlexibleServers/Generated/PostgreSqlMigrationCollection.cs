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
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlMigrationResource"/> and their operations.
    /// Each <see cref="PostgreSqlMigrationResource"/> in the collection will belong to the same instance of <see cref="PostgreSqlFlexibleServerResource"/>.
    /// To get a <see cref="PostgreSqlMigrationCollection"/> instance call the GetPostgreSqlMigrations method from an instance of <see cref="PostgreSqlFlexibleServerResource"/>.
    /// </summary>
    public partial class PostgreSqlMigrationCollection : ArmCollection, IEnumerable<PostgreSqlMigrationResource>, IAsyncEnumerable<PostgreSqlMigrationResource>
    {
        private readonly ClientDiagnostics _postgreSqlMigrationMigrationsClientDiagnostics;
        private readonly MigrationsRestOperations _postgreSqlMigrationMigrationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlMigrationCollection"/> class for mocking. </summary>
        protected PostgreSqlMigrationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlMigrationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlMigrationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlMigrationMigrationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", PostgreSqlMigrationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlMigrationResource.ResourceType, out string postgreSqlMigrationMigrationsApiVersion);
            _postgreSqlMigrationMigrationsRestClient = new MigrationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlMigrationMigrationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new migration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="migrationName"> The name of the migration. </param>
        /// <param name="data"> The required parameters for creating a migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="migrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlMigrationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string migrationName, PostgreSqlMigrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(migrationName, nameof(migrationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlMigrationMigrationsClientDiagnostics.CreateScope("PostgreSqlMigrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlMigrationMigrationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, data, cancellationToken).ConfigureAwait(false);
                var uri = _postgreSqlMigrationMigrationsRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new FlexibleServersArmOperation<PostgreSqlMigrationResource>(Response.FromValue(new PostgreSqlMigrationResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates a new migration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="migrationName"> The name of the migration. </param>
        /// <param name="data"> The required parameters for creating a migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="migrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlMigrationResource> CreateOrUpdate(WaitUntil waitUntil, string migrationName, PostgreSqlMigrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(migrationName, nameof(migrationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlMigrationMigrationsClientDiagnostics.CreateScope("PostgreSqlMigrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlMigrationMigrationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, data, cancellationToken);
                var uri = _postgreSqlMigrationMigrationsRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new FlexibleServersArmOperation<PostgreSqlMigrationResource>(Response.FromValue(new PostgreSqlMigrationResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets details of a migration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="migrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlMigrationResource>> GetAsync(string migrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(migrationName, nameof(migrationName));

            using var scope = _postgreSqlMigrationMigrationsClientDiagnostics.CreateScope("PostgreSqlMigrationCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlMigrationMigrationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlMigrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details of a migration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="migrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationName"/> is null. </exception>
        public virtual Response<PostgreSqlMigrationResource> Get(string migrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(migrationName, nameof(migrationName));

            using var scope = _postgreSqlMigrationMigrationsClientDiagnostics.CreateScope("PostgreSqlMigrationCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlMigrationMigrationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlMigrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the migrations on a given target server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_ListByTargetServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationListFilter"> Migration list filter. Retrieves either active migrations or all migrations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlMigrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlMigrationResource> GetAllAsync(PostgreSqlMigrationListFilter? migrationListFilter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlMigrationMigrationsRestClient.CreateListByTargetServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationListFilter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlMigrationMigrationsRestClient.CreateListByTargetServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationListFilter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlMigrationResource(Client, PostgreSqlMigrationData.DeserializePostgreSqlMigrationData(e)), _postgreSqlMigrationMigrationsClientDiagnostics, Pipeline, "PostgreSqlMigrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the migrations on a given target server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_ListByTargetServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationListFilter"> Migration list filter. Retrieves either active migrations or all migrations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlMigrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlMigrationResource> GetAll(PostgreSqlMigrationListFilter? migrationListFilter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlMigrationMigrationsRestClient.CreateListByTargetServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationListFilter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlMigrationMigrationsRestClient.CreateListByTargetServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationListFilter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlMigrationResource(Client, PostgreSqlMigrationData.DeserializePostgreSqlMigrationData(e)), _postgreSqlMigrationMigrationsClientDiagnostics, Pipeline, "PostgreSqlMigrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="migrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string migrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(migrationName, nameof(migrationName));

            using var scope = _postgreSqlMigrationMigrationsClientDiagnostics.CreateScope("PostgreSqlMigrationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlMigrationMigrationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="migrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationName"/> is null. </exception>
        public virtual Response<bool> Exists(string migrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(migrationName, nameof(migrationName));

            using var scope = _postgreSqlMigrationMigrationsClientDiagnostics.CreateScope("PostgreSqlMigrationCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlMigrationMigrationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="migrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationName"/> is null. </exception>
        public virtual async Task<NullableResponse<PostgreSqlMigrationResource>> GetIfExistsAsync(string migrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(migrationName, nameof(migrationName));

            using var scope = _postgreSqlMigrationMigrationsClientDiagnostics.CreateScope("PostgreSqlMigrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _postgreSqlMigrationMigrationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlMigrationResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlMigrationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{targetDbServerName}/migrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Migrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="migrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationName"/> is null. </exception>
        public virtual NullableResponse<PostgreSqlMigrationResource> GetIfExists(string migrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(migrationName, nameof(migrationName));

            using var scope = _postgreSqlMigrationMigrationsClientDiagnostics.CreateScope("PostgreSqlMigrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _postgreSqlMigrationMigrationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlMigrationResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlMigrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlMigrationResource> IEnumerable<PostgreSqlMigrationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlMigrationResource> IAsyncEnumerable<PostgreSqlMigrationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
