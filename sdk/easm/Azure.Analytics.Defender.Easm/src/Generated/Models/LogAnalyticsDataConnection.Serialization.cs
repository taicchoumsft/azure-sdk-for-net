// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    public partial class LogAnalyticsDataConnection
    {
        internal static LogAnalyticsDataConnection DeserializeLogAnalyticsDataConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LogAnalyticsDataConnectionProperties properties = default;
            string kind = default;
            Optional<string> id = default;
            string name = default;
            Optional<string> displayName = default;
            Optional<DataConnectionContent> content = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<DataConnectionFrequency> frequency = default;
            Optional<int> frequencyOffset = default;
            Optional<DateTimeOffset> updatedDate = default;
            Optional<DateTimeOffset> userUpdatedAt = default;
            Optional<bool> active = default;
            Optional<string> inactiveMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = LogAnalyticsDataConnectionProperties.DeserializeLogAnalyticsDataConnectionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = new DataConnectionContent(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("frequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequency = new DataConnectionFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frequencyOffset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequencyOffset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("updatedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userUpdatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userUpdatedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("active"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    active = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("inactiveMessage"u8))
                {
                    inactiveMessage = property.Value.GetString();
                    continue;
                }
            }
            return new LogAnalyticsDataConnection(kind, id.Value, name, displayName.Value, Optional.ToNullable(content), Optional.ToNullable(createdDate), Optional.ToNullable(frequency), Optional.ToNullable(frequencyOffset), Optional.ToNullable(updatedDate), Optional.ToNullable(userUpdatedAt), Optional.ToNullable(active), inactiveMessage.Value, properties);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LogAnalyticsDataConnection FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLogAnalyticsDataConnection(document.RootElement);
        }
    }
}
