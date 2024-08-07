// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class WorkspaceConnectionPersonalAccessToken : IUtf8JsonSerializable, IJsonModel<WorkspaceConnectionPersonalAccessToken>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkspaceConnectionPersonalAccessToken>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkspaceConnectionPersonalAccessToken>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionPersonalAccessToken>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionPersonalAccessToken)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Pat))
            {
                writer.WritePropertyName("pat"u8);
                writer.WriteStringValue(Pat);
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

        WorkspaceConnectionPersonalAccessToken IJsonModel<WorkspaceConnectionPersonalAccessToken>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionPersonalAccessToken>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionPersonalAccessToken)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkspaceConnectionPersonalAccessToken(document.RootElement, options);
        }

        internal static WorkspaceConnectionPersonalAccessToken DeserializeWorkspaceConnectionPersonalAccessToken(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string pat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pat"u8))
                {
                    pat = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkspaceConnectionPersonalAccessToken(pat, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkspaceConnectionPersonalAccessToken>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionPersonalAccessToken>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkspaceConnectionPersonalAccessToken)} does not support writing '{options.Format}' format.");
            }
        }

        WorkspaceConnectionPersonalAccessToken IPersistableModel<WorkspaceConnectionPersonalAccessToken>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionPersonalAccessToken>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkspaceConnectionPersonalAccessToken(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkspaceConnectionPersonalAccessToken)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkspaceConnectionPersonalAccessToken>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
