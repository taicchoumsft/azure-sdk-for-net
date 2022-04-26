// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataMigration
{
    internal class DatabaseMigrationSqlMiResourceOperationSource : IOperationSource<DatabaseMigrationSqlMiResource>
    {
        private readonly ArmClient _client;

        internal DatabaseMigrationSqlMiResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        DatabaseMigrationSqlMiResource IOperationSource<DatabaseMigrationSqlMiResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DatabaseMigrationSqlMiData.DeserializeDatabaseMigrationSqlMiData(document.RootElement);
            return new DatabaseMigrationSqlMiResource(_client, data);
        }

        async ValueTask<DatabaseMigrationSqlMiResource> IOperationSource<DatabaseMigrationSqlMiResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DatabaseMigrationSqlMiData.DeserializeDatabaseMigrationSqlMiData(document.RootElement);
            return new DatabaseMigrationSqlMiResource(_client, data);
        }
    }
}
