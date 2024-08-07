// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownScheduleActionBase))]
    public partial class MachineLearningScheduleAction : IUtf8JsonSerializable, IJsonModel<MachineLearningScheduleAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningScheduleAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningScheduleAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScheduleAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningScheduleAction)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
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

        MachineLearningScheduleAction IJsonModel<MachineLearningScheduleAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScheduleAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningScheduleAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningScheduleAction(document.RootElement, options);
        }

        internal static MachineLearningScheduleAction DeserializeMachineLearningScheduleAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("actionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CreateJob": return MachineLearningJobScheduleAction.DeserializeMachineLearningJobScheduleAction(element, options);
                    case "CreateMonitor": return CreateMonitorAction.DeserializeCreateMonitorAction(element, options);
                    case "ImportData": return ImportDataAction.DeserializeImportDataAction(element, options);
                    case "InvokeBatchEndpoint": return MachineLearningEndpointScheduleAction.DeserializeMachineLearningEndpointScheduleAction(element, options);
                }
            }
            return UnknownScheduleActionBase.DeserializeUnknownScheduleActionBase(element, options);
        }

        BinaryData IPersistableModel<MachineLearningScheduleAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScheduleAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningScheduleAction)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningScheduleAction IPersistableModel<MachineLearningScheduleAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScheduleAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningScheduleAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningScheduleAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningScheduleAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
