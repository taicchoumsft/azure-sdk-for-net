// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a source based trigger. </summary>
    public partial class ContainerRegistrySourceTrigger
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySourceTrigger"/>. </summary>
        /// <param name="sourceRepository"> The properties that describes the source(code) for the task. </param>
        /// <param name="sourceTriggerEvents"> The source event corresponding to the trigger. </param>
        /// <param name="name"> The name of the trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceRepository"/>, <paramref name="sourceTriggerEvents"/> or <paramref name="name"/> is null. </exception>
        public ContainerRegistrySourceTrigger(SourceCodeRepoProperties sourceRepository, IEnumerable<ContainerRegistrySourceTriggerEvent> sourceTriggerEvents, string name)
        {
            Argument.AssertNotNull(sourceRepository, nameof(sourceRepository));
            Argument.AssertNotNull(sourceTriggerEvents, nameof(sourceTriggerEvents));
            Argument.AssertNotNull(name, nameof(name));

            SourceRepository = sourceRepository;
            SourceTriggerEvents = sourceTriggerEvents.ToList();
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySourceTrigger"/>. </summary>
        /// <param name="sourceRepository"> The properties that describes the source(code) for the task. </param>
        /// <param name="sourceTriggerEvents"> The source event corresponding to the trigger. </param>
        /// <param name="status"> The current status of trigger. </param>
        /// <param name="name"> The name of the trigger. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistrySourceTrigger(SourceCodeRepoProperties sourceRepository, IList<ContainerRegistrySourceTriggerEvent> sourceTriggerEvents, ContainerRegistryTriggerStatus? status, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceRepository = sourceRepository;
            SourceTriggerEvents = sourceTriggerEvents;
            Status = status;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySourceTrigger"/> for deserialization. </summary>
        internal ContainerRegistrySourceTrigger()
        {
        }

        /// <summary> The properties that describes the source(code) for the task. </summary>
        public SourceCodeRepoProperties SourceRepository { get; set; }
        /// <summary> The source event corresponding to the trigger. </summary>
        public IList<ContainerRegistrySourceTriggerEvent> SourceTriggerEvents { get; }
        /// <summary> The current status of trigger. </summary>
        public ContainerRegistryTriggerStatus? Status { get; set; }
        /// <summary> The name of the trigger. </summary>
        public string Name { get; set; }
    }
}
