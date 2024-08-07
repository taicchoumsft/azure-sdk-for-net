// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    public partial class InformaticaProperties : IUtf8JsonSerializable, IJsonModel<InformaticaProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InformaticaProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InformaticaProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OrganizationId))
            {
                writer.WritePropertyName("organizationId"u8);
                writer.WriteStringValue(OrganizationId);
            }
            if (Optional.IsDefined(OrganizationName))
            {
                writer.WritePropertyName("organizationName"u8);
                writer.WriteStringValue(OrganizationName);
            }
            if (Optional.IsDefined(InformaticaRegion))
            {
                writer.WritePropertyName("informaticaRegion"u8);
                writer.WriteStringValue(InformaticaRegion);
            }
            if (Optional.IsDefined(SingleSignOnUri))
            {
                writer.WritePropertyName("singleSignOnUrl"u8);
                writer.WriteStringValue(SingleSignOnUri.AbsoluteUri);
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

        InformaticaProperties IJsonModel<InformaticaProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInformaticaProperties(document.RootElement, options);
        }

        internal static InformaticaProperties DeserializeInformaticaProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string organizationId = default;
            string organizationName = default;
            string informaticaRegion = default;
            Uri singleSignOnUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizationId"u8))
                {
                    organizationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationName"u8))
                {
                    organizationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("informaticaRegion"u8))
                {
                    informaticaRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("singleSignOnUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InformaticaProperties(organizationId, organizationName, informaticaRegion, singleSignOnUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InformaticaProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InformaticaProperties)} does not support writing '{options.Format}' format.");
            }
        }

        InformaticaProperties IPersistableModel<InformaticaProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInformaticaProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InformaticaProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InformaticaProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
