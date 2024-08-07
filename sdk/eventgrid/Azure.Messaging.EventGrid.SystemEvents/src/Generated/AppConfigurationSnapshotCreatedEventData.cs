// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AppConfiguration.SnapshotCreated event. </summary>
    public partial class AppConfigurationSnapshotCreatedEventData : AppConfigurationSnapshotEventData
    {
        /// <summary> Initializes a new instance of <see cref="AppConfigurationSnapshotCreatedEventData"/>. </summary>
        internal AppConfigurationSnapshotCreatedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationSnapshotCreatedEventData"/>. </summary>
        /// <param name="name"> The name of the snapshot. </param>
        /// <param name="etag"> The etag representing the new state of the snapshot. </param>
        /// <param name="syncToken"> The sync token representing the server state after the event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationSnapshotCreatedEventData(string name, string etag, string syncToken, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(name, etag, syncToken, serializedAdditionalRawData)
        {
        }
    }
}
