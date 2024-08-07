// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageActions.Models
{
    public partial class StorageTaskReportProperties : IUtf8JsonSerializable, IJsonModel<StorageTaskReportProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageTaskReportProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageTaskReportProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskReportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTaskReportProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TaskAssignmentId))
            {
                writer.WritePropertyName("taskAssignmentId"u8);
                writer.WriteStringValue(TaskAssignmentId);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (options.Format != "W" && Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartTime);
            }
            if (options.Format != "W" && Optional.IsDefined(FinishTime))
            {
                writer.WritePropertyName("finishTime"u8);
                writer.WriteStringValue(FinishTime);
            }
            if (options.Format != "W" && Optional.IsDefined(ObjectsTargetedCount))
            {
                writer.WritePropertyName("objectsTargetedCount"u8);
                writer.WriteStringValue(ObjectsTargetedCount);
            }
            if (options.Format != "W" && Optional.IsDefined(ObjectsOperatedOnCount))
            {
                writer.WritePropertyName("objectsOperatedOnCount"u8);
                writer.WriteStringValue(ObjectsOperatedOnCount);
            }
            if (options.Format != "W" && Optional.IsDefined(ObjectFailedCount))
            {
                writer.WritePropertyName("objectFailedCount"u8);
                writer.WriteStringValue(ObjectFailedCount);
            }
            if (options.Format != "W" && Optional.IsDefined(ObjectsSucceededCount))
            {
                writer.WritePropertyName("objectsSucceededCount"u8);
                writer.WriteStringValue(ObjectsSucceededCount);
            }
            if (options.Format != "W" && Optional.IsDefined(RunStatusError))
            {
                writer.WritePropertyName("runStatusError"u8);
                writer.WriteStringValue(RunStatusError);
            }
            if (options.Format != "W" && Optional.IsDefined(RunStatusEnum))
            {
                writer.WritePropertyName("runStatusEnum"u8);
                writer.WriteStringValue(RunStatusEnum.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SummaryReportPath))
            {
                writer.WritePropertyName("summaryReportPath"u8);
                writer.WriteStringValue(SummaryReportPath);
            }
            if (options.Format != "W" && Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId"u8);
                writer.WriteStringValue(TaskId);
            }
            if (options.Format != "W" && Optional.IsDefined(TaskVersion))
            {
                writer.WritePropertyName("taskVersion"u8);
                writer.WriteStringValue(TaskVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(RunResult))
            {
                writer.WritePropertyName("runResult"u8);
                writer.WriteStringValue(RunResult.Value.ToString());
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

        StorageTaskReportProperties IJsonModel<StorageTaskReportProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskReportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTaskReportProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageTaskReportProperties(document.RootElement, options);
        }

        internal static StorageTaskReportProperties DeserializeStorageTaskReportProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier taskAssignmentId = default;
            ResourceIdentifier storageAccountId = default;
            string startTime = default;
            string finishTime = default;
            string objectsTargetedCount = default;
            string objectsOperatedOnCount = default;
            string objectFailedCount = default;
            string objectsSucceededCount = default;
            string runStatusError = default;
            StorageTaskRunStatus? runStatusEnum = default;
            string summaryReportPath = default;
            ResourceIdentifier taskId = default;
            string taskVersion = default;
            StorageTaskRunResult? runResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taskAssignmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    taskAssignmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("finishTime"u8))
                {
                    finishTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectsTargetedCount"u8))
                {
                    objectsTargetedCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectsOperatedOnCount"u8))
                {
                    objectsOperatedOnCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectFailedCount"u8))
                {
                    objectFailedCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectsSucceededCount"u8))
                {
                    objectsSucceededCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runStatusError"u8))
                {
                    runStatusError = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runStatusEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runStatusEnum = new StorageTaskRunStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("summaryReportPath"u8))
                {
                    summaryReportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    taskId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskVersion"u8))
                {
                    taskVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runResult = new StorageTaskRunResult(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageTaskReportProperties(
                taskAssignmentId,
                storageAccountId,
                startTime,
                finishTime,
                objectsTargetedCount,
                objectsOperatedOnCount,
                objectFailedCount,
                objectsSucceededCount,
                runStatusError,
                runStatusEnum,
                summaryReportPath,
                taskId,
                taskVersion,
                runResult,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageTaskReportProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskReportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageTaskReportProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StorageTaskReportProperties IPersistableModel<StorageTaskReportProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskReportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageTaskReportProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageTaskReportProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageTaskReportProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
