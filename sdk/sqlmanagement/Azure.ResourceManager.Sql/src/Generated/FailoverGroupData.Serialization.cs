// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class FailoverGroupData : IUtf8JsonSerializable, IJsonModel<FailoverGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailoverGroupData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FailoverGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverGroupData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
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
            if (Optional.IsDefined(ReadWriteEndpoint))
            {
                writer.WritePropertyName("readWriteEndpoint"u8);
                writer.WriteObjectValue(ReadWriteEndpoint, options);
            }
            if (Optional.IsDefined(ReadOnlyEndpoint))
            {
                writer.WritePropertyName("readOnlyEndpoint"u8);
                writer.WriteObjectValue(ReadOnlyEndpoint, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationRole))
            {
                writer.WritePropertyName("replicationRole"u8);
                writer.WriteStringValue(ReplicationRole.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationState))
            {
                writer.WritePropertyName("replicationState"u8);
                writer.WriteStringValue(ReplicationState);
            }
            if (Optional.IsCollectionDefined(PartnerServers))
            {
                writer.WritePropertyName("partnerServers"u8);
                writer.WriteStartArray();
                foreach (var item in PartnerServers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FailoverDatabases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartArray();
                foreach (var item in FailoverDatabases)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SecondaryType))
            {
                writer.WritePropertyName("secondaryType"u8);
                writer.WriteStringValue(SecondaryType.Value.ToString());
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

        FailoverGroupData IJsonModel<FailoverGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverGroupData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailoverGroupData(document.RootElement, options);
        }

        internal static FailoverGroupData DeserializeFailoverGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            FailoverGroupReadWriteEndpoint readWriteEndpoint = default;
            FailoverGroupReadOnlyEndpoint readOnlyEndpoint = default;
            FailoverGroupReplicationRole? replicationRole = default;
            string replicationState = default;
            IList<PartnerServerInfo> partnerServers = default;
            IList<ResourceIdentifier> databases = default;
            FailoverGroupDatabasesSecondaryType? secondaryType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
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
                        if (property0.NameEquals("readWriteEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readWriteEndpoint = FailoverGroupReadWriteEndpoint.DeserializeFailoverGroupReadWriteEndpoint(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("readOnlyEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readOnlyEndpoint = FailoverGroupReadOnlyEndpoint.DeserializeFailoverGroupReadOnlyEndpoint(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationRole = new FailoverGroupReplicationRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicationState"u8))
                        {
                            replicationState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerServers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PartnerServerInfo> array = new List<PartnerServerInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PartnerServerInfo.DeserializePartnerServerInfo(item, options));
                            }
                            partnerServers = array;
                            continue;
                        }
                        if (property0.NameEquals("databases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            databases = array;
                            continue;
                        }
                        if (property0.NameEquals("secondaryType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryType = new FailoverGroupDatabasesSecondaryType(property0.Value.GetString());
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
            return new FailoverGroupData(
                id,
                name,
                type,
                systemData,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                readWriteEndpoint,
                readOnlyEndpoint,
                replicationRole,
                replicationState,
                partnerServers ?? new ChangeTrackingList<PartnerServerInfo>(),
                databases ?? new ChangeTrackingList<ResourceIdentifier>(),
                secondaryType,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Location))
                {
                    builder.Append("  location: ");
                    builder.AppendLine($"'{Location.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReadWriteEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    readWriteEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReadWriteEndpoint))
                {
                    builder.Append("    readWriteEndpoint: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ReadWriteEndpoint, options, 4, false, "    readWriteEndpoint: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReadOnlyEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    readOnlyEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReadOnlyEndpoint))
                {
                    builder.Append("    readOnlyEndpoint: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ReadOnlyEndpoint, options, 4, false, "    readOnlyEndpoint: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReplicationRole), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    replicationRole: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReplicationRole))
                {
                    builder.Append("    replicationRole: ");
                    builder.AppendLine($"'{ReplicationRole.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReplicationState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    replicationState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReplicationState))
                {
                    builder.Append("    replicationState: ");
                    if (ReplicationState.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ReplicationState}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ReplicationState}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartnerServers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    partnerServers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PartnerServers))
                {
                    if (PartnerServers.Any())
                    {
                        builder.Append("    partnerServers: ");
                        builder.AppendLine("[");
                        foreach (var item in PartnerServers)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    partnerServers: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FailoverDatabases), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    databases: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(FailoverDatabases))
                {
                    if (FailoverDatabases.Any())
                    {
                        builder.Append("    databases: ");
                        builder.AppendLine("[");
                        foreach (var item in FailoverDatabases)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"      '{item.ToString()}'");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecondaryType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    secondaryType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecondaryType))
                {
                    builder.Append("    secondaryType: ");
                    builder.AppendLine($"'{SecondaryType.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FailoverGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FailoverGroupData)} does not support writing '{options.Format}' format.");
            }
        }

        FailoverGroupData IPersistableModel<FailoverGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFailoverGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailoverGroupData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailoverGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
