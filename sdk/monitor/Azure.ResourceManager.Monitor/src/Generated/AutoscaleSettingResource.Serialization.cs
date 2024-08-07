// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Monitor
{
    public partial class AutoscaleSettingResource : IJsonModel<AutoscaleSettingData>
    {
        void IJsonModel<AutoscaleSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutoscaleSettingData>)Data).Write(writer, options);

        AutoscaleSettingData IJsonModel<AutoscaleSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutoscaleSettingData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AutoscaleSettingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AutoscaleSettingData IPersistableModel<AutoscaleSettingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutoscaleSettingData>(data, options);

        string IPersistableModel<AutoscaleSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutoscaleSettingData>)Data).GetFormatFromOptions(options);
    }
}
