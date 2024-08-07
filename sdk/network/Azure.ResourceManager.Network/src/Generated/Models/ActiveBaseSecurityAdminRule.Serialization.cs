// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    [PersistableModelProxy(typeof(UnknownActiveBaseSecurityAdminRule))]
    public partial class ActiveBaseSecurityAdminRule : IUtf8JsonSerializable, IJsonModel<ActiveBaseSecurityAdminRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActiveBaseSecurityAdminRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ActiveBaseSecurityAdminRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActiveBaseSecurityAdminRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(CommitOn))
            {
                writer.WritePropertyName("commitTime"u8);
                writer.WriteStringValue(CommitOn.Value, "O");
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(ConfigurationDescription))
            {
                writer.WritePropertyName("configurationDescription"u8);
                writer.WriteStringValue(ConfigurationDescription);
            }
            if (Optional.IsDefined(RuleCollectionDescription))
            {
                writer.WritePropertyName("ruleCollectionDescription"u8);
                writer.WriteStringValue(RuleCollectionDescription);
            }
            if (Optional.IsCollectionDefined(RuleCollectionAppliesToGroups))
            {
                writer.WritePropertyName("ruleCollectionAppliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleCollectionAppliesToGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RuleGroups))
            {
                writer.WritePropertyName("ruleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        ActiveBaseSecurityAdminRule IJsonModel<ActiveBaseSecurityAdminRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActiveBaseSecurityAdminRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActiveBaseSecurityAdminRule(document.RootElement, options);
        }

        internal static ActiveBaseSecurityAdminRule DeserializeActiveBaseSecurityAdminRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Custom": return ActiveSecurityAdminRule.DeserializeActiveSecurityAdminRule(element, options);
                    case "Default": return ActiveDefaultSecurityAdminRule.DeserializeActiveDefaultSecurityAdminRule(element, options);
                }
            }
            return UnknownActiveBaseSecurityAdminRule.DeserializeUnknownActiveBaseSecurityAdminRule(element, options);
        }

        BinaryData IPersistableModel<ActiveBaseSecurityAdminRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ActiveBaseSecurityAdminRule)} does not support writing '{options.Format}' format.");
            }
        }

        ActiveBaseSecurityAdminRule IPersistableModel<ActiveBaseSecurityAdminRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeActiveBaseSecurityAdminRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActiveBaseSecurityAdminRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActiveBaseSecurityAdminRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
