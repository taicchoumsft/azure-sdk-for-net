// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreTrustedIdProviderPatch : IUtf8JsonSerializable, IJsonModel<DataLakeStoreTrustedIdProviderPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeStoreTrustedIdProviderPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataLakeStoreTrustedIdProviderPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreTrustedIdProviderPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreTrustedIdProviderPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IdProvider))
            {
                writer.WritePropertyName("idProvider"u8);
                writer.WriteStringValue(IdProvider.AbsoluteUri);
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

        DataLakeStoreTrustedIdProviderPatch IJsonModel<DataLakeStoreTrustedIdProviderPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreTrustedIdProviderPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreTrustedIdProviderPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreTrustedIdProviderPatch(document.RootElement, options);
        }

        internal static DataLakeStoreTrustedIdProviderPatch DeserializeDataLakeStoreTrustedIdProviderPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri idProvider = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("idProvider"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idProvider = new Uri(property0.Value.GetString());
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
            return new DataLakeStoreTrustedIdProviderPatch(idProvider, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeStoreTrustedIdProviderPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreTrustedIdProviderPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreTrustedIdProviderPatch)} does not support writing '{options.Format}' format.");
            }
        }

        DataLakeStoreTrustedIdProviderPatch IPersistableModel<DataLakeStoreTrustedIdProviderPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreTrustedIdProviderPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeStoreTrustedIdProviderPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreTrustedIdProviderPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeStoreTrustedIdProviderPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
