// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableEventGridTenantResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableEventGridTenantResource"/> class for mocking. </summary>
        protected MockableEventGridTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableEventGridTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableEventGridTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of TopicTypeResources in the TenantResource. </summary>
        /// <returns> An object representing collection of TopicTypeResources and their operations over a TopicTypeResource. </returns>
        public virtual TopicTypeCollection GetTopicTypes()
        {
            return GetCachedClient(client => new TopicTypeCollection(client, Id));
        }

        /// <summary>
        /// Get information about a topic type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TopicTypeResource>> GetTopicTypeAsync(string topicTypeName, CancellationToken cancellationToken = default)
        {
            return await GetTopicTypes().GetAsync(topicTypeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about a topic type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TopicTypeResource> GetTopicType(string topicTypeName, CancellationToken cancellationToken = default)
        {
            return GetTopicTypes().Get(topicTypeName, cancellationToken);
        }

        /// <summary> Gets a collection of VerifiedPartnerResources in the TenantResource. </summary>
        /// <returns> An object representing collection of VerifiedPartnerResources and their operations over a VerifiedPartnerResource. </returns>
        public virtual VerifiedPartnerCollection GetVerifiedPartners()
        {
            return GetCachedClient(client => new VerifiedPartnerCollection(client, Id));
        }

        /// <summary>
        /// Get properties of a verified partner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/verifiedPartners/{verifiedPartnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VerifiedPartners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VerifiedPartnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="verifiedPartnerName"> Name of the verified partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="verifiedPartnerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="verifiedPartnerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VerifiedPartnerResource>> GetVerifiedPartnerAsync(string verifiedPartnerName, CancellationToken cancellationToken = default)
        {
            return await GetVerifiedPartners().GetAsync(verifiedPartnerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of a verified partner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/verifiedPartners/{verifiedPartnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VerifiedPartners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VerifiedPartnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="verifiedPartnerName"> Name of the verified partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="verifiedPartnerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="verifiedPartnerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VerifiedPartnerResource> GetVerifiedPartner(string verifiedPartnerName, CancellationToken cancellationToken = default)
        {
            return GetVerifiedPartners().Get(verifiedPartnerName, cancellationToken);
        }
    }
}
