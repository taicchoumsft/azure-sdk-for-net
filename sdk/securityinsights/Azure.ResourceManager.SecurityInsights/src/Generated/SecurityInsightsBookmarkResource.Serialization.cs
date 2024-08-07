// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsBookmarkResource : IJsonModel<SecurityInsightsBookmarkData>
    {
        void IJsonModel<SecurityInsightsBookmarkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsBookmarkData>)Data).Write(writer, options);

        SecurityInsightsBookmarkData IJsonModel<SecurityInsightsBookmarkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsBookmarkData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsBookmarkData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityInsightsBookmarkData IPersistableModel<SecurityInsightsBookmarkData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsBookmarkData>(data, options);

        string IPersistableModel<SecurityInsightsBookmarkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsBookmarkData>)Data).GetFormatFromOptions(options);
    }
}
