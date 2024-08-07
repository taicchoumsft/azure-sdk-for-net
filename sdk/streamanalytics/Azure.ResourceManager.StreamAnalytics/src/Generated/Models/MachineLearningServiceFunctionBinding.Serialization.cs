// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class MachineLearningServiceFunctionBinding : IUtf8JsonSerializable, IJsonModel<MachineLearningServiceFunctionBinding>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServiceFunctionBinding>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningServiceFunctionBinding>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServiceFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServiceFunctionBinding)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionBindingType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize"u8);
                writer.WriteNumberValue(BatchSize.Value);
            }
            if (Optional.IsDefined(NumberOfParallelRequests))
            {
                writer.WritePropertyName("numberOfParallelRequests"u8);
                writer.WriteNumberValue(NumberOfParallelRequests.Value);
            }
            if (Optional.IsDefined(InputRequestName))
            {
                writer.WritePropertyName("inputRequestName"u8);
                writer.WriteStringValue(InputRequestName);
            }
            if (Optional.IsDefined(OutputResponseName))
            {
                writer.WritePropertyName("outputResponseName"u8);
                writer.WriteStringValue(OutputResponseName);
            }
            writer.WriteEndObject();
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

        MachineLearningServiceFunctionBinding IJsonModel<MachineLearningServiceFunctionBinding>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServiceFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServiceFunctionBinding)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServiceFunctionBinding(document.RootElement, options);
        }

        internal static MachineLearningServiceFunctionBinding DeserializeMachineLearningServiceFunctionBinding(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string endpoint = default;
            string apiKey = default;
            IList<MachineLearningServiceInputColumn> inputs = default;
            IList<MachineLearningServiceOutputColumn> outputs = default;
            int? batchSize = default;
            int? numberOfParallelRequests = default;
            string inputRequestName = default;
            string outputResponseName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiKey"u8))
                        {
                            apiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineLearningServiceInputColumn> array = new List<MachineLearningServiceInputColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineLearningServiceInputColumn.DeserializeMachineLearningServiceInputColumn(item, options));
                            }
                            inputs = array;
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineLearningServiceOutputColumn> array = new List<MachineLearningServiceOutputColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineLearningServiceOutputColumn.DeserializeMachineLearningServiceOutputColumn(item, options));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("batchSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            batchSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfParallelRequests"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfParallelRequests = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("inputRequestName"u8))
                        {
                            inputRequestName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("outputResponseName"u8))
                        {
                            outputResponseName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningServiceFunctionBinding(
                type,
                serializedAdditionalRawData,
                endpoint,
                apiKey,
                inputs ?? new ChangeTrackingList<MachineLearningServiceInputColumn>(),
                outputs ?? new ChangeTrackingList<MachineLearningServiceOutputColumn>(),
                batchSize,
                numberOfParallelRequests,
                inputRequestName,
                outputResponseName);
        }

        BinaryData IPersistableModel<MachineLearningServiceFunctionBinding>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServiceFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServiceFunctionBinding)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningServiceFunctionBinding IPersistableModel<MachineLearningServiceFunctionBinding>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServiceFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningServiceFunctionBinding(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServiceFunctionBinding)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningServiceFunctionBinding>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
