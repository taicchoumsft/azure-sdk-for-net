// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class MigrationContent : IUtf8JsonSerializable, IJsonModel<MigrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrationContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku, options);
            writer.WritePropertyName("classicResourceReference"u8);
            JsonSerializer.Serialize(writer, ClassicResourceReference);
            writer.WritePropertyName("profileName"u8);
            writer.WriteStringValue(ProfileName);
            if (Optional.IsCollectionDefined(MigrationWebApplicationFirewallMappings))
            {
                writer.WritePropertyName("migrationWebApplicationFirewallMappings"u8);
                writer.WriteStartArray();
                foreach (var item in MigrationWebApplicationFirewallMappings)
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

        MigrationContent IJsonModel<MigrationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationContent(document.RootElement, options);
        }

        internal static MigrationContent DeserializeMigrationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CdnSku sku = default;
            WritableSubResource classicResourceReference = default;
            string profileName = default;
            IList<MigrationWebApplicationFirewallMapping> migrationWebApplicationFirewallMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = CdnSku.DeserializeCdnSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("classicResourceReference"u8))
                {
                    classicResourceReference = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("profileName"u8))
                {
                    profileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationWebApplicationFirewallMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MigrationWebApplicationFirewallMapping> array = new List<MigrationWebApplicationFirewallMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrationWebApplicationFirewallMapping.DeserializeMigrationWebApplicationFirewallMapping(item, options));
                    }
                    migrationWebApplicationFirewallMappings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrationContent(sku, classicResourceReference, profileName, migrationWebApplicationFirewallMappings ?? new ChangeTrackingList<MigrationWebApplicationFirewallMapping>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrationContent)} does not support writing '{options.Format}' format.");
            }
        }

        MigrationContent IPersistableModel<MigrationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
