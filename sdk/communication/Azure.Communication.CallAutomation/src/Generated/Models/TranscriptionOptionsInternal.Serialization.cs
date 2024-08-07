// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class TranscriptionOptionsInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("transportUrl"u8);
            writer.WriteStringValue(TransportUrl);
            writer.WritePropertyName("transportType"u8);
            writer.WriteStringValue(TransportType.ToString());
            writer.WritePropertyName("locale"u8);
            writer.WriteStringValue(Locale);
            writer.WritePropertyName("startTranscription"u8);
            writer.WriteBooleanValue(StartTranscription);
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
