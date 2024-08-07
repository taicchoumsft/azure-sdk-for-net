// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.OracleDatabase
{
    public partial class CloudVmClusterVirtualNetworkAddressResource : IJsonModel<CloudVmClusterVirtualNetworkAddressData>
    {
        void IJsonModel<CloudVmClusterVirtualNetworkAddressData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CloudVmClusterVirtualNetworkAddressData>)Data).Write(writer, options);

        CloudVmClusterVirtualNetworkAddressData IJsonModel<CloudVmClusterVirtualNetworkAddressData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CloudVmClusterVirtualNetworkAddressData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CloudVmClusterVirtualNetworkAddressData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CloudVmClusterVirtualNetworkAddressData IPersistableModel<CloudVmClusterVirtualNetworkAddressData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CloudVmClusterVirtualNetworkAddressData>(data, options);

        string IPersistableModel<CloudVmClusterVirtualNetworkAddressData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CloudVmClusterVirtualNetworkAddressData>)Data).GetFormatFromOptions(options);
    }
}
