// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="GovernanceRuleResource"/> and their operations.
    /// Each <see cref="GovernanceRuleResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="GovernanceRuleCollection"/> instance call the GetGovernanceRules method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class GovernanceRuleCollection : ArmCollection, IEnumerable<GovernanceRuleResource>, IAsyncEnumerable<GovernanceRuleResource>
    {
        private readonly ClientDiagnostics _governanceRuleClientDiagnostics;
        private readonly GovernanceRulesRestOperations _governanceRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="GovernanceRuleCollection"/> class for mocking. </summary>
        protected GovernanceRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GovernanceRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GovernanceRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _governanceRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", GovernanceRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GovernanceRuleResource.ResourceType, out string governanceRuleApiVersion);
            _governanceRuleRestClient = new GovernanceRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, governanceRuleApiVersion);
        }

        /// <summary>
        /// Creates or updates a governance rule over a given scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleId"> The governance rule key - unique key for the standard governance rule (GUID). </param>
        /// <param name="data"> Governance rule over a given scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GovernanceRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleId, GovernanceRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _governanceRuleRestClient.CreateOrUpdateAsync(Id, ruleId, data, cancellationToken).ConfigureAwait(false);
                var uri = _governanceRuleRestClient.CreateCreateOrUpdateRequestUri(Id, ruleId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation<GovernanceRuleResource>(Response.FromValue(new GovernanceRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a governance rule over a given scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleId"> The governance rule key - unique key for the standard governance rule (GUID). </param>
        /// <param name="data"> Governance rule over a given scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GovernanceRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleId, GovernanceRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _governanceRuleRestClient.CreateOrUpdate(Id, ruleId, data, cancellationToken);
                var uri = _governanceRuleRestClient.CreateCreateOrUpdateRequestUri(Id, ruleId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation<GovernanceRuleResource>(Response.FromValue(new GovernanceRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get a specific governance rule for the requested scope by ruleId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The governance rule key - unique key for the standard governance rule (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual async Task<Response<GovernanceRuleResource>> GetAsync(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _governanceRuleRestClient.GetAsync(Id, ruleId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific governance rule for the requested scope by ruleId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The governance rule key - unique key for the standard governance rule (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual Response<GovernanceRuleResource> Get(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _governanceRuleRestClient.Get(Id, ruleId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all relevant governance rules over a scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GovernanceRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GovernanceRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _governanceRuleRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _governanceRuleRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GovernanceRuleResource(Client, GovernanceRuleData.DeserializeGovernanceRuleData(e)), _governanceRuleClientDiagnostics, Pipeline, "GovernanceRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all relevant governance rules over a scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GovernanceRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GovernanceRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _governanceRuleRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _governanceRuleRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GovernanceRuleResource(Client, GovernanceRuleData.DeserializeGovernanceRuleData(e)), _governanceRuleClientDiagnostics, Pipeline, "GovernanceRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The governance rule key - unique key for the standard governance rule (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _governanceRuleRestClient.GetAsync(Id, ruleId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The governance rule key - unique key for the standard governance rule (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _governanceRuleRestClient.Get(Id, ruleId, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The governance rule key - unique key for the standard governance rule (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual async Task<NullableResponse<GovernanceRuleResource>> GetIfExistsAsync(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _governanceRuleRestClient.GetAsync(Id, ruleId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GovernanceRuleResource>(response.GetRawResponse());
                return Response.FromValue(new GovernanceRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GovernanceRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The governance rule key - unique key for the standard governance rule (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual NullableResponse<GovernanceRuleResource> GetIfExists(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _governanceRuleRestClient.Get(Id, ruleId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GovernanceRuleResource>(response.GetRawResponse());
                return Response.FromValue(new GovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GovernanceRuleResource> IEnumerable<GovernanceRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GovernanceRuleResource> IAsyncEnumerable<GovernanceRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
