// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerResourceRequestsContent : IUtf8JsonSerializable, IJsonModel<ContainerResourceRequestsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerResourceRequestsContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerResourceRequestsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerResourceRequestsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerResourceRequestsContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("memoryInGB"u8);
            writer.WriteNumberValue(MemoryInGB);
            writer.WritePropertyName("cpu"u8);
            writer.WriteNumberValue(Cpu);
            if (Optional.IsDefined(Gpu))
            {
                writer.WritePropertyName("gpu"u8);
                writer.WriteObjectValue(Gpu, options);
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

        ContainerResourceRequestsContent IJsonModel<ContainerResourceRequestsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerResourceRequestsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerResourceRequestsContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerResourceRequestsContent(document.RootElement, options);
        }

        internal static ContainerResourceRequestsContent DeserializeContainerResourceRequestsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double memoryInGB = default;
            double cpu = default;
            ContainerGpuResourceInfo gpu = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memoryInGB"u8))
                {
                    memoryInGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("cpu"u8))
                {
                    cpu = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("gpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gpu = ContainerGpuResourceInfo.DeserializeContainerGpuResourceInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerResourceRequestsContent(memoryInGB, cpu, gpu, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerResourceRequestsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerResourceRequestsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerResourceRequestsContent)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerResourceRequestsContent IPersistableModel<ContainerResourceRequestsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerResourceRequestsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerResourceRequestsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerResourceRequestsContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerResourceRequestsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
