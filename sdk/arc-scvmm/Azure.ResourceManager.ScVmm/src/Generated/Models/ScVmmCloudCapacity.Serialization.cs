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
    public partial class ScVmmCloudCapacity : IUtf8JsonSerializable, IJsonModel<ScVmmCloudCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScVmmCloudCapacity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScVmmCloudCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmCloudCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmCloudCapacity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CpuCount))
            {
                writer.WritePropertyName("cpuCount"u8);
                writer.WriteNumberValue(CpuCount.Value);
            }
            if (Optional.IsDefined(MemoryMB))
            {
                writer.WritePropertyName("memoryMB"u8);
                writer.WriteNumberValue(MemoryMB.Value);
            }
            if (Optional.IsDefined(VmCount))
            {
                writer.WritePropertyName("vmCount"u8);
                writer.WriteNumberValue(VmCount.Value);
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

        ScVmmCloudCapacity IJsonModel<ScVmmCloudCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmCloudCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmCloudCapacity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScVmmCloudCapacity(document.RootElement, options);
        }

        internal static ScVmmCloudCapacity DeserializeScVmmCloudCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? cpuCount = default;
            long? memoryMB = default;
            long? vmCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vmCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScVmmCloudCapacity(cpuCount, memoryMB, vmCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScVmmCloudCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmCloudCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScVmmCloudCapacity)} does not support writing '{options.Format}' format.");
            }
        }

        ScVmmCloudCapacity IPersistableModel<ScVmmCloudCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmCloudCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScVmmCloudCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScVmmCloudCapacity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScVmmCloudCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
