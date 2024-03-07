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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleEligibilityScheduleInstanceResource"/> and their operations.
    /// Each <see cref="RoleEligibilityScheduleInstanceResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="RoleEligibilityScheduleInstanceCollection"/> instance call the GetRoleEligibilityScheduleInstances method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class RoleEligibilityScheduleInstanceCollection : ArmCollection, IEnumerable<RoleEligibilityScheduleInstanceResource>, IAsyncEnumerable<RoleEligibilityScheduleInstanceResource>
    {
        private readonly ClientDiagnostics _roleEligibilityScheduleInstanceClientDiagnostics;
        private readonly RoleEligibilityScheduleInstancesRestOperations _roleEligibilityScheduleInstanceRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleInstanceCollection"/> class for mocking. </summary>
        protected RoleEligibilityScheduleInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleEligibilityScheduleInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleEligibilityScheduleInstanceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleEligibilityScheduleInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleEligibilityScheduleInstanceResource.ResourceType, out string roleEligibilityScheduleInstanceApiVersion);
            _roleEligibilityScheduleInstanceRestClient = new RoleEligibilityScheduleInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleEligibilityScheduleInstanceApiVersion);
        }

        /// <summary>
        /// Gets the specified role eligibility schedule instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        public virtual async Task<Response<RoleEligibilityScheduleInstanceResource>> GetAsync(string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleInstanceName, nameof(roleEligibilityScheduleInstanceName));

            using var scope = _roleEligibilityScheduleInstanceClientDiagnostics.CreateScope("RoleEligibilityScheduleInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleInstanceRestClient.GetAsync(Id, roleEligibilityScheduleInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified role eligibility schedule instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        public virtual Response<RoleEligibilityScheduleInstanceResource> Get(string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleInstanceName, nameof(roleEligibilityScheduleInstanceName));

            using var scope = _roleEligibilityScheduleInstanceClientDiagnostics.CreateScope("RoleEligibilityScheduleInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleInstanceRestClient.Get(Id, roleEligibilityScheduleInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role eligibility schedule instances of a role eligibility schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_ListForScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal. Use $filter=assignedTo('{userId}') to return all role eligibility schedules for the user. Use $filter=asTarget() to return all role eligibility schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleEligibilityScheduleInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleEligibilityScheduleInstanceResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleEligibilityScheduleInstanceRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleEligibilityScheduleInstanceRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RoleEligibilityScheduleInstanceResource(Client, RoleEligibilityScheduleInstanceData.DeserializeRoleEligibilityScheduleInstanceData(e)), _roleEligibilityScheduleInstanceClientDiagnostics, Pipeline, "RoleEligibilityScheduleInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets role eligibility schedule instances of a role eligibility schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_ListForScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal. Use $filter=assignedTo('{userId}') to return all role eligibility schedules for the user. Use $filter=asTarget() to return all role eligibility schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleEligibilityScheduleInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleEligibilityScheduleInstanceResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleEligibilityScheduleInstanceRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleEligibilityScheduleInstanceRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RoleEligibilityScheduleInstanceResource(Client, RoleEligibilityScheduleInstanceData.DeserializeRoleEligibilityScheduleInstanceData(e)), _roleEligibilityScheduleInstanceClientDiagnostics, Pipeline, "RoleEligibilityScheduleInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleInstanceName, nameof(roleEligibilityScheduleInstanceName));

            using var scope = _roleEligibilityScheduleInstanceClientDiagnostics.CreateScope("RoleEligibilityScheduleInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleInstanceRestClient.GetAsync(Id, roleEligibilityScheduleInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleInstanceName, nameof(roleEligibilityScheduleInstanceName));

            using var scope = _roleEligibilityScheduleInstanceClientDiagnostics.CreateScope("RoleEligibilityScheduleInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleInstanceRestClient.Get(Id, roleEligibilityScheduleInstanceName, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        public virtual async Task<NullableResponse<RoleEligibilityScheduleInstanceResource>> GetIfExistsAsync(string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleInstanceName, nameof(roleEligibilityScheduleInstanceName));

            using var scope = _roleEligibilityScheduleInstanceClientDiagnostics.CreateScope("RoleEligibilityScheduleInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleInstanceRestClient.GetAsync(Id, roleEligibilityScheduleInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RoleEligibilityScheduleInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleInstanceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        public virtual NullableResponse<RoleEligibilityScheduleInstanceResource> GetIfExists(string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleInstanceName, nameof(roleEligibilityScheduleInstanceName));

            using var scope = _roleEligibilityScheduleInstanceClientDiagnostics.CreateScope("RoleEligibilityScheduleInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleInstanceRestClient.Get(Id, roleEligibilityScheduleInstanceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RoleEligibilityScheduleInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleEligibilityScheduleInstanceResource> IEnumerable<RoleEligibilityScheduleInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleEligibilityScheduleInstanceResource> IAsyncEnumerable<RoleEligibilityScheduleInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
