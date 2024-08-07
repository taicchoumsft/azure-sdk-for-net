// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Event Subscription update. </summary>
    public partial class EventGridSubscriptionPatch
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

        /// <summary> Initializes a new instance of <see cref="EventGridSubscriptionPatch"/>. </summary>
        public EventGridSubscriptionPatch()
        {
            Labels = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EventGridSubscriptionPatch"/>. </summary>
        /// <param name="destination">
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
        /// Please note <see cref="EventSubscriptionDestination"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureFunctionEventSubscriptionDestination"/>, <see cref="EventHubEventSubscriptionDestination"/>, <see cref="HybridConnectionEventSubscriptionDestination"/>, <see cref="MonitorAlertEventSubscriptionDestination"/>, <see cref="NamespaceTopicEventSubscriptionDestination"/>, <see cref="PartnerEventSubscriptionDestination"/>, <see cref="ServiceBusQueueEventSubscriptionDestination"/>, <see cref="ServiceBusTopicEventSubscriptionDestination"/>, <see cref="StorageQueueEventSubscriptionDestination"/> and <see cref="WebHookEventSubscriptionDestination"/>.
        /// </param>
        /// <param name="deliveryWithResourceIdentity">
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses the managed identity setup on the parent resource (topic / domain) to acquire the authentication tokens being used during delivery / dead-lettering.
        /// </param>
        /// <param name="filter"> Information about the filter for the event subscription. </param>
        /// <param name="labels"> List of user defined labels. </param>
        /// <param name="expireOn"> Information about the expiration time for the event subscription. </param>
        /// <param name="eventDeliverySchema"> The event delivery schema for the event subscription. </param>
        /// <param name="retryPolicy"> The retry policy for events. This can be used to configure maximum number of delivery attempts and time to live for events. </param>
        /// <param name="deadLetterDestination">
        /// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
        /// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
        /// Please note <see cref="Models.DeadLetterDestination"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="StorageBlobDeadLetterDestination"/>.
        /// </param>
        /// <param name="deadLetterWithResourceIdentity">
        /// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
        /// Uses the managed identity setup on the parent resource (topic / domain) to acquire the authentication tokens being used during delivery / dead-lettering.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGridSubscriptionPatch(EventSubscriptionDestination destination, DeliveryWithResourceIdentity deliveryWithResourceIdentity, EventSubscriptionFilter filter, IList<string> labels, DateTimeOffset? expireOn, EventDeliverySchema? eventDeliverySchema, EventSubscriptionRetryPolicy retryPolicy, DeadLetterDestination deadLetterDestination, DeadLetterWithResourceIdentity deadLetterWithResourceIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Destination = destination;
            DeliveryWithResourceIdentity = deliveryWithResourceIdentity;
            Filter = filter;
            Labels = labels;
            ExpireOn = expireOn;
            EventDeliverySchema = eventDeliverySchema;
            RetryPolicy = retryPolicy;
            DeadLetterDestination = deadLetterDestination;
            DeadLetterWithResourceIdentity = deadLetterWithResourceIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
        /// Please note <see cref="EventSubscriptionDestination"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureFunctionEventSubscriptionDestination"/>, <see cref="EventHubEventSubscriptionDestination"/>, <see cref="HybridConnectionEventSubscriptionDestination"/>, <see cref="MonitorAlertEventSubscriptionDestination"/>, <see cref="NamespaceTopicEventSubscriptionDestination"/>, <see cref="PartnerEventSubscriptionDestination"/>, <see cref="ServiceBusQueueEventSubscriptionDestination"/>, <see cref="ServiceBusTopicEventSubscriptionDestination"/>, <see cref="StorageQueueEventSubscriptionDestination"/> and <see cref="WebHookEventSubscriptionDestination"/>.
        /// </summary>
        public EventSubscriptionDestination Destination { get; set; }
        /// <summary>
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses the managed identity setup on the parent resource (topic / domain) to acquire the authentication tokens being used during delivery / dead-lettering.
        /// </summary>
        public DeliveryWithResourceIdentity DeliveryWithResourceIdentity { get; set; }
        /// <summary> Information about the filter for the event subscription. </summary>
        public EventSubscriptionFilter Filter { get; set; }
        /// <summary> List of user defined labels. </summary>
        public IList<string> Labels { get; }
        /// <summary> Information about the expiration time for the event subscription. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The event delivery schema for the event subscription. </summary>
        public EventDeliverySchema? EventDeliverySchema { get; set; }
        /// <summary> The retry policy for events. This can be used to configure maximum number of delivery attempts and time to live for events. </summary>
        public EventSubscriptionRetryPolicy RetryPolicy { get; set; }
        /// <summary>
        /// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
        /// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
        /// Please note <see cref="Models.DeadLetterDestination"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="StorageBlobDeadLetterDestination"/>.
        /// </summary>
        public DeadLetterDestination DeadLetterDestination { get; set; }
        /// <summary>
        /// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
        /// Uses the managed identity setup on the parent resource (topic / domain) to acquire the authentication tokens being used during delivery / dead-lettering.
        /// </summary>
        public DeadLetterWithResourceIdentity DeadLetterWithResourceIdentity { get; set; }
    }
}
