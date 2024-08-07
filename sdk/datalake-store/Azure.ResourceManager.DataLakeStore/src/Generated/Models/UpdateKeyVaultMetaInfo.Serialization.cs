// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal partial class UpdateKeyVaultMetaInfo : IUtf8JsonSerializable, IJsonModel<UpdateKeyVaultMetaInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateKeyVaultMetaInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateKeyVaultMetaInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateKeyVaultMetaInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateKeyVaultMetaInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptionKeyVersion))
            {
                writer.WritePropertyName("encryptionKeyVersion"u8);
                writer.WriteStringValue(EncryptionKeyVersion);
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

        UpdateKeyVaultMetaInfo IJsonModel<UpdateKeyVaultMetaInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateKeyVaultMetaInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateKeyVaultMetaInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateKeyVaultMetaInfo(document.RootElement, options);
        }

        internal static UpdateKeyVaultMetaInfo DeserializeUpdateKeyVaultMetaInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string encryptionKeyVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encryptionKeyVersion"u8))
                {
                    encryptionKeyVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateKeyVaultMetaInfo(encryptionKeyVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateKeyVaultMetaInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateKeyVaultMetaInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateKeyVaultMetaInfo)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateKeyVaultMetaInfo IPersistableModel<UpdateKeyVaultMetaInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateKeyVaultMetaInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateKeyVaultMetaInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateKeyVaultMetaInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateKeyVaultMetaInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
