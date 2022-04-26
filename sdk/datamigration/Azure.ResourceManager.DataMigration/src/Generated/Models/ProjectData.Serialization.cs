// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    public partial class ProjectData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(SourcePlatform))
            {
                writer.WritePropertyName("sourcePlatform");
                writer.WriteStringValue(SourcePlatform.Value.ToString());
            }
            if (Optional.IsDefined(AzureAuthenticationInfo))
            {
                writer.WritePropertyName("azureAuthenticationInfo");
                writer.WriteObjectValue(AzureAuthenticationInfo);
            }
            if (Optional.IsDefined(TargetPlatform))
            {
                writer.WritePropertyName("targetPlatform");
                writer.WriteStringValue(TargetPlatform.Value.ToString());
            }
            if (Optional.IsDefined(SourceConnectionInfo))
            {
                writer.WritePropertyName("sourceConnectionInfo");
                writer.WriteObjectValue(SourceConnectionInfo);
            }
            if (Optional.IsDefined(TargetConnectionInfo))
            {
                writer.WritePropertyName("targetConnectionInfo");
                writer.WriteObjectValue(TargetConnectionInfo);
            }
            if (Optional.IsCollectionDefined(DatabasesInfo))
            {
                writer.WritePropertyName("databasesInfo");
                writer.WriteStartArray();
                foreach (var item in DatabasesInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ProjectData DeserializeProjectData(JsonElement element)
        {
            Optional<string> etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            SystemData systemData = default;
            Optional<ProjectSourcePlatform> sourcePlatform = default;
            Optional<AzureActiveDirectoryApp> azureAuthenticationInfo = default;
            Optional<ProjectTargetPlatform> targetPlatform = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<ConnectionInfo> sourceConnectionInfo = default;
            Optional<ConnectionInfo> targetConnectionInfo = default;
            Optional<IList<DatabaseInfo>> databasesInfo = default;
            Optional<ProjectProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourcePlatform"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourcePlatform = new ProjectSourcePlatform(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureAuthenticationInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureAuthenticationInfo = AzureActiveDirectoryApp.DeserializeAzureActiveDirectoryApp(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetPlatform"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetPlatform = new ProjectTargetPlatform(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceConnectionInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceConnectionInfo = ConnectionInfo.DeserializeConnectionInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetConnectionInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetConnectionInfo = ConnectionInfo.DeserializeConnectionInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("databasesInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DatabaseInfo> array = new List<DatabaseInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseInfo.DeserializeDatabaseInfo(item));
                            }
                            databasesInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProjectProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProjectData(id, name, type, systemData, tags, location, etag.Value, Optional.ToNullable(sourcePlatform), azureAuthenticationInfo.Value, Optional.ToNullable(targetPlatform), Optional.ToNullable(creationTime), sourceConnectionInfo.Value, targetConnectionInfo.Value, Optional.ToList(databasesInfo), Optional.ToNullable(provisioningState));
        }
    }
}
