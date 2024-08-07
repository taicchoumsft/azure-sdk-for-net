// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterRunCommandResult : IUtf8JsonSerializable, IJsonModel<ManagedClusterRunCommandResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterRunCommandResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterRunCommandResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterRunCommandResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterRunCommandResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(ExitCode))
            {
                writer.WritePropertyName("exitCode"u8);
                writer.WriteNumberValue(ExitCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedAt"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(FinishedOn))
            {
                writer.WritePropertyName("finishedAt"u8);
                writer.WriteStringValue(FinishedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Logs))
            {
                writer.WritePropertyName("logs"u8);
                writer.WriteStringValue(Logs);
            }
            if (options.Format != "W" && Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            writer.WriteEndObject();
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

        ManagedClusterRunCommandResult IJsonModel<ManagedClusterRunCommandResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterRunCommandResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterRunCommandResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterRunCommandResult(document.RootElement, options);
        }

        internal static ManagedClusterRunCommandResult DeserializeManagedClusterRunCommandResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string provisioningState = default;
            int? exitCode = default;
            DateTimeOffset? startedAt = default;
            DateTimeOffset? finishedAt = default;
            string logs = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("exitCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exitCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("startedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("finishedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            finishedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("logs"u8))
                        {
                            logs = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reason"u8))
                        {
                            reason = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterRunCommandResult(
                id,
                provisioningState,
                exitCode,
                startedAt,
                finishedAt,
                logs,
                reason,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterRunCommandResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterRunCommandResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterRunCommandResult)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterRunCommandResult IPersistableModel<ManagedClusterRunCommandResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterRunCommandResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterRunCommandResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterRunCommandResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterRunCommandResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
