// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmNotificationHubsModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubAvailabilityContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="isAvailiable"> Not used and deprecated since API version 2023-01-01-preview. </param>
        /// <param name="sku"> The Sku description for a namespace. </param>
        /// <returns> A new <see cref="Models.NotificationHubAvailabilityContent"/> instance for mocking. </returns>
        public static NotificationHubAvailabilityContent NotificationHubAvailabilityContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, bool? isAvailiable = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubAvailabilityContent(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                isAvailiable,
                sku,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubAvailabilityResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="isAvailiable">
        /// Gets or sets true if the name is available and can be used to
        /// create new Namespace/NotificationHub. Otherwise false.
        /// </param>
        /// <param name="sku"> The Sku description for a namespace. </param>
        /// <returns> A new <see cref="Models.NotificationHubAvailabilityResult"/> instance for mocking. </returns>
        public static NotificationHubAvailabilityResult NotificationHubAvailabilityResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, bool? isAvailiable = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubAvailabilityResult(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                isAvailiable,
                sku,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubs.NotificationHubData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The Sku description for a namespace. </param>
        /// <param name="notificationHubName"> Gets or sets the NotificationHub name. </param>
        /// <param name="registrationTtl"> Gets or sets the RegistrationTtl of the created NotificationHub. </param>
        /// <param name="authorizationRules"> Gets or sets the AuthorizationRules of the created NotificationHub. </param>
        /// <param name="apnsCredential"> Description of a NotificationHub ApnsCredential. </param>
        /// <param name="wnsCredential"> Description of a NotificationHub WnsCredential. </param>
        /// <param name="gcmCredential"> Description of a NotificationHub GcmCredential. </param>
        /// <param name="mpnsCredential"> Description of a NotificationHub MpnsCredential. </param>
        /// <param name="admCredential"> Description of a NotificationHub AdmCredential. </param>
        /// <param name="baiduCredential"> Description of a NotificationHub BaiduCredential. </param>
        /// <param name="browserCredential"> Description of a NotificationHub BrowserCredential. </param>
        /// <param name="xiaomiCredential"> Description of a NotificationHub XiaomiCredential. </param>
        /// <param name="fcmV1Credential"> Description of a NotificationHub FcmV1Credential. </param>
        /// <param name="dailyMaxActiveDevices"></param>
        /// <returns> A new <see cref="NotificationHubs.NotificationHubData"/> instance for mocking. </returns>
        public static NotificationHubData NotificationHubData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, NotificationHubSku sku = null, string notificationHubName = null, TimeSpan? registrationTtl = null, IEnumerable<SharedAccessAuthorizationRuleProperties> authorizationRules = null, NotificationHubApnsCredential apnsCredential = null, NotificationHubWnsCredential wnsCredential = null, NotificationHubGcmCredential gcmCredential = null, NotificationHubMpnsCredential mpnsCredential = null, NotificationHubAdmCredential admCredential = null, NotificationHubBaiduCredential baiduCredential = null, BrowserCredential browserCredential = null, XiaomiCredential xiaomiCredential = null, FcmV1Credential fcmV1Credential = null, long? dailyMaxActiveDevices = null)
        {
            tags ??= new Dictionary<string, string>();
            authorizationRules ??= new List<SharedAccessAuthorizationRuleProperties>();

            return new NotificationHubData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                sku,
                notificationHubName,
                registrationTtl,
                authorizationRules?.ToList(),
                apnsCredential,
                wnsCredential,
                gcmCredential,
                mpnsCredential,
                admCredential,
                baiduCredential,
                browserCredential,
                xiaomiCredential,
                fcmV1Credential,
                dailyMaxActiveDevices,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SharedAccessAuthorizationRuleProperties"/>. </summary>
        /// <param name="accessRights"> Gets or sets the rights associated with the rule. </param>
        /// <param name="primaryKey">
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </param>
        /// <param name="secondaryKey">
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </param>
        /// <param name="keyName"> Gets a string that describes the authorization rule. </param>
        /// <param name="modifiedOn"> Gets the last modified time for this rule. </param>
        /// <param name="createdOn"> Gets the created time for this rule. </param>
        /// <param name="claimType"> Gets a string that describes the claim type. </param>
        /// <param name="claimValue"> Gets a string that describes the claim value. </param>
        /// <param name="revision"> Gets the revision number for the rule. </param>
        /// <returns> A new <see cref="Models.SharedAccessAuthorizationRuleProperties"/> instance for mocking. </returns>
        public static SharedAccessAuthorizationRuleProperties SharedAccessAuthorizationRuleProperties(IEnumerable<AuthorizationRuleAccessRightExt> accessRights = null, string primaryKey = null, string secondaryKey = null, string keyName = null, DateTimeOffset? modifiedOn = null, DateTimeOffset? createdOn = null, string claimType = null, string claimValue = null, int? revision = null)
        {
            accessRights ??= new List<AuthorizationRuleAccessRightExt>();

            return new SharedAccessAuthorizationRuleProperties(
                accessRights?.ToList(),
                primaryKey,
                secondaryKey,
                keyName,
                modifiedOn,
                createdOn,
                claimType,
                claimValue,
                revision,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubTestSendResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="success"> Gets or sets successful send. </param>
        /// <param name="failure"> Gets or sets send failure. </param>
        /// <param name="failureDescription"> Gets or sets actual failure description. </param>
        /// <returns> A new <see cref="Models.NotificationHubTestSendResult"/> instance for mocking. </returns>
        public static NotificationHubTestSendResult NotificationHubTestSendResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, int? success = null, int? failure = null, IEnumerable<NotificationHubPubRegistrationResult> failureDescription = null)
        {
            tags ??= new Dictionary<string, string>();
            failureDescription ??= new List<NotificationHubPubRegistrationResult>();

            return new NotificationHubTestSendResult(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                success,
                failure,
                failureDescription?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubPubRegistrationResult"/>. </summary>
        /// <param name="applicationPlatform"> PNS type. </param>
        /// <param name="pnsHandle"> PNS handle. </param>
        /// <param name="registrationId"> Registration id. </param>
        /// <param name="outcome"> Notification outcome. </param>
        /// <returns> A new <see cref="Models.NotificationHubPubRegistrationResult"/> instance for mocking. </returns>
        public static NotificationHubPubRegistrationResult NotificationHubPubRegistrationResult(string applicationPlatform = null, string pnsHandle = null, string registrationId = null, string outcome = null)
        {
            return new NotificationHubPubRegistrationResult(applicationPlatform, pnsHandle, registrationId, outcome, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubs.NotificationHubAuthorizationRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="accessRights"> Gets or sets the rights associated with the rule. </param>
        /// <param name="primaryKey">
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </param>
        /// <param name="secondaryKey">
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </param>
        /// <param name="keyName"> Gets a string that describes the authorization rule. </param>
        /// <param name="modifiedOn"> Gets the last modified time for this rule. </param>
        /// <param name="createdOn"> Gets the created time for this rule. </param>
        /// <param name="claimType"> Gets a string that describes the claim type. </param>
        /// <param name="claimValue"> Gets a string that describes the claim value. </param>
        /// <param name="revision"> Gets the revision number for the rule. </param>
        /// <returns> A new <see cref="NotificationHubs.NotificationHubAuthorizationRuleData"/> instance for mocking. </returns>
        public static NotificationHubAuthorizationRuleData NotificationHubAuthorizationRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IEnumerable<AuthorizationRuleAccessRightExt> accessRights = null, string primaryKey = null, string secondaryKey = null, string keyName = null, DateTimeOffset? modifiedOn = null, DateTimeOffset? createdOn = null, string claimType = null, string claimValue = null, int? revision = null)
        {
            tags ??= new Dictionary<string, string>();
            accessRights ??= new List<AuthorizationRuleAccessRightExt>();

            return new NotificationHubAuthorizationRuleData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                accessRights?.ToList(),
                primaryKey,
                secondaryKey,
                keyName,
                modifiedOn,
                createdOn,
                claimType,
                claimValue,
                revision,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubResourceKeys"/>. </summary>
        /// <param name="primaryConnectionString"> Gets or sets primaryConnectionString of the AuthorizationRule. </param>
        /// <param name="secondaryConnectionString">
        /// Gets or sets secondaryConnectionString of the created
        /// AuthorizationRule
        /// </param>
        /// <param name="primaryKey"> Gets or sets primaryKey of the created AuthorizationRule. </param>
        /// <param name="secondaryKey"> Gets or sets secondaryKey of the created AuthorizationRule. </param>
        /// <param name="keyName"> Gets or sets keyName of the created AuthorizationRule. </param>
        /// <returns> A new <see cref="Models.NotificationHubResourceKeys"/> instance for mocking. </returns>
        public static NotificationHubResourceKeys NotificationHubResourceKeys(string primaryConnectionString = null, string secondaryConnectionString = null, string primaryKey = null, string secondaryKey = null, string keyName = null)
        {
            return new NotificationHubResourceKeys(
                primaryConnectionString,
                secondaryConnectionString,
                primaryKey,
                secondaryKey,
                keyName,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubPnsCredentials"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="admCredential"> Description of a NotificationHub AdmCredential. </param>
        /// <param name="apnsCredential"> Description of a NotificationHub ApnsCredential. </param>
        /// <param name="baiduCredential"> Description of a NotificationHub BaiduCredential. </param>
        /// <param name="browserCredential"> Description of a NotificationHub BrowserCredential. </param>
        /// <param name="gcmCredential"> Description of a NotificationHub GcmCredential. </param>
        /// <param name="mpnsCredential"> Description of a NotificationHub MpnsCredential. </param>
        /// <param name="wnsCredential"> Description of a NotificationHub WnsCredential. </param>
        /// <param name="xiaomiCredential"> Description of a NotificationHub XiaomiCredential. </param>
        /// <param name="fcmV1Credential"> Description of a NotificationHub FcmV1Credential. </param>
        /// <returns> A new <see cref="Models.NotificationHubPnsCredentials"/> instance for mocking. </returns>
        public static NotificationHubPnsCredentials NotificationHubPnsCredentials(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, NotificationHubAdmCredential admCredential = null, NotificationHubApnsCredential apnsCredential = null, NotificationHubBaiduCredential baiduCredential = null, BrowserCredential browserCredential = null, NotificationHubGcmCredential gcmCredential = null, NotificationHubMpnsCredential mpnsCredential = null, NotificationHubWnsCredential wnsCredential = null, XiaomiCredential xiaomiCredential = null, FcmV1Credential fcmV1Credential = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubPnsCredentials(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                admCredential,
                apnsCredential,
                baiduCredential,
                browserCredential,
                gcmCredential,
                mpnsCredential,
                wnsCredential,
                xiaomiCredential,
                fcmV1Credential,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubs.NotificationHubNamespaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The Sku description for a namespace. </param>
        /// <param name="namespaceName">
        /// Name of the Notification Hubs namespace. This is immutable property, set automatically
        /// by the service when the namespace is created.
        /// </param>
        /// <param name="operationProvisioningState"> Defines values for OperationProvisioningState. </param>
        /// <param name="namespaceStatus"> Namespace status. </param>
        /// <param name="isEnabled"> Gets or sets whether or not the namespace is currently enabled. </param>
        /// <param name="isCritical"> Gets or sets whether or not the namespace is set as Critical. </param>
        /// <param name="subscriptionId"> Namespace subscription id. </param>
        /// <param name="region">
        /// Region. The value is always set to the same value as Namespace.Location, so we are deprecating
        /// this property.
        /// </param>
        /// <param name="metricId"> Azure Insights Metrics id. </param>
        /// <param name="createdOn"> Time when the namespace was created. </param>
        /// <param name="updatedOn"> Time when the namespace was updated. </param>
        /// <param name="hubNamespaceType"> Defines values for NamespaceType. </param>
        /// <param name="replicationRegion"> Allowed replication region. </param>
        /// <param name="zoneRedundancy"> Namespace SKU name. </param>
        /// <param name="networkAcls"> A collection of network authorization rules. </param>
        /// <param name="pnsCredentials"> Collection of Notification Hub or Notification Hub Namespace PNS credentials. </param>
        /// <param name="serviceBusEndpoint">
        /// Gets or sets endpoint you can use to perform NotificationHub
        /// operations.
        /// </param>
        /// <param name="privateEndpointConnections"> Private Endpoint Connections for namespace. </param>
        /// <param name="scaleUnit"> Gets or sets scaleUnit where the namespace gets created. </param>
        /// <param name="dataCenter"> Deprecated. </param>
        /// <param name="publicNetworkAccess"> Type of public network access. </param>
        /// <returns> A new <see cref="NotificationHubs.NotificationHubNamespaceData"/> instance for mocking. </returns>
        public static NotificationHubNamespaceData NotificationHubNamespaceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, NotificationHubSku sku = null, string namespaceName = null, OperationProvisioningState? operationProvisioningState = null, NotificationHubNamespaceStatus? namespaceStatus = null, bool? isEnabled = null, bool? isCritical = null, string subscriptionId = null, string region = null, string metricId = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, NotificationHubNamespaceTypeExt? hubNamespaceType = null, AllowedReplicationRegion? replicationRegion = null, ZoneRedundancyPreference? zoneRedundancy = null, NotificationHubNetworkAcls networkAcls = null, PnsCredentials pnsCredentials = null, Uri serviceBusEndpoint = null, IEnumerable<NotificationHubPrivateEndpointConnectionData> privateEndpointConnections = null, string scaleUnit = null, string dataCenter = null, NotificationHubPublicNetworkAccess? publicNetworkAccess = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<NotificationHubPrivateEndpointConnectionData>();

            return new NotificationHubNamespaceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                sku,
                namespaceName,
                operationProvisioningState,
                namespaceStatus,
                isEnabled,
                isCritical,
                subscriptionId,
                region,
                metricId,
                createdOn,
                updatedOn,
                hubNamespaceType,
                replicationRegion,
                zoneRedundancy,
                networkAcls,
                pnsCredentials,
                serviceBusEndpoint,
                privateEndpointConnections?.ToList(),
                scaleUnit,
                dataCenter,
                publicNetworkAccess,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubNamespaceProperties"/>. </summary>
        /// <param name="namespaceName">
        /// Name of the Notification Hubs namespace. This is immutable property, set automatically
        /// by the service when the namespace is created.
        /// </param>
        /// <param name="provisioningState"> Defines values for OperationProvisioningState. </param>
        /// <param name="status"> Namespace status. </param>
        /// <param name="isEnabled"> Gets or sets whether or not the namespace is currently enabled. </param>
        /// <param name="isCritical"> Gets or sets whether or not the namespace is set as Critical. </param>
        /// <param name="subscriptionId"> Namespace subscription id. </param>
        /// <param name="region">
        /// Region. The value is always set to the same value as Namespace.Location, so we are deprecating
        /// this property.
        /// </param>
        /// <param name="metricId"> Azure Insights Metrics id. </param>
        /// <param name="createdOn"> Time when the namespace was created. </param>
        /// <param name="updatedOn"> Time when the namespace was updated. </param>
        /// <param name="namespaceType"> Defines values for NamespaceType. </param>
        /// <param name="replicationRegion"> Allowed replication region. </param>
        /// <param name="zoneRedundancy"> Namespace SKU name. </param>
        /// <param name="networkAcls"> A collection of network authorization rules. </param>
        /// <param name="pnsCredentials"> Collection of Notification Hub or Notification Hub Namespace PNS credentials. </param>
        /// <param name="serviceBusEndpoint">
        /// Gets or sets endpoint you can use to perform NotificationHub
        /// operations.
        /// </param>
        /// <param name="privateEndpointConnections"> Private Endpoint Connections for namespace. </param>
        /// <param name="scaleUnit"> Gets or sets scaleUnit where the namespace gets created. </param>
        /// <param name="dataCenter"> Deprecated. </param>
        /// <param name="publicNetworkAccess"> Type of public network access. </param>
        /// <returns> A new <see cref="Models.NotificationHubNamespaceProperties"/> instance for mocking. </returns>
        public static NotificationHubNamespaceProperties NotificationHubNamespaceProperties(string namespaceName = null, OperationProvisioningState? provisioningState = null, NotificationHubNamespaceStatus? status = null, bool? isEnabled = null, bool? isCritical = null, string subscriptionId = null, string region = null, string metricId = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, NotificationHubNamespaceTypeExt? namespaceType = null, AllowedReplicationRegion? replicationRegion = null, ZoneRedundancyPreference? zoneRedundancy = null, NotificationHubNetworkAcls networkAcls = null, PnsCredentials pnsCredentials = null, Uri serviceBusEndpoint = null, IEnumerable<NotificationHubPrivateEndpointConnectionData> privateEndpointConnections = null, string scaleUnit = null, string dataCenter = null, NotificationHubPublicNetworkAccess? publicNetworkAccess = null)
        {
            privateEndpointConnections ??= new List<NotificationHubPrivateEndpointConnectionData>();

            return new NotificationHubNamespaceProperties(
                namespaceName,
                provisioningState,
                status,
                isEnabled,
                isCritical,
                subscriptionId,
                region,
                metricId,
                createdOn,
                updatedOn,
                namespaceType,
                replicationRegion,
                zoneRedundancy,
                networkAcls,
                pnsCredentials,
                serviceBusEndpoint,
                privateEndpointConnections?.ToList(),
                scaleUnit,
                dataCenter,
                publicNetworkAccess,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubs.NotificationHubPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Private Endpoint Connection properties. </param>
        /// <returns> A new <see cref="NotificationHubs.NotificationHubPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static NotificationHubPrivateEndpointConnectionData NotificationHubPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, NotificationHubPrivateEndpointConnectionProperties properties = null)
        {
            return new NotificationHubPrivateEndpointConnectionData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="provisioningState"> State of Private Endpoint Connection. </param>
        /// <param name="privateEndpointId"> Represents a Private Endpoint that is connected to Notification Hubs namespace using Private Endpoint Connection. </param>
        /// <param name="groupIds"> List of group ids. For Notification Hubs, it always contains a single "namespace" element. </param>
        /// <param name="connectionState"> State of the Private Link Service connection. </param>
        /// <returns> A new <see cref="Models.NotificationHubPrivateEndpointConnectionProperties"/> instance for mocking. </returns>
        public static NotificationHubPrivateEndpointConnectionProperties NotificationHubPrivateEndpointConnectionProperties(NotificationHubsPrivateEndpointConnectionProvisioningState? provisioningState = null, ResourceIdentifier privateEndpointId = null, IEnumerable<string> groupIds = null, RemotePrivateLinkServiceConnectionState connectionState = null)
        {
            groupIds ??= new List<string>();

            return new NotificationHubPrivateEndpointConnectionProperties(provisioningState, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, groupIds?.ToList(), connectionState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.RemotePrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> State of Private Link Connection. </param>
        /// <param name="description"> Human-friendly description. </param>
        /// <param name="actionsRequired"> Human-friendly description of required actions. </param>
        /// <returns> A new <see cref="Models.RemotePrivateLinkServiceConnectionState"/> instance for mocking. </returns>
        public static RemotePrivateLinkServiceConnectionState RemotePrivateLinkServiceConnectionState(NotificationHubPrivateLinkConnectionStatus? status = null, string description = null, string actionsRequired = null)
        {
            return new RemotePrivateLinkServiceConnectionState(status, description, actionsRequired, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubs.NotificationHubsPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Represents properties of Private Link Resource. </param>
        /// <returns> A new <see cref="NotificationHubs.NotificationHubsPrivateLinkResourceData"/> instance for mocking. </returns>
        public static NotificationHubsPrivateLinkResourceData NotificationHubsPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, NotificationHubsPrivateLinkResourceProperties properties = null)
        {
            return new NotificationHubsPrivateLinkResourceData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubsPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> A Group Id for Private Link. For Notification Hubs, it is always set to "namespace". </param>
        /// <param name="requiredMembers"> Required members. For Notification Hubs, it's always a collection with a single "namespace" item. </param>
        /// <param name="requiredZoneNames"> Required DNS zone names. For Notification Hubs, it contains two CNames for Service Bus and Notification Hubs zones. </param>
        /// <returns> A new <see cref="Models.NotificationHubsPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static NotificationHubsPrivateLinkResourceProperties NotificationHubsPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new NotificationHubsPrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="T:Azure.ResourceManager.NotificationHubs.NotificationHubData" />. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="notificationHubName"> The NotificationHub name. </param>
        /// <param name="registrationTtl"> The RegistrationTtl of the created NotificationHub. </param>
        /// <param name="authorizationRules"> The AuthorizationRules of the created NotificationHub. </param>
        /// <param name="apnsCredential"> The ApnsCredential of the created NotificationHub. </param>
        /// <param name="wnsCredential"> The WnsCredential of the created NotificationHub. </param>
        /// <param name="gcmCredential"> The GcmCredential of the created NotificationHub. </param>
        /// <param name="mpnsCredential"> The MpnsCredential of the created NotificationHub. </param>
        /// <param name="admCredential"> The AdmCredential of the created NotificationHub. </param>
        /// <param name="baiduCredential"> The BaiduCredential of the created NotificationHub. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.NotificationHubs.NotificationHubData" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static NotificationHubData NotificationHubData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string notificationHubName, TimeSpan? registrationTtl, IEnumerable<SharedAccessAuthorizationRuleProperties> authorizationRules, NotificationHubApnsCredential apnsCredential, NotificationHubWnsCredential wnsCredential, NotificationHubGcmCredential gcmCredential, NotificationHubMpnsCredential mpnsCredential, NotificationHubAdmCredential admCredential, NotificationHubBaiduCredential baiduCredential, NotificationHubSku sku)
        {
            return NotificationHubData(id: id, name: name, resourceType: resourceType, systemData: systemData, tags: tags, location: location, sku: sku, notificationHubName: notificationHubName, registrationTtl: registrationTtl, authorizationRules: authorizationRules, apnsCredential: apnsCredential, wnsCredential: wnsCredential, gcmCredential: gcmCredential, mpnsCredential: mpnsCredential, admCredential: admCredential, baiduCredential: baiduCredential, browserCredential: default, xiaomiCredential: default, fcmV1Credential: default, dailyMaxActiveDevices: default);
        }
    }
}
