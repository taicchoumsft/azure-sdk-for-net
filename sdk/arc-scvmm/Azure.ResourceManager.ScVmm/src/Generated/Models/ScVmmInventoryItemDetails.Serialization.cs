// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm.Models
{
    public partial class ScVmmInventoryItemDetails : IUtf8JsonSerializable, IJsonModel<ScVmmInventoryItemDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScVmmInventoryItemDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScVmmInventoryItemDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmInventoryItemDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmInventoryItemDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId"u8);
                writer.WriteStringValue(InventoryItemId);
            }
            if (Optional.IsDefined(InventoryItemName))
            {
                writer.WritePropertyName("inventoryItemName"u8);
                writer.WriteStringValue(InventoryItemName);
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

        ScVmmInventoryItemDetails IJsonModel<ScVmmInventoryItemDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmInventoryItemDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmInventoryItemDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScVmmInventoryItemDetails(document.RootElement, options);
        }

        internal static ScVmmInventoryItemDetails DeserializeScVmmInventoryItemDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string inventoryItemId = default;
            string inventoryItemName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inventoryItemId"u8))
                {
                    inventoryItemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inventoryItemName"u8))
                {
                    inventoryItemName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScVmmInventoryItemDetails(inventoryItemId, inventoryItemName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScVmmInventoryItemDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmInventoryItemDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScVmmInventoryItemDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ScVmmInventoryItemDetails IPersistableModel<ScVmmInventoryItemDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmInventoryItemDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScVmmInventoryItemDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScVmmInventoryItemDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScVmmInventoryItemDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
