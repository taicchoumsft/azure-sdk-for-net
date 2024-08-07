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
    public partial class MachineLearningSslConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningSslConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSslConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningSslConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSslConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSslConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Cert))
            {
                if (Cert != null)
                {
                    writer.WritePropertyName("cert"u8);
                    writer.WriteStringValue(Cert);
                }
                else
                {
                    writer.WriteNull("cert");
                }
            }
            if (Optional.IsDefined(Key))
            {
                if (Key != null)
                {
                    writer.WritePropertyName("key"u8);
                    writer.WriteStringValue(Key);
                }
                else
                {
                    writer.WriteNull("key");
                }
            }
            if (Optional.IsDefined(Cname))
            {
                if (Cname != null)
                {
                    writer.WritePropertyName("cname"u8);
                    writer.WriteStringValue(Cname);
                }
                else
                {
                    writer.WriteNull("cname");
                }
            }
            if (Optional.IsDefined(LeafDomainLabel))
            {
                if (LeafDomainLabel != null)
                {
                    writer.WritePropertyName("leafDomainLabel"u8);
                    writer.WriteStringValue(LeafDomainLabel);
                }
                else
                {
                    writer.WriteNull("leafDomainLabel");
                }
            }
            if (Optional.IsDefined(OverwriteExistingDomain))
            {
                writer.WritePropertyName("overwriteExistingDomain"u8);
                writer.WriteBooleanValue(OverwriteExistingDomain.Value);
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

        MachineLearningSslConfiguration IJsonModel<MachineLearningSslConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSslConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSslConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSslConfiguration(document.RootElement, options);
        }

        internal static MachineLearningSslConfiguration DeserializeMachineLearningSslConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningSslConfigStatus? status = default;
            string cert = default;
            string key = default;
            string cname = default;
            string leafDomainLabel = default;
            bool? overwriteExistingDomain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineLearningSslConfigStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cert"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cert = null;
                        continue;
                    }
                    cert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        key = null;
                        continue;
                    }
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cname"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cname = null;
                        continue;
                    }
                    cname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("leafDomainLabel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        leafDomainLabel = null;
                        continue;
                    }
                    leafDomainLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overwriteExistingDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overwriteExistingDomain = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningSslConfiguration(
                status,
                cert,
                key,
                cname,
                leafDomainLabel,
                overwriteExistingDomain,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningSslConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSslConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSslConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningSslConfiguration IPersistableModel<MachineLearningSslConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSslConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningSslConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSslConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSslConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
