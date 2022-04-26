// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDbMigrationProgress
    {
        internal static MongoDbMigrationProgress DeserializeMongoDbMigrationProgress(JsonElement element)
        {
            Optional<IReadOnlyDictionary<string, MongoDbDatabaseProgress>> databases = default;
            long bytesCopied = default;
            long documentsCopied = default;
            string elapsedTime = default;
            IReadOnlyDictionary<string, MongoDbError> errors = default;
            long eventsPending = default;
            long eventsReplayed = default;
            Optional<DateTimeOffset> lastEventTime = default;
            Optional<DateTimeOffset> lastReplayTime = default;
            Optional<string> name = default;
            Optional<string> qualifiedName = default;
            MongoDbProgressResultType resultType = default;
            MongoDbMigrationState state = default;
            long totalBytes = default;
            long totalDocuments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databases"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, MongoDbDatabaseProgress> dictionary = new Dictionary<string, MongoDbDatabaseProgress>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDbDatabaseProgress.DeserializeMongoDbDatabaseProgress(property0.Value));
                    }
                    databases = dictionary;
                    continue;
                }
                if (property.NameEquals("bytesCopied"))
                {
                    bytesCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentsCopied"))
                {
                    documentsCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("elapsedTime"))
                {
                    elapsedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    Dictionary<string, MongoDbError> dictionary = new Dictionary<string, MongoDbError>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDbError.DeserializeMongoDbError(property0.Value));
                    }
                    errors = dictionary;
                    continue;
                }
                if (property.NameEquals("eventsPending"))
                {
                    eventsPending = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("eventsReplayed"))
                {
                    eventsReplayed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastEventTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastEventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastReplayTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastReplayTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = new MongoDbProgressResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = new MongoDbMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalBytes"))
                {
                    totalBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDocuments"))
                {
                    totalDocuments = property.Value.GetInt64();
                    continue;
                }
            }
            return new MongoDbMigrationProgress(bytesCopied, documentsCopied, elapsedTime, errors, eventsPending, eventsReplayed, Optional.ToNullable(lastEventTime), Optional.ToNullable(lastReplayTime), name.Value, qualifiedName.Value, resultType, state, totalBytes, totalDocuments, Optional.ToDictionary(databases));
        }
    }
}
