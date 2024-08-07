// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quantum.Models
{
    public partial class WorkspaceKeyListResult : IUtf8JsonSerializable, IJsonModel<WorkspaceKeyListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkspaceKeyListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkspaceKeyListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceKeyListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceKeyListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsApiKeyEnabled))
            {
                writer.WritePropertyName("apiKeyEnabled"u8);
                writer.WriteBooleanValue(IsApiKeyEnabled.Value);
            }
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteObjectValue(PrimaryKey, options);
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteObjectValue(SecondaryKey, options);
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryConnectionString))
            {
                writer.WritePropertyName("primaryConnectionString"u8);
                writer.WriteStringValue(PrimaryConnectionString);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryConnectionString))
            {
                writer.WritePropertyName("secondaryConnectionString"u8);
                writer.WriteStringValue(SecondaryConnectionString);
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

        WorkspaceKeyListResult IJsonModel<WorkspaceKeyListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceKeyListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceKeyListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkspaceKeyListResult(document.RootElement, options);
        }

        internal static WorkspaceKeyListResult DeserializeWorkspaceKeyListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? apiKeyEnabled = default;
            WorkspaceApiKey primaryKey = default;
            WorkspaceApiKey secondaryKey = default;
            string primaryConnectionString = default;
            string secondaryConnectionString = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiKeyEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiKeyEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKey = WorkspaceApiKey.DeserializeWorkspaceApiKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryKey = WorkspaceApiKey.DeserializeWorkspaceApiKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("primaryConnectionString"u8))
                {
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"u8))
                {
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkspaceKeyListResult(
                apiKeyEnabled,
                primaryKey,
                secondaryKey,
                primaryConnectionString,
                secondaryConnectionString,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkspaceKeyListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceKeyListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkspaceKeyListResult)} does not support writing '{options.Format}' format.");
            }
        }

        WorkspaceKeyListResult IPersistableModel<WorkspaceKeyListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceKeyListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkspaceKeyListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkspaceKeyListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkspaceKeyListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
