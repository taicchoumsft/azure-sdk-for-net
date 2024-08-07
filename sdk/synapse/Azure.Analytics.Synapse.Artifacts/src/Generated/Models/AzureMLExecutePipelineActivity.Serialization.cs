// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureMLExecutePipelineActivityConverter))]
    public partial class AzureMLExecutePipelineActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName"u8);
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("mlPipelineId"u8);
            writer.WriteObjectValue<object>(MlPipelineId);
            if (Optional.IsDefined(ExperimentName))
            {
                writer.WritePropertyName("experimentName"u8);
                writer.WriteObjectValue<object>(ExperimentName);
            }
            if (Optional.IsDefined(MlPipelineParameters))
            {
                writer.WritePropertyName("mlPipelineParameters"u8);
                writer.WriteObjectValue<object>(MlPipelineParameters);
            }
            if (Optional.IsDefined(MlParentRunId))
            {
                writer.WritePropertyName("mlParentRunId"u8);
                writer.WriteObjectValue<object>(MlParentRunId);
            }
            if (Optional.IsDefined(ContinueOnStepFailure))
            {
                writer.WritePropertyName("continueOnStepFailure"u8);
                writer.WriteObjectValue<object>(ContinueOnStepFailure);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureMLExecutePipelineActivity DeserializeAzureMLExecutePipelineActivity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference linkedServiceName = default;
            ActivityPolicy policy = default;
            string name = default;
            string type = default;
            string description = default;
            ActivityState? state = default;
            ActivityOnInactiveMarkAs? onInactiveMarkAs = default;
            IList<ActivityDependency> dependsOn = default;
            IList<UserProperty> userProperties = default;
            object mlPipelineId = default;
            object experimentName = default;
            object mlPipelineParameters = default;
            object mlParentRunId = default;
            object continueOnStepFailure = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("mlPipelineId"u8))
                        {
                            mlPipelineId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("experimentName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            experimentName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("mlPipelineParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mlPipelineParameters = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("mlParentRunId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mlParentRunId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("continueOnStepFailure"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            continueOnStepFailure = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureMLExecutePipelineActivity(
                name,
                type,
                description,
                state,
                onInactiveMarkAs,
                dependsOn ?? new ChangeTrackingList<ActivityDependency>(),
                userProperties ?? new ChangeTrackingList<UserProperty>(),
                additionalProperties,
                linkedServiceName,
                policy,
                mlPipelineId,
                experimentName,
                mlPipelineParameters,
                mlParentRunId,
                continueOnStepFailure);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AzureMLExecutePipelineActivity FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureMLExecutePipelineActivity(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class AzureMLExecutePipelineActivityConverter : JsonConverter<AzureMLExecutePipelineActivity>
        {
            public override void Write(Utf8JsonWriter writer, AzureMLExecutePipelineActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override AzureMLExecutePipelineActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureMLExecutePipelineActivity(document.RootElement);
            }
        }
    }
}
