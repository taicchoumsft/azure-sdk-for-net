// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    internal partial class CosmosDBForPostgreSqlFirewallRuleListResult : IUtf8JsonSerializable, IJsonModel<CosmosDBForPostgreSqlFirewallRuleListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBForPostgreSqlFirewallRuleListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBForPostgreSqlFirewallRuleListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlFirewallRuleListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlFirewallRuleListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        CosmosDBForPostgreSqlFirewallRuleListResult IJsonModel<CosmosDBForPostgreSqlFirewallRuleListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlFirewallRuleListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlFirewallRuleListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlFirewallRuleListResult(document.RootElement, options);
        }

        internal static CosmosDBForPostgreSqlFirewallRuleListResult DeserializeCosmosDBForPostgreSqlFirewallRuleListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<CosmosDBForPostgreSqlFirewallRuleData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBForPostgreSqlFirewallRuleData> array = new List<CosmosDBForPostgreSqlFirewallRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBForPostgreSqlFirewallRuleData.DeserializeCosmosDBForPostgreSqlFirewallRuleData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosDBForPostgreSqlFirewallRuleListResult(value ?? new ChangeTrackingList<CosmosDBForPostgreSqlFirewallRuleData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBForPostgreSqlFirewallRuleListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlFirewallRuleListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlFirewallRuleListResult)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBForPostgreSqlFirewallRuleListResult IPersistableModel<CosmosDBForPostgreSqlFirewallRuleListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlFirewallRuleListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBForPostgreSqlFirewallRuleListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlFirewallRuleListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBForPostgreSqlFirewallRuleListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
