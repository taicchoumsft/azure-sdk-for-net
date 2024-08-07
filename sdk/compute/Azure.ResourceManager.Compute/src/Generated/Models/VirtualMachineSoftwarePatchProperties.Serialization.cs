// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineSoftwarePatchProperties : IUtf8JsonSerializable, IJsonModel<VirtualMachineSoftwarePatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineSoftwarePatchProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineSoftwarePatchProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineSoftwarePatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineSoftwarePatchProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PatchId))
            {
                writer.WritePropertyName("patchId"u8);
                writer.WriteStringValue(PatchId);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(KbId))
            {
                writer.WritePropertyName("kbId"u8);
                writer.WriteStringValue(KbId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Classifications))
            {
                writer.WritePropertyName("classifications"u8);
                writer.WriteStartArray();
                foreach (var item in Classifications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(RebootBehavior))
            {
                writer.WritePropertyName("rebootBehavior"u8);
                writer.WriteStringValue(RebootBehavior.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ActivityId))
            {
                writer.WritePropertyName("activityId"u8);
                writer.WriteStringValue(ActivityId);
            }
            if (options.Format != "W" && Optional.IsDefined(PublishedOn))
            {
                writer.WritePropertyName("publishedDate"u8);
                writer.WriteStringValue(PublishedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedDateTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(AssessmentState))
            {
                writer.WritePropertyName("assessmentState"u8);
                writer.WriteStringValue(AssessmentState.Value.ToString());
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

        VirtualMachineSoftwarePatchProperties IJsonModel<VirtualMachineSoftwarePatchProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineSoftwarePatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineSoftwarePatchProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineSoftwarePatchProperties(document.RootElement, options);
        }

        internal static VirtualMachineSoftwarePatchProperties DeserializeVirtualMachineSoftwarePatchProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string patchId = default;
            string name = default;
            string version = default;
            string kbId = default;
            IReadOnlyList<string> classifications = default;
            VmGuestPatchRebootBehavior? rebootBehavior = default;
            string activityId = default;
            DateTimeOffset? publishedDate = default;
            DateTimeOffset? lastModifiedDateTime = default;
            PatchAssessmentState? assessmentState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchId"u8))
                {
                    patchId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kbId"u8))
                {
                    kbId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classifications"u8))
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
                    classifications = array;
                    continue;
                }
                if (property.NameEquals("rebootBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootBehavior = new VmGuestPatchRebootBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("activityId"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publishedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("assessmentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentState = new PatchAssessmentState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineSoftwarePatchProperties(
                patchId,
                name,
                version,
                kbId,
                classifications ?? new ChangeTrackingList<string>(),
                rebootBehavior,
                activityId,
                publishedDate,
                lastModifiedDateTime,
                assessmentState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineSoftwarePatchProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineSoftwarePatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineSoftwarePatchProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineSoftwarePatchProperties IPersistableModel<VirtualMachineSoftwarePatchProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineSoftwarePatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineSoftwarePatchProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineSoftwarePatchProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineSoftwarePatchProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
