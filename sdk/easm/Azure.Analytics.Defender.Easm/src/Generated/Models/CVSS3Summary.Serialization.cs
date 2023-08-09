// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    public partial class CVSS3Summary
    {
        internal static CVSS3Summary DeserializeCVSS3Summary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> version = default;
            Optional<string> vectorString = default;
            Optional<string> attackVector = default;
            Optional<string> attackComplexity = default;
            Optional<string> privilegesRequired = default;
            Optional<string> userInteraction = default;
            Optional<string> scope = default;
            Optional<string> confidentialityImpact = default;
            Optional<string> integrityImpact = default;
            Optional<string> availabilityImpact = default;
            Optional<float> baseScore = default;
            Optional<string> baseSeverity = default;
            Optional<string> exploitCodeMaturity = default;
            Optional<string> remediationLevel = default;
            Optional<string> reportConfidence = default;
            Optional<float> exploitabilityScore = default;
            Optional<float> impactScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vectorString"u8))
                {
                    vectorString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attackVector"u8))
                {
                    attackVector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attackComplexity"u8))
                {
                    attackComplexity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privilegesRequired"u8))
                {
                    privilegesRequired = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userInteraction"u8))
                {
                    userInteraction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidentialityImpact"u8))
                {
                    confidentialityImpact = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("integrityImpact"u8))
                {
                    integrityImpact = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availabilityImpact"u8))
                {
                    availabilityImpact = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseScore = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("baseSeverity"u8))
                {
                    baseSeverity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exploitCodeMaturity"u8))
                {
                    exploitCodeMaturity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediationLevel"u8))
                {
                    remediationLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportConfidence"u8))
                {
                    reportConfidence = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exploitabilityScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exploitabilityScore = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("impactScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    impactScore = property.Value.GetSingle();
                    continue;
                }
            }
            return new CVSS3Summary(version.Value, vectorString.Value, attackVector.Value, attackComplexity.Value, privilegesRequired.Value, userInteraction.Value, scope.Value, confidentialityImpact.Value, integrityImpact.Value, availabilityImpact.Value, Optional.ToNullable(baseScore), baseSeverity.Value, exploitCodeMaturity.Value, remediationLevel.Value, reportConfidence.Value, Optional.ToNullable(exploitabilityScore), Optional.ToNullable(impactScore));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CVSS3Summary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCVSS3Summary(document.RootElement);
        }
    }
}
