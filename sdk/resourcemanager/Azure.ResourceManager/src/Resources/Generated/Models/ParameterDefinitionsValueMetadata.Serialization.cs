// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ParameterDefinitionsValueMetadata : IUtf8JsonSerializable, IJsonModel<ParameterDefinitionsValueMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ParameterDefinitionsValueMetadata>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ParameterDefinitionsValueMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(StrongType))
            {
                writer.WritePropertyName("strongType"u8);
                writer.WriteStringValue(StrongType);
            }
            if (Optional.IsDefined(AssignPermissions))
            {
                writer.WritePropertyName("assignPermissions"u8);
                writer.WriteBooleanValue(AssignPermissions.Value);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        ParameterDefinitionsValueMetadata IJsonModel<ParameterDefinitionsValueMetadata>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeParameterDefinitionsValueMetadata(document.RootElement, options);
        }

        internal static ParameterDefinitionsValueMetadata DeserializeParameterDefinitionsValueMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> strongType = default;
            Optional<bool> assignPermissions = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("strongType"u8))
                {
                    strongType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignPermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignPermissions = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ParameterDefinitionsValueMetadata(displayName.Value, description.Value, strongType.Value, Optional.ToNullable(assignPermissions), additionalProperties);
        }

        BinaryData IModel<ParameterDefinitionsValueMetadata>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ParameterDefinitionsValueMetadata IModel<ParameterDefinitionsValueMetadata>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeParameterDefinitionsValueMetadata(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ParameterDefinitionsValueMetadata>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
