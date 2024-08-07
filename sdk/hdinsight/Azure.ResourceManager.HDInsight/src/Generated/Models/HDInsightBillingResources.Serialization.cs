// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightBillingResources : IUtf8JsonSerializable, IJsonModel<HDInsightBillingResources>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightBillingResources>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightBillingResources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightBillingResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightBillingResources)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region.Value);
            }
            if (Optional.IsCollectionDefined(BillingMeters))
            {
                writer.WritePropertyName("billingMeters"u8);
                writer.WriteStartArray();
                foreach (var item in BillingMeters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DiskBillingMeters))
            {
                writer.WritePropertyName("diskBillingMeters"u8);
                writer.WriteStartArray();
                foreach (var item in DiskBillingMeters)
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

        HDInsightBillingResources IJsonModel<HDInsightBillingResources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightBillingResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightBillingResources)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightBillingResources(document.RootElement, options);
        }

        internal static HDInsightBillingResources DeserializeHDInsightBillingResources(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? region = default;
            IReadOnlyList<HDInsightBillingMeters> billingMeters = default;
            IReadOnlyList<HDInsightDiskBillingMeters> diskBillingMeters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("region"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    region = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingMeters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightBillingMeters> array = new List<HDInsightBillingMeters>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightBillingMeters.DeserializeHDInsightBillingMeters(item, options));
                    }
                    billingMeters = array;
                    continue;
                }
                if (property.NameEquals("diskBillingMeters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightDiskBillingMeters> array = new List<HDInsightDiskBillingMeters>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightDiskBillingMeters.DeserializeHDInsightDiskBillingMeters(item, options));
                    }
                    diskBillingMeters = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightBillingResources(region, billingMeters ?? new ChangeTrackingList<HDInsightBillingMeters>(), diskBillingMeters ?? new ChangeTrackingList<HDInsightDiskBillingMeters>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightBillingResources>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightBillingResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightBillingResources)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightBillingResources IPersistableModel<HDInsightBillingResources>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightBillingResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightBillingResources(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightBillingResources)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightBillingResources>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
