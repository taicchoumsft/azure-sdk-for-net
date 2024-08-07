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
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel : IUtf8JsonSerializable, IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(CdcInsertCounter))
            {
                writer.WritePropertyName("cdcInsertCounter"u8);
                writer.WriteNumberValue(CdcInsertCounter.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CdcUpdateCounter))
            {
                writer.WritePropertyName("cdcUpdateCounter"u8);
                writer.WriteNumberValue(CdcUpdateCounter.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CdcDeleteCounter))
            {
                writer.WritePropertyName("cdcDeleteCounter"u8);
                writer.WriteNumberValue(CdcDeleteCounter.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FullLoadEstFinishOn))
            {
                writer.WritePropertyName("fullLoadEstFinishTime"u8);
                writer.WriteStringValue(FullLoadEstFinishOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(FullLoadStartedOn))
            {
                writer.WritePropertyName("fullLoadStartedOn"u8);
                writer.WriteStringValue(FullLoadStartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(FullLoadEndedOn))
            {
                writer.WritePropertyName("fullLoadEndedOn"u8);
                writer.WriteStringValue(FullLoadEndedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(FullLoadTotalRows))
            {
                writer.WritePropertyName("fullLoadTotalRows"u8);
                writer.WriteNumberValue(FullLoadTotalRows.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TotalChangesApplied))
            {
                writer.WritePropertyName("totalChangesApplied"u8);
                writer.WriteNumberValue(TotalChangesApplied.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DataErrorsCounter))
            {
                writer.WritePropertyName("dataErrorsCounter"u8);
                writer.WriteNumberValue(DataErrorsCounter.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
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

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel(document.RootElement, options);
        }

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tableName = default;
            string databaseName = default;
            long? cdcInsertCounter = default;
            long? cdcUpdateCounter = default;
            long? cdcDeleteCounter = default;
            DateTimeOffset? fullLoadEstFinishTime = default;
            DateTimeOffset? fullLoadStartedOn = default;
            DateTimeOffset? fullLoadEndedOn = default;
            long? fullLoadTotalRows = default;
            SyncTableMigrationState? state = default;
            long? totalChangesApplied = default;
            long? dataErrorsCounter = default;
            DateTimeOffset? lastModifiedTime = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cdcInsertCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcInsertCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcUpdateCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcUpdateCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcDeleteCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcDeleteCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadEstFinishTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadEstFinishTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fullLoadStartedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadStartedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fullLoadEndedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadEndedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fullLoadTotalRows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadTotalRows = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SyncTableMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalChangesApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalChangesApplied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataErrorsCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataErrorsCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
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
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel(
                id,
                resultType,
                serializedAdditionalRawData,
                tableName,
                databaseName,
                cdcInsertCounter,
                cdcUpdateCounter,
                cdcDeleteCounter,
                fullLoadEstFinishTime,
                fullLoadStartedOn,
                fullLoadEndedOn,
                fullLoadTotalRows,
                state,
                totalChangesApplied,
                dataErrorsCounter,
                lastModifiedTime);
        }

        BinaryData IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel)} does not support writing '{options.Format}' format.");
            }
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
