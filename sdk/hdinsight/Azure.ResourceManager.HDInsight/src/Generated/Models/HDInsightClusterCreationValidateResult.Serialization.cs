// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterCreationValidateResult : IUtf8JsonSerializable, IJsonModel<HDInsightClusterCreationValidateResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterCreationValidateResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightClusterCreationValidateResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterCreationValidateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterCreationValidateResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ValidationWarnings))
            {
                writer.WritePropertyName("validationWarnings"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationWarnings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EstimatedCreationDuration))
            {
                writer.WritePropertyName("estimatedCreationDuration"u8);
                writer.WriteStringValue(EstimatedCreationDuration.Value, "P");
            }
            if (Optional.IsCollectionDefined(AaddsResourcesDetails))
            {
                writer.WritePropertyName("aaddsResourcesDetails"u8);
                writer.WriteStartArray();
                foreach (var item in AaddsResourcesDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        HDInsightClusterCreationValidateResult IJsonModel<HDInsightClusterCreationValidateResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterCreationValidateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterCreationValidateResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterCreationValidateResult(document.RootElement, options);
        }

        internal static HDInsightClusterCreationValidateResult DeserializeHDInsightClusterCreationValidateResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<HDInsightClusterValidationErrorInfo> validationErrors = default;
            IReadOnlyList<HDInsightClusterValidationErrorInfo> validationWarnings = default;
            TimeSpan? estimatedCreationDuration = default;
            IReadOnlyList<HDInsightClusterAaddsDetail> aaddsResourcesDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightClusterValidationErrorInfo> array = new List<HDInsightClusterValidationErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightClusterValidationErrorInfo.DeserializeHDInsightClusterValidationErrorInfo(item, options));
                    }
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("validationWarnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightClusterValidationErrorInfo> array = new List<HDInsightClusterValidationErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightClusterValidationErrorInfo.DeserializeHDInsightClusterValidationErrorInfo(item, options));
                    }
                    validationWarnings = array;
                    continue;
                }
                if (property.NameEquals("estimatedCreationDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedCreationDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("aaddsResourcesDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightClusterAaddsDetail> array = new List<HDInsightClusterAaddsDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightClusterAaddsDetail.DeserializeHDInsightClusterAaddsDetail(item, options));
                    }
                    aaddsResourcesDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightClusterCreationValidateResult(validationErrors ?? new ChangeTrackingList<HDInsightClusterValidationErrorInfo>(), validationWarnings ?? new ChangeTrackingList<HDInsightClusterValidationErrorInfo>(), estimatedCreationDuration, aaddsResourcesDetails ?? new ChangeTrackingList<HDInsightClusterAaddsDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterCreationValidateResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterCreationValidateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterCreationValidateResult)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightClusterCreationValidateResult IPersistableModel<HDInsightClusterCreationValidateResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterCreationValidateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightClusterCreationValidateResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterCreationValidateResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterCreationValidateResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
