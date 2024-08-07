// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabRosterProfile : IUtf8JsonSerializable, IJsonModel<LabRosterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabRosterProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LabRosterProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabRosterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabRosterProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveDirectoryGroupId))
            {
                writer.WritePropertyName("activeDirectoryGroupId"u8);
                writer.WriteStringValue(ActiveDirectoryGroupId);
            }
            if (Optional.IsDefined(LtiContextId))
            {
                writer.WritePropertyName("ltiContextId"u8);
                writer.WriteStringValue(LtiContextId);
            }
            if (Optional.IsDefined(LmsInstance))
            {
                writer.WritePropertyName("lmsInstance"u8);
                writer.WriteStringValue(LmsInstance.AbsoluteUri);
            }
            if (Optional.IsDefined(LtiClientId))
            {
                writer.WritePropertyName("ltiClientId"u8);
                writer.WriteStringValue(LtiClientId);
            }
            if (Optional.IsDefined(LtiRosterEndpoint))
            {
                writer.WritePropertyName("ltiRosterEndpoint"u8);
                writer.WriteStringValue(LtiRosterEndpoint.AbsoluteUri);
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

        LabRosterProfile IJsonModel<LabRosterProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabRosterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabRosterProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabRosterProfile(document.RootElement, options);
        }

        internal static LabRosterProfile DeserializeLabRosterProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activeDirectoryGroupId = default;
            string ltiContextId = default;
            Uri lmsInstance = default;
            string ltiClientId = default;
            Uri ltiRosterEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeDirectoryGroupId"u8))
                {
                    activeDirectoryGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ltiContextId"u8))
                {
                    ltiContextId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lmsInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lmsInstance = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ltiClientId"u8))
                {
                    ltiClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ltiRosterEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ltiRosterEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LabRosterProfile(
                activeDirectoryGroupId,
                ltiContextId,
                lmsInstance,
                ltiClientId,
                ltiRosterEndpoint,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LabRosterProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabRosterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LabRosterProfile)} does not support writing '{options.Format}' format.");
            }
        }

        LabRosterProfile IPersistableModel<LabRosterProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabRosterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabRosterProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LabRosterProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabRosterProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
