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
    [JsonConverter(typeof(ExposureControlRequestConverter))]
    public partial class ExposureControlRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FeatureName))
            {
                writer.WritePropertyName("featureName"u8);
                writer.WriteStringValue(FeatureName);
            }
            if (Optional.IsDefined(FeatureType))
            {
                writer.WritePropertyName("featureType"u8);
                writer.WriteStringValue(FeatureType);
            }
            writer.WriteEndObject();
        }

        internal static ExposureControlRequest DeserializeExposureControlRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string featureName = default;
            string featureType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featureName"u8))
                {
                    featureName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("featureType"u8))
                {
                    featureType = property.Value.GetString();
                    continue;
                }
            }
            return new ExposureControlRequest(featureName, featureType);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ExposureControlRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeExposureControlRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class ExposureControlRequestConverter : JsonConverter<ExposureControlRequest>
        {
            public override void Write(Utf8JsonWriter writer, ExposureControlRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override ExposureControlRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeExposureControlRequest(document.RootElement);
            }
        }
    }
}
