// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class MethodRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("methodName"u8);
            writer.WriteStringValue(MethodName);
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static MethodRequest DeserializeMethodRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("methodName", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "livePipelineActivate": return LivePipelineActivateRequest.DeserializeLivePipelineActivateRequest(element);
                    case "livePipelineDeactivate": return LivePipelineDeactivateRequest.DeserializeLivePipelineDeactivateRequest(element);
                    case "livePipelineDelete": return LivePipelineDeleteRequest.DeserializeLivePipelineDeleteRequest(element);
                    case "livePipelineGet": return LivePipelineGetRequest.DeserializeLivePipelineGetRequest(element);
                    case "livePipelineList": return LivePipelineListRequest.DeserializeLivePipelineListRequest(element);
                    case "livePipelineSet": return LivePipelineSetRequest.DeserializeLivePipelineSetRequest(element);
                    case "LivePipelineSetRequestBody": return LivePipelineSetRequestBody.DeserializeLivePipelineSetRequestBody(element);
                    case "MethodRequestEmptyBodyBase": return MethodRequestEmptyBodyBase.DeserializeMethodRequestEmptyBodyBase(element);
                    case "onvifDeviceDiscover": return OnvifDeviceDiscoverRequest.DeserializeOnvifDeviceDiscoverRequest(element);
                    case "onvifDeviceGet": return OnvifDeviceGetRequest.DeserializeOnvifDeviceGetRequest(element);
                    case "pipelineTopologyDelete": return PipelineTopologyDeleteRequest.DeserializePipelineTopologyDeleteRequest(element);
                    case "pipelineTopologyGet": return PipelineTopologyGetRequest.DeserializePipelineTopologyGetRequest(element);
                    case "pipelineTopologyList": return PipelineTopologyListRequest.DeserializePipelineTopologyListRequest(element);
                    case "pipelineTopologySet": return PipelineTopologySetRequest.DeserializePipelineTopologySetRequest(element);
                    case "PipelineTopologySetRequestBody": return PipelineTopologySetRequestBody.DeserializePipelineTopologySetRequestBody(element);
                    case "remoteDeviceAdapterDelete": return RemoteDeviceAdapterDeleteRequest.DeserializeRemoteDeviceAdapterDeleteRequest(element);
                    case "remoteDeviceAdapterGet": return RemoteDeviceAdapterGetRequest.DeserializeRemoteDeviceAdapterGetRequest(element);
                    case "remoteDeviceAdapterList": return RemoteDeviceAdapterListRequest.DeserializeRemoteDeviceAdapterListRequest(element);
                    case "remoteDeviceAdapterSet": return RemoteDeviceAdapterSetRequest.DeserializeRemoteDeviceAdapterSetRequest(element);
                    case "RemoteDeviceAdapterSetRequestBody": return RemoteDeviceAdapterSetRequestBody.DeserializeRemoteDeviceAdapterSetRequestBody(element);
                }
            }
            return UnknownMethodRequest.DeserializeUnknownMethodRequest(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MethodRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMethodRequest(document.RootElement);
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
