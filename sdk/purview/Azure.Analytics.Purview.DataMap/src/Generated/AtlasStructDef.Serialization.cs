// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasStructDef : IUtf8JsonSerializable, IJsonModel<AtlasStructDef>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasStructDef>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AtlasStructDef>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasStructDef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasStructDef)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(CreateTime))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteNumberValue(CreateTime.Value);
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(DateFormatter))
            {
                writer.WritePropertyName("dateFormatter"u8);
                writer.WriteObjectValue(DateFormatter, options);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Guid))
            {
                writer.WritePropertyName("guid"u8);
                writer.WriteStringValue(Guid);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ServiceType))
            {
                writer.WritePropertyName("serviceType"u8);
                writer.WriteStringValue(ServiceType);
            }
            if (Optional.IsDefined(TypeVersion))
            {
                writer.WritePropertyName("typeVersion"u8);
                writer.WriteStringValue(TypeVersion);
            }
            if (Optional.IsDefined(UpdateTime))
            {
                writer.WritePropertyName("updateTime"u8);
                writer.WriteNumberValue(UpdateTime.Value);
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteStringValue(UpdatedBy);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(LastModifiedTS))
            {
                writer.WritePropertyName("lastModifiedTS"u8);
                writer.WriteStringValue(LastModifiedTS);
            }
            if (Optional.IsCollectionDefined(AttributeDefs))
            {
                writer.WritePropertyName("attributeDefs"u8);
                writer.WriteStartArray();
                foreach (var item in AttributeDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AtlasStructDef IJsonModel<AtlasStructDef>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasStructDef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasStructDef)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasStructDef(document.RootElement, options);
        }

        internal static AtlasStructDef DeserializeAtlasStructDef(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeCategory? category = default;
            long? createTime = default;
            string createdBy = default;
            AtlasDateFormat dateFormatter = default;
            string description = default;
            string guid = default;
            string name = default;
            IDictionary<string, string> options0 = default;
            string serviceType = default;
            string typeVersion = default;
            long? updateTime = default;
            string updatedBy = default;
            long? version = default;
            string lastModifiedTS = default;
            IList<AtlasAttributeDef> attributeDefs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new TypeCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dateFormatter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateFormatter = AtlasDateFormat.DeserializeAtlasDateFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guid"u8))
                {
                    guid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    options0 = dictionary;
                    continue;
                }
                if (property.NameEquals("serviceType"u8))
                {
                    serviceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeVersion"u8))
                {
                    typeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("updatedBy"u8))
                {
                    updatedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastModifiedTS"u8))
                {
                    lastModifiedTS = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributeDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasAttributeDef> array = new List<AtlasAttributeDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasAttributeDef.DeserializeAtlasAttributeDef(item, options));
                    }
                    attributeDefs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AtlasStructDef(
                category,
                createTime,
                createdBy,
                dateFormatter,
                description,
                guid,
                name,
                options0 ?? new ChangeTrackingDictionary<string, string>(),
                serviceType,
                typeVersion,
                updateTime,
                updatedBy,
                version,
                lastModifiedTS,
                attributeDefs ?? new ChangeTrackingList<AtlasAttributeDef>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasStructDef>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasStructDef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasStructDef)} does not support writing '{options.Format}' format.");
            }
        }

        AtlasStructDef IPersistableModel<AtlasStructDef>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasStructDef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAtlasStructDef(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasStructDef)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasStructDef>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasStructDef FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAtlasStructDef(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
