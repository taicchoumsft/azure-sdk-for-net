// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerInstanceView : IUtf8JsonSerializable, IJsonModel<ContainerInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerInstanceView>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerInstanceView)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RestartCount))
            {
                writer.WritePropertyName("restartCount"u8);
                writer.WriteNumberValue(RestartCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentState))
            {
                writer.WritePropertyName("currentState"u8);
                writer.WriteObjectValue(CurrentState, options);
            }
            if (options.Format != "W" && Optional.IsDefined(PreviousState))
            {
                writer.WritePropertyName("previousState"u8);
                writer.WriteObjectValue(PreviousState, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ContainerInstanceView IJsonModel<ContainerInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerInstanceView)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerInstanceView(document.RootElement, options);
        }

        internal static ContainerInstanceView DeserializeContainerInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? restartCount = default;
            ContainerState currentState = default;
            ContainerState previousState = default;
            IReadOnlyList<ContainerEvent> events = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restartCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restartCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = ContainerState.DeserializeContainerState(property.Value, options);
                    continue;
                }
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = ContainerState.DeserializeContainerState(property.Value, options);
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerEvent> array = new List<ContainerEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerEvent.DeserializeContainerEvent(item, options));
                    }
                    events = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerInstanceView(restartCount, currentState, previousState, events ?? new ChangeTrackingList<ContainerEvent>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerInstanceView)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerInstanceView IPersistableModel<ContainerInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerInstanceView)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
