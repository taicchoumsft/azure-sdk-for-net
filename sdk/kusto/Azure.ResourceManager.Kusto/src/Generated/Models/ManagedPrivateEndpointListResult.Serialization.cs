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
    internal partial class ManagedPrivateEndpointListResult : IUtf8JsonSerializable, IJsonModel<ManagedPrivateEndpointListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedPrivateEndpointListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedPrivateEndpointListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedPrivateEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedPrivateEndpointListResult)} does not support writing '{format}' format.");
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

        ManagedPrivateEndpointListResult IJsonModel<ManagedPrivateEndpointListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedPrivateEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedPrivateEndpointListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedPrivateEndpointListResult(document.RootElement, options);
        }

        internal static ManagedPrivateEndpointListResult DeserializeManagedPrivateEndpointListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<KustoManagedPrivateEndpointData> value = default;
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
                    List<KustoManagedPrivateEndpointData> array = new List<KustoManagedPrivateEndpointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoManagedPrivateEndpointData.DeserializeKustoManagedPrivateEndpointData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedPrivateEndpointListResult(value ?? new ChangeTrackingList<KustoManagedPrivateEndpointData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedPrivateEndpointListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedPrivateEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedPrivateEndpointListResult)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedPrivateEndpointListResult IPersistableModel<ManagedPrivateEndpointListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedPrivateEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedPrivateEndpointListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedPrivateEndpointListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedPrivateEndpointListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
