// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.Chat
{
    /// <summary> Content of a chat message. </summary>
    internal partial class ChatMessageContentInternal
    {
        /// <summary> Initializes a new instance of <see cref="ChatMessageContentInternal"/>. </summary>
        internal ChatMessageContentInternal()
        {
            Participants = new ChangeTrackingList<ChatParticipantInternal>();
            Attachments = new ChangeTrackingList<ChatAttachmentInternal>();
        }

        /// <summary> Initializes a new instance of <see cref="ChatMessageContentInternal"/>. </summary>
        /// <param name="message"> Chat message content for messages of types text or html. </param>
        /// <param name="topic"> Chat message content for messages of type topicUpdated. </param>
        /// <param name="participants"> Chat message content for messages of types participantAdded or participantRemoved. </param>
        /// <param name="attachments"> List of attachments for this message. </param>
        /// <param name="initiatorCommunicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </param>
        internal ChatMessageContentInternal(string message, string topic, IReadOnlyList<ChatParticipantInternal> participants, IReadOnlyList<ChatAttachmentInternal> attachments, CommunicationIdentifierModel initiatorCommunicationIdentifier)
        {
            Message = message;
            Topic = topic;
            Participants = participants;
            Attachments = attachments;
            InitiatorCommunicationIdentifier = initiatorCommunicationIdentifier;
        }

        /// <summary> Chat message content for messages of types text or html. </summary>
        public string Message { get; }
        /// <summary> Chat message content for messages of type topicUpdated. </summary>
        public string Topic { get; }
        /// <summary> Chat message content for messages of types participantAdded or participantRemoved. </summary>
        public IReadOnlyList<ChatParticipantInternal> Participants { get; }
        /// <summary> List of attachments for this message. </summary>
        public IReadOnlyList<ChatAttachmentInternal> Attachments { get; }
        /// <summary> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </summary>
        public CommunicationIdentifierModel InitiatorCommunicationIdentifier { get; }
    }
}
