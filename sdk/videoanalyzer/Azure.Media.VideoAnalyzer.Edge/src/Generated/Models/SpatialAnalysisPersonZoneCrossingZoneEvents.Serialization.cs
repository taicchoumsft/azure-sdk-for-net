// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonZoneCrossingZoneEvents : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("zone"u8);
            writer.WriteObjectValue(Zone);
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonZoneCrossingZoneEvents DeserializeSpatialAnalysisPersonZoneCrossingZoneEvents(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NamedPolygonBase zone = default;
            IList<SpatialAnalysisPersonZoneCrossingEvent> events = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"u8))
                {
                    zone = NamedPolygonBase.DeserializeNamedPolygonBase(property.Value);
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpatialAnalysisPersonZoneCrossingEvent> array = new List<SpatialAnalysisPersonZoneCrossingEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonZoneCrossingEvent.DeserializeSpatialAnalysisPersonZoneCrossingEvent(item));
                    }
                    events = array;
                    continue;
                }
            }
            return new SpatialAnalysisPersonZoneCrossingZoneEvents(zone, events ?? new ChangeTrackingList<SpatialAnalysisPersonZoneCrossingEvent>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SpatialAnalysisPersonZoneCrossingZoneEvents FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSpatialAnalysisPersonZoneCrossingZoneEvents(document.RootElement);
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
