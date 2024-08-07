// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal class GatewayRouteListResultOperationSource : IOperationSource<GatewayRouteListResult>
    {
        GatewayRouteListResult IOperationSource<GatewayRouteListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return GatewayRouteListResult.DeserializeGatewayRouteListResult(document.RootElement);
        }

        async ValueTask<GatewayRouteListResult> IOperationSource<GatewayRouteListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return GatewayRouteListResult.DeserializeGatewayRouteListResult(document.RootElement);
        }
    }
}
