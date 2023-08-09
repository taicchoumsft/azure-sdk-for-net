// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    public partial class Service
    {
        internal static Service DeserializeService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> scheme = default;
            Optional<int> port = default;
            Optional<IReadOnlyList<WebComponent>> webComponents = default;
            Optional<IReadOnlyList<SslCertAsset>> sslCerts = default;
            Optional<IReadOnlyList<ObservedString>> exceptions = default;
            Optional<IReadOnlyList<Source>> sources = default;
            Optional<DateTimeOffset> firstSeen = default;
            Optional<DateTimeOffset> lastSeen = default;
            Optional<long> count = default;
            Optional<bool> recent = default;
            Optional<IReadOnlyList<ObservedPortState>> portStates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheme"u8))
                {
                    scheme = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("webComponents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebComponent> array = new List<WebComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebComponent.DeserializeWebComponent(item));
                    }
                    webComponents = array;
                    continue;
                }
                if (property.NameEquals("sslCerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SslCertAsset> array = new List<SslCertAsset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SslCertAsset.DeserializeSslCertAsset(item));
                    }
                    sslCerts = array;
                    continue;
                }
                if (property.NameEquals("exceptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    exceptions = array;
                    continue;
                }
                if (property.NameEquals("sources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Source> array = new List<Source>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Source.DeserializeSource(item));
                    }
                    sources = array;
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("portStates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedPortState> array = new List<ObservedPortState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedPortState.DeserializeObservedPortState(item));
                    }
                    portStates = array;
                    continue;
                }
            }
            return new Service(scheme.Value, Optional.ToNullable(port), Optional.ToList(webComponents), Optional.ToList(sslCerts), Optional.ToList(exceptions), Optional.ToList(sources), Optional.ToNullable(firstSeen), Optional.ToNullable(lastSeen), Optional.ToNullable(count), Optional.ToNullable(recent), Optional.ToList(portStates));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Service FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeService(document.RootElement);
        }
    }
}
