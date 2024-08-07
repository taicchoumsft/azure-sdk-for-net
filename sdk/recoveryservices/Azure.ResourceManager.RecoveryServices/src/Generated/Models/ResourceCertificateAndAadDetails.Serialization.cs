// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class ResourceCertificateAndAadDetails : IUtf8JsonSerializable, IJsonModel<ResourceCertificateAndAadDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceCertificateAndAadDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceCertificateAndAadDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceCertificateAndAadDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceCertificateAndAadDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("aadAuthority"u8);
            writer.WriteStringValue(AadAuthority);
            writer.WritePropertyName("aadTenantId"u8);
            writer.WriteStringValue(AadTenantId);
            writer.WritePropertyName("servicePrincipalClientId"u8);
            writer.WriteStringValue(ServicePrincipalClientId);
            writer.WritePropertyName("servicePrincipalObjectId"u8);
            writer.WriteStringValue(ServicePrincipalObjectId);
            writer.WritePropertyName("azureManagementEndpointAudience"u8);
            writer.WriteStringValue(AzureManagementEndpointAudience);
            if (Optional.IsDefined(ServiceResourceId))
            {
                writer.WritePropertyName("serviceResourceId"u8);
                writer.WriteStringValue(ServiceResourceId);
            }
            if (Optional.IsDefined(AadAudience))
            {
                writer.WritePropertyName("aadAudience"u8);
                writer.WriteStringValue(AadAudience);
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType);
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteBase64StringValue(Certificate, "D");
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteNumberValue(ResourceId.Value);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Thumbprint);
#else
                using (JsonDocument document = JsonDocument.Parse(Thumbprint))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ValidStartOn))
            {
                writer.WritePropertyName("validFrom"u8);
                writer.WriteStringValue(ValidStartOn.Value, "O");
            }
            if (Optional.IsDefined(ValidEndOn))
            {
                writer.WritePropertyName("validTo"u8);
                writer.WriteStringValue(ValidEndOn.Value, "O");
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

        ResourceCertificateAndAadDetails IJsonModel<ResourceCertificateAndAadDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceCertificateAndAadDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceCertificateAndAadDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceCertificateAndAadDetails(document.RootElement, options);
        }

        internal static ResourceCertificateAndAadDetails DeserializeResourceCertificateAndAadDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string aadAuthority = default;
            Guid aadTenantId = default;
            string servicePrincipalClientId = default;
            string servicePrincipalObjectId = default;
            string azureManagementEndpointAudience = default;
            ResourceIdentifier serviceResourceId = default;
            string aadAudience = default;
            string authType = default;
            byte[] certificate = default;
            string friendlyName = default;
            string issuer = default;
            long? resourceId = default;
            string subject = default;
            BinaryData thumbprint = default;
            DateTimeOffset? validFrom = default;
            DateTimeOffset? validTo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aadAuthority"u8))
                {
                    aadAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadTenantId"u8))
                {
                    aadTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("servicePrincipalClientId"u8))
                {
                    servicePrincipalClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalObjectId"u8))
                {
                    servicePrincipalObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureManagementEndpointAudience"u8))
                {
                    azureManagementEndpointAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadAudience"u8))
                {
                    aadAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificate = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("validFrom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validTo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validTo = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceCertificateAndAadDetails(
                authType,
                certificate,
                friendlyName,
                issuer,
                resourceId,
                subject,
                thumbprint,
                validFrom,
                validTo,
                serializedAdditionalRawData,
                aadAuthority,
                aadTenantId,
                servicePrincipalClientId,
                servicePrincipalObjectId,
                azureManagementEndpointAudience,
                serviceResourceId,
                aadAudience);
        }

        BinaryData IPersistableModel<ResourceCertificateAndAadDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceCertificateAndAadDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceCertificateAndAadDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceCertificateAndAadDetails IPersistableModel<ResourceCertificateAndAadDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceCertificateAndAadDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceCertificateAndAadDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceCertificateAndAadDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceCertificateAndAadDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
