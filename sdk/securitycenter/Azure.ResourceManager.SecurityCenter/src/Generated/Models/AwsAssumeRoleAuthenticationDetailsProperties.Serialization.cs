// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AwsAssumeRoleAuthenticationDetailsProperties : IUtf8JsonSerializable, IJsonModel<AwsAssumeRoleAuthenticationDetailsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AwsAssumeRoleAuthenticationDetailsProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AwsAssumeRoleAuthenticationDetailsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsAssumeRoleAuthenticationDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsAssumeRoleAuthenticationDetailsProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AccountId))
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            writer.WritePropertyName("awsAssumeRoleArn"u8);
            writer.WriteStringValue(AwsAssumeRoleArn);
            writer.WritePropertyName("awsExternalId"u8);
            writer.WriteStringValue(AwsExternalId);
            if (options.Format != "W" && Optional.IsDefined(AuthenticationProvisioningState))
            {
                writer.WritePropertyName("authenticationProvisioningState"u8);
                writer.WriteStringValue(AuthenticationProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(GrantedPermissions))
            {
                writer.WritePropertyName("grantedPermissions"u8);
                writer.WriteStartArray();
                foreach (var item in GrantedPermissions)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
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

        AwsAssumeRoleAuthenticationDetailsProperties IJsonModel<AwsAssumeRoleAuthenticationDetailsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsAssumeRoleAuthenticationDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsAssumeRoleAuthenticationDetailsProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAwsAssumeRoleAuthenticationDetailsProperties(document.RootElement, options);
        }

        internal static AwsAssumeRoleAuthenticationDetailsProperties DeserializeAwsAssumeRoleAuthenticationDetailsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountId = default;
            string awsAssumeRoleArn = default;
            Guid awsExternalId = default;
            AuthenticationProvisioningState? authenticationProvisioningState = default;
            IReadOnlyList<SecurityCenterCloudPermission> grantedPermissions = default;
            AuthenticationType authenticationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountId"u8))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("awsAssumeRoleArn"u8))
                {
                    awsAssumeRoleArn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("awsExternalId"u8))
                {
                    awsExternalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("authenticationProvisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationProvisioningState = new AuthenticationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grantedPermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityCenterCloudPermission> array = new List<SecurityCenterCloudPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityCenterCloudPermission(item.GetString()));
                    }
                    grantedPermissions = array;
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new AuthenticationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AwsAssumeRoleAuthenticationDetailsProperties(
                authenticationProvisioningState,
                grantedPermissions ?? new ChangeTrackingList<SecurityCenterCloudPermission>(),
                authenticationType,
                serializedAdditionalRawData,
                accountId,
                awsAssumeRoleArn,
                awsExternalId);
        }

        BinaryData IPersistableModel<AwsAssumeRoleAuthenticationDetailsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsAssumeRoleAuthenticationDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AwsAssumeRoleAuthenticationDetailsProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AwsAssumeRoleAuthenticationDetailsProperties IPersistableModel<AwsAssumeRoleAuthenticationDetailsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsAssumeRoleAuthenticationDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAwsAssumeRoleAuthenticationDetailsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AwsAssumeRoleAuthenticationDetailsProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AwsAssumeRoleAuthenticationDetailsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
