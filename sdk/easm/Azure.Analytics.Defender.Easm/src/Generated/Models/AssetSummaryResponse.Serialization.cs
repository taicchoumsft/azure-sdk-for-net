// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    public partial class AssetSummaryResponse
    {
        internal static AssetSummaryResponse DeserializeAssetSummaryResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<string> metricCategory = default;
            Optional<string> metric = default;
            Optional<string> filter = default;
            Optional<string> labelName = default;
            Optional<long> count = default;
            Optional<string> link = default;
            Optional<IReadOnlyList<AssetSummaryResponse>> children = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metricCategory"u8))
                {
                    metricCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelName"u8))
                {
                    labelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("link"u8))
                {
                    link = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("children"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssetSummaryResponse> array = new List<AssetSummaryResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeAssetSummaryResponse(item));
                    }
                    children = array;
                    continue;
                }
            }
            return new AssetSummaryResponse(displayName.Value, description.Value, Optional.ToNullable(updatedAt), metricCategory.Value, metric.Value, filter.Value, labelName.Value, Optional.ToNullable(count), link.Value, Optional.ToList(children));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AssetSummaryResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAssetSummaryResponse(document.RootElement);
        }
    }
}
