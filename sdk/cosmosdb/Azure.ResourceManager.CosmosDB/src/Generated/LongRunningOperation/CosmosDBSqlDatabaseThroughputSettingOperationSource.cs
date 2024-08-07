// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBSqlDatabaseThroughputSettingOperationSource : IOperationSource<CosmosDBSqlDatabaseThroughputSettingResource>
    {
        private readonly ArmClient _client;
        private readonly Dictionary<string, string> _idMappings = new Dictionary<string, string>()
        {
            { "subscriptionId", "Microsoft.Resources/subscriptions" },
            { "resourceGroupName", "Microsoft.Resources/resourceGroups" },
            { "accountName", "Microsoft.DocumentDB/databaseAccounts" },
            { "databaseName", "Microsoft.DocumentDB/databaseAccounts/sqlDatabases" },
        };

        internal CosmosDBSqlDatabaseThroughputSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBSqlDatabaseThroughputSettingResource IOperationSource<CosmosDBSqlDatabaseThroughputSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScrubId(ThroughputSettingData.DeserializeThroughputSettingData(document.RootElement));
            return new CosmosDBSqlDatabaseThroughputSettingResource(_client, data);
        }

        async ValueTask<CosmosDBSqlDatabaseThroughputSettingResource> IOperationSource<CosmosDBSqlDatabaseThroughputSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScrubId(ThroughputSettingData.DeserializeThroughputSettingData(document.RootElement));
            return new CosmosDBSqlDatabaseThroughputSettingResource(_client, data);
        }

        private ThroughputSettingData ScrubId(ThroughputSettingData data)
        {
            if (data.Id.ResourceType == CosmosDBSqlDatabaseThroughputSettingResource.ResourceType)
                return data;

            var newId = CosmosDBSqlDatabaseThroughputSettingResource.CreateResourceIdentifier(
                GetName("subscriptionId", data.Id),
                GetName("resourceGroupName", data.Id),
                GetName("accountName", data.Id),
                GetName("databaseName", data.Id));

            return new ThroughputSettingData(
                newId,
                newId.Name,
                newId.ResourceType,
                data.SystemData,
                data.Tags,
                data.Location,
                data.Resource,
                data.Identity,
                null);
        }

        private string GetName(string param, ResourceIdentifier id)
        {
            while (id.ResourceType != _idMappings[param])
                id = id.Parent;
            return id.Name;
        }
    }
}
