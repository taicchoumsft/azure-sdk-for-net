// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class RecognizeOptionsInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InterruptPrompt))
            {
                writer.WritePropertyName("interruptPrompt"u8);
                writer.WriteBooleanValue(InterruptPrompt.Value);
            }
            if (Optional.IsDefined(InitialSilenceTimeoutInSeconds))
            {
                writer.WritePropertyName("initialSilenceTimeoutInSeconds"u8);
                writer.WriteNumberValue(InitialSilenceTimeoutInSeconds.Value);
            }
            writer.WritePropertyName("targetParticipant"u8);
            writer.WriteObjectValue(TargetParticipant);
            if (Optional.IsDefined(DtmfOptions))
            {
                writer.WritePropertyName("dtmfOptions"u8);
                writer.WriteObjectValue(DtmfOptions);
            }
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
