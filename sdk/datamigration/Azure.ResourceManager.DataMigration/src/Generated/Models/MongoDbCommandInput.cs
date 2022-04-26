// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes the input to the &apos;cancel&apos; and &apos;restart&apos; MongoDB migration commands. </summary>
    public partial class MongoDbCommandInput
    {
        /// <summary> Initializes a new instance of MongoDbCommandInput. </summary>
        public MongoDbCommandInput()
        {
        }

        /// <summary> Initializes a new instance of MongoDbCommandInput. </summary>
        /// <param name="objectName"> The qualified name of a database or collection to act upon, or null to act upon the entire migration. </param>
        internal MongoDbCommandInput(string objectName)
        {
            ObjectName = objectName;
        }

        /// <summary> The qualified name of a database or collection to act upon, or null to act upon the entire migration. </summary>
        public string ObjectName { get; set; }
    }
}
