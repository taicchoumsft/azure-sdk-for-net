// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class PageViewData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration);
            }
            if (Optional.IsDefined(ReferredUri))
            {
                writer.WritePropertyName("referredUri"u8);
                writer.WriteStringValue(ReferredUri);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Measurements))
            {
                writer.WritePropertyName("measurements"u8);
                writer.WriteStartObject();
                foreach (var item in Measurements)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("ver"u8);
            writer.WriteNumberValue(Version);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
