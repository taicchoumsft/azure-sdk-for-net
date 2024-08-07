// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class DiscoveryGroupPayload : IUtf8JsonSerializable, IJsonModel<DiscoveryGroupPayload>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiscoveryGroupPayload>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiscoveryGroupPayload>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryGroupPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryGroupPayload)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (Optional.IsDefined(FrequencyMilliseconds))
            {
                writer.WritePropertyName("frequencyMilliseconds"u8);
                writer.WriteNumberValue(FrequencyMilliseconds.Value);
            }
            if (Optional.IsCollectionDefined(Seeds))
            {
                writer.WritePropertyName("seeds"u8);
                writer.WriteStartArray();
                foreach (var item in Seeds)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Names))
            {
                writer.WritePropertyName("names"u8);
                writer.WriteStartArray();
                foreach (var item in Names)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Excludes))
            {
                writer.WritePropertyName("excludes"u8);
                writer.WriteStartArray();
                foreach (var item in Excludes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TemplateId))
            {
                writer.WritePropertyName("templateId"u8);
                writer.WriteStringValue(TemplateId);
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

        DiscoveryGroupPayload IJsonModel<DiscoveryGroupPayload>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryGroupPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryGroupPayload)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiscoveryGroupPayload(document.RootElement, options);
        }

        internal static DiscoveryGroupPayload DeserializeDiscoveryGroupPayload(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string description = default;
            string tier = default;
            long? frequencyMilliseconds = default;
            IList<DiscoverySource> seeds = default;
            IList<string> names = default;
            IList<DiscoverySource> excludes = default;
            string templateId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frequencyMilliseconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequencyMilliseconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("seeds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoverySource> array = new List<DiscoverySource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoverySource.DeserializeDiscoverySource(item, options));
                    }
                    seeds = array;
                    continue;
                }
                if (property.NameEquals("names"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    names = array;
                    continue;
                }
                if (property.NameEquals("excludes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoverySource> array = new List<DiscoverySource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoverySource.DeserializeDiscoverySource(item, options));
                    }
                    excludes = array;
                    continue;
                }
                if (property.NameEquals("templateId"u8))
                {
                    templateId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DiscoveryGroupPayload(
                name,
                description,
                tier,
                frequencyMilliseconds,
                seeds ?? new ChangeTrackingList<DiscoverySource>(),
                names ?? new ChangeTrackingList<string>(),
                excludes ?? new ChangeTrackingList<DiscoverySource>(),
                templateId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiscoveryGroupPayload>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryGroupPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiscoveryGroupPayload)} does not support writing '{options.Format}' format.");
            }
        }

        DiscoveryGroupPayload IPersistableModel<DiscoveryGroupPayload>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryGroupPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiscoveryGroupPayload(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiscoveryGroupPayload)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiscoveryGroupPayload>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DiscoveryGroupPayload FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDiscoveryGroupPayload(document.RootElement);
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
