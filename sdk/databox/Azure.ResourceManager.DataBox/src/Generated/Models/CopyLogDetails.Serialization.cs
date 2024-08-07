// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [PersistableModelProxy(typeof(UnknownCopyLogDetails))]
    public partial class CopyLogDetails : IUtf8JsonSerializable, IJsonModel<CopyLogDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CopyLogDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CopyLogDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyLogDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("copyLogDetailsType"u8);
            writer.WriteStringValue(CopyLogDetailsType.ToSerialString());
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

        CopyLogDetails IJsonModel<CopyLogDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyLogDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyLogDetails(document.RootElement, options);
        }

        internal static CopyLogDetails DeserializeCopyLogDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("copyLogDetailsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataBox": return DataBoxAccountCopyLogDetails.DeserializeDataBoxAccountCopyLogDetails(element, options);
                    case "DataBoxCustomerDisk": return DataBoxCustomerDiskCopyLogDetails.DeserializeDataBoxCustomerDiskCopyLogDetails(element, options);
                    case "DataBoxDisk": return DataBoxDiskCopyLogDetails.DeserializeDataBoxDiskCopyLogDetails(element, options);
                    case "DataBoxHeavy": return DataBoxHeavyAccountCopyLogDetails.DeserializeDataBoxHeavyAccountCopyLogDetails(element, options);
                }
            }
            return UnknownCopyLogDetails.DeserializeUnknownCopyLogDetails(element, options);
        }

        BinaryData IPersistableModel<CopyLogDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CopyLogDetails)} does not support writing '{options.Format}' format.");
            }
        }

        CopyLogDetails IPersistableModel<CopyLogDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCopyLogDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CopyLogDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CopyLogDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
