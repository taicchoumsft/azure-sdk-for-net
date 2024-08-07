// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class DdosCustomPolicyResource : IJsonModel<DdosCustomPolicyData>
    {
        void IJsonModel<DdosCustomPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DdosCustomPolicyData>)Data).Write(writer, options);

        DdosCustomPolicyData IJsonModel<DdosCustomPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DdosCustomPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DdosCustomPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DdosCustomPolicyData IPersistableModel<DdosCustomPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DdosCustomPolicyData>(data, options);

        string IPersistableModel<DdosCustomPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DdosCustomPolicyData>)Data).GetFormatFromOptions(options);
    }
}
