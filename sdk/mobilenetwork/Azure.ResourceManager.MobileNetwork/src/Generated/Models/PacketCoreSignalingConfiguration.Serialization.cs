// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PacketCoreSignalingConfiguration : IUtf8JsonSerializable, IJsonModel<PacketCoreSignalingConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PacketCoreSignalingConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PacketCoreSignalingConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCoreSignalingConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PacketCoreSignalingConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NasReroute))
            {
                writer.WritePropertyName("nasReroute"u8);
                writer.WriteObjectValue(NasReroute, options);
            }
            if (Optional.IsCollectionDefined(NasEncryption))
            {
                writer.WritePropertyName("nasEncryption"u8);
                writer.WriteStartArray();
                foreach (var item in NasEncryption)
                {
                    writer.WriteStringValue(item.ToString());
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

        PacketCoreSignalingConfiguration IJsonModel<PacketCoreSignalingConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCoreSignalingConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PacketCoreSignalingConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePacketCoreSignalingConfiguration(document.RootElement, options);
        }

        internal static PacketCoreSignalingConfiguration DeserializePacketCoreSignalingConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NASRerouteConfiguration nasReroute = default;
            IList<MobileNetworkNasEncryptionType> nasEncryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nasReroute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nasReroute = NASRerouteConfiguration.DeserializeNASRerouteConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nasEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MobileNetworkNasEncryptionType> array = new List<MobileNetworkNasEncryptionType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MobileNetworkNasEncryptionType(item.GetString()));
                    }
                    nasEncryption = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PacketCoreSignalingConfiguration(nasReroute, nasEncryption ?? new ChangeTrackingList<MobileNetworkNasEncryptionType>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("NasRerouteMacroMmeGroupId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nasReroute: ");
                builder.AppendLine("{");
                builder.Append("    macroMmeGroupId: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(NasReroute))
                {
                    builder.Append("  nasReroute: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NasReroute, options, 2, false, "  nasReroute: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NasEncryption), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nasEncryption: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NasEncryption))
                {
                    if (NasEncryption.Any())
                    {
                        builder.Append("  nasEncryption: ");
                        builder.AppendLine("[");
                        foreach (var item in NasEncryption)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PacketCoreSignalingConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCoreSignalingConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PacketCoreSignalingConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        PacketCoreSignalingConfiguration IPersistableModel<PacketCoreSignalingConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCoreSignalingConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePacketCoreSignalingConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PacketCoreSignalingConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PacketCoreSignalingConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
