// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class KeyVaultPatchProperties : IUtf8JsonSerializable, IJsonModel<KeyVaultPatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyVaultPatchProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KeyVaultPatchProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultPatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultPatchProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsCollectionDefined(AccessPolicies))
            {
                writer.WritePropertyName("accessPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AccessPolicies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnabledForDeployment))
            {
                writer.WritePropertyName("enabledForDeployment"u8);
                writer.WriteBooleanValue(EnabledForDeployment.Value);
            }
            if (Optional.IsDefined(EnabledForDiskEncryption))
            {
                writer.WritePropertyName("enabledForDiskEncryption"u8);
                writer.WriteBooleanValue(EnabledForDiskEncryption.Value);
            }
            if (Optional.IsDefined(EnabledForTemplateDeployment))
            {
                writer.WritePropertyName("enabledForTemplateDeployment"u8);
                writer.WriteBooleanValue(EnabledForTemplateDeployment.Value);
            }
            if (Optional.IsDefined(EnableSoftDelete))
            {
                writer.WritePropertyName("enableSoftDelete"u8);
                writer.WriteBooleanValue(EnableSoftDelete.Value);
            }
            if (Optional.IsDefined(EnableRbacAuthorization))
            {
                writer.WritePropertyName("enableRbacAuthorization"u8);
                writer.WriteBooleanValue(EnableRbacAuthorization.Value);
            }
            if (Optional.IsDefined(SoftDeleteRetentionInDays))
            {
                writer.WritePropertyName("softDeleteRetentionInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionInDays.Value);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(EnablePurgeProtection))
            {
                writer.WritePropertyName("enablePurgeProtection"u8);
                writer.WriteBooleanValue(EnablePurgeProtection.Value);
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkRuleSet, options);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess);
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

        KeyVaultPatchProperties IJsonModel<KeyVaultPatchProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultPatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultPatchProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultPatchProperties(document.RootElement, options);
        }

        internal static KeyVaultPatchProperties DeserializeKeyVaultPatchProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? tenantId = default;
            KeyVaultSku sku = default;
            IList<KeyVaultAccessPolicy> accessPolicies = default;
            bool? enabledForDeployment = default;
            bool? enabledForDiskEncryption = default;
            bool? enabledForTemplateDeployment = default;
            bool? enableSoftDelete = default;
            bool? enableRbacAuthorization = default;
            int? softDeleteRetentionInDays = default;
            KeyVaultPatchMode? createMode = default;
            bool? enablePurgeProtection = default;
            KeyVaultNetworkRuleSet networkAcls = default;
            string publicNetworkAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = KeyVaultSku.DeserializeKeyVaultSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("accessPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyVaultAccessPolicy> array = new List<KeyVaultAccessPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyVaultAccessPolicy.DeserializeKeyVaultAccessPolicy(item, options));
                    }
                    accessPolicies = array;
                    continue;
                }
                if (property.NameEquals("enabledForDeployment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledForDeployment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enabledForDiskEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledForDiskEncryption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enabledForTemplateDeployment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledForTemplateDeployment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableSoftDelete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableSoftDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableRbacAuthorization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableRbacAuthorization = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = property.Value.GetString().ToKeyVaultPatchMode();
                    continue;
                }
                if (property.NameEquals("enablePurgeProtection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePurgeProtection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("networkAcls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkAcls = KeyVaultNetworkRuleSet.DeserializeKeyVaultNetworkRuleSet(property.Value, options);
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    publicNetworkAccess = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KeyVaultPatchProperties(
                tenantId,
                sku,
                accessPolicies ?? new ChangeTrackingList<KeyVaultAccessPolicy>(),
                enabledForDeployment,
                enabledForDiskEncryption,
                enabledForTemplateDeployment,
                enableSoftDelete,
                enableRbacAuthorization,
                softDeleteRetentionInDays,
                createMode,
                enablePurgeProtection,
                networkAcls,
                publicNetworkAccess,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeyVaultPatchProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultPatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KeyVaultPatchProperties)} does not support writing '{options.Format}' format.");
            }
        }

        KeyVaultPatchProperties IPersistableModel<KeyVaultPatchProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultPatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeyVaultPatchProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KeyVaultPatchProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeyVaultPatchProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
