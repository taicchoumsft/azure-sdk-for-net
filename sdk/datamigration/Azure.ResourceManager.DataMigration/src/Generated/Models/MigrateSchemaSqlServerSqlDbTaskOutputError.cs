// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSchemaSqlServerSqlDbTaskOutputError. </summary>
    public partial class MigrateSchemaSqlServerSqlDbTaskOutputError : MigrateSchemaSqlServerSqlDbTaskOutput
    {
        /// <summary> Initializes a new instance of MigrateSchemaSqlServerSqlDbTaskOutputError. </summary>
        internal MigrateSchemaSqlServerSqlDbTaskOutputError()
        {
            ResultType = "SchemaErrorOutput";
        }

        /// <summary> Initializes a new instance of MigrateSchemaSqlServerSqlDbTaskOutputError. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="commandText"> Schema command which failed. </param>
        /// <param name="errorText"> Reason of failure. </param>
        internal MigrateSchemaSqlServerSqlDbTaskOutputError(string id, string resultType, string commandText, string errorText) : base(id, resultType)
        {
            CommandText = commandText;
            ErrorText = errorText;
            ResultType = resultType ?? "SchemaErrorOutput";
        }

        /// <summary> Schema command which failed. </summary>
        public string CommandText { get; }
        /// <summary> Reason of failure. </summary>
        public string ErrorText { get; }
    }
}
