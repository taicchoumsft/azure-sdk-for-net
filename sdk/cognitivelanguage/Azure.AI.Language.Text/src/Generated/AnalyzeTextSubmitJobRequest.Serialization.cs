// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    internal partial class AnalyzeTextSubmitJobRequest : IUtf8JsonSerializable, IJsonModel<AnalyzeTextSubmitJobRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeTextSubmitJobRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalyzeTextSubmitJobRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextSubmitJobRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextSubmitJobRequest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WritePropertyName("analysisInput"u8);
            writer.WriteObjectValue(TextInput, options);
            writer.WritePropertyName("tasks"u8);
            writer.WriteStartArray();
            foreach (var item in Actions)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(DefaultLanguage))
            {
                writer.WritePropertyName("defaultLanguage"u8);
                writer.WriteStringValue(DefaultLanguage);
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

        AnalyzeTextSubmitJobRequest IJsonModel<AnalyzeTextSubmitJobRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextSubmitJobRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextSubmitJobRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextSubmitJobRequest(document.RootElement, options);
        }

        internal static AnalyzeTextSubmitJobRequest DeserializeAnalyzeTextSubmitJobRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            MultiLanguageTextInput analysisInput = default;
            IReadOnlyList<AnalyzeTextOperationAction> tasks = default;
            string defaultLanguage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("analysisInput"u8))
                {
                    analysisInput = MultiLanguageTextInput.DeserializeMultiLanguageTextInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tasks"u8))
                {
                    List<AnalyzeTextOperationAction> array = new List<AnalyzeTextOperationAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalyzeTextOperationAction.DeserializeAnalyzeTextOperationAction(item, options));
                    }
                    tasks = array;
                    continue;
                }
                if (property.NameEquals("defaultLanguage"u8))
                {
                    defaultLanguage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AnalyzeTextSubmitJobRequest(displayName, analysisInput, tasks, defaultLanguage, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyzeTextSubmitJobRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextSubmitJobRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextSubmitJobRequest)} does not support writing '{options.Format}' format.");
            }
        }

        AnalyzeTextSubmitJobRequest IPersistableModel<AnalyzeTextSubmitJobRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextSubmitJobRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyzeTextSubmitJobRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextSubmitJobRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeTextSubmitJobRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnalyzeTextSubmitJobRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnalyzeTextSubmitJobRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
