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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualMachineExtensionImageResource"/> and their operations.
    /// Each <see cref="VirtualMachineExtensionImageResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="VirtualMachineExtensionImageCollection"/> instance call the GetVirtualMachineExtensionImages method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class VirtualMachineExtensionImageCollection : ArmCollection, IEnumerable<VirtualMachineExtensionImageResource>, IAsyncEnumerable<VirtualMachineExtensionImageResource>
    {
        private readonly ClientDiagnostics _virtualMachineExtensionImageClientDiagnostics;
        private readonly VirtualMachineExtensionImagesRestOperations _virtualMachineExtensionImageRestClient;
        private readonly AzureLocation _location;
        private readonly string _publisherName;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineExtensionImageCollection"/> class for mocking. </summary>
        protected VirtualMachineExtensionImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineExtensionImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The <see cref="string"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        internal VirtualMachineExtensionImageCollection(ArmClient client, ResourceIdentifier id, AzureLocation location, string publisherName) : base(client, id)
        {
            _location = location;
            _publisherName = publisherName;
            _virtualMachineExtensionImageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", VirtualMachineExtensionImageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualMachineExtensionImageResource.ResourceType, out string virtualMachineExtensionImageApiVersion);
            _virtualMachineExtensionImageRestClient = new VirtualMachineExtensionImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineExtensionImageApiVersion);
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
        /// Gets a virtual machine extension image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="type"> The <see cref="string"/> to use. </param>
        /// <param name="version"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineExtensionImageResource>> GetAsync(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _virtualMachineExtensionImageClientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), _publisherName, type, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineExtensionImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a virtual machine extension image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="type"> The <see cref="string"/> to use. </param>
        /// <param name="version"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual Response<VirtualMachineExtensionImageResource> Get(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _virtualMachineExtensionImageClientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImageRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), _publisherName, type, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineExtensionImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of virtual machine extension image types.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_ListTypes</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineExtensionImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineExtensionImageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineExtensionImageRestClient.CreateListTypesRequest(Id.SubscriptionId, new AzureLocation(_location), _publisherName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new VirtualMachineExtensionImageResource(Client, VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(e)), _virtualMachineExtensionImageClientDiagnostics, Pipeline, "VirtualMachineExtensionImageCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of virtual machine extension image types.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_ListTypes</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineExtensionImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineExtensionImageResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineExtensionImageRestClient.CreateListTypesRequest(Id.SubscriptionId, new AzureLocation(_location), _publisherName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new VirtualMachineExtensionImageResource(Client, VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(e)), _virtualMachineExtensionImageClientDiagnostics, Pipeline, "VirtualMachineExtensionImageCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of virtual machine extension image versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_ListVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="type"> The <see cref="string"/> to use. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The <see cref="int"/>? to use. </param>
        /// <param name="orderby"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> is null. </exception>
        /// <returns> An async collection of <see cref="VirtualMachineExtensionImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineExtensionImageResource> GetAllAsync(string type, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineExtensionImageRestClient.CreateListVersionsRequest(Id.SubscriptionId, new AzureLocation(_location), _publisherName, type, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new VirtualMachineExtensionImageResource(Client, VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(e)), _virtualMachineExtensionImageClientDiagnostics, Pipeline, "VirtualMachineExtensionImageCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of virtual machine extension image versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_ListVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="type"> The <see cref="string"/> to use. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The <see cref="int"/>? to use. </param>
        /// <param name="orderby"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> is null. </exception>
        /// <returns> A collection of <see cref="VirtualMachineExtensionImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineExtensionImageResource> GetAll(string type, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineExtensionImageRestClient.CreateListVersionsRequest(Id.SubscriptionId, new AzureLocation(_location), _publisherName, type, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new VirtualMachineExtensionImageResource(Client, VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(e)), _virtualMachineExtensionImageClientDiagnostics, Pipeline, "VirtualMachineExtensionImageCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="type"> The <see cref="string"/> to use. </param>
        /// <param name="version"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _virtualMachineExtensionImageClientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), _publisherName, type, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="type"> The <see cref="string"/> to use. </param>
        /// <param name="version"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _virtualMachineExtensionImageClientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImageRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), _publisherName, type, version, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="type"> The <see cref="string"/> to use. </param>
        /// <param name="version"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualMachineExtensionImageResource>> GetIfExistsAsync(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _virtualMachineExtensionImageClientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), _publisherName, type, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualMachineExtensionImageResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineExtensionImageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineExtensionImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineExtensionImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="type"> The <see cref="string"/> to use. </param>
        /// <param name="version"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual NullableResponse<VirtualMachineExtensionImageResource> GetIfExists(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _virtualMachineExtensionImageClientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImageRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), _publisherName, type, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualMachineExtensionImageResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineExtensionImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineExtensionImageResource> IEnumerable<VirtualMachineExtensionImageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineExtensionImageResource> IAsyncEnumerable<VirtualMachineExtensionImageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
