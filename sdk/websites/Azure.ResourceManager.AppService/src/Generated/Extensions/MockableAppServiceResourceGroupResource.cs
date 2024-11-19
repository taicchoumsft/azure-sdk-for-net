// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableAppServiceResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _resourceHealthMetadataClientDiagnostics;
        private ResourceHealthMetadataRestOperations _resourceHealthMetadataRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private WebSiteManagementRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAppServiceResourceGroupResource"/> class for mocking. </summary>
        protected MockableAppServiceResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppServiceResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppServiceResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ResourceHealthMetadataClientDiagnostics => _resourceHealthMetadataClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ResourceHealthMetadataRestOperations ResourceHealthMetadataRestClient => _resourceHealthMetadataRestClient ??= new ResourceHealthMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private WebSiteManagementRestOperations DefaultRestClient => _defaultRestClient ??= new WebSiteManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AppServiceCertificateOrderResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AppServiceCertificateOrderResources and their operations over a AppServiceCertificateOrderResource. </returns>
        public virtual AppServiceCertificateOrderCollection GetAppServiceCertificateOrders()
        {
            return GetCachedClient(client => new AppServiceCertificateOrderCollection(client, Id));
        }

        /// <summary>
        /// Description for Get a certificate order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceCertificateOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppServiceCertificateOrderResource>> GetAppServiceCertificateOrderAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            return await GetAppServiceCertificateOrders().GetAsync(certificateOrderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get a certificate order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceCertificateOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppServiceCertificateOrderResource> GetAppServiceCertificateOrder(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            return GetAppServiceCertificateOrders().Get(certificateOrderName, cancellationToken);
        }

        /// <summary> Gets a collection of AppServiceDomainResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AppServiceDomainResources and their operations over a AppServiceDomainResource. </returns>
        public virtual AppServiceDomainCollection GetAppServiceDomains()
        {
            return GetCachedClient(client => new AppServiceDomainCollection(client, Id));
        }

        /// <summary>
        /// Description for Get a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppServiceDomainResource>> GetAppServiceDomainAsync(string domainName, CancellationToken cancellationToken = default)
        {
            return await GetAppServiceDomains().GetAsync(domainName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppServiceDomainResource> GetAppServiceDomain(string domainName, CancellationToken cancellationToken = default)
        {
            return GetAppServiceDomains().Get(domainName, cancellationToken);
        }

        /// <summary> Gets a collection of AppServiceEnvironmentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AppServiceEnvironmentResources and their operations over a AppServiceEnvironmentResource. </returns>
        public virtual AppServiceEnvironmentCollection GetAppServiceEnvironments()
        {
            return GetCachedClient(client => new AppServiceEnvironmentCollection(client, Id));
        }

        /// <summary>
        /// Description for Get the properties of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppServiceEnvironmentResource>> GetAppServiceEnvironmentAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetAppServiceEnvironments().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get the properties of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppServiceEnvironmentResource> GetAppServiceEnvironment(string name, CancellationToken cancellationToken = default)
        {
            return GetAppServiceEnvironments().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of AppServicePlanResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AppServicePlanResources and their operations over a AppServicePlanResource. </returns>
        public virtual AppServicePlanCollection GetAppServicePlans()
        {
            return GetCachedClient(client => new AppServicePlanCollection(client, Id));
        }

        /// <summary>
        /// Description for Get an App Service plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the App Service plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppServicePlanResource>> GetAppServicePlanAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetAppServicePlans().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get an App Service plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the App Service plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppServicePlanResource> GetAppServicePlan(string name, CancellationToken cancellationToken = default)
        {
            return GetAppServicePlans().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of AppCertificateResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AppCertificateResources and their operations over a AppCertificateResource. </returns>
        public virtual AppCertificateCollection GetAppCertificates()
        {
            return GetCachedClient(client => new AppCertificateCollection(client, Id));
        }

        /// <summary>
        /// Description for Get a certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppCertificateResource>> GetAppCertificateAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetAppCertificates().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get a certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppCertificateResource> GetAppCertificate(string name, CancellationToken cancellationToken = default)
        {
            return GetAppCertificates().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of KubeEnvironmentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of KubeEnvironmentResources and their operations over a KubeEnvironmentResource. </returns>
        public virtual KubeEnvironmentCollection GetKubeEnvironments()
        {
            return GetCachedClient(client => new KubeEnvironmentCollection(client, Id));
        }

        /// <summary>
        /// Description for Get the properties of a Kubernetes Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubeEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubeEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<KubeEnvironmentResource>> GetKubeEnvironmentAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetKubeEnvironments().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get the properties of a Kubernetes Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubeEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubeEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<KubeEnvironmentResource> GetKubeEnvironment(string name, CancellationToken cancellationToken = default)
        {
            return GetKubeEnvironments().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of StaticSiteResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StaticSiteResources and their operations over a StaticSiteResource. </returns>
        public virtual StaticSiteCollection GetStaticSites()
        {
            return GetCachedClient(client => new StaticSiteCollection(client, Id));
        }

        /// <summary>
        /// Description for Gets the details of a static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSite</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StaticSiteResource>> GetStaticSiteAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetStaticSites().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets the details of a static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSite</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<StaticSiteResource> GetStaticSite(string name, CancellationToken cancellationToken = default)
        {
            return GetStaticSites().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of WebSiteResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of WebSiteResources and their operations over a WebSiteResource. </returns>
        public virtual WebSiteCollection GetWebSites()
        {
            return GetCachedClient(client => new WebSiteCollection(client, Id));
        }

        /// <summary>
        /// Description for Gets the details of a web, mobile, or API app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WebSiteResource>> GetWebSiteAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetWebSites().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets the details of a web, mobile, or API app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WebSiteResource> GetWebSite(string name, CancellationToken cancellationToken = default)
        {
            return GetWebSites().Get(name, cancellationToken);
        }

        /// <summary>
        /// Description for Validate if a resource can be created.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Validate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request with the resources to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<AppServiceValidateResult>> ValidateAsync(AppServiceValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableAppServiceResourceGroupResource.Validate");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.ValidateAsync(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Validate if a resource can be created.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Validate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request with the resources to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<AppServiceValidateResult> Validate(AppServiceValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableAppServiceResourceGroupResource.Validate");
            scope.Start();
            try
            {
                var response = DefaultRestClient.Validate(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
