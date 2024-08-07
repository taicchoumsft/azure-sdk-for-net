// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The SentimentResponse. </summary>
    internal partial class SentimentResponse : PreBuiltResult
    {
        /// <summary> Initializes a new instance of <see cref="SentimentResponse"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="documents"> Sentiment analysis per document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/>, <paramref name="modelVersion"/> or <paramref name="documents"/> is null. </exception>
        public SentimentResponse(IEnumerable<DocumentError> errors, string modelVersion, IEnumerable<SentimentResponseDocumentsItem> documents) : base(errors, modelVersion)
        {
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));
            Argument.AssertNotNull(documents, nameof(documents));

            Documents = documents.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SentimentResponse"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="documents"> Sentiment analysis per document. </param>
        internal SentimentResponse(IList<DocumentError> errors, TextDocumentBatchStatistics statistics, string modelVersion, IList<SentimentResponseDocumentsItem> documents) : base(errors, statistics, modelVersion)
        {
            Documents = documents;
        }

        /// <summary> Sentiment analysis per document. </summary>
        public IList<SentimentResponseDocumentsItem> Documents { get; }
    }
}
