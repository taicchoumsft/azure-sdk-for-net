// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class SqlServerDatabaseRestorePointOperationSource : IOperationSource<SqlServerDatabaseRestorePointResource>
    {
        private readonly ArmClient _client;

        internal SqlServerDatabaseRestorePointOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlServerDatabaseRestorePointResource IOperationSource<SqlServerDatabaseRestorePointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlServerDatabaseRestorePointData.DeserializeSqlServerDatabaseRestorePointData(document.RootElement);
            return new SqlServerDatabaseRestorePointResource(_client, data);
        }

        async ValueTask<SqlServerDatabaseRestorePointResource> IOperationSource<SqlServerDatabaseRestorePointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlServerDatabaseRestorePointData.DeserializeSqlServerDatabaseRestorePointData(document.RootElement);
            return new SqlServerDatabaseRestorePointResource(_client, data);
        }
    }
}
