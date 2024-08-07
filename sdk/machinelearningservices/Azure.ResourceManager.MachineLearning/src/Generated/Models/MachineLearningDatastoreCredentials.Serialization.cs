// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownDatastoreCredentials))]
    public partial class MachineLearningDatastoreCredentials : IUtf8JsonSerializable, IJsonModel<MachineLearningDatastoreCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDatastoreCredentials>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningDatastoreCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDatastoreCredentials)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
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

        MachineLearningDatastoreCredentials IJsonModel<MachineLearningDatastoreCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDatastoreCredentials)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDatastoreCredentials(document.RootElement, options);
        }

        internal static MachineLearningDatastoreCredentials DeserializeMachineLearningDatastoreCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("credentialsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AccountKey": return MachineLearningAccountKeyDatastoreCredentials.DeserializeMachineLearningAccountKeyDatastoreCredentials(element, options);
                    case "Certificate": return MachineLearningCertificateDatastoreCredentials.DeserializeMachineLearningCertificateDatastoreCredentials(element, options);
                    case "KerberosKeytab": return KerberosKeytabCredentials.DeserializeKerberosKeytabCredentials(element, options);
                    case "KerberosPassword": return KerberosPasswordCredentials.DeserializeKerberosPasswordCredentials(element, options);
                    case "None": return MachineLearningNoneDatastoreCredentials.DeserializeMachineLearningNoneDatastoreCredentials(element, options);
                    case "Sas": return MachineLearningSasDatastoreCredentials.DeserializeMachineLearningSasDatastoreCredentials(element, options);
                    case "ServicePrincipal": return MachineLearningServicePrincipalDatastoreCredentials.DeserializeMachineLearningServicePrincipalDatastoreCredentials(element, options);
                }
            }
            return UnknownDatastoreCredentials.DeserializeUnknownDatastoreCredentials(element, options);
        }

        BinaryData IPersistableModel<MachineLearningDatastoreCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDatastoreCredentials)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningDatastoreCredentials IPersistableModel<MachineLearningDatastoreCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningDatastoreCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDatastoreCredentials)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningDatastoreCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
