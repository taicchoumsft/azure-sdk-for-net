// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The AzureContentFilterResultForPromptContentFilterResultsError. </summary>
    internal partial class InternalAzureContentFilterResultForPromptContentFilterResultsError
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

        /// <summary> Initializes a new instance of <see cref="InternalAzureContentFilterResultForPromptContentFilterResultsError"/>. </summary>
        /// <param name="code"> A distinct, machine-readable code associated with the error. </param>
        /// <param name="message"> A human-readable message associated with the error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal InternalAzureContentFilterResultForPromptContentFilterResultsError(int code, string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureContentFilterResultForPromptContentFilterResultsError"/>. </summary>
        /// <param name="code"> A distinct, machine-readable code associated with the error. </param>
        /// <param name="message"> A human-readable message associated with the error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalAzureContentFilterResultForPromptContentFilterResultsError(int code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureContentFilterResultForPromptContentFilterResultsError"/> for deserialization. </summary>
        internal InternalAzureContentFilterResultForPromptContentFilterResultsError()
        {
        }

        /// <summary> A distinct, machine-readable code associated with the error. </summary>
        internal int Code { get; set; }
        /// <summary> A human-readable message associated with the error. </summary>
        internal string Message { get; set; }
    }
}

