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
    public partial class MachineLearningDatabricksProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningDatabricksProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDatabricksProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningDatabricksProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatabricksProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDatabricksProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DatabricksAccessToken))
            {
                writer.WritePropertyName("databricksAccessToken"u8);
                writer.WriteStringValue(DatabricksAccessToken);
            }
            if (Optional.IsDefined(WorkspaceUri))
            {
                writer.WritePropertyName("workspaceUrl"u8);
                writer.WriteStringValue(WorkspaceUri.AbsoluteUri);
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

        MachineLearningDatabricksProperties IJsonModel<MachineLearningDatabricksProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatabricksProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDatabricksProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDatabricksProperties(document.RootElement, options);
        }

        internal static MachineLearningDatabricksProperties DeserializeMachineLearningDatabricksProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databricksAccessToken = default;
            Uri workspaceUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databricksAccessToken"u8))
                {
                    databricksAccessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningDatabricksProperties(databricksAccessToken, workspaceUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningDatabricksProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatabricksProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDatabricksProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningDatabricksProperties IPersistableModel<MachineLearningDatabricksProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatabricksProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningDatabricksProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDatabricksProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningDatabricksProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
