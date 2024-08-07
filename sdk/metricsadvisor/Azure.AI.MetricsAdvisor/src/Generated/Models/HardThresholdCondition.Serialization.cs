// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class HardThresholdCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LowerBound))
            {
                writer.WritePropertyName("lowerBound"u8);
                writer.WriteNumberValue(LowerBound.Value);
            }
            if (Optional.IsDefined(UpperBound))
            {
                writer.WritePropertyName("upperBound"u8);
                writer.WriteNumberValue(UpperBound.Value);
            }
            writer.WritePropertyName("anomalyDetectorDirection"u8);
            writer.WriteStringValue(AnomalyDetectorDirection.ToString());
            writer.WritePropertyName("suppressCondition"u8);
            writer.WriteObjectValue<SuppressCondition>(SuppressCondition);
            writer.WriteEndObject();
        }

        internal static HardThresholdCondition DeserializeHardThresholdCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? lowerBound = default;
            double? upperBound = default;
            AnomalyDetectorDirection anomalyDetectorDirection = default;
            SuppressCondition suppressCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowerBound = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("upperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upperBound = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("anomalyDetectorDirection"u8))
                {
                    anomalyDetectorDirection = new AnomalyDetectorDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suppressCondition"u8))
                {
                    suppressCondition = Models.SuppressCondition.DeserializeSuppressCondition(property.Value);
                    continue;
                }
            }
            return new HardThresholdCondition(lowerBound, upperBound, anomalyDetectorDirection, suppressCondition);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HardThresholdCondition FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeHardThresholdCondition(document.RootElement);
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
