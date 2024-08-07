// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Identity.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Identity
{
    internal partial class CommunicationIdentityRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of CommunicationIdentityRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://my-resource.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public CommunicationIdentityRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2023-10-01")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateRequest(IEnumerable<CommunicationTokenScope> createTokenWithScopes, int? expiresInMinutes)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/identities", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            CommunicationIdentityCreateRequest communicationIdentityCreateRequest = new CommunicationIdentityCreateRequest()
            {
                ExpiresInMinutes = expiresInMinutes
            };
            if (createTokenWithScopes != null)
            {
                foreach (var value in createTokenWithScopes)
                {
                    communicationIdentityCreateRequest.CreateTokenWithScopes.Add(value);
                }
            }
            var model = communicationIdentityCreateRequest;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Create a new identity, and optionally, an access token. </summary>
        /// <param name="createTokenWithScopes"> Also create access token for the created identity. </param>
        /// <param name="expiresInMinutes"> Optional custom validity period of the token within [60,1440] minutes range. If not provided, the default value of 1440 minutes (24 hours) will be used. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<CommunicationUserIdentifierAndToken>> CreateAsync(IEnumerable<CommunicationTokenScope> createTokenWithScopes = null, int? expiresInMinutes = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRequest(createTokenWithScopes, expiresInMinutes);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CommunicationUserIdentifierAndToken value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunicationUserIdentifierAndToken.DeserializeCommunicationUserIdentifierAndToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a new identity, and optionally, an access token. </summary>
        /// <param name="createTokenWithScopes"> Also create access token for the created identity. </param>
        /// <param name="expiresInMinutes"> Optional custom validity period of the token within [60,1440] minutes range. If not provided, the default value of 1440 minutes (24 hours) will be used. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<CommunicationUserIdentifierAndToken> Create(IEnumerable<CommunicationTokenScope> createTokenWithScopes = null, int? expiresInMinutes = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRequest(createTokenWithScopes, expiresInMinutes);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CommunicationUserIdentifierAndToken value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunicationUserIdentifierAndToken.DeserializeCommunicationUserIdentifierAndToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/identities/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete the identity, revoke all tokens for the identity and delete all associated data. </summary>
        /// <param name="id"> Identifier of the identity to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response> DeleteAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete the identity, revoke all tokens for the identity and delete all associated data. </summary>
        /// <param name="id"> Identifier of the identity to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response Delete(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRevokeAccessTokensRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/identities/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/:revokeAccessTokens", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Revoke all access tokens for the specific identity. </summary>
        /// <param name="id"> Identifier of the identity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response> RevokeAccessTokensAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateRevokeAccessTokensRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Revoke all access tokens for the specific identity. </summary>
        /// <param name="id"> Identifier of the identity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response RevokeAccessTokens(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateRevokeAccessTokensRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateExchangeTeamsUserAccessTokenRequest(string token, string appId, string userId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/teamsUser/:exchangeAccessToken", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new TeamsUserExchangeTokenRequest(token, appId, userId);
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Exchange an Azure Active Directory (Azure AD) access token of a Teams user for a new Communication Identity access token with a matching expiration time. </summary>
        /// <param name="token"> Azure AD access token of a Teams User to acquire a new Communication Identity access token. </param>
        /// <param name="appId"> Client ID of an Azure AD application to be verified against the appid claim in the Azure AD access token. </param>
        /// <param name="userId"> Object ID of an Azure AD user (Teams User) to be verified against the oid claim in the Azure AD access token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="token"/>, <paramref name="appId"/> or <paramref name="userId"/> is null. </exception>
        public async Task<Response<CommunicationIdentityAccessToken>> ExchangeTeamsUserAccessTokenAsync(string token, string appId, string userId, CancellationToken cancellationToken = default)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));
            }
            if (appId == null)
            {
                throw new ArgumentNullException(nameof(appId));
            }
            if (userId == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            using var message = CreateExchangeTeamsUserAccessTokenRequest(token, appId, userId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationIdentityAccessToken value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunicationIdentityAccessToken.DeserializeCommunicationIdentityAccessToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Exchange an Azure Active Directory (Azure AD) access token of a Teams user for a new Communication Identity access token with a matching expiration time. </summary>
        /// <param name="token"> Azure AD access token of a Teams User to acquire a new Communication Identity access token. </param>
        /// <param name="appId"> Client ID of an Azure AD application to be verified against the appid claim in the Azure AD access token. </param>
        /// <param name="userId"> Object ID of an Azure AD user (Teams User) to be verified against the oid claim in the Azure AD access token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="token"/>, <paramref name="appId"/> or <paramref name="userId"/> is null. </exception>
        public Response<CommunicationIdentityAccessToken> ExchangeTeamsUserAccessToken(string token, string appId, string userId, CancellationToken cancellationToken = default)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));
            }
            if (appId == null)
            {
                throw new ArgumentNullException(nameof(appId));
            }
            if (userId == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            using var message = CreateExchangeTeamsUserAccessTokenRequest(token, appId, userId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationIdentityAccessToken value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunicationIdentityAccessToken.DeserializeCommunicationIdentityAccessToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateIssueAccessTokenRequest(string id, IEnumerable<CommunicationTokenScope> scopes, int? expiresInMinutes)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/identities/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/:issueAccessToken", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new CommunicationIdentityAccessTokenRequest(scopes.ToList())
            {
                ExpiresInMinutes = expiresInMinutes
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Issue a new token for an identity. </summary>
        /// <param name="id"> Identifier of the identity to issue token for. </param>
        /// <param name="scopes"> List of scopes attached to the token. </param>
        /// <param name="expiresInMinutes"> Optional custom validity period of the token within [60,1440] minutes range. If not provided, the default value of 1440 minutes (24 hours) will be used. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="scopes"/> is null. </exception>
        public async Task<Response<CommunicationIdentityAccessToken>> IssueAccessTokenAsync(string id, IEnumerable<CommunicationTokenScope> scopes, int? expiresInMinutes = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (scopes == null)
            {
                throw new ArgumentNullException(nameof(scopes));
            }

            using var message = CreateIssueAccessTokenRequest(id, scopes, expiresInMinutes);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationIdentityAccessToken value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunicationIdentityAccessToken.DeserializeCommunicationIdentityAccessToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Issue a new token for an identity. </summary>
        /// <param name="id"> Identifier of the identity to issue token for. </param>
        /// <param name="scopes"> List of scopes attached to the token. </param>
        /// <param name="expiresInMinutes"> Optional custom validity period of the token within [60,1440] minutes range. If not provided, the default value of 1440 minutes (24 hours) will be used. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="scopes"/> is null. </exception>
        public Response<CommunicationIdentityAccessToken> IssueAccessToken(string id, IEnumerable<CommunicationTokenScope> scopes, int? expiresInMinutes = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (scopes == null)
            {
                throw new ArgumentNullException(nameof(scopes));
            }

            using var message = CreateIssueAccessTokenRequest(id, scopes, expiresInMinutes);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationIdentityAccessToken value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunicationIdentityAccessToken.DeserializeCommunicationIdentityAccessToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
