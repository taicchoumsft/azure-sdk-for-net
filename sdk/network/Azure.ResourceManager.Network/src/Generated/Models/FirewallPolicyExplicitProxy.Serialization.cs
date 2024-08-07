// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyExplicitProxy : IUtf8JsonSerializable, IJsonModel<FirewallPolicyExplicitProxy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicyExplicitProxy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FirewallPolicyExplicitProxy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyExplicitProxy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyExplicitProxy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EnableExplicitProxy))
            {
                if (EnableExplicitProxy != null)
                {
                    writer.WritePropertyName("enableExplicitProxy"u8);
                    writer.WriteBooleanValue(EnableExplicitProxy.Value);
                }
                else
                {
                    writer.WriteNull("enableExplicitProxy");
                }
            }
            if (Optional.IsDefined(HttpPort))
            {
                writer.WritePropertyName("httpPort"u8);
                writer.WriteNumberValue(HttpPort.Value);
            }
            if (Optional.IsDefined(HttpsPort))
            {
                writer.WritePropertyName("httpsPort"u8);
                writer.WriteNumberValue(HttpsPort.Value);
            }
            if (Optional.IsDefined(EnablePacFile))
            {
                if (EnablePacFile != null)
                {
                    writer.WritePropertyName("enablePacFile"u8);
                    writer.WriteBooleanValue(EnablePacFile.Value);
                }
                else
                {
                    writer.WriteNull("enablePacFile");
                }
            }
            if (Optional.IsDefined(PacFilePort))
            {
                writer.WritePropertyName("pacFilePort"u8);
                writer.WriteNumberValue(PacFilePort.Value);
            }
            if (Optional.IsDefined(PacFile))
            {
                writer.WritePropertyName("pacFile"u8);
                writer.WriteStringValue(PacFile);
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

        FirewallPolicyExplicitProxy IJsonModel<FirewallPolicyExplicitProxy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyExplicitProxy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyExplicitProxy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyExplicitProxy(document.RootElement, options);
        }

        internal static FirewallPolicyExplicitProxy DeserializeFirewallPolicyExplicitProxy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableExplicitProxy = default;
            int? httpPort = default;
            int? httpsPort = default;
            bool? enablePacFile = default;
            int? pacFilePort = default;
            string pacFile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableExplicitProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableExplicitProxy = null;
                        continue;
                    }
                    enableExplicitProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("httpPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpsPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpsPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enablePacFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enablePacFile = null;
                        continue;
                    }
                    enablePacFile = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pacFilePort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pacFilePort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pacFile"u8))
                {
                    pacFile = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FirewallPolicyExplicitProxy(
                enableExplicitProxy,
                httpPort,
                httpsPort,
                enablePacFile,
                pacFilePort,
                pacFile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallPolicyExplicitProxy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyExplicitProxy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyExplicitProxy)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallPolicyExplicitProxy IPersistableModel<FirewallPolicyExplicitProxy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyExplicitProxy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPolicyExplicitProxy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyExplicitProxy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPolicyExplicitProxy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
