// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MySql
{
    internal class MySqlVirtualNetworkRuleOperationSource : IOperationSource<MySqlVirtualNetworkRuleResource>
    {
        private readonly ArmClient _client;

        internal MySqlVirtualNetworkRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlVirtualNetworkRuleResource IOperationSource<MySqlVirtualNetworkRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlVirtualNetworkRuleData.DeserializeMySqlVirtualNetworkRuleData(document.RootElement);
            return new MySqlVirtualNetworkRuleResource(_client, data);
        }

        async ValueTask<MySqlVirtualNetworkRuleResource> IOperationSource<MySqlVirtualNetworkRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlVirtualNetworkRuleData.DeserializeMySqlVirtualNetworkRuleData(document.RootElement);
            return new MySqlVirtualNetworkRuleResource(_client, data);
        }
    }
}
