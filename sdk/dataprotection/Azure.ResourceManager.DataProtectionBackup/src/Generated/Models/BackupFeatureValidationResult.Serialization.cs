// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupFeatureValidationResult : IUtf8JsonSerializable, IJsonModel<BackupFeatureValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupFeatureValidationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupFeatureValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFeatureValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupFeatureValidationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FeatureType))
            {
                writer.WritePropertyName("featureType"u8);
                writer.WriteStringValue(FeatureType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        BackupFeatureValidationResult IJsonModel<BackupFeatureValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFeatureValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupFeatureValidationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupFeatureValidationResult(document.RootElement, options);
        }

        internal static BackupFeatureValidationResult DeserializeBackupFeatureValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BackupSupportedFeatureType? featureType = default;
            IReadOnlyList<BackupSupportedFeature> features = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featureType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featureType = new BackupSupportedFeatureType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupSupportedFeature> array = new List<BackupSupportedFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupSupportedFeature.DeserializeBackupSupportedFeature(item, options));
                    }
                    features = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackupFeatureValidationResult(objectType, serializedAdditionalRawData, featureType, features ?? new ChangeTrackingList<BackupSupportedFeature>());
        }

        BinaryData IPersistableModel<BackupFeatureValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFeatureValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupFeatureValidationResult)} does not support writing '{options.Format}' format.");
            }
        }

        BackupFeatureValidationResult IPersistableModel<BackupFeatureValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFeatureValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupFeatureValidationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupFeatureValidationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupFeatureValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
