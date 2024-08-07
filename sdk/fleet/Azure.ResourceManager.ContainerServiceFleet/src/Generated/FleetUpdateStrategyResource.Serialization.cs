// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    public partial class FleetUpdateStrategyResource : IJsonModel<FleetUpdateStrategyData>
    {
        void IJsonModel<FleetUpdateStrategyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FleetUpdateStrategyData>)Data).Write(writer, options);

        FleetUpdateStrategyData IJsonModel<FleetUpdateStrategyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FleetUpdateStrategyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FleetUpdateStrategyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FleetUpdateStrategyData IPersistableModel<FleetUpdateStrategyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FleetUpdateStrategyData>(data, options);

        string IPersistableModel<FleetUpdateStrategyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FleetUpdateStrategyData>)Data).GetFormatFromOptions(options);
    }
}
