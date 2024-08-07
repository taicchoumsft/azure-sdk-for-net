// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class ArmDeploymentScriptResource : IJsonModel<ArmDeploymentScriptData>
    {
        void IJsonModel<ArmDeploymentScriptData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ArmDeploymentScriptData>)Data).Write(writer, options);

        ArmDeploymentScriptData IJsonModel<ArmDeploymentScriptData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ArmDeploymentScriptData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ArmDeploymentScriptData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ArmDeploymentScriptData IPersistableModel<ArmDeploymentScriptData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ArmDeploymentScriptData>(data, options);

        string IPersistableModel<ArmDeploymentScriptData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ArmDeploymentScriptData>)Data).GetFormatFromOptions(options);
    }
}
