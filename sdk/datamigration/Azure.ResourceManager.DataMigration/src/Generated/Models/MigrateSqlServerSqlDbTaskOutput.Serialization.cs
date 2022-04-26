// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDbTaskOutput
    {
        internal static MigrateSqlServerSqlDbTaskOutput DeserializeMigrateSqlServerSqlDbTaskOutput(JsonElement element)
        {
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelOutput": return MigrateSqlServerSqlDbTaskOutputDatabaseLevel.DeserializeMigrateSqlServerSqlDbTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateSqlServerSqlDbTaskOutputError.DeserializeMigrateSqlServerSqlDbTaskOutputError(element);
                    case "MigrationDatabaseLevelValidationOutput": return MigrateSqlServerSqlDbTaskOutputDatabaseLevelValidationResult.DeserializeMigrateSqlServerSqlDbTaskOutputDatabaseLevelValidationResult(element);
                    case "MigrationLevelOutput": return MigrateSqlServerSqlDbTaskOutputMigrationLevel.DeserializeMigrateSqlServerSqlDbTaskOutputMigrationLevel(element);
                    case "MigrationValidationOutput": return MigrateSqlServerSqlDbTaskOutputValidationResult.DeserializeMigrateSqlServerSqlDbTaskOutputValidationResult(element);
                    case "TableLevelOutput": return MigrateSqlServerSqlDbTaskOutputTableLevel.DeserializeMigrateSqlServerSqlDbTaskOutputTableLevel(element);
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
            return new MigrateSqlServerSqlDbTaskOutput(id.Value, resultType);
        }
    }
}
