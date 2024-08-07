// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the task that validates a migration for Oracle to Azure Database for PostgreSQL for online migrations. </summary>
    public partial class ValidateOracleAzureDBForPostgreSqlSyncTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of <see cref="ValidateOracleAzureDBForPostgreSqlSyncTaskProperties"/>. </summary>
        public ValidateOracleAzureDBForPostgreSqlSyncTaskProperties()
        {
            Output = new ChangeTrackingList<ValidateOracleAzureDBPostgreSqlSyncTaskOutput>();
            TaskType = TaskType.ValidateOracleAzureDBPostgreSqlSync;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateOracleAzureDBForPostgreSqlSyncTaskProperties"/>. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/>, <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="input"> Input for the task that migrates Oracle databases to Azure Database for PostgreSQL for online migrations. </param>
        /// <param name="output"> An array containing a single validation error response object. </param>
        internal ValidateOracleAzureDBForPostgreSqlSyncTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, IDictionary<string, BinaryData> serializedAdditionalRawData, MigrateOracleAzureDBPostgreSqlSyncTaskInput input, IReadOnlyList<ValidateOracleAzureDBPostgreSqlSyncTaskOutput> output) : base(taskType, errors, state, commands, clientData, serializedAdditionalRawData)
        {
            Input = input;
            Output = output;
            TaskType = taskType;
        }

        /// <summary> Input for the task that migrates Oracle databases to Azure Database for PostgreSQL for online migrations. </summary>
        public MigrateOracleAzureDBPostgreSqlSyncTaskInput Input { get; set; }
        /// <summary> An array containing a single validation error response object. </summary>
        public IReadOnlyList<ValidateOracleAzureDBPostgreSqlSyncTaskOutput> Output { get; }
    }
}
