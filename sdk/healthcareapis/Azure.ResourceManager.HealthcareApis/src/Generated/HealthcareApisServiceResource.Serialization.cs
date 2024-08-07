// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HealthcareApis
{
    public partial class HealthcareApisServiceResource : IJsonModel<HealthcareApisServiceData>
    {
        void IJsonModel<HealthcareApisServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HealthcareApisServiceData>)Data).Write(writer, options);

        HealthcareApisServiceData IJsonModel<HealthcareApisServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HealthcareApisServiceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HealthcareApisServiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        HealthcareApisServiceData IPersistableModel<HealthcareApisServiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HealthcareApisServiceData>(data, options);

        string IPersistableModel<HealthcareApisServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HealthcareApisServiceData>)Data).GetFormatFromOptions(options);
    }
}
