// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core.Tests.Common;

namespace Azure.Core.Tests.ResourceManager.Resources.Models
{
    public partial class ProviderExtendedLocation : IUtf8JsonSerializable, IJsonModel<ProviderExtendedLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProviderExtendedLocation>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        internal static ProviderExtendedLocation DeserializeProviderExtendedLocation(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<string> type = default;
            Optional<IReadOnlyList<string>> extendedLocations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    extendedLocations = array;
                    continue;
                }
            }
            return new ProviderExtendedLocation(Optional.ToNullable(location), type.Value, Optional.ToList(extendedLocations));
        }

        void IJsonModel<ProviderExtendedLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value.DisplayName);
            }
            if (Optional.IsDefined(ProviderExtendedLocationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ProviderExtendedLocationType);
            }
            if (Optional.IsCollectionDefined(ExtendedLocations))
            {
                writer.WritePropertyName("extendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedLocations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        private struct ProviderExtendedLocationProperties
        {
            public Optional<AzureLocation> Location { get; set; }
            public Optional<string> ProviderExtendedLocationType { get; set; }
            public Optional<IReadOnlyList<string>> ExtendedLocations { get; set; }
        }

        ProviderExtendedLocation IJsonModel<ProviderExtendedLocation>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderExtendedLocation(doc.RootElement, options);
        }

        ProviderExtendedLocation IModel<ProviderExtendedLocation>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderExtendedLocation(doc.RootElement, options);
        }

        BinaryData IModel<ProviderExtendedLocation>.Write(ModelReaderWriterOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.WriteCore(this, options);
        }
    }
}
