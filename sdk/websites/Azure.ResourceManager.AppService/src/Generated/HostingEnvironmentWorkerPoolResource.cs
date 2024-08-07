// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a HostingEnvironmentWorkerPool along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HostingEnvironmentWorkerPoolResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHostingEnvironmentWorkerPoolResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServiceEnvironmentResource"/> using the GetHostingEnvironmentWorkerPool method.
    /// </summary>
    public partial class HostingEnvironmentWorkerPoolResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HostingEnvironmentWorkerPoolResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="workerPoolName"> The workerPoolName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string workerPoolName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient;
        private readonly AppServiceWorkerPoolData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/workerPools";

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPoolResource"/> class for mocking. </summary>
        protected HostingEnvironmentWorkerPoolResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HostingEnvironmentWorkerPoolResource(ArmClient client, AppServiceWorkerPoolData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentWorkerPoolResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hostingEnvironmentWorkerPoolAppServiceEnvironmentsApiVersion);
            _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentWorkerPoolAppServiceEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppServiceWorkerPoolData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get properties of a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetWorkerPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HostingEnvironmentWorkerPoolResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolResource.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.GetWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentWorkerPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get properties of a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetWorkerPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HostingEnvironmentWorkerPoolResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolResource.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.GetWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentWorkerPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_UpdateWorkerPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Properties of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<HostingEnvironmentWorkerPoolResource>> UpdateAsync(AppServiceWorkerPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolResource.Update");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.UpdateWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentWorkerPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_UpdateWorkerPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Properties of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<HostingEnvironmentWorkerPoolResource> Update(AppServiceWorkerPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolResource.Update");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.UpdateWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new HostingEnvironmentWorkerPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get metric definitions for a specific instance of a worker pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/instances/{instance}/metricdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWorkerPoolInstanceMetricDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instance"> Name of the instance in the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instance"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetWorkerPoolInstanceMetricDefinitionsAsync(string instance, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instance, nameof(instance));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolInstanceMetricDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, instance);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolInstanceMetricDefinitionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, instance);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ResourceMetricDefinition.DeserializeResourceMetricDefinition(e), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolResource.GetWorkerPoolInstanceMetricDefinitions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get metric definitions for a specific instance of a worker pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/instances/{instance}/metricdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWorkerPoolInstanceMetricDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instance"> Name of the instance in the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instance"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceMetricDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetWorkerPoolInstanceMetricDefinitions(string instance, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instance, nameof(instance));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolInstanceMetricDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, instance);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolInstanceMetricDefinitionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, instance);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ResourceMetricDefinition.DeserializeResourceMetricDefinition(e), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolResource.GetWorkerPoolInstanceMetricDefinitions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get metric definitions for a worker pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/metricdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWebWorkerMetricDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetWebWorkerMetricDefinitionsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWebWorkerMetricDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWebWorkerMetricDefinitionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ResourceMetricDefinition.DeserializeResourceMetricDefinition(e), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolResource.GetWebWorkerMetricDefinitions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get metric definitions for a worker pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/metricdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWebWorkerMetricDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceMetricDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetWebWorkerMetricDefinitions(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWebWorkerMetricDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWebWorkerMetricDefinitionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ResourceMetricDefinition.DeserializeResourceMetricDefinition(e), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolResource.GetWebWorkerMetricDefinitions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available SKUs for scaling a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWorkerPoolSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServicePoolSkuInfo"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServicePoolSkuInfo> GetWorkerPoolSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolSkusRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolSkusNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => AppServicePoolSkuInfo.DeserializeAppServicePoolSkuInfo(e), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolResource.GetWorkerPoolSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available SKUs for scaling a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWorkerPoolSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServicePoolSkuInfo"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServicePoolSkuInfo> GetWorkerPoolSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolSkusRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolSkusNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => AppServicePoolSkuInfo.DeserializeAppServicePoolSkuInfo(e), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolResource.GetWorkerPoolSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get usage metrics for a worker pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWebWorkerUsages</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceUsage> GetWebWorkerUsagesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWebWorkerUsagesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWebWorkerUsagesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => AppServiceUsage.DeserializeAppServiceUsage(e), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolResource.GetWebWorkerUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get usage metrics for a worker pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWebWorkerUsages</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentWorkerPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceUsage> GetWebWorkerUsages(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWebWorkerUsagesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWebWorkerUsagesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => AppServiceUsage.DeserializeAppServiceUsage(e), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolResource.GetWebWorkerUsages", "value", "nextLink", cancellationToken);
        }
    }
}
