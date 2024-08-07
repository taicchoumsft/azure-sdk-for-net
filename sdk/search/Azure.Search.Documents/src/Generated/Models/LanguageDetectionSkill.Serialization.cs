// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class LanguageDetectionSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultCountryHint))
            {
                if (DefaultCountryHint != null)
                {
                    writer.WritePropertyName("defaultCountryHint"u8);
                    writer.WriteStringValue(DefaultCountryHint);
                }
                else
                {
                    writer.WriteNull("defaultCountryHint");
                }
            }
            if (Optional.IsDefined(ModelVersion))
            {
                if (ModelVersion != null)
                {
                    writer.WritePropertyName("modelVersion"u8);
                    writer.WriteStringValue(ModelVersion);
                }
                else
                {
                    writer.WriteNull("modelVersion");
                }
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue<InputFieldMappingEntry>(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue<OutputFieldMappingEntry>(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static LanguageDetectionSkill DeserializeLanguageDetectionSkill(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string defaultCountryHint = default;
            string modelVersion = default;
            string odataType = default;
            string name = default;
            string description = default;
            string context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultCountryHint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultCountryHint = null;
                        continue;
                    }
                    defaultCountryHint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelVersion = null;
                        continue;
                    }
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
            }
            return new LanguageDetectionSkill(
                odataType,
                name,
                description,
                context,
                inputs,
                outputs,
                defaultCountryHint,
                modelVersion);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LanguageDetectionSkill FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLanguageDetectionSkill(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
