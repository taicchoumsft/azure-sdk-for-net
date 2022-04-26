// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for task that migrates SQL Server databases to Azure SQL Database Managed Instance. </summary>
    public partial class MigrateSqlServerSqlMITaskOutput
    {
        /// <summary> Initializes a new instance of MigrateSqlServerSqlMITaskOutput. </summary>
        internal MigrateSqlServerSqlMITaskOutput()
        {
        }

        /// <summary> Initializes a new instance of MigrateSqlServerSqlMITaskOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        internal MigrateSqlServerSqlMITaskOutput(string id, string resultType)
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
