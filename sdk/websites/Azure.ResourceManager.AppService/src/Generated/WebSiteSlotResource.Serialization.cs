// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class WebSiteSlotResource : IJsonModel<WebSiteData>
    {
        void IJsonModel<WebSiteData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<WebSiteData>)Data).Write(writer, options);

        WebSiteData IJsonModel<WebSiteData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<WebSiteData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<WebSiteData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        WebSiteData IPersistableModel<WebSiteData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<WebSiteData>(data, options);

        string IPersistableModel<WebSiteData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<WebSiteData>)Data).GetFormatFromOptions(options);
    }
}
