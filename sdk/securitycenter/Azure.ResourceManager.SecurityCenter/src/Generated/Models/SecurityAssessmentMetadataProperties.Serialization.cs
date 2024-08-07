// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAssessmentMetadataProperties : IUtf8JsonSerializable, IJsonModel<SecurityAssessmentMetadataProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAssessmentMetadataProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityAssessmentMetadataProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentMetadataProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            if (options.Format != "W" && Optional.IsDefined(PolicyDefinitionId))
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RemediationDescription))
            {
                writer.WritePropertyName("remediationDescription"u8);
                writer.WriteStringValue(RemediationDescription);
            }
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories"u8);
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("severity"u8);
            writer.WriteStringValue(Severity.ToString());
            if (Optional.IsDefined(UserImpact))
            {
                writer.WritePropertyName("userImpact"u8);
                writer.WriteStringValue(UserImpact.Value.ToString());
            }
            if (Optional.IsDefined(ImplementationEffort))
            {
                writer.WritePropertyName("implementationEffort"u8);
                writer.WriteStringValue(ImplementationEffort.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Threats))
            {
                writer.WritePropertyName("threats"u8);
                writer.WriteStartArray();
                foreach (var item in Threats)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("preview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            writer.WritePropertyName("assessmentType"u8);
            writer.WriteStringValue(AssessmentType.ToString());
            if (Optional.IsDefined(PartnerData))
            {
                writer.WritePropertyName("partnerData"u8);
                writer.WriteObjectValue(PartnerData, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SecurityAssessmentMetadataProperties IJsonModel<SecurityAssessmentMetadataProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentMetadataProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAssessmentMetadataProperties(document.RootElement, options);
        }

        internal static SecurityAssessmentMetadataProperties DeserializeSecurityAssessmentMetadataProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            ResourceIdentifier policyDefinitionId = default;
            string description = default;
            string remediationDescription = default;
            IList<SecurityAssessmentResourceCategory> categories = default;
            SecurityAssessmentSeverity severity = default;
            SecurityAssessmentUserImpact? userImpact = default;
            ImplementationEffort? implementationEffort = default;
            IList<SecurityThreat> threats = default;
            bool? preview = default;
            SecurityAssessmentType assessmentType = default;
            SecurityAssessmentMetadataPartner partnerData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediationDescription"u8))
                {
                    remediationDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityAssessmentResourceCategory> array = new List<SecurityAssessmentResourceCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityAssessmentResourceCategory(item.GetString()));
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = new SecurityAssessmentSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userImpact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userImpact = new SecurityAssessmentUserImpact(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("implementationEffort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    implementationEffort = new ImplementationEffort(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threats"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityThreat> array = new List<SecurityThreat>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityThreat(item.GetString()));
                    }
                    threats = array;
                    continue;
                }
                if (property.NameEquals("preview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("assessmentType"u8))
                {
                    assessmentType = new SecurityAssessmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("partnerData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerData = SecurityAssessmentMetadataPartner.DeserializeSecurityAssessmentMetadataPartner(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityAssessmentMetadataProperties(
                displayName,
                policyDefinitionId,
                description,
                remediationDescription,
                categories ?? new ChangeTrackingList<SecurityAssessmentResourceCategory>(),
                severity,
                userImpact,
                implementationEffort,
                threats ?? new ChangeTrackingList<SecurityThreat>(),
                preview,
                assessmentType,
                partnerData,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityAssessmentMetadataProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentMetadataProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityAssessmentMetadataProperties IPersistableModel<SecurityAssessmentMetadataProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAssessmentMetadataProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentMetadataProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAssessmentMetadataProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
