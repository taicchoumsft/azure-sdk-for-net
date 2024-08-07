// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MigrationId))
            {
                writer.WritePropertyName("migrationId"u8);
                writer.WriteStringValue(MigrationId);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName"u8);
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndedOn))
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(DataIntegrityValidationResult))
            {
                writer.WritePropertyName("dataIntegrityValidationResult"u8);
                writer.WriteObjectValue(DataIntegrityValidationResult, options);
            }
            if (options.Format != "W" && Optional.IsDefined(SchemaValidationResult))
            {
                writer.WritePropertyName("schemaValidationResult"u8);
                writer.WriteObjectValue(SchemaValidationResult, options);
            }
            if (options.Format != "W" && Optional.IsDefined(QueryAnalysisValidationResult))
            {
                writer.WritePropertyName("queryAnalysisValidationResult"u8);
                writer.WriteObjectValue(QueryAnalysisValidationResult, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult IJsonModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string migrationId = default;
            string sourceDatabaseName = default;
            string targetDatabaseName = default;
            DateTimeOffset? startedOn = default;
            DateTimeOffset? endedOn = default;
            DataIntegrityValidationResult dataIntegrityValidationResult = default;
            SchemaComparisonValidationResult schemaValidationResult = default;
            QueryAnalysisValidationResult queryAnalysisValidationResult = default;
            ValidationStatus? status = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationId"u8))
                {
                    migrationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceDatabaseName"u8))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dataIntegrityValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataIntegrityValidationResult = DataIntegrityValidationResult.DeserializeDataIntegrityValidationResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("schemaValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaValidationResult = SchemaComparisonValidationResult.DeserializeSchemaComparisonValidationResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("queryAnalysisValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryAnalysisValidationResult = QueryAnalysisValidationResult.DeserializeQueryAnalysisValidationResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ValidationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(
                id,
                resultType,
                serializedAdditionalRawData,
                migrationId,
                sourceDatabaseName,
                targetDatabaseName,
                startedOn,
                endedOn,
                dataIntegrityValidationResult,
                schemaValidationResult,
                queryAnalysisValidationResult,
                status);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
