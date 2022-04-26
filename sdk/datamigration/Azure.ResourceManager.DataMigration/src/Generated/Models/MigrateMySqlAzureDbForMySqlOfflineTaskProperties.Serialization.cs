// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMySqlAzureDbForMySqlOfflineTaskProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input");
                writer.WriteObjectValue(Input);
            }
            if (Optional.IsDefined(IsCloneable))
            {
                writer.WritePropertyName("isCloneable");
                writer.WriteBooleanValue(IsCloneable.Value);
            }
            if (Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId");
                writer.WriteStringValue(TaskId);
            }
            writer.WritePropertyName("taskType");
            writer.WriteStringValue(TaskType.ToString());
            if (Optional.IsCollectionDefined(ClientData))
            {
                writer.WritePropertyName("clientData");
                writer.WriteStartObject();
                foreach (var item in ClientData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static MigrateMySqlAzureDbForMySqlOfflineTaskProperties DeserializeMigrateMySqlAzureDbForMySqlOfflineTaskProperties(JsonElement element)
        {
            Optional<MigrateMySqlAzureDbForMySqlOfflineTaskInput> input = default;
            Optional<IReadOnlyList<MigrateMySqlAzureDbForMySqlOfflineTaskOutput>> output = default;
            Optional<bool> isCloneable = default;
            Optional<string> taskId = default;
            TaskType taskType = default;
            Optional<IReadOnlyList<ODataError>> errors = default;
            Optional<TaskState> state = default;
            Optional<IReadOnlyList<CommandProperties>> commands = default;
            Optional<IDictionary<string, string>> clientData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    input = MigrateMySqlAzureDbForMySqlOfflineTaskInput.DeserializeMigrateMySqlAzureDbForMySqlOfflineTaskInput(property.Value);
                    continue;
                }
                if (property.NameEquals("output"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MigrateMySqlAzureDbForMySqlOfflineTaskOutput> array = new List<MigrateMySqlAzureDbForMySqlOfflineTaskOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateMySqlAzureDbForMySqlOfflineTaskOutput.DeserializeMigrateMySqlAzureDbForMySqlOfflineTaskOutput(item));
                    }
                    output = array;
                    continue;
                }
                if (property.NameEquals("isCloneable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isCloneable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("taskId"))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new TaskState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commands"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CommandProperties> array = new List<CommandProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommandProperties.DeserializeCommandProperties(item));
                    }
                    commands = array;
                    continue;
                }
                if (property.NameEquals("clientData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    clientData = dictionary;
                    continue;
                }
            }
            return new MigrateMySqlAzureDbForMySqlOfflineTaskProperties(taskType, Optional.ToList(errors), Optional.ToNullable(state), Optional.ToList(commands), Optional.ToDictionary(clientData), input.Value, Optional.ToList(output), Optional.ToNullable(isCloneable), taskId.Value);
        }
    }
}
