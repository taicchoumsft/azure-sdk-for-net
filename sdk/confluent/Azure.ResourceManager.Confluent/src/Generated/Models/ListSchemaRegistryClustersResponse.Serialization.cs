// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    internal partial class ListSchemaRegistryClustersResponse : IUtf8JsonSerializable, IJsonModel<ListSchemaRegistryClustersResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ListSchemaRegistryClustersResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ListSchemaRegistryClustersResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListSchemaRegistryClustersResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListSchemaRegistryClustersResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        ListSchemaRegistryClustersResponse IJsonModel<ListSchemaRegistryClustersResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListSchemaRegistryClustersResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListSchemaRegistryClustersResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeListSchemaRegistryClustersResponse(document.RootElement, options);
        }

        internal static ListSchemaRegistryClustersResponse DeserializeListSchemaRegistryClustersResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SchemaRegistryClusterRecord> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SchemaRegistryClusterRecord> array = new List<SchemaRegistryClusterRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SchemaRegistryClusterRecord.DeserializeSchemaRegistryClusterRecord(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ListSchemaRegistryClustersResponse(value ?? new ChangeTrackingList<SchemaRegistryClusterRecord>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ListSchemaRegistryClustersResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListSchemaRegistryClustersResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ListSchemaRegistryClustersResponse)} does not support writing '{options.Format}' format.");
            }
        }

        ListSchemaRegistryClustersResponse IPersistableModel<ListSchemaRegistryClustersResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListSchemaRegistryClustersResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeListSchemaRegistryClustersResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ListSchemaRegistryClustersResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ListSchemaRegistryClustersResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
