// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class EventHubCaptureFileCreatedEventData : IUtf8JsonSerializable, IJsonModel<EventHubCaptureFileCreatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubCaptureFileCreatedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventHubCaptureFileCreatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCaptureFileCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubCaptureFileCreatedEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Fileurl))
            {
                writer.WritePropertyName("fileUrl"u8);
                writer.WriteStringValue(Fileurl);
            }
            if (Optional.IsDefined(FileType))
            {
                writer.WritePropertyName("fileType"u8);
                writer.WriteStringValue(FileType);
            }
            if (Optional.IsDefined(PartitionId))
            {
                writer.WritePropertyName("partitionId"u8);
                writer.WriteStringValue(PartitionId);
            }
            if (Optional.IsDefined(SizeInBytes))
            {
                writer.WritePropertyName("sizeInBytes"u8);
                writer.WriteNumberValue(SizeInBytes.Value);
            }
            if (Optional.IsDefined(EventCount))
            {
                writer.WritePropertyName("eventCount"u8);
                writer.WriteNumberValue(EventCount.Value);
            }
            if (Optional.IsDefined(FirstSequenceNumber))
            {
                writer.WritePropertyName("firstSequenceNumber"u8);
                writer.WriteNumberValue(FirstSequenceNumber.Value);
            }
            if (Optional.IsDefined(LastSequenceNumber))
            {
                writer.WritePropertyName("lastSequenceNumber"u8);
                writer.WriteNumberValue(LastSequenceNumber.Value);
            }
            writer.WritePropertyName("firstEnqueueTime"u8);
            writer.WriteStringValue(FirstEnqueueTime, "O");
            writer.WritePropertyName("lastEnqueueTime"u8);
            writer.WriteStringValue(LastEnqueueTime, "O");
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

        EventHubCaptureFileCreatedEventData IJsonModel<EventHubCaptureFileCreatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCaptureFileCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubCaptureFileCreatedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubCaptureFileCreatedEventData(document.RootElement, options);
        }

        internal static EventHubCaptureFileCreatedEventData DeserializeEventHubCaptureFileCreatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileUrl = default;
            string fileType = default;
            string partitionId = default;
            int? sizeInBytes = default;
            int? eventCount = default;
            int? firstSequenceNumber = default;
            int? lastSequenceNumber = default;
            DateTimeOffset firstEnqueueTime = default;
            DateTimeOffset lastEnqueueTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileUrl"u8))
                {
                    fileUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileType"u8))
                {
                    fileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partitionId"u8))
                {
                    partitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sizeInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeInBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("firstSequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastSequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("firstEnqueueTime"u8))
                {
                    firstEnqueueTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEnqueueTime"u8))
                {
                    lastEnqueueTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventHubCaptureFileCreatedEventData(
                fileUrl,
                fileType,
                partitionId,
                sizeInBytes,
                eventCount,
                firstSequenceNumber,
                lastSequenceNumber,
                firstEnqueueTime,
                lastEnqueueTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventHubCaptureFileCreatedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCaptureFileCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubCaptureFileCreatedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        EventHubCaptureFileCreatedEventData IPersistableModel<EventHubCaptureFileCreatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCaptureFileCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubCaptureFileCreatedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubCaptureFileCreatedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubCaptureFileCreatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EventHubCaptureFileCreatedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEventHubCaptureFileCreatedEventData(document.RootElement);
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
