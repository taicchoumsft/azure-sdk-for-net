// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automanage.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automanage
{
    public partial class AutomanageConfigurationProfileAssignmentReportData : IUtf8JsonSerializable, IJsonModel<AutomanageConfigurationProfileAssignmentReportData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomanageConfigurationProfileAssignmentReportData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutomanageConfigurationProfileAssignmentReportData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomanageConfigurationProfileAssignmentReportData)} does not support writing '{format}' format.");
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
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationProfileAssignmentProcessingType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ConfigurationProfileAssignmentProcessingType);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationProfile))
            {
                writer.WritePropertyName("configurationProfile"u8);
                writer.WriteStringValue(ConfigurationProfile);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
            if (options.Format != "W" && Optional.IsDefined(ReportFormatVersion))
            {
                writer.WritePropertyName("reportFormatVersion"u8);
                writer.WriteStringValue(ReportFormatVersion);
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

        AutomanageConfigurationProfileAssignmentReportData IJsonModel<AutomanageConfigurationProfileAssignmentReportData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomanageConfigurationProfileAssignmentReportData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomanageConfigurationProfileAssignmentReportData(document.RootElement, options);
        }

        internal static AutomanageConfigurationProfileAssignmentReportData DeserializeAutomanageConfigurationProfileAssignmentReportData(JsonElement element, ModelReaderWriterOptions options = null)
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
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            DateTimeOffset? lastModifiedTime = default;
            TimeSpan? duration = default;
            string type0 = default;
            string status = default;
            string configurationProfile = default;
            IReadOnlyList<ConfigurationProfileAssignmentReportResourceDetails> resources = default;
            ResponseError error = default;
            string reportFormatVersion = default;
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
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("duration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            duration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationProfile"u8))
                        {
                            configurationProfile = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConfigurationProfileAssignmentReportResourceDetails> array = new List<ConfigurationProfileAssignmentReportResourceDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConfigurationProfileAssignmentReportResourceDetails.DeserializeConfigurationProfileAssignmentReportResourceDetails(item, options));
                            }
                            resources = array;
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("reportFormatVersion"u8))
                        {
                            reportFormatVersion = property0.Value.GetString();
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
            return new AutomanageConfigurationProfileAssignmentReportData(
                id,
                name,
                type,
                systemData,
                startTime,
                endTime,
                lastModifiedTime,
                duration,
                type0,
                status,
                configurationProfile,
                resources ?? new ChangeTrackingList<ConfigurationProfileAssignmentReportResourceDetails>(),
                error,
                reportFormatVersion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomanageConfigurationProfileAssignmentReportData)} does not support writing '{options.Format}' format.");
            }
        }

        AutomanageConfigurationProfileAssignmentReportData IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomanageConfigurationProfileAssignmentReportData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomanageConfigurationProfileAssignmentReportData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
