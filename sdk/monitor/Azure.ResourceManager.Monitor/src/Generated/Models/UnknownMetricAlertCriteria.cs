// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Unknown version of MetricAlertCriteria. </summary>
    internal partial class UnknownMetricAlertCriteria : MetricAlertCriteria
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMetricAlertCriteria"/>. </summary>
        /// <param name="odataType"> specifies the type of the alert criteria. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownMetricAlertCriteria(MonitorOdataType odataType, IDictionary<string, BinaryData> additionalProperties) : base(odataType, additionalProperties)
        {
            OdataType = odataType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownMetricAlertCriteria"/> for deserialization. </summary>
        internal UnknownMetricAlertCriteria()
        {
        }
    }
}
