// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubsPrivateLinkResourceProperties : IUtf8JsonSerializable, IJsonModel<NotificationHubsPrivateLinkResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHubsPrivateLinkResourceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NotificationHubsPrivateLinkResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubsPrivateLinkResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubsPrivateLinkResourceProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RequiredMembers))
            {
                writer.WritePropertyName("requiredMembers"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredMembers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RequiredZoneNames))
            {
                writer.WritePropertyName("requiredZoneNames"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredZoneNames)
                {
                    writer.WriteStringValue(item);
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

        NotificationHubsPrivateLinkResourceProperties IJsonModel<NotificationHubsPrivateLinkResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubsPrivateLinkResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubsPrivateLinkResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubsPrivateLinkResourceProperties(document.RootElement, options);
        }

        internal static NotificationHubsPrivateLinkResourceProperties DeserializeNotificationHubsPrivateLinkResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string groupId = default;
            IReadOnlyList<string> requiredMembers = default;
            IReadOnlyList<string> requiredZoneNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredMembers"u8))
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
                    requiredMembers = array;
                    continue;
                }
                if (property.NameEquals("requiredZoneNames"u8))
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
                    requiredZoneNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NotificationHubsPrivateLinkResourceProperties(groupId, requiredMembers ?? new ChangeTrackingList<string>(), requiredZoneNames ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationHubsPrivateLinkResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubsPrivateLinkResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationHubsPrivateLinkResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NotificationHubsPrivateLinkResourceProperties IPersistableModel<NotificationHubsPrivateLinkResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubsPrivateLinkResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationHubsPrivateLinkResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationHubsPrivateLinkResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationHubsPrivateLinkResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
