// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database file specific information for input. </summary>
    internal partial class DatabaseFileInput
    {
        /// <summary> Initializes a new instance of DatabaseFileInput. </summary>
        internal DatabaseFileInput()
        {
        }

        /// <summary> Unique identifier for database file. </summary>
        public string Id { get; }
        /// <summary> Logical name of the file. </summary>
        public string LogicalName { get; }
        /// <summary> Operating-system full path of the file. </summary>
        public string PhysicalFullName { get; }
        /// <summary> Suggested full path of the file for restoring. </summary>
        public string RestoreFullName { get; }
        /// <summary> Database file type. </summary>
        public DatabaseFileType? FileType { get; }
    }
}
