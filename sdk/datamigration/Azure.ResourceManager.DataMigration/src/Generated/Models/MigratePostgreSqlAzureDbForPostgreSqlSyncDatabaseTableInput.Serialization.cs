// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseTableInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WriteEndObject();
        }

        internal static MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseTableInput DeserializeMigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseTableInput(JsonElement element)
        {
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseTableInput(name.Value);
        }
    }
}
