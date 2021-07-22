// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Ranking function based on the Okapi BM25 similarity algorithm. BM25 is a TF-IDF-like algorithm that includes length normalization (controlled by the &apos;b&apos; parameter) as well as term frequency saturation (controlled by the &apos;k1&apos; parameter). </summary>
    public partial class BM25Similarity : SimilarityAlgorithm
    {
        /// <summary> Initializes a new instance of BM25Similarity. </summary>
        public BM25Similarity()
        {
            ODataType = "#Microsoft.Azure.Search.BM25Similarity";
        }

        /// <summary> Initializes a new instance of BM25Similarity. </summary>
        /// <param name="oDataType"></param>
        /// <param name="k1"> This property controls the scaling function between the term frequency of each matching terms and the final relevance score of a document-query pair. By default, a value of 1.2 is used. A value of 0.0 means the score does not scale with an increase in term frequency. </param>
        /// <param name="b"> This property controls how the length of a document affects the relevance score. By default, a value of 0.75 is used. A value of 0.0 means no length normalization is applied, while a value of 1.0 means the score is fully normalized by the length of the document. </param>
        internal BM25Similarity(string oDataType, double? k1, double? b) : base(oDataType)
        {
            K1 = k1;
            B = b;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.BM25Similarity";
        }

        /// <summary> This property controls the scaling function between the term frequency of each matching terms and the final relevance score of a document-query pair. By default, a value of 1.2 is used. A value of 0.0 means the score does not scale with an increase in term frequency. </summary>
        public double? K1 { get; set; }
        /// <summary> This property controls how the length of a document affects the relevance score. By default, a value of 0.75 is used. A value of 0.0 means no length normalization is applied, while a value of 1.0 means the score is fully normalized by the length of the document. </summary>
        public double? B { get; set; }
    }
}
