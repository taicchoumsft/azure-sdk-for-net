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
    public partial class SslCertAssetResource
    {
        internal static SslCertAssetResource DeserializeSslCertAssetResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SslCertAsset asset = default;
            string kind = default;
            string id = default;
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<Guid> uuid = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<DateTimeOffset> updatedDate = default;
            Optional<AssetState> state = default;
            Optional<string> externalId = default;
            Optional<IReadOnlyList<string>> labels = default;
            Optional<bool> wildcard = default;
            Optional<string> discoGroupName = default;
            Optional<IReadOnlyList<AuditTrailItem>> auditTrail = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("asset"u8))
                {
                    asset = SslCertAsset.DeserializeSslCertAsset(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new AssetState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("externalId"u8))
                {
                    externalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("wildcard"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcard = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("discoGroupName"u8))
                {
                    discoGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("auditTrail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuditTrailItem> array = new List<AuditTrailItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuditTrailItem.DeserializeAuditTrailItem(item));
                    }
                    auditTrail = array;
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new SslCertAssetResource(kind, id, name.Value, displayName.Value, Optional.ToNullable(uuid), Optional.ToNullable(createdDate), Optional.ToNullable(updatedDate), Optional.ToNullable(state), externalId.Value, Optional.ToList(labels), Optional.ToNullable(wildcard), discoGroupName.Value, Optional.ToList(auditTrail), reason.Value, asset);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new SslCertAssetResource FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSslCertAssetResource(document.RootElement);
        }
    }
}
