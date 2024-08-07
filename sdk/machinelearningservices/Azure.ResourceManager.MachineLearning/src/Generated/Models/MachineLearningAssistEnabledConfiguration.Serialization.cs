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
    public partial class MachineLearningAssistEnabledConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningAssistEnabledConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAssistEnabledConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningAssistEnabledConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssistEnabledConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAssistEnabledConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("inferencingComputeBinding"u8);
            writer.WriteStringValue(InferencingComputeBinding);
            writer.WritePropertyName("trainingComputeBinding"u8);
            writer.WriteStringValue(TrainingComputeBinding);
            writer.WritePropertyName("mlAssist"u8);
            writer.WriteStringValue(MlAssist.ToString());
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

        MachineLearningAssistEnabledConfiguration IJsonModel<MachineLearningAssistEnabledConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssistEnabledConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAssistEnabledConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAssistEnabledConfiguration(document.RootElement, options);
        }

        internal static MachineLearningAssistEnabledConfiguration DeserializeMachineLearningAssistEnabledConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string inferencingComputeBinding = default;
            string trainingComputeBinding = default;
            MLAssistConfigurationType mlAssist = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inferencingComputeBinding"u8))
                {
                    inferencingComputeBinding = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trainingComputeBinding"u8))
                {
                    trainingComputeBinding = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mlAssist"u8))
                {
                    mlAssist = new MLAssistConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningAssistEnabledConfiguration(mlAssist, serializedAdditionalRawData, inferencingComputeBinding, trainingComputeBinding);
        }

        BinaryData IPersistableModel<MachineLearningAssistEnabledConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssistEnabledConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAssistEnabledConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningAssistEnabledConfiguration IPersistableModel<MachineLearningAssistEnabledConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssistEnabledConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAssistEnabledConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAssistEnabledConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAssistEnabledConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
