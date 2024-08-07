// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge
{
    internal class DataBoxEdgeShareOperationSource : IOperationSource<DataBoxEdgeShareResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeShareOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeShareResource IOperationSource<DataBoxEdgeShareResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxEdgeShareData.DeserializeDataBoxEdgeShareData(document.RootElement);
            return new DataBoxEdgeShareResource(_client, data);
        }

        async ValueTask<DataBoxEdgeShareResource> IOperationSource<DataBoxEdgeShareResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxEdgeShareData.DeserializeDataBoxEdgeShareData(document.RootElement);
            return new DataBoxEdgeShareResource(_client, data);
        }
    }
}
