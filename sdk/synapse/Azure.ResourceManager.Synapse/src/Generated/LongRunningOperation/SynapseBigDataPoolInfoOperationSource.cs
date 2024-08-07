// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseBigDataPoolInfoOperationSource : IOperationSource<SynapseBigDataPoolInfoResource>
    {
        private readonly ArmClient _client;

        internal SynapseBigDataPoolInfoOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseBigDataPoolInfoResource IOperationSource<SynapseBigDataPoolInfoResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SynapseBigDataPoolInfoData.DeserializeSynapseBigDataPoolInfoData(document.RootElement);
            return new SynapseBigDataPoolInfoResource(_client, data);
        }

        async ValueTask<SynapseBigDataPoolInfoResource> IOperationSource<SynapseBigDataPoolInfoResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SynapseBigDataPoolInfoData.DeserializeSynapseBigDataPoolInfoData(document.RootElement);
            return new SynapseBigDataPoolInfoResource(_client, data);
        }
    }
}
