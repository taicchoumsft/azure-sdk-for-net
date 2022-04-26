// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that migrates PostgreSQL databases to Azure Database for PostgreSQL for online migrations. </summary>
    public partial class MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput. </summary>
        internal MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput()
        {
        }

        /// <summary> Initializes a new instance of MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        internal MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput(string id, string resultType)
        {
            Id = id;
            ResultType = resultType;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Result type. </summary>
        internal string ResultType { get; set; }
    }
}
