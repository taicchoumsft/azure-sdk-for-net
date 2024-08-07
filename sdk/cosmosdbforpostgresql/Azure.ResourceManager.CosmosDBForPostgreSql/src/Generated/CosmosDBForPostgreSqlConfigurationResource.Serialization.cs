// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    public partial class CosmosDBForPostgreSqlConfigurationResource : IJsonModel<CosmosDBForPostgreSqlConfigurationData>
    {
        void IJsonModel<CosmosDBForPostgreSqlConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBForPostgreSqlConfigurationData>)Data).Write(writer, options);

        CosmosDBForPostgreSqlConfigurationData IJsonModel<CosmosDBForPostgreSqlConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBForPostgreSqlConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CosmosDBForPostgreSqlConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CosmosDBForPostgreSqlConfigurationData IPersistableModel<CosmosDBForPostgreSqlConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CosmosDBForPostgreSqlConfigurationData>(data, options);

        string IPersistableModel<CosmosDBForPostgreSqlConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CosmosDBForPostgreSqlConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
