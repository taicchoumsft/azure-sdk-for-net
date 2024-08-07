// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(PipelineRunsQueryResponseConverter))]
    public partial class PipelineRunsQueryResponse
    {
        internal static PipelineRunsQueryResponse DeserializePipelineRunsQueryResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PipelineRun> value = default;
            string continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<PipelineRun> array = new List<PipelineRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineRun.DeserializePipelineRun(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new PipelineRunsQueryResponse(value, continuationToken);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PipelineRunsQueryResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePipelineRunsQueryResponse(document.RootElement);
        }

        internal partial class PipelineRunsQueryResponseConverter : JsonConverter<PipelineRunsQueryResponse>
        {
            public override void Write(Utf8JsonWriter writer, PipelineRunsQueryResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override PipelineRunsQueryResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePipelineRunsQueryResponse(document.RootElement);
            }
        }
    }
}
