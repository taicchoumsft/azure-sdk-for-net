// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTextTaskResult
    {
        internal static AnalyzeTextTaskResult DeserializeAnalyzeTextTaskResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "EntityLinkingResults": return EntityLinkingTaskResult.DeserializeEntityLinkingTaskResult(element);
                    case "EntityRecognitionResults": return EntitiesTaskResult.DeserializeEntitiesTaskResult(element);
                    case "KeyPhraseExtractionResults": return KeyPhraseTaskResult.DeserializeKeyPhraseTaskResult(element);
                    case "LanguageDetectionResults": return LanguageDetectionTaskResult.DeserializeLanguageDetectionTaskResult(element);
                    case "PiiEntityRecognitionResults": return PiiTaskResult.DeserializePiiTaskResult(element);
                    case "SentimentAnalysisResults": return SentimentTaskResult.DeserializeSentimentTaskResult(element);
                }
            }
            return UnknownAnalyzeTextTaskResult.DeserializeUnknownAnalyzeTextTaskResult(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnalyzeTextTaskResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnalyzeTextTaskResult(document.RootElement);
        }
    }
}
