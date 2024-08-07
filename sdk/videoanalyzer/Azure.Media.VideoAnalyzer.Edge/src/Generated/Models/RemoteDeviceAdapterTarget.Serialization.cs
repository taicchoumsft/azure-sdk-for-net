// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class RemoteDeviceAdapterTarget : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("host"u8);
            writer.WriteStringValue(Host);
            writer.WriteEndObject();
        }

        internal static RemoteDeviceAdapterTarget DeserializeRemoteDeviceAdapterTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string host = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
            }
            return new RemoteDeviceAdapterTarget(host);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RemoteDeviceAdapterTarget FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRemoteDeviceAdapterTarget(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
