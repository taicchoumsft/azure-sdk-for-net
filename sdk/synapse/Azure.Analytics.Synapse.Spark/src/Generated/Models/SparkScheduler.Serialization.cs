// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkScheduler
    {
        internal static SparkScheduler DeserializeSparkScheduler(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? submittedAt = default;
            DateTimeOffset? scheduledAt = default;
            DateTimeOffset? endedAt = default;
            DateTimeOffset? cancellationRequestedAt = default;
            SchedulerCurrentState? currentState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("submittedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        submittedAt = null;
                        continue;
                    }
                    submittedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scheduledAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scheduledAt = null;
                        continue;
                    }
                    scheduledAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endedAt = null;
                        continue;
                    }
                    endedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cancellationRequestedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cancellationRequestedAt = null;
                        continue;
                    }
                    cancellationRequestedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = new SchedulerCurrentState(property.Value.GetString());
                    continue;
                }
            }
            return new SparkScheduler(submittedAt, scheduledAt, endedAt, cancellationRequestedAt, currentState);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SparkScheduler FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSparkScheduler(document.RootElement);
        }
    }
}
