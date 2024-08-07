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
using Azure.ResourceManager.MarketplaceOrdering.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    /// <summary>
    /// A class representing a collection of <see cref="MarketplaceAgreementTermResource"/> and their operations.
    /// Each <see cref="MarketplaceAgreementTermResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="MarketplaceAgreementTermCollection"/> instance call the GetMarketplaceAgreementTerms method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class MarketplaceAgreementTermCollection : ArmCollection
    {
        private readonly ClientDiagnostics _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics;
        private readonly MarketplaceAgreementsRestOperations _marketplaceAgreementTermMarketplaceAgreementsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAgreementTermCollection"/> class for mocking. </summary>
        protected MarketplaceAgreementTermCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAgreementTermCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MarketplaceAgreementTermCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MarketplaceOrdering", MarketplaceAgreementTermResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MarketplaceAgreementTermResource.ResourceType, out string marketplaceAgreementTermMarketplaceAgreementsApiVersion);
            _marketplaceAgreementTermMarketplaceAgreementsRestClient = new MarketplaceAgreementsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceAgreementTermMarketplaceAgreementsApiVersion);
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
        /// Save marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="data"> Parameters supplied to the Create Marketplace Terms operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/>, <paramref name="planId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MarketplaceAgreementTermResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AgreementOfferType offerType, string publisherId, string offerId, string planId, MarketplaceAgreementTermData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementTermMarketplaceAgreementsRestClient.CreateAsync(Id.SubscriptionId, offerType, publisherId, offerId, planId, data, cancellationToken).ConfigureAwait(false);
                var uri = _marketplaceAgreementTermMarketplaceAgreementsRestClient.CreateCreateRequestUri(Id.SubscriptionId, offerType, publisherId, offerId, planId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MarketplaceOrderingArmOperation<MarketplaceAgreementTermResource>(Response.FromValue(new MarketplaceAgreementTermResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Save marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="data"> Parameters supplied to the Create Marketplace Terms operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/>, <paramref name="planId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MarketplaceAgreementTermResource> CreateOrUpdate(WaitUntil waitUntil, AgreementOfferType offerType, string publisherId, string offerId, string planId, MarketplaceAgreementTermData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementTermMarketplaceAgreementsRestClient.Create(Id.SubscriptionId, offerType, publisherId, offerId, planId, data, cancellationToken);
                var uri = _marketplaceAgreementTermMarketplaceAgreementsRestClient.CreateCreateRequestUri(Id.SubscriptionId, offerType, publisherId, offerId, planId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MarketplaceOrderingArmOperation<MarketplaceAgreementTermResource>(Response.FromValue(new MarketplaceAgreementTermResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        public virtual async Task<Response<MarketplaceAgreementTermResource>> GetAsync(AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermCollection.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementTermMarketplaceAgreementsRestClient.GetAsync(Id.SubscriptionId, offerType, publisherId, offerId, planId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAgreementTermResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        public virtual Response<MarketplaceAgreementTermResource> Get(AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermCollection.Get");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementTermMarketplaceAgreementsRestClient.Get(Id.SubscriptionId, offerType, publisherId, offerId, planId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAgreementTermResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermCollection.Exists");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementTermMarketplaceAgreementsRestClient.GetAsync(Id.SubscriptionId, offerType, publisherId, offerId, planId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        public virtual Response<bool> Exists(AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermCollection.Exists");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementTermMarketplaceAgreementsRestClient.Get(Id.SubscriptionId, offerType, publisherId, offerId, planId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        public virtual async Task<NullableResponse<MarketplaceAgreementTermResource>> GetIfExistsAsync(AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementTermMarketplaceAgreementsRestClient.GetAsync(Id.SubscriptionId, offerType, publisherId, offerId, planId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MarketplaceAgreementTermResource>(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAgreementTermResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        public virtual NullableResponse<MarketplaceAgreementTermResource> GetIfExists(AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementTermMarketplaceAgreementsRestClient.Get(Id.SubscriptionId, offerType, publisherId, offerId, planId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MarketplaceAgreementTermResource>(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAgreementTermResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
