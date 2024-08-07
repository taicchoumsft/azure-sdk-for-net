// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute
{
    internal class HybridComputeMachineExtensionOperationSource : IOperationSource<HybridComputeMachineExtensionResource>
    {
        private readonly ArmClient _client;

        internal HybridComputeMachineExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        HybridComputeMachineExtensionResource IOperationSource<HybridComputeMachineExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HybridComputeMachineExtensionData.DeserializeHybridComputeMachineExtensionData(document.RootElement);
            return new HybridComputeMachineExtensionResource(_client, data);
        }

        async ValueTask<HybridComputeMachineExtensionResource> IOperationSource<HybridComputeMachineExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HybridComputeMachineExtensionData.DeserializeHybridComputeMachineExtensionData(document.RootElement);
            return new HybridComputeMachineExtensionResource(_client, data);
        }
    }
}
