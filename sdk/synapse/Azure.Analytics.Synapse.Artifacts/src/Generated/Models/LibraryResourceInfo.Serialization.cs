// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LibraryResourceInfoConverter))]
    public partial class LibraryResourceInfo
    {
        internal static LibraryResourceInfo DeserializeLibraryResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            int? recordId = default;
            string state = default;
            string created = default;
            string changed = default;
            string type = default;
            string name = default;
            string operationId = default;
            string artifactId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recordId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    created = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changed"u8))
                {
                    changed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
            }
            return new LibraryResourceInfo(
                id,
                recordId,
                state,
                created,
                changed,
                type,
                name,
                operationId,
                artifactId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LibraryResourceInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLibraryResourceInfo(document.RootElement);
        }

        internal partial class LibraryResourceInfoConverter : JsonConverter<LibraryResourceInfo>
        {
            public override void Write(Utf8JsonWriter writer, LibraryResourceInfo model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override LibraryResourceInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryResourceInfo(document.RootElement);
            }
        }
    }
}
