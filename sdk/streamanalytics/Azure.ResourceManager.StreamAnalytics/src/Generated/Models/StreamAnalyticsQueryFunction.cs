// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A function for the query compilation. </summary>
    public partial class StreamAnalyticsQueryFunction
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

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryFunction"/>. </summary>
        /// <param name="name"> The name of the function. </param>
        /// <param name="queryFunctionType"> The type of the function. </param>
        /// <param name="bindingType"> The type of the function binding. </param>
        /// <param name="inputs"> The inputs for the function. </param>
        /// <param name="output"> An output for the function. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="queryFunctionType"/>, <paramref name="bindingType"/>, <paramref name="inputs"/> or <paramref name="output"/> is null. </exception>
        public StreamAnalyticsQueryFunction(string name, string queryFunctionType, string bindingType, IEnumerable<StreamingJobFunctionInput> inputs, StreamingJobFunctionOutput output)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(queryFunctionType, nameof(queryFunctionType));
            Argument.AssertNotNull(bindingType, nameof(bindingType));
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(output, nameof(output));

            Name = name;
            QueryFunctionType = queryFunctionType;
            BindingType = bindingType;
            Inputs = inputs.ToList();
            Output = output;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryFunction"/>. </summary>
        /// <param name="name"> The name of the function. </param>
        /// <param name="queryFunctionType"> The type of the function. </param>
        /// <param name="bindingType"> The type of the function binding. </param>
        /// <param name="inputs"> The inputs for the function. </param>
        /// <param name="output"> An output for the function. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsQueryFunction(string name, string queryFunctionType, string bindingType, IList<StreamingJobFunctionInput> inputs, StreamingJobFunctionOutput output, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            QueryFunctionType = queryFunctionType;
            BindingType = bindingType;
            Inputs = inputs;
            Output = output;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryFunction"/> for deserialization. </summary>
        internal StreamAnalyticsQueryFunction()
        {
        }

        /// <summary> The name of the function. </summary>
        public string Name { get; }
        /// <summary> The type of the function. </summary>
        public string QueryFunctionType { get; }
        /// <summary> The type of the function binding. </summary>
        public string BindingType { get; }
        /// <summary> The inputs for the function. </summary>
        public IList<StreamingJobFunctionInput> Inputs { get; }
        /// <summary> An output for the function. </summary>
        internal StreamingJobFunctionOutput Output { get; }
        /// <summary> The (Azure Stream Analytics supported) data type of the function output. A list of valid Azure Stream Analytics data types are described at https://msdn.microsoft.com/en-us/library/azure/dn835065.aspx. </summary>
        public string OutputDataType
        {
            get => Output?.DataType;
        }
    }
}
