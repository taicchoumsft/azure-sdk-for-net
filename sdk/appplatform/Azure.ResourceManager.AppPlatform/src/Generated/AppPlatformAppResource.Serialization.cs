// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppPlatform
{
    public partial class AppPlatformAppResource : IJsonModel<AppPlatformAppData>
    {
        void IJsonModel<AppPlatformAppData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AppPlatformAppData>)Data).Write(writer, options);

        AppPlatformAppData IJsonModel<AppPlatformAppData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AppPlatformAppData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AppPlatformAppData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AppPlatformAppData IPersistableModel<AppPlatformAppData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AppPlatformAppData>(data, options);

        string IPersistableModel<AppPlatformAppData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AppPlatformAppData>)Data).GetFormatFromOptions(options);
    }
}
