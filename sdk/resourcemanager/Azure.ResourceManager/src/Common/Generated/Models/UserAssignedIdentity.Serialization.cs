// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(UserAssignedIdentityConverter))]
    public partial class UserAssignedIdentity : IUtf8JsonSerializable, IJsonModel<UserAssignedIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserAssignedIdentity>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<UserAssignedIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PrincipalId))
                {
                    writer.WritePropertyName("principalId"u8);
                    writer.WriteStringValue(PrincipalId.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ClientId))
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId.Value);
                }
            }
            writer.WriteEndObject();
        }

        UserAssignedIdentity IJsonModel<UserAssignedIdentity>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserAssignedIdentity(document.RootElement, options);
        }

        internal static UserAssignedIdentity DeserializeUserAssignedIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> principalId = default;
            Optional<Guid> clientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
            }
            return new UserAssignedIdentity(Optional.ToNullable(principalId), Optional.ToNullable(clientId));
        }

        BinaryData IModel<UserAssignedIdentity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        UserAssignedIdentity IModel<UserAssignedIdentity>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUserAssignedIdentity(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<UserAssignedIdentity>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        internal partial class UserAssignedIdentityConverter : JsonConverter<UserAssignedIdentity>
        {
            public override void Write(Utf8JsonWriter writer, UserAssignedIdentity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override UserAssignedIdentity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeUserAssignedIdentity(document.RootElement);
            }
        }
    }
}
