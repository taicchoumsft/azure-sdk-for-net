// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EdgeOrder
{
    public partial class EdgeOrderItemResource : IJsonModel<EdgeOrderItemData>
    {
        void IJsonModel<EdgeOrderItemData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<EdgeOrderItemData>)Data).Write(writer, options);

        EdgeOrderItemData IJsonModel<EdgeOrderItemData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<EdgeOrderItemData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<EdgeOrderItemData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        EdgeOrderItemData IPersistableModel<EdgeOrderItemData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<EdgeOrderItemData>(data, options);

        string IPersistableModel<EdgeOrderItemData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<EdgeOrderItemData>)Data).GetFormatFromOptions(options);
    }
}
