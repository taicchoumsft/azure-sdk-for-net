// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    public partial class RunStepToolCallDetails : IUtf8JsonSerializable, IJsonModel<RunStepToolCallDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunStepToolCallDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RunStepToolCallDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepToolCallDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("tool_calls"u8);
            writer.WriteStartArray();
            foreach (var item in ToolCalls)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
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

        RunStepToolCallDetails IJsonModel<RunStepToolCallDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepToolCallDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepToolCallDetails(document.RootElement, options);
        }

        internal static RunStepToolCallDetails DeserializeRunStepToolCallDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RunStepToolCall> toolCalls = default;
            RunStepType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tool_calls"u8))
                {
                    List<RunStepToolCall> array = new List<RunStepToolCall>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunStepToolCall.DeserializeRunStepToolCall(item, options));
                    }
                    toolCalls = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new RunStepType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RunStepToolCallDetails(type, serializedAdditionalRawData, toolCalls);
        }

        BinaryData IPersistableModel<RunStepToolCallDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunStepToolCallDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepToolCallDetails IPersistableModel<RunStepToolCallDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunStepToolCallDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepToolCallDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepToolCallDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RunStepToolCallDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunStepToolCallDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
