// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> A message that describes why a resource is non-compliant with the policy. This is shown in 'deny' error messages and on resource's non-compliant compliance results. </summary>
    public partial class NonComplianceMessage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NonComplianceMessage"/>. </summary>
        /// <param name="message"> A message that describes why a resource is non-compliant with the policy. This is shown in 'deny' error messages and on resource's non-compliant compliance results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public NonComplianceMessage(string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="NonComplianceMessage"/>. </summary>
        /// <param name="message"> A message that describes why a resource is non-compliant with the policy. This is shown in 'deny' error messages and on resource's non-compliant compliance results. </param>
        /// <param name="policyDefinitionReferenceId"> The policy definition reference ID within a policy set definition the message is intended for. This is only applicable if the policy assignment assigns a policy set definition. If this is not provided the message applies to all policies assigned by this policy assignment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NonComplianceMessage(string message, string policyDefinitionReferenceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NonComplianceMessage"/> for deserialization. </summary>
        internal NonComplianceMessage()
        {
        }

        /// <summary> A message that describes why a resource is non-compliant with the policy. This is shown in 'deny' error messages and on resource's non-compliant compliance results. </summary>
        public string Message { get; set; }
        /// <summary> The policy definition reference ID within a policy set definition the message is intended for. This is only applicable if the policy assignment assigns a policy set definition. If this is not provided the message applies to all policies assigned by this policy assignment. </summary>
        public string PolicyDefinitionReferenceId { get; set; }
    }
}
