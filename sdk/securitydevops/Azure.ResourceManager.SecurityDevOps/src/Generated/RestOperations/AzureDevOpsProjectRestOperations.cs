// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SecurityDevOps.Models;

namespace Azure.ResourceManager.SecurityDevOps
{
    internal partial class AzureDevOpsProjectRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AzureDevOpsProjectRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AzureDevOpsProjectRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/", false);
            uri.AppendPath(azureDevOpsConnectorName, true);
            uri.AppendPath("/orgs/", false);
            uri.AppendPath(azureDevOpsOrgName, true);
            uri.AppendPath("/projects", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/", false);
            uri.AppendPath(azureDevOpsConnectorName, true);
            uri.AppendPath("/orgs/", false);
            uri.AppendPath(azureDevOpsOrgName, true);
            uri.AppendPath("/projects", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/> or <paramref name="azureDevOpsOrgName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/> or <paramref name="azureDevOpsOrgName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureDevOpsProjectListResponse>> ListAsync(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureDevOpsProjectListResponse.DeserializeAzureDevOpsProjectListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/> or <paramref name="azureDevOpsOrgName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/> or <paramref name="azureDevOpsOrgName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureDevOpsProjectListResponse> List(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureDevOpsProjectListResponse.DeserializeAzureDevOpsProjectListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/", false);
            uri.AppendPath(azureDevOpsConnectorName, true);
            uri.AppendPath("/orgs/", false);
            uri.AppendPath(azureDevOpsOrgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(azureDevOpsProjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/", false);
            uri.AppendPath(azureDevOpsConnectorName, true);
            uri.AppendPath("/orgs/", false);
            uri.AppendPath(azureDevOpsOrgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(azureDevOpsProjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns a monitored AzureDevOps Project resource for a given ID. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="azureDevOpsProjectName"> Name of the AzureDevOps Project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/> or <paramref name="azureDevOpsProjectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/> or <paramref name="azureDevOpsProjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureDevOpsProjectData>> GetAsync(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));
            Argument.AssertNotNullOrEmpty(azureDevOpsProjectName, nameof(azureDevOpsProjectName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName, azureDevOpsProjectName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureDevOpsProjectData.DeserializeAzureDevOpsProjectData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AzureDevOpsProjectData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a monitored AzureDevOps Project resource for a given ID. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="azureDevOpsProjectName"> Name of the AzureDevOps Project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/> or <paramref name="azureDevOpsProjectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/> or <paramref name="azureDevOpsProjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureDevOpsProjectData> Get(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));
            Argument.AssertNotNullOrEmpty(azureDevOpsProjectName, nameof(azureDevOpsProjectName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName, azureDevOpsProjectName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureDevOpsProjectData.DeserializeAzureDevOpsProjectData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AzureDevOpsProjectData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, AzureDevOpsProjectData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/", false);
            uri.AppendPath(azureDevOpsConnectorName, true);
            uri.AppendPath("/orgs/", false);
            uri.AppendPath(azureDevOpsOrgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(azureDevOpsProjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, AzureDevOpsProjectData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/", false);
            uri.AppendPath(azureDevOpsConnectorName, true);
            uri.AppendPath("/orgs/", false);
            uri.AppendPath(azureDevOpsOrgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(azureDevOpsProjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates an Azure DevOps Project. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="azureDevOpsProjectName"> Name of the AzureDevOps Project. </param>
        /// <param name="data"> Azure DevOps Org resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/>, <paramref name="azureDevOpsProjectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/> or <paramref name="azureDevOpsProjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, AzureDevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));
            Argument.AssertNotNullOrEmpty(azureDevOpsProjectName, nameof(azureDevOpsProjectName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName, azureDevOpsProjectName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates an Azure DevOps Project. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="azureDevOpsProjectName"> Name of the AzureDevOps Project. </param>
        /// <param name="data"> Azure DevOps Org resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/>, <paramref name="azureDevOpsProjectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/> or <paramref name="azureDevOpsProjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, AzureDevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));
            Argument.AssertNotNullOrEmpty(azureDevOpsProjectName, nameof(azureDevOpsProjectName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName, azureDevOpsProjectName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, AzureDevOpsProjectData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/", false);
            uri.AppendPath(azureDevOpsConnectorName, true);
            uri.AppendPath("/orgs/", false);
            uri.AppendPath(azureDevOpsOrgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(azureDevOpsProjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, AzureDevOpsProjectData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/", false);
            uri.AppendPath(azureDevOpsConnectorName, true);
            uri.AppendPath("/orgs/", false);
            uri.AppendPath(azureDevOpsOrgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(azureDevOpsProjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update monitored AzureDevOps Project details. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="azureDevOpsProjectName"> Name of the AzureDevOps Project. </param>
        /// <param name="data"> Azure DevOps Org resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/>, <paramref name="azureDevOpsProjectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/> or <paramref name="azureDevOpsProjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, AzureDevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));
            Argument.AssertNotNullOrEmpty(azureDevOpsProjectName, nameof(azureDevOpsProjectName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName, azureDevOpsProjectName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update monitored AzureDevOps Project details. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="azureDevOpsProjectName"> Name of the AzureDevOps Project. </param>
        /// <param name="data"> Azure DevOps Org resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/>, <paramref name="azureDevOpsProjectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/>, <paramref name="azureDevOpsOrgName"/> or <paramref name="azureDevOpsProjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName, AzureDevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));
            Argument.AssertNotNullOrEmpty(azureDevOpsProjectName, nameof(azureDevOpsProjectName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName, azureDevOpsProjectName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/> or <paramref name="azureDevOpsOrgName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/> or <paramref name="azureDevOpsOrgName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureDevOpsProjectListResponse>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureDevOpsProjectListResponse.DeserializeAzureDevOpsProjectListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="azureDevOpsOrgName"> Name of the AzureDevOps Org. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/> or <paramref name="azureDevOpsOrgName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureDevOpsConnectorName"/> or <paramref name="azureDevOpsOrgName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureDevOpsProjectListResponse> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNullOrEmpty(azureDevOpsOrgName, nameof(azureDevOpsOrgName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureDevOpsProjectListResponse.DeserializeAzureDevOpsProjectListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
