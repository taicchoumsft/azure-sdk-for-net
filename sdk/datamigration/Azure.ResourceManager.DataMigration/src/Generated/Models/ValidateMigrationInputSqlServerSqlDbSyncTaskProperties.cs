// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for task that validates migration input for SQL to Azure SQL DB sync migrations. </summary>
    public partial class ValidateMigrationInputSqlServerSqlDbSyncTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of ValidateMigrationInputSqlServerSqlDbSyncTaskProperties. </summary>
        public ValidateMigrationInputSqlServerSqlDbSyncTaskProperties()
        {
            Output = new ChangeTrackingList<ValidateSyncMigrationInputSqlServerTaskOutput>();
            TaskType = TaskType.ValidateMigrationInputSqlServerSqlDbSync;
        }

        /// <summary> Initializes a new instance of ValidateMigrationInputSqlServerSqlDbSyncTaskProperties. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands"> Array of command properties. </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="input"> Task input. </param>
        /// <param name="output"> Task output. This is ignored if submitted. </param>
        internal ValidateMigrationInputSqlServerSqlDbSyncTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, ValidateSyncMigrationInputSqlServerTaskInput input, IReadOnlyList<ValidateSyncMigrationInputSqlServerTaskOutput> output) : base(taskType, errors, state, commands, clientData)
        {
            Input = input;
            Output = output;
            TaskType = taskType;
        }

        /// <summary> Task input. </summary>
        public ValidateSyncMigrationInputSqlServerTaskInput Input { get; set; }
        /// <summary> Task output. This is ignored if submitted. </summary>
        public IReadOnlyList<ValidateSyncMigrationInputSqlServerTaskOutput> Output { get; }
    }
}
