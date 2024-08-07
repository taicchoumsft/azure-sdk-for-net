// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class GalleryImageVersionResource : IJsonModel<GalleryImageVersionData>
    {
        void IJsonModel<GalleryImageVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GalleryImageVersionData>)Data).Write(writer, options);

        GalleryImageVersionData IJsonModel<GalleryImageVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GalleryImageVersionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GalleryImageVersionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        GalleryImageVersionData IPersistableModel<GalleryImageVersionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GalleryImageVersionData>(data, options);

        string IPersistableModel<GalleryImageVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GalleryImageVersionData>)Data).GetFormatFromOptions(options);
    }
}
