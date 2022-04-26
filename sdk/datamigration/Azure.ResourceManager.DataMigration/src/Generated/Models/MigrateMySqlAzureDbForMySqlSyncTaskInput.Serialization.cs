// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMySqlAzureDbForMySqlSyncTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo");
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo");
            writer.WriteObjectValue(TargetConnectionInfo);
            writer.WritePropertyName("selectedDatabases");
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MigrateMySqlAzureDbForMySqlSyncTaskInput DeserializeMigrateMySqlAzureDbForMySqlSyncTaskInput(JsonElement element)
        {
            MySqlConnectionInfo sourceConnectionInfo = default;
            MySqlConnectionInfo targetConnectionInfo = default;
            IList<MigrateMySqlAzureDbForMySqlSyncDatabaseInput> selectedDatabases = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"))
                {
                    sourceConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"))
                {
                    targetConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("selectedDatabases"))
                {
                    List<MigrateMySqlAzureDbForMySqlSyncDatabaseInput> array = new List<MigrateMySqlAzureDbForMySqlSyncDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateMySqlAzureDbForMySqlSyncDatabaseInput.DeserializeMigrateMySqlAzureDbForMySqlSyncDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
            }
            return new MigrateMySqlAzureDbForMySqlSyncTaskInput(sourceConnectionInfo, targetConnectionInfo, selectedDatabases);
        }
    }
}
