// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Specifies some text and analysis components used to break that text into tokens. </summary>
    public partial class AnalyzeTextOptions
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOptions"/>. </summary>
        /// <param name="text"> The text to break into tokens. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public AnalyzeTextOptions(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            TokenFilters = new ChangeTrackingList<TokenFilterName>();
            CharFilters = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOptions"/>. </summary>
        /// <param name="text"> The text to break into tokens. </param>
        /// <param name="analyzerName"> The name of the analyzer to use to break the given text. </param>
        /// <param name="tokenizerName"> The name of the tokenizer to use to break the given text. </param>
        /// <param name="normalizerName"> The name of the normalizer to use to normalize the given text. </param>
        /// <param name="tokenFilters"> An optional list of token filters to use when breaking the given text. </param>
        /// <param name="charFilters"> An optional list of character filters to use when breaking the given text. </param>
        internal AnalyzeTextOptions(string text, LexicalAnalyzerName? analyzerName, LexicalTokenizerName? tokenizerName, LexicalNormalizerName? normalizerName, IList<TokenFilterName> tokenFilters, IList<string> charFilters)
        {
            Text = text;
            AnalyzerName = analyzerName;
            TokenizerName = tokenizerName;
            NormalizerName = normalizerName;
            TokenFilters = tokenFilters;
            CharFilters = charFilters;
        }

        /// <summary> The text to break into tokens. </summary>
        public string Text { get; }
    }
}
