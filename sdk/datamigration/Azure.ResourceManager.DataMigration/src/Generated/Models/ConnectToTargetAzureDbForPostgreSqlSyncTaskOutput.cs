// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that validates connection to Azure Database for PostgreSQL and target server requirements. </summary>
    public partial class ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput. </summary>
        internal ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput()
        {
            Databases = new ChangeTrackingList<string>();
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="targetServerVersion"> Version of the target server. </param>
        /// <param name="databases"> List of databases on target server. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="validationErrors"> Validation errors associated with the task. </param>
        internal ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput(string id, string targetServerVersion, IReadOnlyList<string> databases, string targetServerBrandVersion, IReadOnlyList<ReportableException> validationErrors)
        {
            Id = id;
            TargetServerVersion = targetServerVersion;
            Databases = databases;
            TargetServerBrandVersion = targetServerBrandVersion;
            ValidationErrors = validationErrors;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Version of the target server. </summary>
        public string TargetServerVersion { get; }
        /// <summary> List of databases on target server. </summary>
        public IReadOnlyList<string> Databases { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Validation errors associated with the task. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
