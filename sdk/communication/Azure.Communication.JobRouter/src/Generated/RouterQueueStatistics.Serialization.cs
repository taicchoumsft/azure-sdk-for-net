// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RouterQueueStatistics : IUtf8JsonSerializable, IJsonModel<RouterQueueStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouterQueueStatistics>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RouterQueueStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterQueueStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterQueueStatistics)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("queueId"u8);
            writer.WriteStringValue(QueueId);
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
            if (Optional.IsCollectionDefined(EstimatedWaitTimes))
            {
                writer.WritePropertyName("estimatedWaitTimeMinutes"u8);
                WriteEstimatedWaitTimes(writer, options);
            }
            if (Optional.IsDefined(LongestJobWaitTimeMinutes))
            {
                writer.WritePropertyName("longestJobWaitTimeMinutes"u8);
                writer.WriteNumberValue(LongestJobWaitTimeMinutes.Value);
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

        RouterQueueStatistics IJsonModel<RouterQueueStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterQueueStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterQueueStatistics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterQueueStatistics(document.RootElement, options);
        }

        internal static RouterQueueStatistics DeserializeRouterQueueStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queueId = default;
            int length = default;
            IDictionary<int, TimeSpan> estimatedWaitTimeMinutes = default;
            double? longestJobWaitTimeMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("estimatedWaitTimeMinutes"u8))
                {
                    ReadEstimatedWaitTimes(property, ref estimatedWaitTimeMinutes);
                    continue;
                }
                if (property.NameEquals("longestJobWaitTimeMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longestJobWaitTimeMinutes = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RouterQueueStatistics(queueId, length, estimatedWaitTimeMinutes ?? new ChangeTrackingDictionary<int, TimeSpan>(), longestJobWaitTimeMinutes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouterQueueStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterQueueStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RouterQueueStatistics)} does not support writing '{options.Format}' format.");
            }
        }

        RouterQueueStatistics IPersistableModel<RouterQueueStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterQueueStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouterQueueStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RouterQueueStatistics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouterQueueStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RouterQueueStatistics FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterQueueStatistics(document.RootElement);
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
