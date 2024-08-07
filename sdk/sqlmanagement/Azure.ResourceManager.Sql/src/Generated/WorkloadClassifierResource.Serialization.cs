// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class WorkloadClassifierResource : IJsonModel<WorkloadClassifierData>
    {
        void IJsonModel<WorkloadClassifierData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<WorkloadClassifierData>)Data).Write(writer, options);

        WorkloadClassifierData IJsonModel<WorkloadClassifierData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<WorkloadClassifierData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<WorkloadClassifierData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        WorkloadClassifierData IPersistableModel<WorkloadClassifierData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<WorkloadClassifierData>(data, options);

        string IPersistableModel<WorkloadClassifierData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<WorkloadClassifierData>)Data).GetFormatFromOptions(options);
    }
}
