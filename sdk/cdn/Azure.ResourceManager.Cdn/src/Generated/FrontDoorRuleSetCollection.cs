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

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontDoorRuleSetResource"/> and their operations.
    /// Each <see cref="FrontDoorRuleSetResource"/> in the collection will belong to the same instance of <see cref="ProfileResource"/>.
    /// To get a <see cref="FrontDoorRuleSetCollection"/> instance call the GetFrontDoorRuleSets method from an instance of <see cref="ProfileResource"/>.
    /// </summary>
    public partial class FrontDoorRuleSetCollection : ArmCollection, IEnumerable<FrontDoorRuleSetResource>, IAsyncEnumerable<FrontDoorRuleSetResource>
    {
        private readonly ClientDiagnostics _frontDoorRuleSetClientDiagnostics;
        private readonly FrontDoorRuleSetsRestOperations _frontDoorRuleSetRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontDoorRuleSetCollection"/> class for mocking. </summary>
        protected FrontDoorRuleSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorRuleSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontDoorRuleSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorRuleSetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", FrontDoorRuleSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontDoorRuleSetResource.ResourceType, out string frontDoorRuleSetApiVersion);
            _frontDoorRuleSetRestClient = new FrontDoorRuleSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorRuleSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new rule set within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorRuleSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _frontDoorRuleSetClientDiagnostics.CreateScope("FrontDoorRuleSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _frontDoorRuleSetRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken).ConfigureAwait(false);
                var uri = _frontDoorRuleSetRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new CdnArmOperation<FrontDoorRuleSetResource>(Response.FromValue(new FrontDoorRuleSetResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates a new rule set within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual ArmOperation<FrontDoorRuleSetResource> CreateOrUpdate(WaitUntil waitUntil, string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _frontDoorRuleSetClientDiagnostics.CreateScope("FrontDoorRuleSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _frontDoorRuleSetRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken);
                var uri = _frontDoorRuleSetRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new CdnArmOperation<FrontDoorRuleSetResource>(Response.FromValue(new FrontDoorRuleSetResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets an existing AzureFrontDoor rule set with the specified rule set name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<FrontDoorRuleSetResource>> GetAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _frontDoorRuleSetClientDiagnostics.CreateScope("FrontDoorRuleSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorRuleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorRuleSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing AzureFrontDoor rule set with the specified rule set name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<FrontDoorRuleSetResource> Get(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _frontDoorRuleSetClientDiagnostics.CreateScope("FrontDoorRuleSetCollection.Get");
            scope.Start();
            try
            {
                var response = _frontDoorRuleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorRuleSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists existing AzureFrontDoor rule sets within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_ListByProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorRuleSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorRuleSetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorRuleSetRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorRuleSetRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontDoorRuleSetResource(Client, FrontDoorRuleSetData.DeserializeFrontDoorRuleSetData(e)), _frontDoorRuleSetClientDiagnostics, Pipeline, "FrontDoorRuleSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists existing AzureFrontDoor rule sets within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_ListByProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorRuleSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorRuleSetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorRuleSetRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorRuleSetRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontDoorRuleSetResource(Client, FrontDoorRuleSetData.DeserializeFrontDoorRuleSetData(e)), _frontDoorRuleSetClientDiagnostics, Pipeline, "FrontDoorRuleSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _frontDoorRuleSetClientDiagnostics.CreateScope("FrontDoorRuleSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontDoorRuleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _frontDoorRuleSetClientDiagnostics.CreateScope("FrontDoorRuleSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontDoorRuleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<NullableResponse<FrontDoorRuleSetResource>> GetIfExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _frontDoorRuleSetClientDiagnostics.CreateScope("FrontDoorRuleSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _frontDoorRuleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FrontDoorRuleSetResource>(response.GetRawResponse());
                return Response.FromValue(new FrontDoorRuleSetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRuleSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorRuleSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual NullableResponse<FrontDoorRuleSetResource> GetIfExists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _frontDoorRuleSetClientDiagnostics.CreateScope("FrontDoorRuleSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _frontDoorRuleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FrontDoorRuleSetResource>(response.GetRawResponse());
                return Response.FromValue(new FrontDoorRuleSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontDoorRuleSetResource> IEnumerable<FrontDoorRuleSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontDoorRuleSetResource> IAsyncEnumerable<FrontDoorRuleSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
