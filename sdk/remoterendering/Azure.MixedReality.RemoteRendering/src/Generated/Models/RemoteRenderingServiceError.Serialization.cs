// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.MixedReality.RemoteRendering
{
    public partial class RemoteRenderingServiceError
    {
        internal static RemoteRenderingServiceError DeserializeRemoteRenderingServiceError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            IReadOnlyList<RemoteRenderingServiceError> details = default;
            string target = default;
            RemoteRenderingServiceError innerError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RemoteRenderingServiceError> array = new List<RemoteRenderingServiceError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeRemoteRenderingServiceError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    innerError = DeserializeRemoteRenderingServiceError(property.Value);
                    continue;
                }
            }
            return new RemoteRenderingServiceError(code, message, details ?? new ChangeTrackingList<RemoteRenderingServiceError>(), target, innerError);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RemoteRenderingServiceError FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRemoteRenderingServiceError(document.RootElement);
        }
    }
}
