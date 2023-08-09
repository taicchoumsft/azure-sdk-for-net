// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The AzureDataExplorerDataConnectionData. </summary>
    public partial class AzureDataExplorerDataConnectionData : DataConnectionData
    {
        /// <summary> Initializes a new instance of AzureDataExplorerDataConnectionData. </summary>
        /// <param name="properties"> properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal AzureDataExplorerDataConnectionData(AzureDataExplorerDataConnectionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Kind = "azureDataExplorer";
            Properties = properties;
        }

        /// <summary> Initializes a new instance of AzureDataExplorerDataConnectionData. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"> The name of data connection. </param>
        /// <param name="content"> The type of data the data connection will transfer. </param>
        /// <param name="frequency"> The rate at which the data connection will receive updates. </param>
        /// <param name="frequencyOffset"> The day to update the data connection on. (1-7 for weekly, 1-31 for monthly). </param>
        /// <param name="properties"> properties. </param>
        internal AzureDataExplorerDataConnectionData(string kind, string name, DataConnectionContent? content, DataConnectionFrequency? frequency, int? frequencyOffset, AzureDataExplorerDataConnectionProperties properties) : base(kind, name, content, frequency, frequencyOffset)
        {
            Properties = properties;
        }

        /// <summary> properties. </summary>
        public AzureDataExplorerDataConnectionProperties Properties { get; }
    }
}
