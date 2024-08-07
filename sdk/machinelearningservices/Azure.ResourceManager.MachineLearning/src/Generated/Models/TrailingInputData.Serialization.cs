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
    public partial class TrailingInputData : IUtf8JsonSerializable, IJsonModel<TrailingInputData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrailingInputData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TrailingInputData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrailingInputData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrailingInputData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PreprocessingComponentId))
            {
                if (PreprocessingComponentId != null)
                {
                    writer.WritePropertyName("preprocessingComponentId"u8);
                    writer.WriteStringValue(PreprocessingComponentId);
                }
                else
                {
                    writer.WriteNull("preprocessingComponentId");
                }
            }
            writer.WritePropertyName("windowOffset"u8);
            writer.WriteStringValue(WindowOffset, "P");
            writer.WritePropertyName("windowSize"u8);
            writer.WriteStringValue(WindowSize, "P");
            if (Optional.IsCollectionDefined(Columns))
            {
                if (Columns != null)
                {
                    writer.WritePropertyName("columns"u8);
                    writer.WriteStartObject();
                    foreach (var item in Columns)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("columns");
                }
            }
            if (Optional.IsDefined(DataContext))
            {
                if (DataContext != null)
                {
                    writer.WritePropertyName("dataContext"u8);
                    writer.WriteStringValue(DataContext);
                }
                else
                {
                    writer.WriteNull("dataContext");
                }
            }
            writer.WritePropertyName("inputDataType"u8);
            writer.WriteStringValue(InputDataType.ToString());
            writer.WritePropertyName("jobInputType"u8);
            writer.WriteStringValue(JobInputType.ToString());
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
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

        TrailingInputData IJsonModel<TrailingInputData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrailingInputData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrailingInputData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrailingInputData(document.RootElement, options);
        }

        internal static TrailingInputData DeserializeTrailingInputData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string preprocessingComponentId = default;
            TimeSpan windowOffset = default;
            TimeSpan windowSize = default;
            IDictionary<string, string> columns = default;
            string dataContext = default;
            MonitoringInputDataType inputDataType = default;
            JobInputType jobInputType = default;
            Uri uri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preprocessingComponentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        preprocessingComponentId = null;
                        continue;
                    }
                    preprocessingComponentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowOffset"u8))
                {
                    windowOffset = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("windowSize"u8))
                {
                    windowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        columns = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    columns = dictionary;
                    continue;
                }
                if (property.NameEquals("dataContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataContext = null;
                        continue;
                    }
                    dataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDataType"u8))
                {
                    inputDataType = new MonitoringInputDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobInputType"u8))
                {
                    jobInputType = new JobInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TrailingInputData(
                columns ?? new ChangeTrackingDictionary<string, string>(),
                dataContext,
                inputDataType,
                jobInputType,
                uri,
                serializedAdditionalRawData,
                preprocessingComponentId,
                windowOffset,
                windowSize);
        }

        BinaryData IPersistableModel<TrailingInputData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrailingInputData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrailingInputData)} does not support writing '{options.Format}' format.");
            }
        }

        TrailingInputData IPersistableModel<TrailingInputData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrailingInputData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrailingInputData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrailingInputData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrailingInputData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
