// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Unknown version of Recurrence. </summary>
    internal partial class UnknownRecurrence : AlertProcessingRuleRecurrence
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecurrence"/>. </summary>
        /// <param name="recurrenceType"> Specifies when the recurrence should be applied. </param>
        /// <param name="startOn"> Start time for recurrence. </param>
        /// <param name="endOn"> End time for recurrence. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRecurrence(RecurrenceType recurrenceType, TimeSpan? startOn, TimeSpan? endOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(recurrenceType, startOn, endOn, serializedAdditionalRawData)
        {
            RecurrenceType = recurrenceType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRecurrence"/> for deserialization. </summary>
        internal UnknownRecurrence()
        {
        }
    }
}
