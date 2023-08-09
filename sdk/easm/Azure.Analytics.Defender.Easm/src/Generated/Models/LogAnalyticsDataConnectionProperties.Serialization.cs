// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    public partial class LogAnalyticsDataConnectionProperties
    {
        internal static LogAnalyticsDataConnectionProperties DeserializeLogAnalyticsDataConnectionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> apiKey = default;
            Optional<string> workspaceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiKey"u8))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
            }
            return new LogAnalyticsDataConnectionProperties(apiKey.Value, workspaceId.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LogAnalyticsDataConnectionProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLogAnalyticsDataConnectionProperties(document.RootElement);
        }
    }
}
