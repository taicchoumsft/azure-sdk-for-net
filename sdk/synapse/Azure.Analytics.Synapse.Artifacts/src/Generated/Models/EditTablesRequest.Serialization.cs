// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(EditTablesRequestConverter))]
    public partial class EditTablesRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LinkTables))
            {
                writer.WritePropertyName("linkTables"u8);
                writer.WriteStartArray();
                foreach (var item in LinkTables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EditTablesRequest DeserializeEditTablesRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<LinkTableRequest> linkTables = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkTableRequest> array = new List<LinkTableRequest>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkTableRequest.DeserializeLinkTableRequest(item));
                    }
                    linkTables = array;
                    continue;
                }
            }
            return new EditTablesRequest(linkTables ?? new ChangeTrackingList<LinkTableRequest>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EditTablesRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEditTablesRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class EditTablesRequestConverter : JsonConverter<EditTablesRequest>
        {
            public override void Write(Utf8JsonWriter writer, EditTablesRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override EditTablesRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEditTablesRequest(document.RootElement);
            }
        }
    }
}
