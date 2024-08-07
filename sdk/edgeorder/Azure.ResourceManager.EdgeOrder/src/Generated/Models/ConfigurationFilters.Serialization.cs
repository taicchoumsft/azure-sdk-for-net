// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ConfigurationFilters : IUtf8JsonSerializable, IJsonModel<ConfigurationFilters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationFilters>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfigurationFilters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationFilters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationFilters)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("hierarchyInformation"u8);
            writer.WriteObjectValue(HierarchyInformation, options);
            if (Optional.IsCollectionDefined(FilterableProperty))
            {
                writer.WritePropertyName("filterableProperty"u8);
                writer.WriteStartArray();
                foreach (var item in FilterableProperty)
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

        ConfigurationFilters IJsonModel<ConfigurationFilters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationFilters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationFilters)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationFilters(document.RootElement, options);
        }

        internal static ConfigurationFilters DeserializeConfigurationFilters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HierarchyInformation hierarchyInformation = default;
            IList<FilterableProperty> filterableProperty = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hierarchyInformation"u8))
                {
                    hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("filterableProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FilterableProperty> array = new List<FilterableProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.FilterableProperty.DeserializeFilterableProperty(item, options));
                    }
                    filterableProperty = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfigurationFilters(hierarchyInformation, filterableProperty ?? new ChangeTrackingList<FilterableProperty>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationFilters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationFilters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationFilters)} does not support writing '{options.Format}' format.");
            }
        }

        ConfigurationFilters IPersistableModel<ConfigurationFilters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationFilters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationFilters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationFilters)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationFilters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
