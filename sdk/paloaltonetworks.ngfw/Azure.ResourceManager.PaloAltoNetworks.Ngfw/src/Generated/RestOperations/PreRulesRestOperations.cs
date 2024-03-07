// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal partial class PreRulesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PreRulesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PreRulesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string globalRulestackName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/preRules", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List PreRulesResource resources by Tenant. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PreRulesResourceListResult>> ListAsync(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var message = CreateListRequest(globalRulestackName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PreRulesResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PreRulesResourceListResult.DeserializePreRulesResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List PreRulesResource resources by Tenant. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PreRulesResourceListResult> List(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var message = CreateListRequest(globalRulestackName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PreRulesResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PreRulesResourceListResult.DeserializePreRulesResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string globalRulestackName, string priority)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/preRules/", false);
            uri.AppendPath(priority, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a PreRulesResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PreRulestackRuleData>> GetAsync(string globalRulestackName, string priority, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateGetRequest(globalRulestackName, priority);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PreRulestackRuleData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PreRulestackRuleData.DeserializePreRulestackRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PreRulestackRuleData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a PreRulesResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PreRulestackRuleData> Get(string globalRulestackName, string priority, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateGetRequest(globalRulestackName, priority);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PreRulestackRuleData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PreRulestackRuleData.DeserializePreRulestackRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PreRulestackRuleData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string globalRulestackName, string priority, PreRulestackRuleData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/preRules/", false);
            uri.AppendPath(priority, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a PreRulesResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/>, <paramref name="priority"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string globalRulestackName, string priority, PreRulestackRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(globalRulestackName, priority, data);
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

        /// <summary> Create a PreRulesResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/>, <paramref name="priority"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string globalRulestackName, string priority, PreRulestackRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(globalRulestackName, priority, data);
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

        internal HttpMessage CreateDeleteRequest(string globalRulestackName, string priority)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/preRules/", false);
            uri.AppendPath(priority, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a PreRulesResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string globalRulestackName, string priority, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateDeleteRequest(globalRulestackName, priority);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a PreRulesResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string globalRulestackName, string priority, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateDeleteRequest(globalRulestackName, priority);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetCountersRequest(string globalRulestackName, string priority, string firewallName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/preRules/", false);
            uri.AppendPath(priority, true);
            uri.AppendPath("/getCounters", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (firewallName != null)
            {
                uri.AppendQuery("firewallName", firewallName, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get counters. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FirewallRuleCounter>> GetCountersAsync(string globalRulestackName, string priority, string firewallName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateGetCountersRequest(globalRulestackName, priority, firewallName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallRuleCounter value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FirewallRuleCounter.DeserializeFirewallRuleCounter(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get counters. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FirewallRuleCounter> GetCounters(string globalRulestackName, string priority, string firewallName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateGetCountersRequest(globalRulestackName, priority, firewallName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallRuleCounter value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FirewallRuleCounter.DeserializeFirewallRuleCounter(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRefreshCountersRequest(string globalRulestackName, string priority, string firewallName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/preRules/", false);
            uri.AppendPath(priority, true);
            uri.AppendPath("/refreshCounters", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (firewallName != null)
            {
                uri.AppendQuery("firewallName", firewallName, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Refresh counters. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> RefreshCountersAsync(string globalRulestackName, string priority, string firewallName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateRefreshCountersRequest(globalRulestackName, priority, firewallName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Refresh counters. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public Response RefreshCounters(string globalRulestackName, string priority, string firewallName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateRefreshCountersRequest(globalRulestackName, priority, firewallName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateResetCountersRequest(string globalRulestackName, string priority, string firewallName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/preRules/", false);
            uri.AppendPath(priority, true);
            uri.AppendPath("/resetCounters", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (firewallName != null)
            {
                uri.AppendQuery("firewallName", firewallName, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Reset counters. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FirewallRuleResetConter>> ResetCountersAsync(string globalRulestackName, string priority, string firewallName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateResetCountersRequest(globalRulestackName, priority, firewallName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallRuleResetConter value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FirewallRuleResetConter.DeserializeFirewallRuleResetConter(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Reset counters. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="priority"> Pre Rule priority. </param>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="priority"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FirewallRuleResetConter> ResetCounters(string globalRulestackName, string priority, string firewallName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(priority, nameof(priority));

            using var message = CreateResetCountersRequest(globalRulestackName, priority, firewallName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallRuleResetConter value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FirewallRuleResetConter.DeserializeFirewallRuleResetConter(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string globalRulestackName)
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

        /// <summary> List PreRulesResource resources by Tenant. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PreRulesResourceListResult>> ListNextPageAsync(string nextLink, string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var message = CreateListNextPageRequest(nextLink, globalRulestackName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PreRulesResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PreRulesResourceListResult.DeserializePreRulesResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List PreRulesResource resources by Tenant. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PreRulesResourceListResult> ListNextPage(string nextLink, string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var message = CreateListNextPageRequest(nextLink, globalRulestackName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PreRulesResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PreRulesResourceListResult.DeserializePreRulesResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
