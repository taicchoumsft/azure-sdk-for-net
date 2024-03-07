// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary>
    /// A paragraph object consisting with contiguous lines generally with common
    /// alignment and spacing.
    /// </summary>
    public partial class DocumentParagraph
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

        /// <summary> Initializes a new instance of <see cref="DocumentParagraph"/>. </summary>
        /// <param name="content"> Concatenated content of the paragraph in reading order. </param>
        /// <param name="spans"> Location of the paragraph in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentParagraph(string content, IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(spans, nameof(spans));

            Content = content;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentParagraph"/>. </summary>
        /// <param name="role"> Semantic role of the paragraph. </param>
        /// <param name="content"> Concatenated content of the paragraph in reading order. </param>
        /// <param name="boundingRegions"> Bounding regions covering the paragraph. </param>
        /// <param name="spans"> Location of the paragraph in the reading order concatenated content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentParagraph(ParagraphRole? role, string content, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentParagraph"/> for deserialization. </summary>
        internal DocumentParagraph()
        {
        }

        /// <summary> Semantic role of the paragraph. </summary>
        public ParagraphRole? Role { get; }
        /// <summary> Concatenated content of the paragraph in reading order. </summary>
        public string Content { get; }
        /// <summary> Bounding regions covering the paragraph. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the paragraph in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
    }
}
