// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoDatabasePrincipalAssignmentNameAvailabilityContent : IUtf8JsonSerializable, IJsonModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoDatabasePrincipalAssignmentNameAvailabilityContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceType.ToString());
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

        KustoDatabasePrincipalAssignmentNameAvailabilityContent IJsonModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoDatabasePrincipalAssignmentNameAvailabilityContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoDatabasePrincipalAssignmentNameAvailabilityContent(document.RootElement, options);
        }

        internal static KustoDatabasePrincipalAssignmentNameAvailabilityContent DeserializeKustoDatabasePrincipalAssignmentNameAvailabilityContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            KustoDatabasePrincipalAssignmentType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new KustoDatabasePrincipalAssignmentType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KustoDatabasePrincipalAssignmentNameAvailabilityContent(name, type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KustoDatabasePrincipalAssignmentNameAvailabilityContent)} does not support writing '{options.Format}' format.");
            }
        }

        KustoDatabasePrincipalAssignmentNameAvailabilityContent IPersistableModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKustoDatabasePrincipalAssignmentNameAvailabilityContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KustoDatabasePrincipalAssignmentNameAvailabilityContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KustoDatabasePrincipalAssignmentNameAvailabilityContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
