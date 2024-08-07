// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A class representing the FhirService data model.
    /// The description of Fhir Service
    /// </summary>
    public partial class FhirServiceData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FhirServiceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public FhirServiceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<HealthcareApisPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of the service. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="acrConfiguration"> Fhir Service Azure container registry configuration. </param>
        /// <param name="authenticationConfiguration"> Fhir Service authentication configuration. </param>
        /// <param name="corsConfiguration"> Fhir Service Cors configuration. </param>
        /// <param name="exportConfiguration"> Fhir Service export configuration. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="eventState"> Fhir Service event support status. </param>
        /// <param name="resourceVersionPolicyConfiguration"> Determines tracking of history for resources. </param>
        /// <param name="importConfiguration"> Fhir Service import configuration. </param>
        /// <param name="implementationGuidesConfiguration"> Implementation Guides configuration. </param>
        /// <param name="encryption"> The encryption settings of the FHIR service. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FhirServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, FhirServiceKind? kind, HealthcareApisProvisioningState? provisioningState, FhirServiceAcrConfiguration acrConfiguration, FhirServiceAuthenticationConfiguration authenticationConfiguration, FhirServiceCorsConfiguration corsConfiguration, FhirServiceExportConfiguration exportConfiguration, IReadOnlyList<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections, HealthcareApisPublicNetworkAccess? publicNetworkAccess, FhirServiceEventState? eventState, FhirServiceResourceVersionPolicyConfiguration resourceVersionPolicyConfiguration, FhirServiceImportConfiguration importConfiguration, ImplementationGuidesConfiguration implementationGuidesConfiguration, Encryption encryption, ManagedServiceIdentity identity, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Kind = kind;
            ProvisioningState = provisioningState;
            AcrConfiguration = acrConfiguration;
            AuthenticationConfiguration = authenticationConfiguration;
            CorsConfiguration = corsConfiguration;
            ExportConfiguration = exportConfiguration;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            EventState = eventState;
            ResourceVersionPolicyConfiguration = resourceVersionPolicyConfiguration;
            ImportConfiguration = importConfiguration;
            ImplementationGuidesConfiguration = implementationGuidesConfiguration;
            Encryption = encryption;
            Identity = identity;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FhirServiceData"/> for deserialization. </summary>
        internal FhirServiceData()
        {
        }

        /// <summary> The kind of the service. </summary>
        public FhirServiceKind? Kind { get; set; }
        /// <summary> The provisioning state. </summary>
        public HealthcareApisProvisioningState? ProvisioningState { get; }
        /// <summary> Fhir Service Azure container registry configuration. </summary>
        public FhirServiceAcrConfiguration AcrConfiguration { get; set; }
        /// <summary> Fhir Service authentication configuration. </summary>
        public FhirServiceAuthenticationConfiguration AuthenticationConfiguration { get; set; }
        /// <summary> Fhir Service Cors configuration. </summary>
        public FhirServiceCorsConfiguration CorsConfiguration { get; set; }
        /// <summary> Fhir Service export configuration. </summary>
        internal FhirServiceExportConfiguration ExportConfiguration { get; set; }
        /// <summary> The name of the default export storage account. </summary>
        public string ExportStorageAccountName
        {
            get => ExportConfiguration is null ? default : ExportConfiguration.StorageAccountName;
            set
            {
                if (ExportConfiguration is null)
                    ExportConfiguration = new FhirServiceExportConfiguration();
                ExportConfiguration.StorageAccountName = value;
            }
        }

        /// <summary> The list of private endpoint connections that are set up for this resource. </summary>
        public IReadOnlyList<HealthcareApisPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public HealthcareApisPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Fhir Service event support status. </summary>
        public FhirServiceEventState? EventState { get; }
        /// <summary> Determines tracking of history for resources. </summary>
        public FhirServiceResourceVersionPolicyConfiguration ResourceVersionPolicyConfiguration { get; set; }
        /// <summary> Fhir Service import configuration. </summary>
        public FhirServiceImportConfiguration ImportConfiguration { get; set; }
        /// <summary> Implementation Guides configuration. </summary>
        internal ImplementationGuidesConfiguration ImplementationGuidesConfiguration { get; set; }
        /// <summary> If US Core Missing Data requirement is enabled. </summary>
        public bool? IsUsCoreMissingDataEnabled
        {
            get => ImplementationGuidesConfiguration is null ? default : ImplementationGuidesConfiguration.IsUsCoreMissingDataEnabled;
            set
            {
                if (ImplementationGuidesConfiguration is null)
                    ImplementationGuidesConfiguration = new ImplementationGuidesConfiguration();
                ImplementationGuidesConfiguration.IsUsCoreMissingDataEnabled = value;
            }
        }

        /// <summary> The encryption settings of the FHIR service. </summary>
        internal Encryption Encryption { get; set; }
        /// <summary> The URL of the key to use for encryption. </summary>
        public Uri KeyEncryptionKeyUri
        {
            get => Encryption is null ? default : Encryption.KeyEncryptionKeyUri;
            set
            {
                if (Encryption is null)
                    Encryption = new Encryption();
                Encryption.KeyEncryptionKeyUri = value;
            }
        }

        /// <summary> Setting indicating whether the service has a managed identity associated with it. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> An etag associated with the resource, used for optimistic concurrency when editing it. </summary>
        public ETag? ETag { get; set; }
    }
}
