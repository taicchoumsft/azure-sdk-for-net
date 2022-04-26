// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDbFinishCommand : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input");
                writer.WriteObjectValue(Input);
            }
            writer.WritePropertyName("commandType");
            writer.WriteStringValue(CommandType.ToString());
            writer.WriteEndObject();
        }

        internal static MongoDbFinishCommand DeserializeMongoDbFinishCommand(JsonElement element)
        {
            Optional<MongoDbFinishCommandInput> input = default;
            CommandType commandType = default;
            Optional<IReadOnlyList<ODataError>> errors = default;
            Optional<CommandState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    input = MongoDbFinishCommandInput.DeserializeMongoDbFinishCommandInput(property.Value);
                    continue;
                }
                if (property.NameEquals("commandType"))
                {
                    commandType = new CommandType(property.Value.GetString());
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
                    state = new CommandState(property.Value.GetString());
                    continue;
                }
            }
            return new MongoDbFinishCommand(commandType, Optional.ToList(errors), Optional.ToNullable(state), input.Value);
        }
    }
}
