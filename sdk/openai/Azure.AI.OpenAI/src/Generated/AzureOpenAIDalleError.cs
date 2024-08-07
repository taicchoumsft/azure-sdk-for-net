// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The structured representation of an error from an Azure OpenAI image generation request. </summary>
    internal partial class AzureOpenAIDalleError
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

        /// <summary> Initializes a new instance of <see cref="AzureOpenAIDalleError"/>. </summary>
        internal AzureOpenAIDalleError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureOpenAIDalleError"/>. </summary>
        /// <param name="code"> The distinct, machine-generated identifier for the error. </param>
        /// <param name="message"> A human-readable message associated with the error. </param>
        /// <param name="param"> If applicable, the request input parameter associated with the error. </param>
        /// <param name="type"> If applicable, the input line number associated with the error. </param>
        /// <param name="innerError"> If applicable, an upstream error that originated this error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureOpenAIDalleError(string code, string message, string param, string type, InternalAzureOpenAIDalleErrorInnerError innerError, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Param = param;
            Type = type;
            InnerError = innerError;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The distinct, machine-generated identifier for the error. </summary>
        public string Code { get; }
        /// <summary> A human-readable message associated with the error. </summary>
        public string Message { get; }
        /// <summary> If applicable, the request input parameter associated with the error. </summary>
        public string Param { get; }
        /// <summary> If applicable, the input line number associated with the error. </summary>
        public string Type { get; }
        /// <summary> If applicable, an upstream error that originated this error. </summary>
        public InternalAzureOpenAIDalleErrorInnerError InnerError { get; }
    }
}
