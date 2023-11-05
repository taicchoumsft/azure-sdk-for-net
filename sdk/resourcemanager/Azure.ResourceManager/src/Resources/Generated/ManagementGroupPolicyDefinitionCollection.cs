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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementGroups;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagementGroupPolicyDefinitionResource" /> and their operations.
    /// Each <see cref="ManagementGroupPolicyDefinitionResource" /> in the collection will belong to the same instance of <see cref="ManagementGroupResource" />.
    /// To get a <see cref="ManagementGroupPolicyDefinitionCollection" /> instance call the GetManagementGroupPolicyDefinitions method from an instance of <see cref="ManagementGroupResource" />.
    /// </summary>
    public partial class ManagementGroupPolicyDefinitionCollection : ArmCollection, IEnumerable<ManagementGroupPolicyDefinitionResource>, IAsyncEnumerable<ManagementGroupPolicyDefinitionResource>
    {
        private readonly ClientDiagnostics _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics;
        private readonly PolicyDefinitionsRestOperations _managementGroupPolicyDefinitionPolicyDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinitionCollection"/> class for mocking. </summary>
        protected ManagementGroupPolicyDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagementGroupPolicyDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ManagementGroupPolicyDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagementGroupPolicyDefinitionResource.ResourceType, out string managementGroupPolicyDefinitionPolicyDefinitionsApiVersion);
            _managementGroupPolicyDefinitionPolicyDefinitionsRestClient = new PolicyDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managementGroupPolicyDefinitionPolicyDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagementGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagementGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// This operation creates or updates a policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_CreateOrUpdateAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="data"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagementGroupPolicyDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyDefinitionName, PolicyDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateOrUpdateAtManagementGroupAsync(Id.Name, policyDefinitionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<ManagementGroupPolicyDefinitionResource>(Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response), response.GetRawResponse()));
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
        /// This operation creates or updates a policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_CreateOrUpdateAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="data"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagementGroupPolicyDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string policyDefinitionName, PolicyDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateOrUpdateAtManagementGroup(Id.Name, policyDefinitionName, data, cancellationToken);
                var operation = new ResourcesArmOperation<ManagementGroupPolicyDefinitionResource>(Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response), response.GetRawResponse()));
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
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<ManagementGroupPolicyDefinitionResource>> GetAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policyDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<ManagementGroupPolicyDefinitionResource> Get(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroup(Id.Name, policyDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves a list of all the policy definitions in a given management group that match the optional given $filter. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, the unfiltered list includes all policy definitions associated with the management group, including those that apply directly or from management groups that contain the given management group. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given management group. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy definitions whose category match the {value}.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_ListByManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementGroupPolicyDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagementGroupPolicyDefinitionResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateListByManagementGroupRequest(Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateListByManagementGroupNextPageRequest(nextLink, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagementGroupPolicyDefinitionResource(Client, PolicyDefinitionData.DeserializePolicyDefinitionData(e)), _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics, Pipeline, "ManagementGroupPolicyDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This operation retrieves a list of all the policy definitions in a given management group that match the optional given $filter. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, the unfiltered list includes all policy definitions associated with the management group, including those that apply directly or from management groups that contain the given management group. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given management group. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy definitions whose category match the {value}.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_ListByManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementGroupPolicyDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagementGroupPolicyDefinitionResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateListByManagementGroupRequest(Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateListByManagementGroupNextPageRequest(nextLink, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagementGroupPolicyDefinitionResource(Client, PolicyDefinitionData.DeserializePolicyDefinitionData(e)), _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics, Pipeline, "ManagementGroupPolicyDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroup(Id.Name, policyDefinitionName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagementGroupPolicyDefinitionResource>> GetIfExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagementGroupPolicyDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual NullableResponse<ManagementGroupPolicyDefinitionResource> GetIfExists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroup(Id.Name, policyDefinitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagementGroupPolicyDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagementGroupPolicyDefinitionResource> IEnumerable<ManagementGroupPolicyDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagementGroupPolicyDefinitionResource> IAsyncEnumerable<ManagementGroupPolicyDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
