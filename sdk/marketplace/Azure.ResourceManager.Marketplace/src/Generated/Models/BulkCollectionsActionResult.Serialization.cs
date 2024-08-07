// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class BulkCollectionsActionResult : IUtf8JsonSerializable, IJsonModel<BulkCollectionsActionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BulkCollectionsActionResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BulkCollectionsActionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BulkCollectionsActionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BulkCollectionsActionResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Succeeded))
            {
                writer.WritePropertyName("succeeded"u8);
                writer.WriteStartArray();
                foreach (var item in Succeeded)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Failed))
            {
                writer.WritePropertyName("failed"u8);
                writer.WriteStartArray();
                foreach (var item in Failed)
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

        BulkCollectionsActionResult IJsonModel<BulkCollectionsActionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BulkCollectionsActionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BulkCollectionsActionResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBulkCollectionsActionResult(document.RootElement, options);
        }

        internal static BulkCollectionsActionResult DeserializeBulkCollectionsActionResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PrivateStoreCollectionDetails> succeeded = default;
            IReadOnlyList<PrivateStoreCollectionDetails> failed = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionDetails> array = new List<PrivateStoreCollectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionDetails.DeserializePrivateStoreCollectionDetails(item, options));
                    }
                    succeeded = array;
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionDetails> array = new List<PrivateStoreCollectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionDetails.DeserializePrivateStoreCollectionDetails(item, options));
                    }
                    failed = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BulkCollectionsActionResult(succeeded ?? new ChangeTrackingList<PrivateStoreCollectionDetails>(), failed ?? new ChangeTrackingList<PrivateStoreCollectionDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BulkCollectionsActionResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BulkCollectionsActionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BulkCollectionsActionResult)} does not support writing '{options.Format}' format.");
            }
        }

        BulkCollectionsActionResult IPersistableModel<BulkCollectionsActionResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BulkCollectionsActionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBulkCollectionsActionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BulkCollectionsActionResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BulkCollectionsActionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
