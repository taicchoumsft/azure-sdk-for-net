// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsSmsDeliveryAttemptProperties
    {
        internal static AcsSmsDeliveryAttemptProperties DeserializeAcsSmsDeliveryAttemptProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            int? segmentsSucceeded = default;
            int? segmentsFailed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("segmentsSucceeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    segmentsSucceeded = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("segmentsFailed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    segmentsFailed = property.Value.GetInt32();
                    continue;
                }
            }
            return new AcsSmsDeliveryAttemptProperties(timestamp, segmentsSucceeded, segmentsFailed);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsSmsDeliveryAttemptProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAcsSmsDeliveryAttemptProperties(document.RootElement);
        }
    }
}
