// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Describes a profile type participating in an interaction. </summary>
    public partial class Participant
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

        /// <summary> Initializes a new instance of <see cref="Participant"/>. </summary>
        /// <param name="profileTypeName"> Profile type name. </param>
        /// <param name="participantPropertyReferences"> The property references. </param>
        /// <param name="participantName"> Participant name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="profileTypeName"/>, <paramref name="participantPropertyReferences"/> or <paramref name="participantName"/> is null. </exception>
        public Participant(string profileTypeName, IEnumerable<ParticipantPropertyReference> participantPropertyReferences, string participantName)
        {
            Argument.AssertNotNull(profileTypeName, nameof(profileTypeName));
            Argument.AssertNotNull(participantPropertyReferences, nameof(participantPropertyReferences));
            Argument.AssertNotNull(participantName, nameof(participantName));

            ProfileTypeName = profileTypeName;
            ParticipantPropertyReferences = participantPropertyReferences.ToList();
            ParticipantName = participantName;
            DisplayName = new ChangeTrackingDictionary<string, string>();
            Description = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="Participant"/>. </summary>
        /// <param name="profileTypeName"> Profile type name. </param>
        /// <param name="participantPropertyReferences"> The property references. </param>
        /// <param name="participantName"> Participant name. </param>
        /// <param name="displayName"> Localized display name. </param>
        /// <param name="description"> Localized descriptions. </param>
        /// <param name="role"> The role that the participant is playing in the interaction. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Participant(string profileTypeName, IList<ParticipantPropertyReference> participantPropertyReferences, string participantName, IDictionary<string, string> displayName, IDictionary<string, string> description, string role, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProfileTypeName = profileTypeName;
            ParticipantPropertyReferences = participantPropertyReferences;
            ParticipantName = participantName;
            DisplayName = displayName;
            Description = description;
            Role = role;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Participant"/> for deserialization. </summary>
        internal Participant()
        {
        }

        /// <summary> Profile type name. </summary>
        public string ProfileTypeName { get; set; }
        /// <summary> The property references. </summary>
        public IList<ParticipantPropertyReference> ParticipantPropertyReferences { get; }
        /// <summary> Participant name. </summary>
        public string ParticipantName { get; set; }
        /// <summary> Localized display name. </summary>
        public IDictionary<string, string> DisplayName { get; }
        /// <summary> Localized descriptions. </summary>
        public IDictionary<string, string> Description { get; }
        /// <summary> The role that the participant is playing in the interaction. </summary>
        public string Role { get; set; }
    }
}
