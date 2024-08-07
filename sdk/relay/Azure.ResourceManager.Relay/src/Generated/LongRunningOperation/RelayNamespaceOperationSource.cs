// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Relay
{
    internal class RelayNamespaceOperationSource : IOperationSource<RelayNamespaceResource>
    {
        private readonly ArmClient _client;

        internal RelayNamespaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        RelayNamespaceResource IOperationSource<RelayNamespaceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RelayNamespaceData.DeserializeRelayNamespaceData(document.RootElement);
            return new RelayNamespaceResource(_client, data);
        }

        async ValueTask<RelayNamespaceResource> IOperationSource<RelayNamespaceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RelayNamespaceData.DeserializeRelayNamespaceData(document.RootElement);
            return new RelayNamespaceResource(_client, data);
        }
    }
}
