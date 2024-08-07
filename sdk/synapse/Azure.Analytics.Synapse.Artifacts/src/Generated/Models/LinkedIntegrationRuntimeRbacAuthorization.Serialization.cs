// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkedIntegrationRuntimeRbacAuthorizationConverter))]
    public partial class LinkedIntegrationRuntimeRbacAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
            writer.WriteEndObject();
        }

        internal static LinkedIntegrationRuntimeRbacAuthorization DeserializeLinkedIntegrationRuntimeRbacAuthorization(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceId = default;
            string authorizationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedIntegrationRuntimeRbacAuthorization(authorizationType, resourceId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LinkedIntegrationRuntimeRbacAuthorization FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLinkedIntegrationRuntimeRbacAuthorization(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class LinkedIntegrationRuntimeRbacAuthorizationConverter : JsonConverter<LinkedIntegrationRuntimeRbacAuthorization>
        {
            public override void Write(Utf8JsonWriter writer, LinkedIntegrationRuntimeRbacAuthorization model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override LinkedIntegrationRuntimeRbacAuthorization Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkedIntegrationRuntimeRbacAuthorization(document.RootElement);
            }
        }
    }
}
