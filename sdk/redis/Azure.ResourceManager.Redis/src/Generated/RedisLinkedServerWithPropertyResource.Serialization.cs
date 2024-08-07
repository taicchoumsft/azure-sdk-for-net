// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Redis
{
    public partial class RedisLinkedServerWithPropertyResource : IJsonModel<RedisLinkedServerWithPropertyData>
    {
        void IJsonModel<RedisLinkedServerWithPropertyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RedisLinkedServerWithPropertyData>)Data).Write(writer, options);

        RedisLinkedServerWithPropertyData IJsonModel<RedisLinkedServerWithPropertyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RedisLinkedServerWithPropertyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RedisLinkedServerWithPropertyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        RedisLinkedServerWithPropertyData IPersistableModel<RedisLinkedServerWithPropertyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RedisLinkedServerWithPropertyData>(data, options);

        string IPersistableModel<RedisLinkedServerWithPropertyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RedisLinkedServerWithPropertyData>)Data).GetFormatFromOptions(options);
    }
}
