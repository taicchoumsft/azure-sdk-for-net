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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBLocationResource"/> and their operations.
    /// Each <see cref="CosmosDBLocationResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="CosmosDBLocationCollection"/> instance call the GetCosmosDBLocations method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class CosmosDBLocationCollection : ArmCollection, IEnumerable<CosmosDBLocationResource>, IAsyncEnumerable<CosmosDBLocationResource>
    {
        private readonly ClientDiagnostics _cosmosDBLocationLocationsClientDiagnostics;
        private readonly LocationsRestOperations _cosmosDBLocationLocationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBLocationCollection"/> class for mocking. </summary>
        protected CosmosDBLocationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBLocationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBLocationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBLocationLocationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBLocationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBLocationResource.ResourceType, out string cosmosDBLocationLocationsApiVersion);
            _cosmosDBLocationLocationsRestClient = new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBLocationLocationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the properties of an existing Cosmos DB location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosDBLocationResource>> GetAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBLocationLocationsRestClient.GetAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of an existing Cosmos DB location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBLocationResource> Get(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBLocationLocationsRestClient.Get(Id.SubscriptionId, location, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Cosmos DB locations and their properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBLocationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBLocationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBLocationLocationsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBLocationResource(Client, CosmosDBLocationData.DeserializeCosmosDBLocationData(e)), _cosmosDBLocationLocationsClientDiagnostics, Pipeline, "CosmosDBLocationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List Cosmos DB locations and their properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBLocationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBLocationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBLocationLocationsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBLocationResource(Client, CosmosDBLocationData.DeserializeCosmosDBLocationData(e)), _cosmosDBLocationLocationsClientDiagnostics, Pipeline, "CosmosDBLocationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBLocationLocationsRestClient.GetAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBLocationLocationsRestClient.Get(Id.SubscriptionId, location, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<CosmosDBLocationResource>> GetIfExistsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBLocationLocationsRestClient.GetAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBLocationResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<CosmosDBLocationResource> GetIfExists(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBLocationLocationsRestClient.Get(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBLocationResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBLocationResource> IEnumerable<CosmosDBLocationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBLocationResource> IAsyncEnumerable<CosmosDBLocationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
