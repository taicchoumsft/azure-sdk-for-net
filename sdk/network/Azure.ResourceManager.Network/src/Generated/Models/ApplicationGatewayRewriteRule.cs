// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Rewrite rule of an application gateway. </summary>
    public partial class ApplicationGatewayRewriteRule
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

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRewriteRule"/>. </summary>
        public ApplicationGatewayRewriteRule()
        {
            Conditions = new ChangeTrackingList<ApplicationGatewayRewriteRuleCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRewriteRule"/>. </summary>
        /// <param name="name"> Name of the rewrite rule that is unique within an Application Gateway. </param>
        /// <param name="ruleSequence"> Rule Sequence of the rewrite rule that determines the order of execution of a particular rule in a RewriteRuleSet. </param>
        /// <param name="conditions"> Conditions based on which the action set execution will be evaluated. </param>
        /// <param name="actionSet"> Set of actions to be done as part of the rewrite Rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayRewriteRule(string name, int? ruleSequence, IList<ApplicationGatewayRewriteRuleCondition> conditions, ApplicationGatewayRewriteRuleActionSet actionSet, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            RuleSequence = ruleSequence;
            Conditions = conditions;
            ActionSet = actionSet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the rewrite rule that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> Rule Sequence of the rewrite rule that determines the order of execution of a particular rule in a RewriteRuleSet. </summary>
        public int? RuleSequence { get; set; }
        /// <summary> Conditions based on which the action set execution will be evaluated. </summary>
        public IList<ApplicationGatewayRewriteRuleCondition> Conditions { get; }
        /// <summary> Set of actions to be done as part of the rewrite Rule. </summary>
        public ApplicationGatewayRewriteRuleActionSet ActionSet { get; set; }
    }
}
