// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Hci.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableHciSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _galleryImageClientDiagnostics;
        private GalleryImagesRestOperations _galleryImageRestClient;
        private ClientDiagnostics _logicalNetworkClientDiagnostics;
        private LogicalNetworksRestOperations _logicalNetworkRestClient;
        private ClientDiagnostics _marketplaceGalleryImageClientDiagnostics;
        private MarketplaceGalleryImagesRestOperations _marketplaceGalleryImageRestClient;
        private ClientDiagnostics _networkInterfaceClientDiagnostics;
        private NetworkInterfacesRestOperations _networkInterfaceRestClient;
        private ClientDiagnostics _storageContainerClientDiagnostics;
        private StorageContainersRestOperations _storageContainerRestClient;
        private ClientDiagnostics _virtualHardDiskClientDiagnostics;
        private VirtualHardDisksRestOperations _virtualHardDiskRestClient;
        private ClientDiagnostics _hciClusterClustersClientDiagnostics;
        private ClustersRestOperations _hciClusterClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableHciSubscriptionResource"/> class for mocking. </summary>
        protected MockableHciSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHciSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHciSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics GalleryImageClientDiagnostics => _galleryImageClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Hci", GalleryImageResource.ResourceType.Namespace, Diagnostics);
        private GalleryImagesRestOperations GalleryImageRestClient => _galleryImageRestClient ??= new GalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(GalleryImageResource.ResourceType));
        private ClientDiagnostics LogicalNetworkClientDiagnostics => _logicalNetworkClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Hci", LogicalNetworkResource.ResourceType.Namespace, Diagnostics);
        private LogicalNetworksRestOperations LogicalNetworkRestClient => _logicalNetworkRestClient ??= new LogicalNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LogicalNetworkResource.ResourceType));
        private ClientDiagnostics MarketplaceGalleryImageClientDiagnostics => _marketplaceGalleryImageClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Hci", MarketplaceGalleryImageResource.ResourceType.Namespace, Diagnostics);
        private MarketplaceGalleryImagesRestOperations MarketplaceGalleryImageRestClient => _marketplaceGalleryImageRestClient ??= new MarketplaceGalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MarketplaceGalleryImageResource.ResourceType));
        private ClientDiagnostics NetworkInterfaceClientDiagnostics => _networkInterfaceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Hci", NetworkInterfaceResource.ResourceType.Namespace, Diagnostics);
        private NetworkInterfacesRestOperations NetworkInterfaceRestClient => _networkInterfaceRestClient ??= new NetworkInterfacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(NetworkInterfaceResource.ResourceType));
        private ClientDiagnostics StorageContainerClientDiagnostics => _storageContainerClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Hci", StorageContainerResource.ResourceType.Namespace, Diagnostics);
        private StorageContainersRestOperations StorageContainerRestClient => _storageContainerRestClient ??= new StorageContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(StorageContainerResource.ResourceType));
        private ClientDiagnostics VirtualHardDiskClientDiagnostics => _virtualHardDiskClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Hci", VirtualHardDiskResource.ResourceType.Namespace, Diagnostics);
        private VirtualHardDisksRestOperations VirtualHardDiskRestClient => _virtualHardDiskRestClient ??= new VirtualHardDisksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VirtualHardDiskResource.ResourceType));
        private ClientDiagnostics HciClusterClustersClientDiagnostics => _hciClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Hci", HciClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations HciClusterClustersRestClient => _hciClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HciClusterResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all of the gallery images in the specified subscription. Use the nextLink property in the response to get the next page of gallery images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/galleryImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImages_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryImageResource> GetGalleryImagesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => GalleryImageRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => GalleryImageRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GalleryImageResource(Client, GalleryImageData.DeserializeGalleryImageData(e)), GalleryImageClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetGalleryImages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the gallery images in the specified subscription. Use the nextLink property in the response to get the next page of gallery images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/galleryImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImages_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryImageResource> GetGalleryImages(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => GalleryImageRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => GalleryImageRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GalleryImageResource(Client, GalleryImageData.DeserializeGalleryImageData(e)), GalleryImageClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetGalleryImages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the logical networks in the specified subscription. Use the nextLink property in the response to get the next page of logical networks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/logicalNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicalNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicalNetworkResource> GetLogicalNetworksAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LogicalNetworkRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LogicalNetworkRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LogicalNetworkResource(Client, LogicalNetworkData.DeserializeLogicalNetworkData(e)), LogicalNetworkClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetLogicalNetworks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the logical networks in the specified subscription. Use the nextLink property in the response to get the next page of logical networks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/logicalNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicalNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicalNetworkResource> GetLogicalNetworks(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LogicalNetworkRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LogicalNetworkRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LogicalNetworkResource(Client, LogicalNetworkData.DeserializeLogicalNetworkData(e)), LogicalNetworkClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetLogicalNetworks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the marketplace gallery images in the specified subscription. Use the nextLink property in the response to get the next page of marketplace gallery images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MarketplaceGalleryImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MarketplaceGalleryImageResource> GetMarketplaceGalleryImagesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MarketplaceGalleryImageRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MarketplaceGalleryImageRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MarketplaceGalleryImageResource(Client, MarketplaceGalleryImageData.DeserializeMarketplaceGalleryImageData(e)), MarketplaceGalleryImageClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetMarketplaceGalleryImages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the marketplace gallery images in the specified subscription. Use the nextLink property in the response to get the next page of marketplace gallery images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MarketplaceGalleryImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MarketplaceGalleryImageResource> GetMarketplaceGalleryImages(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MarketplaceGalleryImageRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MarketplaceGalleryImageRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MarketplaceGalleryImageResource(Client, MarketplaceGalleryImageData.DeserializeMarketplaceGalleryImageData(e)), MarketplaceGalleryImageClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetMarketplaceGalleryImages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the network interfaces in the specified subscription. Use the nextLink property in the response to get the next page of network interfaces.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/networkInterfaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceResource> GetNetworkInterfacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetworkInterfaceRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NetworkInterfaceRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkInterfaceResource(Client, NetworkInterfaceData.DeserializeNetworkInterfaceData(e)), NetworkInterfaceClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetNetworkInterfaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the network interfaces in the specified subscription. Use the nextLink property in the response to get the next page of network interfaces.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/networkInterfaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceResource> GetNetworkInterfaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetworkInterfaceRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NetworkInterfaceRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkInterfaceResource(Client, NetworkInterfaceData.DeserializeNetworkInterfaceData(e)), NetworkInterfaceClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetNetworkInterfaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the storage containers in the specified subscription. Use the nextLink property in the response to get the next page of storage containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/storageContainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageContainerResource> GetStorageContainersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageContainerRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageContainerRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageContainerResource(Client, StorageContainerData.DeserializeStorageContainerData(e)), StorageContainerClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetStorageContainers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the storage containers in the specified subscription. Use the nextLink property in the response to get the next page of storage containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/storageContainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageContainerResource> GetStorageContainers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageContainerRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageContainerRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageContainerResource(Client, StorageContainerData.DeserializeStorageContainerData(e)), StorageContainerClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetStorageContainers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the virtual hard disks in the specified subscription. Use the nextLink property in the response to get the next page of virtual hard disks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/virtualHardDisks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHardDisks_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualHardDiskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualHardDiskResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualHardDiskResource> GetVirtualHardDisksAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualHardDiskRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VirtualHardDiskRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualHardDiskResource(Client, VirtualHardDiskData.DeserializeVirtualHardDiskData(e)), VirtualHardDiskClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetVirtualHardDisks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the virtual hard disks in the specified subscription. Use the nextLink property in the response to get the next page of virtual hard disks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/virtualHardDisks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHardDisks_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualHardDiskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualHardDiskResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualHardDiskResource> GetVirtualHardDisks(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualHardDiskRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VirtualHardDiskRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualHardDiskResource(Client, VirtualHardDiskData.DeserializeVirtualHardDiskData(e)), VirtualHardDiskClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetVirtualHardDisks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all HCI clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HciClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HciClusterResource> GetHciClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HciClusterClustersRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HciClusterClustersRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HciClusterResource(Client, HciClusterData.DeserializeHciClusterData(e)), HciClusterClustersClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetHciClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all HCI clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HciClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HciClusterResource> GetHciClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HciClusterClustersRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HciClusterClustersRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HciClusterResource(Client, HciClusterData.DeserializeHciClusterData(e)), HciClusterClustersClientDiagnostics, Pipeline, "MockableHciSubscriptionResource.GetHciClusters", "value", "nextLink", cancellationToken);
        }
    }
}
