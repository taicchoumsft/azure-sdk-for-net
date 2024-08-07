// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkPacketBrokerResource : IJsonModel<NetworkPacketBrokerData>
    {
        void IJsonModel<NetworkPacketBrokerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkPacketBrokerData>)Data).Write(writer, options);

        NetworkPacketBrokerData IJsonModel<NetworkPacketBrokerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkPacketBrokerData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkPacketBrokerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        NetworkPacketBrokerData IPersistableModel<NetworkPacketBrokerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkPacketBrokerData>(data, options);

        string IPersistableModel<NetworkPacketBrokerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkPacketBrokerData>)Data).GetFormatFromOptions(options);
    }
}
