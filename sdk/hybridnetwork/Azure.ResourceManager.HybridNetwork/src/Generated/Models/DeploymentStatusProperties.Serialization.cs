// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class DeploymentStatusProperties : IUtf8JsonSerializable, IJsonModel<DeploymentStatusProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentStatusProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentStatusProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentStatusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentStatusProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteObjectValue(Resources, options);
            }
            if (Optional.IsDefined(NextExpectedUpdateOn))
            {
                writer.WritePropertyName("nextExpectedUpdateAt"u8);
                writer.WriteStringValue(NextExpectedUpdateOn.Value, "O");
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

        DeploymentStatusProperties IJsonModel<DeploymentStatusProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentStatusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentStatusProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentStatusProperties(document.RootElement, options);
        }

        internal static DeploymentStatusProperties DeserializeDeploymentStatusProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComponentStatus? status = default;
            ComponentKubernetesResources resources = default;
            DateTimeOffset? nextExpectedUpdateAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resources = ComponentKubernetesResources.DeserializeComponentKubernetesResources(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nextExpectedUpdateAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextExpectedUpdateAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentStatusProperties(status, resources, nextExpectedUpdateAt, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeploymentStatusProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentStatusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentStatusProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentStatusProperties IPersistableModel<DeploymentStatusProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentStatusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeploymentStatusProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentStatusProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentStatusProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
