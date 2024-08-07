// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CveResult : IUtf8JsonSerializable, IJsonModel<CveResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CveResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CveResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CveResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CveId))
            {
                if (CveId != null)
                {
                    writer.WritePropertyName("cveId"u8);
                    writer.WriteStringValue(CveId);
                }
                else
                {
                    writer.WriteNull("cveId");
                }
            }
            if (Optional.IsDefined(Component))
            {
                if (Component != null)
                {
                    writer.WritePropertyName("component"u8);
                    writer.WriteObjectValue(Component, options);
                }
                else
                {
                    writer.WriteNull("component");
                }
            }
            if (Optional.IsDefined(Severity))
            {
                if (Severity != null)
                {
                    writer.WritePropertyName("severity"u8);
                    writer.WriteStringValue(Severity);
                }
                else
                {
                    writer.WriteNull("severity");
                }
            }
            if (Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamePropertiesName);
            }
            if (Optional.IsDefined(CvssScore))
            {
                if (CvssScore != null)
                {
                    writer.WritePropertyName("cvssScore"u8);
                    writer.WriteStringValue(CvssScore);
                }
                else
                {
                    writer.WriteNull("cvssScore");
                }
            }
            if (Optional.IsDefined(CvssVersion))
            {
                if (CvssVersion != null)
                {
                    writer.WritePropertyName("cvssVersion"u8);
                    writer.WriteStringValue(CvssVersion);
                }
                else
                {
                    writer.WriteNull("cvssVersion");
                }
            }
            if (Optional.IsDefined(CvssV2Score))
            {
                if (CvssV2Score != null)
                {
                    writer.WritePropertyName("cvssV2Score"u8);
                    writer.WriteStringValue(CvssV2Score);
                }
                else
                {
                    writer.WriteNull("cvssV2Score");
                }
            }
            if (Optional.IsDefined(CvssV3Score))
            {
                if (CvssV3Score != null)
                {
                    writer.WritePropertyName("cvssV3Score"u8);
                    writer.WriteStringValue(CvssV3Score);
                }
                else
                {
                    writer.WriteNull("cvssV3Score");
                }
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Links))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WriteEndObject();
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

        CveResult IJsonModel<CveResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CveResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCveResult(document.RootElement, options);
        }

        internal static CveResult DeserializeCveResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string cveId = default;
            CveComponent component = default;
            string severity = default;
            string name0 = default;
            string cvssScore = default;
            string cvssVersion = default;
            string cvssV2Score = default;
            string cvssV3Score = default;
            IReadOnlyList<CveLink> links = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cveId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cveId = null;
                                continue;
                            }
                            cveId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("component"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                component = null;
                                continue;
                            }
                            component = CveComponent.DeserializeCveComponent(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                severity = null;
                                continue;
                            }
                            severity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cvssScore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cvssScore = null;
                                continue;
                            }
                            cvssScore = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cvssVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cvssVersion = null;
                                continue;
                            }
                            cvssVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cvssV2Score"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cvssV2Score = null;
                                continue;
                            }
                            cvssV2Score = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cvssV3Score"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cvssV3Score = null;
                                continue;
                            }
                            cvssV3Score = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CveLink> array = new List<CveLink>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CveLink.DeserializeCveLink(item, options));
                            }
                            links = array;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                description = null;
                                continue;
                            }
                            description = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CveResult(
                id,
                name,
                type,
                systemData,
                cveId,
                component,
                severity,
                name0,
                cvssScore,
                cvssVersion,
                cvssV2Score,
                cvssV3Score,
                links ?? new ChangeTrackingList<CveLink>(),
                description,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CveResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CveResult)} does not support writing '{options.Format}' format.");
            }
        }

        CveResult IPersistableModel<CveResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCveResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CveResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CveResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
