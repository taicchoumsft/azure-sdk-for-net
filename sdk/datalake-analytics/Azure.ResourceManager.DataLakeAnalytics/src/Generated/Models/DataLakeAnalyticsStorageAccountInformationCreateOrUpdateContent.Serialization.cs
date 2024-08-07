// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("accessKey"u8);
            writer.WriteStringValue(AccessKey);
            if (Optional.IsDefined(Suffix))
            {
                writer.WritePropertyName("suffix"u8);
                writer.WriteStringValue(Suffix);
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

        DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent IJsonModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent(document.RootElement, options);
        }

        internal static DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent DeserializeDataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accessKey = default;
            string suffix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accessKey"u8))
                        {
                            accessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("suffix"u8))
                        {
                            suffix = property0.Value.GetString();
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
            return new DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent(accessKey, suffix, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent IPersistableModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
