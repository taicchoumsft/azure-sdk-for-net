// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Responsys linked service. </summary>
    public partial class ResponsysLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of ResponsysLinkedService. </summary>
        /// <param name="endpoint"> The endpoint of the Responsys server. </param>
        /// <param name="clientId"> The client ID associated with the Responsys application. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="clientId"/> is null. </exception>
        public ResponsysLinkedService(DataFactoryElement<string> endpoint, DataFactoryElement<string> clientId)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(clientId, nameof(clientId));

            Endpoint = endpoint;
            ClientId = clientId;
            LinkedServiceType = "Responsys";
        }

        /// <summary> Initializes a new instance of ResponsysLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of the Responsys server. </param>
        /// <param name="clientId"> The client ID associated with the Responsys application. Type: string (or Expression with resultType string). </param>
        /// <param name="clientSecret"> The client secret associated with the Responsys application. Type: string (or Expression with resultType string). </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal ResponsysLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> endpoint, DataFactoryElement<string> clientId, DataFactorySecretBaseDefinition clientSecret, DataFactoryElement<bool> useEncryptedEndpoints, DataFactoryElement<bool> useHostVerification, DataFactoryElement<bool> usePeerVerification, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Responsys";
        }

        /// <summary> The endpoint of the Responsys server. </summary>
        public DataFactoryElement<string> Endpoint { get; set; }
        /// <summary> The client ID associated with the Responsys application. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClientId { get; set; }
        /// <summary> The client secret associated with the Responsys application. Type: string (or Expression with resultType string). </summary>
        public DataFactorySecretBaseDefinition ClientSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
