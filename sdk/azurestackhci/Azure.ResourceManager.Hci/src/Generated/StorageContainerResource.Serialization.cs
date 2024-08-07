// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class StorageContainerResource : IJsonModel<StorageContainerData>
    {
        void IJsonModel<StorageContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StorageContainerData>)Data).Write(writer, options);

        StorageContainerData IJsonModel<StorageContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StorageContainerData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<StorageContainerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        StorageContainerData IPersistableModel<StorageContainerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StorageContainerData>(data, options);

        string IPersistableModel<StorageContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StorageContainerData>)Data).GetFormatFromOptions(options);
    }
}
