// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAksComputeSecrets : IUtf8JsonSerializable, IJsonModel<MachineLearningAksComputeSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAksComputeSecrets>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningAksComputeSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAksComputeSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAksComputeSecrets)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UserKubeConfig))
            {
                writer.WritePropertyName("userKubeConfig"u8);
                writer.WriteStringValue(UserKubeConfig);
            }
            if (Optional.IsDefined(AdminKubeConfig))
            {
                writer.WritePropertyName("adminKubeConfig"u8);
                writer.WriteStringValue(AdminKubeConfig);
            }
            if (Optional.IsDefined(ImagePullSecretName))
            {
                if (ImagePullSecretName != null)
                {
                    writer.WritePropertyName("imagePullSecretName"u8);
                    writer.WriteStringValue(ImagePullSecretName);
                }
                else
                {
                    writer.WriteNull("imagePullSecretName");
                }
            }
            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
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

        MachineLearningAksComputeSecrets IJsonModel<MachineLearningAksComputeSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAksComputeSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAksComputeSecrets)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAksComputeSecrets(document.RootElement, options);
        }

        internal static MachineLearningAksComputeSecrets DeserializeMachineLearningAksComputeSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userKubeConfig = default;
            string adminKubeConfig = default;
            string imagePullSecretName = default;
            ComputeType computeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userKubeConfig"u8))
                {
                    userKubeConfig = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminKubeConfig"u8))
                {
                    adminKubeConfig = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imagePullSecretName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        imagePullSecretName = null;
                        continue;
                    }
                    imagePullSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeType"u8))
                {
                    computeType = new ComputeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningAksComputeSecrets(computeType, serializedAdditionalRawData, userKubeConfig, adminKubeConfig, imagePullSecretName);
        }

        BinaryData IPersistableModel<MachineLearningAksComputeSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAksComputeSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAksComputeSecrets)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningAksComputeSecrets IPersistableModel<MachineLearningAksComputeSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAksComputeSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAksComputeSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAksComputeSecrets)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAksComputeSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
