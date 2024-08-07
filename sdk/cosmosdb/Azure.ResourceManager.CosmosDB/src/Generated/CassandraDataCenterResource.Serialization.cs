// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CassandraDataCenterResource : IJsonModel<CassandraDataCenterData>
    {
        void IJsonModel<CassandraDataCenterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CassandraDataCenterData>)Data).Write(writer, options);

        CassandraDataCenterData IJsonModel<CassandraDataCenterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CassandraDataCenterData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CassandraDataCenterData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CassandraDataCenterData IPersistableModel<CassandraDataCenterData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CassandraDataCenterData>(data, options);

        string IPersistableModel<CassandraDataCenterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CassandraDataCenterData>)Data).GetFormatFromOptions(options);
    }
}
