// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class OperationDetails
    {
        internal static OperationDetails DeserializeOperationDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "documentClassifierBuild": return DocumentClassifierBuildOperationDetails.DeserializeDocumentClassifierBuildOperationDetails(element);
                    case "documentModelBuild": return DocumentModelBuildOperationDetails.DeserializeDocumentModelBuildOperationDetails(element);
                    case "documentModelCompose": return DocumentModelComposeOperationDetails.DeserializeDocumentModelComposeOperationDetails(element);
                    case "documentModelCopyTo": return DocumentModelCopyToOperationDetails.DeserializeDocumentModelCopyToOperationDetails(element);
                }
            }
            return UnknownOperationDetails.DeserializeUnknownOperationDetails(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OperationDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOperationDetails(document.RootElement);
        }
    }
}
