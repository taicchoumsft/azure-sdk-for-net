// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class VpnServerConfigurationsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of VpnServerConfigurationsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public VpnServerConfigurationsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string vpnServerConfigurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves the details of a VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public async Task<Response<VpnServerConfigurationData>> GetAsync(string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }

            using var message = CreateGetRequest(resourceGroupName, vpnServerConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnServerConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VpnServerConfigurationData.DeserializeVpnServerConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the details of a VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public Response<VpnServerConfigurationData> Get(string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }

            using var message = CreateGetRequest(resourceGroupName, vpnServerConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnServerConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VpnServerConfigurationData.DeserializeVpnServerConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(vpnServerConfigurationParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/>, or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/>, or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateTagsRequest(string resourceGroupName, string vpnServerConfigurationName, IDictionary<string, string> tags)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            TagsObject tagsObject = new TagsObject();
            if (tags != null)
            {
                foreach (var value in tags)
                {
                    tagsObject.Tags.Add(value);
                }
            }
            var model = tagsObject;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Updates VpnServerConfiguration tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being updated. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public async Task<Response<VpnServerConfigurationData>> UpdateTagsAsync(string resourceGroupName, string vpnServerConfigurationName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }

            using var message = CreateUpdateTagsRequest(resourceGroupName, vpnServerConfigurationName, tags);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnServerConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VpnServerConfigurationData.DeserializeVpnServerConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates VpnServerConfiguration tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being updated. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public Response<VpnServerConfigurationData> UpdateTags(string resourceGroupName, string vpnServerConfigurationName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }

            using var message = CreateUpdateTagsRequest(resourceGroupName, vpnServerConfigurationName, tags);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnServerConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VpnServerConfigurationData.DeserializeVpnServerConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string vpnServerConfigurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, vpnServerConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, vpnServerConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetByResourceGroupRequest(string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<ListVpnServerConfigurationsResult>> GetByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetByResourceGroupRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnServerConfigurationsResult.DeserializeListVpnServerConfigurationsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<ListVpnServerConfigurationsResult> GetByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetByResourceGroupRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnServerConfigurationsResult.DeserializeListVpnServerConfigurationsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all the VpnServerConfigurations in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListVpnServerConfigurationsResult>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnServerConfigurationsResult.DeserializeListVpnServerConfigurationsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the VpnServerConfigurations in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListVpnServerConfigurationsResult> GetAll(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnServerConfigurationsResult.DeserializeListVpnServerConfigurationsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetByResourceGroupNextPageRequest(string nextLink, string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<ListVpnServerConfigurationsResult>> GetByResourceGroupNextPageAsync(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetByResourceGroupNextPageRequest(nextLink, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnServerConfigurationsResult.DeserializeListVpnServerConfigurationsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<ListVpnServerConfigurationsResult> GetByResourceGroupNextPage(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetByResourceGroupNextPageRequest(nextLink, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnServerConfigurationsResult.DeserializeListVpnServerConfigurationsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all the VpnServerConfigurations in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<ListVpnServerConfigurationsResult>> GetAllNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetAllNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnServerConfigurationsResult.DeserializeListVpnServerConfigurationsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the VpnServerConfigurations in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<ListVpnServerConfigurationsResult> GetAllNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetAllNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnServerConfigurationsResult.DeserializeListVpnServerConfigurationsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
