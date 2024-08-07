// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryFabricProviderSpecificDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryFabricProviderSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryFabricProviderSpecificDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryFabricProviderSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryFabricProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryFabricProviderSpecificDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(ContainerIds))
            {
                writer.WritePropertyName("containerIds"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExtendedLocations))
            {
                writer.WritePropertyName("extendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedLocations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LocationDetails))
            {
                writer.WritePropertyName("locationDetails"u8);
                writer.WriteStartArray();
                foreach (var item in LocationDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        SiteRecoveryFabricProviderSpecificDetails IJsonModel<SiteRecoveryFabricProviderSpecificDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryFabricProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryFabricProviderSpecificDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryFabricProviderSpecificDetails(document.RootElement, options);
        }

        internal static SiteRecoveryFabricProviderSpecificDetails DeserializeSiteRecoveryFabricProviderSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            IReadOnlyList<ResourceIdentifier> containerIds = default;
            IReadOnlyList<A2AZoneDetails> zones = default;
            IReadOnlyList<A2AExtendedLocationDetails> extendedLocations = default;
            IReadOnlyList<A2AFabricSpecificLocationDetails> locationDetails = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("containerIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    containerIds = array;
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AZoneDetails> array = new List<A2AZoneDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AZoneDetails.DeserializeA2AZoneDetails(item, options));
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AExtendedLocationDetails> array = new List<A2AExtendedLocationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AExtendedLocationDetails.DeserializeA2AExtendedLocationDetails(item, options));
                    }
                    extendedLocations = array;
                    continue;
                }
                if (property.NameEquals("locationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AFabricSpecificLocationDetails> array = new List<A2AFabricSpecificLocationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AFabricSpecificLocationDetails.DeserializeA2AFabricSpecificLocationDetails(item, options));
                    }
                    locationDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryFabricProviderSpecificDetails(
                instanceType,
                serializedAdditionalRawData,
                location,
                containerIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                zones ?? new ChangeTrackingList<A2AZoneDetails>(),
                extendedLocations ?? new ChangeTrackingList<A2AExtendedLocationDetails>(),
                locationDetails ?? new ChangeTrackingList<A2AFabricSpecificLocationDetails>());
        }

        BinaryData IPersistableModel<SiteRecoveryFabricProviderSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryFabricProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryFabricProviderSpecificDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryFabricProviderSpecificDetails IPersistableModel<SiteRecoveryFabricProviderSpecificDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryFabricProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryFabricProviderSpecificDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryFabricProviderSpecificDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryFabricProviderSpecificDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
