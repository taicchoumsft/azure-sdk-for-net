// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class HostingEnvironmentMultiRolePoolOperationSource : IOperationSource<HostingEnvironmentMultiRolePoolResource>
    {
        private readonly ArmClient _client;

        internal HostingEnvironmentMultiRolePoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        HostingEnvironmentMultiRolePoolResource IOperationSource<HostingEnvironmentMultiRolePoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppServiceWorkerPoolData.DeserializeAppServiceWorkerPoolData(document.RootElement);
            return new HostingEnvironmentMultiRolePoolResource(_client, data);
        }

        async ValueTask<HostingEnvironmentMultiRolePoolResource> IOperationSource<HostingEnvironmentMultiRolePoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppServiceWorkerPoolData.DeserializeAppServiceWorkerPoolData(document.RootElement);
            return new HostingEnvironmentMultiRolePoolResource(_client, data);
        }
    }
}
