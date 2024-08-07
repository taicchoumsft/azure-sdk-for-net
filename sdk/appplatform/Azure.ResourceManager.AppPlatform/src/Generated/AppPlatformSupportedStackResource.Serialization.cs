// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppPlatform
{
    public partial class AppPlatformSupportedStackResource : IJsonModel<AppPlatformSupportedStackData>
    {
        void IJsonModel<AppPlatformSupportedStackData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AppPlatformSupportedStackData>)Data).Write(writer, options);

        AppPlatformSupportedStackData IJsonModel<AppPlatformSupportedStackData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AppPlatformSupportedStackData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AppPlatformSupportedStackData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AppPlatformSupportedStackData IPersistableModel<AppPlatformSupportedStackData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AppPlatformSupportedStackData>(data, options);

        string IPersistableModel<AppPlatformSupportedStackData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AppPlatformSupportedStackData>)Data).GetFormatFromOptions(options);
    }
}
