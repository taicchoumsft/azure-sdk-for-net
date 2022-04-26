// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMySqlAzureDbForMySqlSyncTaskOutput
    {
        internal static MigrateMySqlAzureDbForMySqlSyncTaskOutput DeserializeMigrateMySqlAzureDbForMySqlSyncTaskOutput(JsonElement element)
        {
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelErrorOutput": return MigrateMySqlAzureDbForMySqlSyncTaskOutputDatabaseError.DeserializeMigrateMySqlAzureDbForMySqlSyncTaskOutputDatabaseError(element);
                    case "DatabaseLevelOutput": return MigrateMySqlAzureDbForMySqlSyncTaskOutputDatabaseLevel.DeserializeMigrateMySqlAzureDbForMySqlSyncTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateMySqlAzureDbForMySqlSyncTaskOutputError.DeserializeMigrateMySqlAzureDbForMySqlSyncTaskOutputError(element);
                    case "MigrationLevelOutput": return MigrateMySqlAzureDbForMySqlSyncTaskOutputMigrationLevel.DeserializeMigrateMySqlAzureDbForMySqlSyncTaskOutputMigrationLevel(element);
                    case "TableLevelOutput": return MigrateMySqlAzureDbForMySqlSyncTaskOutputTableLevel.DeserializeMigrateMySqlAzureDbForMySqlSyncTaskOutputTableLevel(element);
                }
            }
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateMySqlAzureDbForMySqlSyncTaskOutput(id.Value, resultType);
        }
    }
}
