// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    public partial class RoleAssignmentDetail : IUtf8JsonSerializable, IJsonModel<RoleAssignmentDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleAssignmentDetail>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RoleAssignmentDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleAssignmentDetail)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("roleId"u8);
            writer.WriteStringValue(RoleId);
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            writer.WritePropertyName("userName"u8);
            writer.WriteStringValue(UserName);
            writer.WritePropertyName("dataTypeScope"u8);
            writer.WriteStartArray();
            foreach (var item in DataTypeScope)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("principalType"u8);
            writer.WriteStringValue(PrincipalType);
            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role.ToString());
            writer.WritePropertyName("roleAssignmentId"u8);
            writer.WriteStringValue(RoleAssignmentId);
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

        RoleAssignmentDetail IJsonModel<RoleAssignmentDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleAssignmentDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleAssignmentDetail(document.RootElement, options);
        }

        internal static RoleAssignmentDetail DeserializeRoleAssignmentDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string roleId = default;
            string principalId = default;
            string userName = default;
            IList<string> dataTypeScope = default;
            string principalType = default;
            DataProductUserRole role = default;
            string roleAssignmentId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("roleId"u8))
                {
                    roleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataTypeScope"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dataTypeScope = array;
                    continue;
                }
                if (property.NameEquals("principalType"u8))
                {
                    principalType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = new DataProductUserRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleAssignmentId"u8))
                {
                    roleAssignmentId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoleAssignmentDetail(
                roleId,
                principalId,
                userName,
                dataTypeScope,
                principalType,
                role,
                roleAssignmentId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleAssignmentDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleAssignmentDetail)} does not support writing '{options.Format}' format.");
            }
        }

        RoleAssignmentDetail IPersistableModel<RoleAssignmentDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleAssignmentDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleAssignmentDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleAssignmentDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
