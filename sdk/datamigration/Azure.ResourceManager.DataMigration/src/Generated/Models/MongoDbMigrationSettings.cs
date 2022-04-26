// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes how a MongoDB data migration should be performed. </summary>
    public partial class MongoDbMigrationSettings
    {
        /// <summary> Initializes a new instance of MongoDbMigrationSettings. </summary>
        /// <param name="databases"> The databases on the source cluster to migrate to the target. The keys are the names of the databases. </param>
        /// <param name="source"> Settings used to connect to the source cluster. </param>
        /// <param name="target"> Settings used to connect to the target cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databases"/>, <paramref name="source"/> or <paramref name="target"/> is null. </exception>
        public MongoDbMigrationSettings(IDictionary<string, MongoDbDatabaseSettings> databases, MongoDbConnectionInfo source, MongoDbConnectionInfo target)
        {
            if (databases == null)
            {
                throw new ArgumentNullException(nameof(databases));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            Databases = databases;
            Source = source;
            Target = target;
        }

        /// <summary> Initializes a new instance of MongoDbMigrationSettings. </summary>
        /// <param name="boostRUs"> The RU limit on a CosmosDB target that collections will be temporarily increased to (if lower) during the initial copy of a migration, from 10,000 to 1,000,000, or 0 to use the default boost (which is generally the maximum), or null to not boost the RUs. This setting has no effect on non-CosmosDB targets. </param>
        /// <param name="databases"> The databases on the source cluster to migrate to the target. The keys are the names of the databases. </param>
        /// <param name="replication"> Describes how changes will be replicated from the source to the target. The default is OneTime. </param>
        /// <param name="source"> Settings used to connect to the source cluster. </param>
        /// <param name="target"> Settings used to connect to the target cluster. </param>
        /// <param name="throttling"> Settings used to limit the resource usage of the migration. </param>
        internal MongoDbMigrationSettings(int? boostRUs, IDictionary<string, MongoDbDatabaseSettings> databases, MongoDbReplication? replication, MongoDbConnectionInfo source, MongoDbConnectionInfo target, MongoDbThrottlingSettings throttling)
        {
            BoostRUs = boostRUs;
            Databases = databases;
            Replication = replication;
            Source = source;
            Target = target;
            Throttling = throttling;
        }

        /// <summary> The RU limit on a CosmosDB target that collections will be temporarily increased to (if lower) during the initial copy of a migration, from 10,000 to 1,000,000, or 0 to use the default boost (which is generally the maximum), or null to not boost the RUs. This setting has no effect on non-CosmosDB targets. </summary>
        public int? BoostRUs { get; set; }
        /// <summary> The databases on the source cluster to migrate to the target. The keys are the names of the databases. </summary>
        public IDictionary<string, MongoDbDatabaseSettings> Databases { get; }
        /// <summary> Describes how changes will be replicated from the source to the target. The default is OneTime. </summary>
        public MongoDbReplication? Replication { get; set; }
        /// <summary> Settings used to connect to the source cluster. </summary>
        public MongoDbConnectionInfo Source { get; set; }
        /// <summary> Settings used to connect to the target cluster. </summary>
        public MongoDbConnectionInfo Target { get; set; }
        /// <summary> Settings used to limit the resource usage of the migration. </summary>
        public MongoDbThrottlingSettings Throttling { get; set; }
    }
}
