// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault
{
    internal class KeyVaultPrivateEndpointConnectionOperationSource : IOperationSource<KeyVaultPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal KeyVaultPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        KeyVaultPrivateEndpointConnectionResource IOperationSource<KeyVaultPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = KeyVaultPrivateEndpointConnectionData.DeserializeKeyVaultPrivateEndpointConnectionData(document.RootElement);
            return new KeyVaultPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<KeyVaultPrivateEndpointConnectionResource> IOperationSource<KeyVaultPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = KeyVaultPrivateEndpointConnectionData.DeserializeKeyVaultPrivateEndpointConnectionData(document.RootElement);
            return new KeyVaultPrivateEndpointConnectionResource(_client, data);
        }
    }
}
