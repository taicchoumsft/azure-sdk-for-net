// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class FailoverWorkflowModelCustomProperties : IUtf8JsonSerializable, IJsonModel<FailoverWorkflowModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailoverWorkflowModelCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FailoverWorkflowModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverWorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverWorkflowModelCustomProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(ProtectedItemDetails))
            {
                writer.WritePropertyName("protectedItemDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedItemDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && Optional.IsCollectionDefined(AffectedObjectDetails))
            {
                writer.WritePropertyName("affectedObjectDetails"u8);
                writer.WriteStartObject();
                foreach (var item in AffectedObjectDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        FailoverWorkflowModelCustomProperties IJsonModel<FailoverWorkflowModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverWorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverWorkflowModelCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailoverWorkflowModelCustomProperties(document.RootElement, options);
        }

        internal static FailoverWorkflowModelCustomProperties DeserializeFailoverWorkflowModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FailoverProtectedItemProperties> protectedItemDetails = default;
            string instanceType = default;
            IReadOnlyDictionary<string, string> affectedObjectDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FailoverProtectedItemProperties> array = new List<FailoverProtectedItemProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FailoverProtectedItemProperties.DeserializeFailoverProtectedItemProperties(item, options));
                    }
                    protectedItemDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    affectedObjectDetails = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FailoverWorkflowModelCustomProperties(instanceType, affectedObjectDetails ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData, protectedItemDetails ?? new ChangeTrackingList<FailoverProtectedItemProperties>());
        }

        BinaryData IPersistableModel<FailoverWorkflowModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverWorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FailoverWorkflowModelCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        FailoverWorkflowModelCustomProperties IPersistableModel<FailoverWorkflowModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverWorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFailoverWorkflowModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailoverWorkflowModelCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailoverWorkflowModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
