// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceDeploymentLocations : IUtf8JsonSerializable, IJsonModel<AppServiceDeploymentLocations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceDeploymentLocations>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppServiceDeploymentLocations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceDeploymentLocations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceDeploymentLocations)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HostingEnvironments))
            {
                writer.WritePropertyName("hostingEnvironments"u8);
                writer.WriteStartArray();
                foreach (var item in HostingEnvironments)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HostingEnvironmentDeploymentInfos))
            {
                writer.WritePropertyName("hostingEnvironmentDeploymentInfos"u8);
                writer.WriteStartArray();
                foreach (var item in HostingEnvironmentDeploymentInfos)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        AppServiceDeploymentLocations IJsonModel<AppServiceDeploymentLocations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceDeploymentLocations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceDeploymentLocations)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceDeploymentLocations(document.RootElement, options);
        }

        internal static AppServiceDeploymentLocations DeserializeAppServiceDeploymentLocations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AppServiceGeoRegion> locations = default;
            IReadOnlyList<AppServiceEnvironmentProperties> hostingEnvironments = default;
            IReadOnlyList<HostingEnvironmentDeploymentInfo> hostingEnvironmentDeploymentInfos = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppServiceGeoRegion> array = new List<AppServiceGeoRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceGeoRegion.DeserializeAppServiceGeoRegion(item, options));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("hostingEnvironments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppServiceEnvironmentProperties> array = new List<AppServiceEnvironmentProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceEnvironmentProperties.DeserializeAppServiceEnvironmentProperties(item, options));
                    }
                    hostingEnvironments = array;
                    continue;
                }
                if (property.NameEquals("hostingEnvironmentDeploymentInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HostingEnvironmentDeploymentInfo> array = new List<HostingEnvironmentDeploymentInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HostingEnvironmentDeploymentInfo.DeserializeHostingEnvironmentDeploymentInfo(item, options));
                    }
                    hostingEnvironmentDeploymentInfos = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppServiceDeploymentLocations(locations ?? new ChangeTrackingList<AppServiceGeoRegion>(), hostingEnvironments ?? new ChangeTrackingList<AppServiceEnvironmentProperties>(), hostingEnvironmentDeploymentInfos ?? new ChangeTrackingList<HostingEnvironmentDeploymentInfo>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Locations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  locations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Locations))
                {
                    if (Locations.Any())
                    {
                        builder.Append("  locations: ");
                        builder.AppendLine("[");
                        foreach (var item in Locations)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  locations: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostingEnvironments), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hostingEnvironments: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(HostingEnvironments))
                {
                    if (HostingEnvironments.Any())
                    {
                        builder.Append("  hostingEnvironments: ");
                        builder.AppendLine("[");
                        foreach (var item in HostingEnvironments)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  hostingEnvironments: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostingEnvironmentDeploymentInfos), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hostingEnvironmentDeploymentInfos: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(HostingEnvironmentDeploymentInfos))
                {
                    if (HostingEnvironmentDeploymentInfos.Any())
                    {
                        builder.Append("  hostingEnvironmentDeploymentInfos: ");
                        builder.AppendLine("[");
                        foreach (var item in HostingEnvironmentDeploymentInfos)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  hostingEnvironmentDeploymentInfos: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AppServiceDeploymentLocations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceDeploymentLocations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceDeploymentLocations)} does not support writing '{options.Format}' format.");
            }
        }

        AppServiceDeploymentLocations IPersistableModel<AppServiceDeploymentLocations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceDeploymentLocations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceDeploymentLocations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceDeploymentLocations)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceDeploymentLocations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
