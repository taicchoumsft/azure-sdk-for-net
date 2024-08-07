// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB
{
    internal class GremlinDatabaseOperationSource : IOperationSource<GremlinDatabaseResource>
    {
        private readonly ArmClient _client;

        internal GremlinDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        GremlinDatabaseResource IOperationSource<GremlinDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GremlinDatabaseData.DeserializeGremlinDatabaseData(document.RootElement);
            return new GremlinDatabaseResource(_client, data);
        }

        async ValueTask<GremlinDatabaseResource> IOperationSource<GremlinDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GremlinDatabaseData.DeserializeGremlinDatabaseData(document.RootElement);
            return new GremlinDatabaseResource(_client, data);
        }
    }
}
