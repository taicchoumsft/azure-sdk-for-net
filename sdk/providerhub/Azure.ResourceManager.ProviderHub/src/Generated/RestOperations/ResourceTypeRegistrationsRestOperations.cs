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
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub
{
    internal partial class ResourceTypeRegistrationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ResourceTypeRegistrationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ResourceTypeRegistrationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-11-20";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string providerNamespace, string resourceType)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/resourcetypeRegistrations/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string providerNamespace, string resourceType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/resourcetypeRegistrations/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a resource type details in the given subscription and provider. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ResourceTypeRegistrationData>> GetAsync(string subscriptionId, string providerNamespace, string resourceType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));

            using var message = CreateGetRequest(subscriptionId, providerNamespace, resourceType);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceTypeRegistrationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceTypeRegistrationData.DeserializeResourceTypeRegistrationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ResourceTypeRegistrationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a resource type details in the given subscription and provider. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ResourceTypeRegistrationData> Get(string subscriptionId, string providerNamespace, string resourceType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));

            using var message = CreateGetRequest(subscriptionId, providerNamespace, resourceType);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceTypeRegistrationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceTypeRegistrationData.DeserializeResourceTypeRegistrationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ResourceTypeRegistrationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string providerNamespace, string resourceType, ResourceTypeRegistrationData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/resourcetypeRegistrations/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string providerNamespace, string resourceType, ResourceTypeRegistrationData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/resourcetypeRegistrations/", false);
            uri.AppendPath(resourceType, true);
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

        /// <summary> Creates or updates a resource type. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="data"> The required request body parameters supplied to the resource type registration CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/>, <paramref name="resourceType"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string providerNamespace, string resourceType, ResourceTypeRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, providerNamespace, resourceType, data);
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

        /// <summary> Creates or updates a resource type. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="data"> The required request body parameters supplied to the resource type registration CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/>, <paramref name="resourceType"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string providerNamespace, string resourceType, ResourceTypeRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, providerNamespace, resourceType, data);
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

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string providerNamespace, string resourceType)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/resourcetypeRegistrations/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string providerNamespace, string resourceType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/resourcetypeRegistrations/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a resource type. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string providerNamespace, string resourceType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));

            using var message = CreateDeleteRequest(subscriptionId, providerNamespace, resourceType);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a resource type. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string providerNamespace, string resourceType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));

            using var message = CreateDeleteRequest(subscriptionId, providerNamespace, resourceType);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByProviderRegistrationRequestUri(string subscriptionId, string providerNamespace)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/resourcetypeRegistrations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByProviderRegistrationRequest(string subscriptionId, string providerNamespace)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/resourcetypeRegistrations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the list of the resource types for the given provider. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ResourceTypeRegistrationListResult>> ListByProviderRegistrationAsync(string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateListByProviderRegistrationRequest(subscriptionId, providerNamespace);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceTypeRegistrationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceTypeRegistrationListResult.DeserializeResourceTypeRegistrationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of the resource types for the given provider. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ResourceTypeRegistrationListResult> ListByProviderRegistration(string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateListByProviderRegistrationRequest(subscriptionId, providerNamespace);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceTypeRegistrationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceTypeRegistrationListResult.DeserializeResourceTypeRegistrationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByProviderRegistrationNextPageRequestUri(string nextLink, string subscriptionId, string providerNamespace)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByProviderRegistrationNextPageRequest(string nextLink, string subscriptionId, string providerNamespace)
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

        /// <summary> Gets the list of the resource types for the given provider. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ResourceTypeRegistrationListResult>> ListByProviderRegistrationNextPageAsync(string nextLink, string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateListByProviderRegistrationNextPageRequest(nextLink, subscriptionId, providerNamespace);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceTypeRegistrationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceTypeRegistrationListResult.DeserializeResourceTypeRegistrationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of the resource types for the given provider. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ResourceTypeRegistrationListResult> ListByProviderRegistrationNextPage(string nextLink, string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateListByProviderRegistrationNextPageRequest(nextLink, subscriptionId, providerNamespace);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceTypeRegistrationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceTypeRegistrationListResult.DeserializeResourceTypeRegistrationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
