// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.ResourceManager.EdgeOrder.Customizations.Models;
using Azure.ResourceManager.EdgeOrder.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Azure.ResourceManager.EdgeOrder
{
    public static partial class EdgeOrderExtensions
    {
        private static void ValidateValidSiteKeyObject(SiteKey siteKeyObject)
        {
            Argument.AssertNotNullOrWhiteSpace(siteKeyObject.ResourceId, nameof(siteKeyObject.ResourceId));
            Argument.AssertNotNullOrWhiteSpace(siteKeyObject.AadEndpoint, nameof(siteKeyObject.AadEndpoint));
            Argument.AssertNotNullOrWhiteSpace(siteKeyObject.TenantId, nameof(siteKeyObject.TenantId));
            Argument.AssertNotNullOrWhiteSpace(siteKeyObject.ClientId, nameof(siteKeyObject.ClientId));
            Argument.AssertNotNullOrWhiteSpace(siteKeyObject.ClientSecret, nameof(siteKeyObject.ClientSecret));
        }

        /// <summary>
        /// Get EdgeOrderDevices for a site.
        /// </summary>
        /// <param name="siteKey"></param>
        /// <param name="top"></param>
        /// <param name="skipToken"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static EdgeOrderDeviceResponse GetEdgeOrderDevices(string siteKey, int? top = null, string skipToken = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            Argument.AssertNotNullOrWhiteSpace(siteKey, nameof(siteKey));

            SiteKey siteKeyObject = siteKey.DeserializeSiteKey();

            ValidateValidSiteKeyObject(siteKeyObject);
            ArmClient armClient = siteKeyObject.CreateArmClient(null);
            ResourceIdentifier siteResource = new ResourceIdentifier(siteKeyObject.ResourceId);

            TenantResourceGetOrderItemsByResourceGroupOptions tenantResourceGetOrderItemsByResourceGroupOptions = new TenantResourceGetOrderItemsByResourceGroupOptions(new Guid(siteResource.SubscriptionId), siteResource.ResourceGroupName)
            {
                Top = top,
                SkipToken = skipToken,
                Filter = "Properties.OrderItemDetails.OrderItemType eq 'External'"
            };
            var tenantResource = armClient.GetTenants().First();
            Pageable<EdgeOrderItem> edgeOrderItem = GetOrderItemsByResourceGroup(tenantResource, tenantResourceGetOrderItemsByResourceGroupOptions, cancellationToken);
            EdgeOrderDeviceResponse edgeOrderDeviceResponse = new EdgeOrderDeviceResponse();
            var EdgeOrderDevices = new List<EdgeOrderDevice>();
            var Pages = edgeOrderItem.AsPages().GetEnumerator();
            Page<EdgeOrderItem> page = null;
            if (Pages.MoveNext())
            {
                 page = Pages.Current;
            }

            foreach (EdgeOrderItem item in page.Values)
                {
                    EdgeOrderDevice edgeOrderDevice = new EdgeOrderDevice();
                    edgeOrderDevice.OrderItemId = item.Id;
                    edgeOrderDevice.Manufacturer = item.OrderItemDetails.ProductDetails?.ParentProvisioningDetails?.VendorName;
                    edgeOrderDevice.SerialNumber = item.OrderItemDetails.ProductDetails?.ParentProvisioningDetails?.SerialNumber;
                    edgeOrderDevice.ModelName = item.OrderItemDetails.ProductDetails?.ParentProvisioningDetails?.Model;
                    edgeOrderDevice.DeviceConfiguration = GetDeviceConfigurationFromOrderItem(item.OrderItemDetails.ProductDetails?.ParentProvisioningDetails?.DeviceConfigurations);
                    EdgeOrderDevices.Add(edgeOrderDevice);
                }
                edgeOrderDeviceResponse.EdgeOrderDevices = EdgeOrderDevices;
                edgeOrderDeviceResponse.SkipToken = page.ContinuationToken;

            return edgeOrderDeviceResponse;
        }

        private static DeviceConfiguration GetDeviceConfigurationFromOrderItem(DeviceConfigurations deviceConfigurations)
        {
            DeviceConfiguration deviceConfiguration = new DeviceConfiguration();
            if (deviceConfigurations == null)
            {
                return deviceConfiguration;
            }
            //Setting up Network Configurations
            List<Models.NetworkConfiguration> networkConfigurations = deviceConfigurations?.NetworkConfigurations.ToList();
            deviceConfiguration.Network = new Customizations.Models.NetworkConfiguration
            {
                NetworkAdapters = new List<NetworkAdapter>()
            };

            foreach (var networkConfiguration in networkConfigurations)
            {
                _ = Enum.TryParse<IPAssignmentType>(networkConfiguration?.Properties?.IPAssignments?.IPAssignmentType, out var result);
                var networkAdapter  = new NetworkAdapter
                {
                    IpAssignmentType = result,
                    Gateway = networkConfiguration?.Properties?.IPAssignments?.IPv4?.DefaultGateway,
                    IpAddress = networkConfiguration?.Properties?.IPAssignments?.IPv4?.IPAddress,
                    IpAddressRange = new IPAddressRange
                    {
                        StartIp = networkConfiguration?.Properties?.IPAssignments?.IPv4?.AddressRange?.StartIP,
                        EndIp = networkConfiguration?.Properties?.IPAssignments?.IPv4?.AddressRange?.EndIP
                    },
                    SubnetMask = networkConfiguration?.Properties?.IPAssignments?.IPv4?.SubnetMask,
                    DnsAddressArray = networkConfiguration?.Properties?.IPAssignments?.IPv4?.DnsServers,
                    VlanId = networkConfiguration?.Properties?.IPAssignments?.IPv4?.VLanId.ToString()
                };

                deviceConfiguration.Network.NetworkAdapters.Add(networkAdapter);
            }

            // Host name config
            deviceConfiguration.HostName = deviceConfigurations?.HostName;

            // Web proxy setup
            deviceConfiguration.WebProxy = new WebProxyConfiguration
            {
                ConnectionUri = deviceConfigurations?.ConnectivityConfiguration?.Properties?.ProxyConfiguration?.Uri?.AbsoluteUri,
                Port = deviceConfigurations?.ConnectivityConfiguration?.Properties?.ProxyConfiguration?.Port.ToString(),
                BypassList = deviceConfigurations?.ConnectivityConfiguration?.Properties?.ProxyConfiguration?.BypassUrls
            };

            // Time server settings
            deviceConfiguration.Time = new TimeConfiguration
            {
                PrimaryTimeServer = deviceConfigurations?.TimeServerConfiguration?.Properties?.NtpServerConfiguration?.NtpServer,
                SecondaryTimeServer = deviceConfigurations?.TimeServerConfiguration?.Properties?.NtpServerConfiguration?.AlternateNtpServer,
                TimeZone = deviceConfigurations?.TimeServerConfiguration?.Properties?.Timezone
            };

            return deviceConfiguration;
        }
    }
}
